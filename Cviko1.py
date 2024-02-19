# -*- coding: utf-8 -*-
"""
Created on Mon Feb 19 19:16:10 2024

@author: Michal
"""

import numpy as np
import re

def solve_pair(left, right, operator):
    result = 0
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

def numericOperation(left, right, operator):
    result = 0
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

errorFlag = 0
target = "(((2*2+3)*4)+2)"
while(target[0] == "(" and target[-1] == ")"):#trim useless brackets
    target = target.removeprefix("(")#Remove leading bracket
    target = target.removesuffix(")")#Remove trailing bracket
characters = []# 2d list with rows being ith bracket and col is the character on jth position in the bracket
operationStack = []
bracketsStack = []
for i in range(0,len(target)):
    if(target[i] == "("):#If brackets start, push them on stack
        bracketsStack.append(target[i])
    elif(target[i] == ")"):#If brackets end, pop them from stack
        characters[-2] = numericOperation(int(characters[-2]),int(characters[-1]),operationStack[-1])#if you come to the end of the bracket, do the operation that is in bracket
        characters.pop()
        operationStack.pop()
        bracketsStack.pop()
    elif(len(characters) == 0):#First number in the sequence 
        characters.append(target[i])
    elif(target[i-1] in ["+","-","*","/"] and target[i] in ["+","-","*","/"]):#If there are 2 operators after each other it means error
        errorFlag = 1#set the errorFlag to 1 to notify other parts of the program that this expression is not correct
        print("ERROR")
        break
    elif(target[i] in ["+","-","*","/"]):#Check if current char is operator
        operationStack.append(target[i])
    elif(operationStack[-1] == "*" and len(bracketsStack) == 0):#If last operator was multiplication and brackets didnt just start then do it target[i-1] not in  ["(",")"]
        characters[-1] = int(characters[-1])*int(target[i])
        operationStack.pop()
    elif(operationStack[-1] == "/" and len(bracketsStack) == 0):#If last operator was dividation and brackets didnt just start then do it
        characters[-1] = int(characters[-1])/int(target[i])
        operationStack.pop()
    else:
        characters.append(target[i])
        #characters[-1] = int(characters[-1]*target[i+1]
while (len(operationStack) != 0 and errorFlag == 0):
    match operationStack[-1]:
        case "+":
            characters[-2] = int(characters[-2]) + int(characters[-1])
        case "-":
            characters[-2] = int(characters[-2]) - int(characters[-1])
    characters.pop()
    operationStack.pop()
if(errorFlag == 0):
    print(characters[0])

    
    
    
    
    
    