# -*- coding: utf-8 -*-
"""
Created on Mon Feb 19 19:16:10 2024

@author: Michal
"""

import numpy as np
import re

def solve_pair(left, right, operator):
    result = 0
    if "(" in left:
        left
    match operator:
        case "+":
            result = left + right
        case "-":
            result = left - right
        case "*":
            result = left * right
        case "/":
            result = left / right
    return result
        

N = int(input())
expressions = []
for i in range(0,N):
    expressions.append(input())
for i in range(0,N):
    expression = expressions[i].replace(" ","")
    
    
    
inputString = "(1+2)+(2/(4-1))"
number_or_symbol = re.compile('(\d+|[^ 0-9])')
print(re.findall(number_or_symbol, inputString))
x = re.findall("^(.*)$", inputString, flags=0)
    