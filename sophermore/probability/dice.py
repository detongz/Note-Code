# ！/usr/bin/python3
# -*- coding: utf-8 -*-
import random

def roll():
    result = random.randint(1, 6)
    return result


c = [0] * 6

def roll_dice(time):
    print("\n抛色子%s次" % time)
    for i in range(time):
        c[roll() - 1] += 1

    for i in range(6):
        print("点数%s出现次数为：%s" % (i+1, c[i]))

if __name__ == "__main__":
    for time in [5000, 1000, 10000]:
        for i in range(6):
            c[i] = 0
        roll_dice(time)