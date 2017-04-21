# -*- coding: utf-8 -*-
"""
Created on Sun Aug 02 14:08:19 2015

@author: Shidi
判断篮球比赛的领先是否安全：
1.获取领先得分数
2.减去三分
3.如果目前是领先队控球，则加0.5；否则减0.5（数字小于0则变0）
4.计算平方后的结果
5.如果得到的结果比当前比赛剩余时间的秒数大，则领先是安全的
"""

points = int(raw_input('leading points: '))
has_ball = raw_input('The leading team has ball (yes/no)')
seconds = int(raw_input('The remaining seconds: '))

points -= 3
if has_ball == 'yes':
    points += 0.5
else:
    points -= 0.5
    
points **=2

if points > seconds:
    print 'Safe'
else:
    print 'Not safe'