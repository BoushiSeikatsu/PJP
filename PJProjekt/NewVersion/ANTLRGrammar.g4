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
    | IF '('expr')' statement (ELSE statement)?     # condStatement
    | WHILE '('expr')' statement          # whileLoopStatement
    ;

condition
    : expr                                           # singleExpr
    ;

joinedCondition
    : condition LOGICALAND joinedCondition          # multipleCondsAnd
    | condition LOGICALOR joinedCondition           # multipleCondsOr
    | condition                                     # singleCond
    ;

expr
    : (op=SUB) expr                         # arNegation
    | (op=NOT) expr                         # lgNegation
    | expr op=(MUL|DIV) expr                # mulDiv
    | expr MOD expr                         # modulo
    | expr op=(ADD|SUB) expr                # addSub
    | expr DOT expr                         # concat
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
BOOL: 'true' | 'false';
STRING: '"'(.)*?'"';
IDENTIFIER : [a-zA-Z][a-zA-Z0-9]* ; 
FLOAT : [0-9]+'.'[0-9]+ ;
INT : [0-9]+ ;
WS : [ \t\r\n]+ -> skip ; // toss out whitespace
COMMENT: '/*' .*? '*/' -> skip;
LINE_COMMENT: '//' ~[\r\n]* -> skip;