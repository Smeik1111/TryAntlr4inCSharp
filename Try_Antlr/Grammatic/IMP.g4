grammar IMP;

prog      : block ;

block     : '{' (block+ | statement)+ '}' 
          | '{' '}' 
          ;

statement :  statementSemicolonRequired ';'   #Statment
          |  'while' exp block                #While
          |  'if' exp block 'else' block      #IfThenElse 
          |  ';'                              #emptyStatment
          ;

statementSemicolonRequired :  VAR ':=' exp                    #VariableDeclaration
                           |  VAR '=' exp                     #VariableAssignment
                           |  'print' exp                     #Print
                           ;

exp : INT              #Int
    | BOOL             #Bool
    | VAR             #Variables
    | exp '+' exp      #Addition
    | exp '*' exp      #Multiplication
    | exp '||' exp     #Disjunction
    | exp '&&' exp     #Conjunction
    | '!' exp          #Negation
    | exp '==' exp     #Equality
    | exp '<' exp      #Lesser
    | '(' exp ')'      #Brackets
    ;
  

//Lexer:
INT : '-'[0-9]+ | [0-9]+ ;
BOOL: 'false' | 'true' ;
VAR:  [a-z] ([a-z] | [A-Z])+;

//Ignore Whitespace
WS : [ \t\r\n]+ -> skip ;
