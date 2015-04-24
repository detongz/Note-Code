#!/usr/bin/python3
# -*- coding: utf-8 -*-
import numpy as np

p = [[1 / 3, 1 / 3, 1 / 3],
     [0, 1 / 2, 1 / 2],
     [0, 0, 1]]

if __name__ == "__main__":
    for time in [20, 50, 100]:
        a = np.matrix(p)
        print("\np^%s:\n%s" %(time, a**time))