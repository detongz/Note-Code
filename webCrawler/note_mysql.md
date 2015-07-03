#小学期笔记之mysql

##启动mysql
系统环境:fedora21
首先，命令行输入mysql，系统提示没有mysql命令，提示安装mariadb和community—mysql,运行```sudo yum isntall community-mysql```。
继续安装mysql-server。

启动mysql守护进程
```
systemctl start mysqld.service
```
运行结束后，使用命令
```
mysql
```
即可进入mysql命令界面
