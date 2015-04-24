# ！/usr/bin/python3
# -*- coding: utf-8 -*-
import random

def coin():
    result = random.uniform(0, 1)

    if result < 0.3:
        return True
    if result > 0.7:
        return False

if __name__ == "__main__":
    front = 0
    back = 0

    for i in range(1000):
        if coin():
            front += 1
        else:
            back += 1

    print("正面次数：\t", front)
    print("反面次数：\t", back)