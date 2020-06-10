# -*- coding: utf-8 -*-
"""
Created on Tue May 19 18:26:09 2020

@author: Eric Busch
"""
from tkinter import *

root = Tk()
root.title('WorkTime')

global timeHrMin
global numOfJobs
global prevHrTotal
global prevMinTotal

numOfJobs = 1
timeHrMin = [0, 0]

class Job:

    global timeHrMin
    global numOfJobs

    def __init__(self):
        self.totalTime = [0,0]
        self.prevHr = 0
        self.prevMin = 0
        self.jobNumber = numOfJobs

    def calc(self,t):

        hrs = t.split(':')[0]
        mins = t.split(':')[1]

        # prevHrTotal = int(timeHrMin[0])
        # prevMinTotal = int(timeHrMin[1])
        prevHr  = self.totalTime[0]
        prevMin = self.totalTime[1]

        hrs = int(hrs)
        print(hrs)
        mins = int(mins)
        if hrs > 8:
            messagebox.showwarning("WorkLength", "You have created a time entry more than a normal workday")

        total_mins = 60 * (hrs + prevHr) + mins + prevMin
        hrs = (total_mins - total_mins % 60) / 60
        mins = total_mins - hrs * 60
        self.totalTime[0] = hrs
        self.totalTime[1] = mins
        # timeHrMin[0] = hrs
        # timeHrMin[1] = mins
        return ["Job " + str(numOfJobs) + ": "+ str(int(self.totalTime[0])) + ' Hr ' + str(int(self.totalTime[1])) + " Min", self.totalTime]


def updateTotal(t):
     global timeHrMin
     hrs = t.split(':')[0]
     mins = t.split(':')[1]
     prevHr = timeHrMin[0]
     prevMin = timeHrMin[1]

     hrs = int(hrs)
     mins = int(mins)

     total_mins = 60 * (hrs + prevHr) + mins + prevMin
     hrs = (total_mins - total_mins % 60) / 60
     mins = total_mins - hrs * 60
     timeHrMin[0] = hrs
     timeHrMin[1] = mins



def addJob():

    global numOfJobs

    if numOfJobs < 8:
        txt.delete("1.0", "end")
        numOfJobs += 1
    else:
        txt.insert(END,"Max Jobs Reached")



def ent():
    global numOfJobs
    txt.delete("1.0", "end")
    time = e.get()
    e.delete(0, END)
    if numOfJobs == 1:
      ans,jobTotal = job1.calc(time)
      txt.insert(END, ans)
      updateTotal(time)
    elif numOfJobs == 2:
        ans,jobTotal = job2.calc(time)
        txt.insert(END, ans)
        updateTotal(time)
    elif numOfJobs == 3:
        ans,jobTotal = job3.calc(time)
        txt.insert(END, ans)
        updateTotal(time)
    elif numOfJobs == 4:
        ans, jobTotal = job4.calc(time)
        txt.insert(END, ans)
        updateTotal(time)
    elif numOfJobs == 5:
        ans, jobTotal = job5.calc(time)
        txt.insert(END, ans)
        updateTotal(time)
    elif numOfJobs == 6:
        ans, jobTotal = job6.calc(time)
        txt.insert(END, ans)
        updateTotal(time)

    elif numOfJobs == 7:
        ans, jobTotal  = job7.calc(time)
        txt.insert(END, ans)
        updateTotal(time)
    elif numOfJobs == 8:
        ans, jobTotal = job8.calc(time)
        txt.insert(END, ans)
        updateTotal(time)

    totalTxt.delete("1.0","end")
    TotalStr = "Total: " + str(int(timeHrMin[0])) + " Hr " + str(int(timeHrMin[1])) + " Min"
    totalTxt.insert(END,TotalStr)




job1 = Job()
job2 = Job()
job3 = Job()
job4 = Job()
job5 = Job()
job6 = Job()
job7 = Job()
job8 = Job()


from tkinter import messagebox

e = Entry(root, width=35, borderwidth=5)
e.grid(row=0, column=0, columnspan=3)
aJob = Button(root, text="Add Job", command=addJob)
aJob.grid(row=2, column=1)
ret = Button(root, text="Enter (XX::YY)", command=ent)
ret.grid(row=1, column=1)
txt = Text(root, height=1, width=25)
txt.grid(column=0, row=1)
totalTxt = Text(root, height=1, width=25)
totalTxt.grid(column=0, row=2)

root.mainloop()
