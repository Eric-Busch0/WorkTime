# -*- coding: utf-8 -*-
"""
Created on Tue May 19 18:26:09 2020

@author: Eric Busch
"""
from tkinter import *

root = Tk()
root.title('WorkTime')
global timeHrMin
timeHrMin = [0,0]

def calc(t):
    hrs = t.split(':')[0]
    mins = t.split(':')[1]
    prevHr = timeHrMin[0]
    prevMin = timeHrMin[1]
    hrs = int(hrs)
    mins = int(mins)
    total_mins = 60*(hrs + prevHr)  + mins + prevMin
    hrs = (total_mins - total_mins%60)/60
    mins = total_mins - hrs*60
    timeHrMin[0] = hrs
    timeHrMin[1] = mins
    
    return 'Hours: ' + str(int(timeHrMin[0])) + ' Minutes: ' + str(int(timeHrMin[1]))


def ent():
    txt.delete("1.0","end")
    time = e.get()
    e.delete(0,END)
    txt.insert(END,calc(time))
    
    
e = Entry(root,width = 35,borderwidth = 5)
e.grid(row = 0, column = 0, columnspan = 3)

ret = Button(root, text = "Enter (XX::YY)",command = ent)
ret.grid(row = 1,column = 1)
txt = Text(root,height=1,width=25)
txt.grid(column = 0, row = 1)

root.mainloop() 
