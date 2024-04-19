using Antlr4.Runtime.Misc;
using Antlr4.Runtime.Tree;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PLC_Lab9
{
    public class CodeGenerator : PLC_Lab9_exprBaseVisitor<string>
    {
        private ParseTreeProperty<Type> Types;
        private SymbolTable SymbolTable;

        public CodeGenerator(ParseTreeProperty<Type> types, SymbolTable symbolTable)
        {
            Types = types;
            SymbolTable = symbolTable;
        }

    }
}
