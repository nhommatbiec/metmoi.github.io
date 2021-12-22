import numpy
import pandas
from sklearn import datasets
import tkinter as tk
from tkinter import *
from tkinter.ttk import *
from tkinter import ttk
from sklearn.model_selection import train_test_split
from sklearn import tree
import sklearn.metrics

root= Tk()
root.geometry("500x550")

label = ttk.Label(root, text="DỰ ĐOÁN MUA LOPTOP", foreground='red', font=("Arial", 20, "bold"))
label.place(x=100, y=50)

lbl1 = ttk.Label(root,text="Tuổi:")
lbl1.place(x=130,y=150)
cbb1 = ttk.Combobox(root)
cbb1['values'] = ("<20", "20...30", "31...40", ">40")
cbb1.place(x=250, y=150)

lbl2 = ttk.Label(root,text="Thu nhập:")
lbl2.place(x=130,y=200)
cbb2 = ttk.Combobox(root)
cbb2['values'] = ("Cao", "Thap", "TB")
cbb2.place(x=250, y=200)

lbl3 = ttk.Label(root,text="Chức vụ:")
lbl3.place(x=130,y=250)
cbb3 = ttk.Combobox(root)
cbb3['values'] = ("HocSinh", "SinhVien", "CongNhan", "NhanVien")
cbb3.place(x=250, y=250)

lbl4 = ttk.Label(root,text="Ram:")
lbl4.place(x=130,y=300)
cbb4 = ttk.Combobox(root)
cbb4['values'] = (4, 8, 16)
cbb4.place(x=250, y=300)

lbl5 = ttk.Label(root,text="SSD:")
lbl5.place(x=130,y=350)
cbb5 = ttk.Combobox(root)
cbb5['values'] = (215, 512)
cbb5.place(x=250, y=350)

lbl6 = ttk.Label(root,text="Hãng:")
lbl6.place(x=130,y=400)
cbb6 = ttk.Combobox(root)
cbb6['values'] = ("MAC", "HP", "ASUS", "DELL")
cbb6.place(x=250, y=400)

root.mainloop()