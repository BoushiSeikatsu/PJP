# -*- coding: utf-8 -*-
"""
Created on Fri Apr 19 09:37:04 2024

@author: msi pc
"""
import math

class Interpreter:
    def __init__(self):
        self.stack = []

    def push(self, value_type, value):
        if value_type == 'S':
            self.stack.append(str(value))
        elif value_type == 'I':
            self.stack.append(int(value))
        elif value_type == 'F':
            self.stack.append(float(value))
        elif value_type == 'B':
            self.stack.append(bool(value))
        #print(type(self.stack[-1]))

    def pop(self):
        return self.stack.pop()

    def printN(self, n):
        values = []
        n = int(n)
        for i in range(0,n):
            values.append(self.stack.pop())
        stringToPrint = ""
        #print(values)
        #print(self.stack)
        for i in range(1,n + 1):
            value = str(values[-i]).replace('\"', "")
            stringToPrint += value
        print(stringToPrint)

    def save(self, var_name):
        value = self.pop()
        setattr(self, var_name, value)

    def load(self, var_name):
        value = getattr(self, var_name)
        self.stack.append(value)

    def add(self):
        op2 = self.pop()
        op1 = self.pop()
        self.stack.append(op1 + op2)

    def sub(self):
        op2 = self.pop()
        op1 = self.pop()
        self.stack.append(op1 - op2)
        
    def mul(self):
        op2 = self.pop()
        op1 = self.pop()
        self.stack.append(op1 * op2)
        
    def div(self):
        op2 = self.pop()
        op1 = self.pop()
        #print(f'Deleni intu: {type(op1)}/{type(op2)} = {op1/op2}')
        if(type(op1) is int and type(op2) is int):
            self.stack.append(math.floor(op1 / op2))
        else:
            self.stack.append(op1 / op2)
        
    def mod(self):
        op2 = self.pop()
        op1 = self.pop()
        self.stack.append(op1 % op2)
        
    def uminus(self):
        op1 = self.pop()
        self.stack.append(-op1)
        
    def concat(self):
        op2 = self.pop()
        op1 = self.pop()
        self.stack.append(op1 + op2)
        
    def logAnd(self):
        op2 = self.pop()
        op1 = self.pop()
        self.stack.append(op1 and op2)
    
    def logOr(self):
        op2 = self.pop()
        op1 = self.pop()
        self.stack.append(op1 or op2)
       
    def gt(self):
        op2 = self.pop()
        op1 = self.pop()
        self.stack.append(op1 > op2)
    
    def lt(self):
        op2 = self.pop()
        op1 = self.pop()
        self.stack.append(op1 < op2)
        
    def eq(self):
        op2 = self.pop()
        op1 = self.pop()
        self.stack.append(op1 == op2)
        
    def logNot(self):
        op1 = self.pop()
        self.stack.append(not op1)
        
    def itof(self):
        op1 = self.pop()
        self.stack.append(float(op1))

    # Implement other arithmetic operations similarly

    def run(self, instructions):
        instructions = code.split("\n")
        for instruction in instructions:
            parts = instruction.split(' ', 2)
            print(parts)
            operation = parts[0]
            if operation == 'push':
                self.push(parts[1], parts[2])
            elif operation == 'print':
                self.printN(parts[1])
            elif operation == 'save':
                self.save(parts[1])
            elif operation == 'load':
                self.load(parts[1])
            elif operation == 'add':
                self.add()
            elif operation == 'sub':
                self.sub()
            elif operation == 'mul':
                self.mul()
            elif operation == 'div':
                self.div()
            elif operation == 'mod':
                self.mod()
            elif operation == 'uminus':
                self.uminus()
            elif operation == 'concat':
                self.concat()
            elif operation == 'and':
                self.logAnd()
            elif operation == 'or':
                self.logOr()
            elif operation == 'gt':
                self.gt()
            elif operation == 'lt':
                self.lt()
            elif operation == 'eq':
                self.eq()
            elif operation == 'not':
                self.logNot()
            elif operation == 'itof':
                self.itof()
            elif operation == 'read':
                self.itof()

# Example usage
with(open("output.txt","r")) as f:
    code = f.read()
 

interpreter = Interpreter()
interpreter.run(code)
