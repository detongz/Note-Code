#linux使用小技巧
#############


##gedit中文乱码
['解决'办法](http://www.v2ex.com/t/114645)：
LANGUAGE=zh_CN gedit ***.txt

##tar压缩文件
范例：将整个 /etc 目录下的文件全部打包成为 /tmp/etc.tar
[root@linux ~]# tar -cvf /tmp/etc.tar /etc <==仅打包，不压缩！
[root@linux ~]# tar -zcvf /tmp/etc.tar.gz /etc <==打包后，以 gzip 压缩
[root@linux ~]# tar -jcvf /tmp/etc.tar.bz2 /etc <==打包后，以 bzip2 压缩 

##git add 多个文件
```git add .```

##cat使用
```$cat filename```现实文件全部内容
创建文件：```$cat > filename```
多个文件合并：```$cat file1 file2 > file```
参考http://www.cnblogs.com/perfy/archive/2012/07```现实文件全部内容
创建文件：```$cat > filename```
多个文件合并：```$cat file1 file2 > file```
参考[linux下cat命令详解](http://www.cnblogs.com/perfy/archive/2012/07/23/2605550.html)/23/2605550.html)
