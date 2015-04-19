f = open("1.fa", 'r')
w = open("result.txt", "w")
#文件读取参数中没有rw这样的选项，参看http://www.cnblogs.com/dkblog/archive/2011/02/24/1980651.html

#判断文件是否结束
#关于readline和readlines，参看http://www.jb51.net/article/57241.htm
done = 0

while not done:
    aline = f.readline()
    if aline != "":
        # 读取文件第一个字符，aline[0]
        if aline[0] != ">":
            w.write(aline + "\n")
    else:
        done = 1

f.close()
w.close()