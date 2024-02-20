# -*- coding: utf-8 -*-
"""
Created on Tue Feb 20 16:21:15 2024

@author: Michal
"""
import re
import numpy as np
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

def finishBrackets(characters, operationStack):    
    while (len(operationStack) != 0):
        match operationStack[-1]:
            case "+":
                characters[-2] = int(characters[-2]) + int(characters[-1])
            case "-":
                characters[-2] = int(characters[-2]) - int(characters[-1])
        characters.pop()
        operationStack.pop()
    return characters[0]

errorFlag = 0
target = "(((2*2+3*2)*4+2)+2)"
while(target[0] == "(" and target[-1] == ")"):#trim useless brackets
    target = target.removeprefix("(")#Remove leading bracket
    target = target.removesuffix(")")#Remove trailing bracket
bracketsCount = 0
maxBracketCount = 0
for char in target:
    if(char == "("):
        bracketsCount += 1
        if(maxBracketCount < bracketsCount):
            maxBracketCount = bracketsCount
    elif(char == ")"):
        bracketsCount -= 1
if(bracketsCount != 0):
    errorFlag = 1

characters = [] # 2d list with rows being ith bracket and col is the character on jth position in the bracket
operationStack = []
for row in range(0,maxBracketCount + 1):
    characters.append([])
    operationStack.append([])
bracketsStack = []
for i in range(0,len(target)):
    if(errorFlag == 1):
        print("ERROR")
        break
    if(target[i] == "("):#If brackets start, push them on stack
        bracketsStack.append(target[i])
    elif(target[i] == ")"):#If brackets end, pop them from stack
        characters[len(bracketsStack)-1].append(finishBrackets(characters[len(bracketsStack)],operationStack[len(bracketsStack)]))#if you come to the end of the bracket, do the operation that is in bracket
        characters[len(bracketsStack)].pop()
        #operationStack[len(bracketsStack)].pop()
        bracketsStack.pop()
    elif(len(characters[len(bracketsStack)]) == 0):#First number in the sequence 
        characters[len(bracketsStack)].append(target[i])
    elif(target[i-1] in ["+","-","*","/"] and target[i] in ["+","-","*","/"]):#If there are 2 operators after each other it means error
        errorFlag = 1#set the errorFlag to 1 to notify other parts of the program that this expression is not correct
        print("ERROR")
        break
    elif(target[i] in ["+","-","*","/"]):#Check if current char is operator
        operationStack[len(bracketsStack)].append(target[i])
    elif(operationStack[len(bracketsStack)][-1] == "*"):#If last operator was multiplication and brackets didnt just start then do it target[i-1] not in  ["(",")"]
        characters[len(bracketsStack)][-1] = int(characters[len(bracketsStack)][-1])*int(target[i])
        operationStack[len(bracketsStack)].pop()
    elif(operationStack[len(bracketsStack)][-1] == "/"):#If last operator was dividation and brackets didnt just start then do it
        characters[len(bracketsStack)][-1] = int(characters[len(bracketsStack)][-1])/int(target[i])
        operationStack[len(bracketsStack)].pop()
    else:
        characters[len(bracketsStack)].append(target[i])
        #characters[-1] = int(characters[-1]*target[i+1]
finishBrackets(characters[0], operationStack[0])