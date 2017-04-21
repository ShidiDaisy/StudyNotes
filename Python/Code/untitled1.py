# -*- coding: utf-8 -*-
"""
Created on Tue Jul 28 16:18:24 2015

@author: Shidi
"""

n = int(raw_input("Please enter a number:"))
def increment(n):
    return n+1

def double(n):
    return n*2
    
n=double(increment(n))

print(n)