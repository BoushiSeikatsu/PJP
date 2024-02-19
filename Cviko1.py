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
processedString = re.findall(number_or_symbol, inputString)

target = "2+3*4"
characters = []
operationStack = []
for i in range(0,len(target)):
    if(target[i] in ["+","-","*","/"]):#Check if current char is operator
        operationStack.append(target[i])
    elif(len(operationStack) == 0):#First number in the sequence 
        characters.append(target[i])
    elif(operationStack[-1] == "*"):#If last operator was multiplication then do it
        characters[-1] = int(characters[-1])*int(target[i])
        operationStack.pop()
    elif(operationStack[-1] == "/"):#If last operator was dividation then do it
        characters[-1] = int(characters[-1])/int(target[i])
        operationStack.pop()
    else:
        characters.append(target[i])
        #characters[-1] = int(characters[-1]*target[i+1]
while (len(operationStack) != 0):
    match operationStack[-1]:
        case "+":
            characters[-2] = int(characters[-2]) + int(characters[-1])
        case "-":
            characters[-2] = int(characters[-2]) - int(characters[-1])
    characters.pop()
    operationStack.pop()
    
    
    
    
    
    
    