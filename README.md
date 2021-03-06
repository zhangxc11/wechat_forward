# wechat_forward
基于新浪SAE的微信后台，转发到本地并弹幕显示

----
代码包括三部分
## server
这一部分代码运行在新浪的SAE服务器上。部署方法如下：

* 在SAE上创建一个新应用，
* 再将`server`文件夹中的三个文件拷贝到原程服务器上即可。
* 注意：这个应用依赖SAE的Channel功能，记得要将应用的这个功能打开，才能正常使用。
* 成功后点开应用对应的链接应该显示 Internal Server Error。

要实现微信转发，需以下步骤：

* 将需要转发的微信公众号的服务器地址设为上面应用的域名。
* 记得要将server/server.py中的token改为你在微信后台设置的字符串。

## local
这一部分代码运行在本地，是一个chrome的扩展包。作用是在本地接收从服务器上转发过来的信息，并通过本地UDP再次发送出去。

* 首先将local/udp.js中`openChannel`中URL里的`XXX`替换为你在SAE上应用的名称；
* 然后打开chrome的扩展程序控制界面，勾选开发者模式；
* 点击 加载改解压的扩展程序...
* 选中local文件夹即可。

## C# 程序
这一部分是C#程序，实现windows系统中的弹幕功能。程序接收从local部分发送的UDP包，将接收到的内容以弹幕的形式显示在桌面上。使用VS 2012打开，编译即可。

![CC-BY-NC 4.0](https://i.creativecommons.org/l/by-nc/4.0/88x31.png)

This work is licensed under a Creative Commons Attribution-NonCommercial 4.0 International License.
http://creativecommons.org/licenses/by-nc/4.0/

不允许商业使用。转载请保留此信息。