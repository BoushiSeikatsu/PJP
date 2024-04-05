grammar ANTLRGrammar;

/** The start rule; begin parsing here. */
program: statement+ ;

statement
    : primitiveType IDENTIFIER (',' IDENTIFIER)* ';' # declaration
    | SEMI                                           # emptyStatement
    | expr ';'                                       # printExpr
    | READ IDENTIFIER (',' IDENTIFIER)* ';'          # readId
    | WRITE expr (',' expr)* ';'         # writeId
    | '{' statement+ '}'                             # blockStatements
    | IF '('joinedCondition')' statement (ELSE statement)?     # condStatement
    | WHILE '('joinedCondition')' statement          # loopStatement
    ;

condition
    : expr COMPARER expr (condition)*                # multipleExprCmp
    | expr EQUALITY expr (condition)*                # multipleExprEq
    | expr                                           # singleExpr
    ;

joinedCondition
    : condition LOGICALAND joinedCondition          # multipleCondsAnd
    | condition LOGICALOR joinedCondition           # multipleCondsOr
    | condition                                     # singleCond
    ;

expr
    : (op=SUB) expr                         # arNegation
    | (op=NOT) expr                         # lgNegation
    | expr op=(MUL|DIV|MOD) expr            # mulDiv
    | expr op=(ADD|SUB|DOT) expr            # addSub
    | expr (op=COMPARER) expr               # compare
    | expr (op=EQUALITY) expr               # equality
    | expr (op=LOGICALAND) expr             # logicalAnd
    | expr (op=LOGICALOR) expr              # logicalOr
    | INT                                   # int
    | IDENTIFIER                            # id
    | FLOAT                                 # float
    | STRING                                # string
    | BOOL                                  # bool
    | '(' expr ')'                          # parens
    | <assoc=right> IDENTIFIER '=' expr     # assignment
    ;

primitiveType
    : type=INT_KEYWORD
    | type=FLOAT_KEYWORD
    | type=BOOL_KEYWORD
    | type=STRING_KEYWORD
    ;


INT_KEYWORD : 'int';
FLOAT_KEYWORD : 'float';
BOOL_KEYWORD: 'bool';
STRING_KEYWORD: 'string';
IF: 'if';
ELSE: 'else';
READ: 'read';
WRITE: 'write';
WHILE: 'while';
SEMI: ';';
COMMA: ',';
DOT: '.';
NOT : '!' ;
MOD : '%' ;
MUL : '*' ; 
DIV : '/' ;
ADD : '+' ;
SUB : '-' ;
ASSIGNMENT: '=';
COMPARER : '>' | '<' ;
EQUALITY : '==' | '!=';
LOGICALOR : '||';
LOGICALAND : '&&';
STRING: '"'(.)*?'"';
IDENTIFIER : [a-zA-Z][a-zA-Z0-9]* ; 
FLOAT : [0-9]+'.'[0-9]+ ;
INT : [0-9]+ ;
BOOL: 'true' | 'false';
WS : [ \t\r\n]+ -> skip ; // toss out whitespace