# -*- coding: utf-8 -*-
"""
Created on Mon Feb 26 19:00:16 2024

@author: Michal
"""
import re
target = "    -2 + (245 div 3);  // note\n2 mod 3 * hello"
   
identifierRule = re.compile('([a-zA-Z]+[0-9]*)')
identifiers = re.findall(identifierRule, target)

numberRule = re.compile('[0-9]+')
numbers = re.findall(numberRule, target)

operatorRule = re.compile('[+*/-]')
operators = re.findall(operatorRule, target)

delimiterRule = re.compile('[();]')
delimiters = re.findall(delimiterRule, target)

keywordRule = re.compile('div|mod')
keywords = re.findall(keywordRule, target)



lines = target.splitlines()
tokens = []
for target in lines:
    comment = re.search('(.*)(//.*)', target)
    if comment:
        target = comment.group(1)
    number_or_symbol = re.compile('(\d+|[a-zA-Z]+[0-9]*|[^ 0-9])')
    targetProcessed = re.findall(number_or_symbol, target)
    
    for i in range(0,len(targetProcessed)):
        token = targetProcessed[i]
        if(token in keywords):
            tokens.append((token.upper(),""))
            continue
        if(token in identifiers):
            tokens.append(("ID",token))
            continue
        if(token in numbers):
            tokens.append(("NUM",token))
            continue
        if(token in delimiters):
            tokens.append(("DEL",token))
            continue
        if(token in operators):
            tokens.append(("OP",token))
                
            