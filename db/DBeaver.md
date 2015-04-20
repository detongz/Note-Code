#数据库学习：

##########################

##sql数据库图形化界面管理工具：
DBeaver[介绍](http://www.techrepublic.com/blog/diy-it-guy/diy-manage-databases-with-the-cross-platform-tool-dbeaver/)

##mariadb(on [fedora](https://fedoraproject.org/wiki/MariaDB))
我使用的系统为fedora21，系统默认支持mariadb，fedora20用开源的mariadb代替了mysql，但还是使用mysql进入数据库。mariadb和mongodb，mysql的启动方式不同，在fedora系统中，需要使用systemctl start mariadb启动，后使用```mysql```调用mariadb数据库。
但在我使用mysql的过程中，数据库报错
```
ERROR 1045 (28000): Access denied for user 'zdt'@'localhost' (using password: NO)
```
其实在这一行错误中，可以明显看出来我犯了什么样的错误：即我在设定mariadb的用户时，并未制定zdt用户，而我设定了用户名密码的是‘root‘用户。
DBeaver中由于我在添加用户的时候，使用了系统的’zdt‘用户名，导致了一直出现和上面相同的报错。最后在创建链接诶的时候，把’zdt‘改成了‘root’，问题解决。
遂使用```mysql -u root -p ```命令输入用户名密码，问题成功解决。

![运行mariadb](https://github.com/tbbrave/smtpPractice/blob/master/pic/mariadb.png)
