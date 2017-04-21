# -*- coding: utf-8 -*-
"""
Created on Sun Aug 02 20:32:32 2015

@author: Shidi
"""
count = 0
sum = 0
while count >= 0:
    inputNo = raw_input('Please input the number:')
    if inputNo == ' ':
        break
    else:
        sum += float(inputNo)
        count += 1

average = sum / count 
print(average)
