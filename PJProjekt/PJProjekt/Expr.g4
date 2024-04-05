grammar Expr;
prog: stat+;
stat:
expr NEWLINE
| ID '=' expr NEWLINE
| NEWLINE
;
//is this even OK? Ambiguity?
expr:
expr ('*'|'/') expr
| expr ('+'|'-') expr
| INT
| ID
| '(' expr ')'
;
ID : [a-zA-Z]+ ;
INT : [0-9]+ ;
NEWLINE:'\r'? '\n' ;
WS : [ \t]+ -> skip ;