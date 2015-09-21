#!/usr/local/bin/python
# -*- coding: utf-8 -*-
# Last modified: 2015  9 22 00时09分47秒

"""docstring
"""

__revision__ = '0.1'
from flask import Flask, make_response, request, url_for
import hashlib
import time
import xml.etree.ElementTree as ET
from sae import channel


app = Flask(__name__)
g_connect = False;
g_count = 0;
chname = 'it_is_a_long_name'

def udpdata(data):
  ADDR = (HOST,PORT)
  udpCliSock.sendto(data,ADDR)
  data,ADDR = udpCliSock.recvfrom(BUFSIZE)
  print data, ADDR
  return data

# @app.route('/test')
# def test():
#   global g_chname
#   response = make_response( g_chname )
#   response.content_type = 'text/html'
#   return response

@app.route('/channel/<channelname>')
def get_channel(channelname):
  global g_connect
  if channelname == 'test':
    g_connect = True
    url = channel.create_channel(chname)
    response = make_response( url )
    response.content_type = 'text/html'
    response.headers['Access-Control-Allow-Credentials'] = True
    response.headers['Access-Control-Allow-Origin'] = '*'
    return response
  return None

@app.route('/_sae/channel/connected', methods = ['POST'])
def connected():
  pass

@app.route('/_sae/channel/disconnected', methods = ['POST'])
def disconnected():
  pass

@app.route('/_sae/channel/message', methods = ['POST'])
def message():
  pass

@app.route('/', methods = ['GET', 'POST'])
def wechat_auth():
  if request.method == 'GET':
    token = 'TOKEN'
    query = request.args
    signature = query.get('signature', '')
    timestamp = query.get('timestamp', '')
    nonce = query.get('nonce', '')
    echostr = query.get('echostr', '')
    s = [timestamp, nonce, token]
    s.sort()
    s = ''.join(s)
    if ( hashlib.sha1(s).hexdigest() == signature ):
      print "auth success"
      return make_response(echostr)
  else:
    xml_recv = ET.fromstring(request.data)
    global g_connect, g_count;
    if g_connect:
      channel.send_message(chname, request.data)
      # return echo(xml_recv)
      g_count += 1
      return reply_res(xml_recv, str(g_count))
    # recv = udpdata(request.data)
    recv = str(g_connect)
    if recv == "xxxx":
      response = make_response('')
      response.content_type = 'application/xml'
    else:
      response = reply_res(xml_recv, recv)
    return response

def reply_res(xml_recv, msg):
  ToUserName = xml_recv.find("ToUserName").text
  FromUserName = xml_recv.find("FromUserName").text
  reply = '''<xml>
<ToUserName><![CDATA[%s]]></ToUserName>
<FromUserName><![CDATA[%s]]></FromUserName>
<CreateTime>%s</CreateTime>
<MsgType><![CDATA[text]]></MsgType>
<Content><![CDATA[%s]]></Content>
<FuncFlag>0</FuncFlag></xml>'''
  response = make_response( reply % (
    FromUserName,
    ToUserName,
    str(int(time.time())),
    msg ) )
  response.content_type = 'application/xml'
  return response

def echo(xml_recv):
  Content = xml_recv.find("Content").text
  return reply_res(xml_recv, Content)

if __name__ == '__main__':
  # app.run(debug = True)
  app.run(host='0.0.0.0', port = 80)
