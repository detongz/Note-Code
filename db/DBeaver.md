#数据库学习：

##########################

##sql数据库图形化界面管理工具：
DBeaver[介绍](http://www.techrepublic.com/blog/diy-it-guy/diy-manage-databases-with-the-cross-platform-tool-dbeaver/)

##mariadb(on [fedora](https://fedoraproject.org/wiki/MariaDB))
我使用的系统为fedora21，系统默认支持mariadb，fedora20用开源的mariadb代替了mysql，但还是使用mysql进入数据库。mariadb和mongodb，mysql的启动方式不同，在fedora系统中，需要使用systemctl start mariadb启动，后使用```mysql```调用mariadb数据库。
但在我使用mysql的过程中，数据库报错
```ERROR 1045 (28000): Access denied for user 'zdt'@'localhost' (using password: NO)
```
遂使用```mysql -u root -p ```命令输入用户名密码，问题成功解决。

![运行mariadb](https://github.com/tbbrave/smtpPractice/blob/master/pic/mariadb.png)
