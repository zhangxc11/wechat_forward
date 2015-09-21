var g_sockinfo;

function str2ab(str) {
  var buf = new ArrayBuffer(str.length); // 2 bytes for each char
  var bufView = new Uint8Array(buf);
  for (var i=0, strLen=str.length; i<strLen; i++) {
    bufView[i] = str.charCodeAt(i);
  }
  return buf;
}

onOpened = function() {
  var out = document.getElementById("send");
  out.value = 'is_open';
}

onError = function() {
  var out = document.getElementById("send");
  out.value = 'error';
}

onClose = function() {
  var out = document.getElementById("send");
  out.value = 'close';
}

onMessage = function(m) {
  var out = document.getElementById("test");
  domParser = new  DOMParser();
  var xmlDoc = domParser.parseFromString(m.data, 'text/xml');
  if (xmlDoc.getElementsByTagName("MsgType")[0].firstChild.nodeValue == 'text') {
    out.value = xmlDoc.getElementsByTagName("Content")[0].firstChild.nodeValue;
  } else {
    out.value = xmlDoc.getElementsByTagName("MsgType")[0].firstChild.nodeValue;
  }
  var socket = chrome.sockets.udp;
  socket.send(g_sockinfo.socketId, str2ab(unescape(encodeURIComponent(m.data))),
    '127.0.0.1', 5068, function(sendInfo) {
      var send = document.getElementById("send");
      send.value = 'success';
      console.log("sent " + sendInfo.bytesSent);
  });
}

function getUrl(theUrl) {
  var xmlHttp = null;
  xmlHttp = new XMLHttpRequest();
  xmlHttp.open( "GET", theUrl, true);
  xmlHttp.onload = function() {
  };
  xmlHttp.send( null );
}
  
openChannel = function() {
  var theUrl = "http://XXX.sinaapp.com/channel/test"
  var xmlHttp = null;
  xmlHttp = new XMLHttpRequest();
  xmlHttp.open( "GET", theUrl, true);
  xmlHttp.onload = function() {
    var out = document.getElementById("test");
    var url = xmlHttp.responseText;
    out.value = xmlHttp.responseText;
    var chan = new sae.Channel(url);
    chan.onopen = onOpened;
    chan.onmessage = onMessage;
    chan.onerror = onError;
    chan.onclose = onClose;
    send.value = 'wait';
    console.log("sent " + sendInfo.bytesSent);
  };
  xmlHttp.send( null );
}

window.addEventListener("load", function() {
  var send = document.getElementById("send");
  var socket = chrome.sockets.udp;
  socket.create({}, function(_socketInfo) {
    g_sockinfo = _socketInfo;
    socket.bind(g_sockinfo.socketId, '127.0.0.1', 0, function(connectResult) {
    });
  });
  send.value = 'in';
  openChannel();
  // send.onclick = function(ev) {
  //   socket.send(g_sockinfo.socketId, str2ab('test'),
  //     '127.0.0.1', 5068, function(sendInfo) {
  //       console.log("sent " + sendInfo.bytesSent);
  //   });
  // };
});
