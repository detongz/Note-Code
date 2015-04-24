#!/usr/lib/python3
# -*- coding:utf-8 -*-
#尝试使用python正则表达式
import re

f = open("info.txt", 'r')
done = 0
my_num = '123456'
name = "x"
matching = re.compile(my_num)

if __name__ == "__main__":

    while not done:
        aline = f.readline()
        if aline != "":
            aline = aline.replace(my_num, name)
            print(aline)
        else:
            done = 1

    f.close()
