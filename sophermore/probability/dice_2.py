#!/usr/bin/python3
# -*- coding: utf-8 -*-
import random

num = []

def roll():
    result = random.randint(1, 6)
    return result

def roll_dice(time):
    print("\n分别抛两个色子%s次" % time)
    for i in range(time):
        num[roll() + roll()] += 1

if __name__ == "__main__":
    for time in [1000, 5000]:
        num = [0 for i in range(13)]
        roll_dice(time)
        for i in range(13):
            print("和为%s出现的次数为：%s" % (i, num[i]))