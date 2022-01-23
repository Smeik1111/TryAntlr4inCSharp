grammar BasicMath;

//Parser
equation
    : '(' equation ')' #BRACKETS
    | op=('+'|'-') equation #UNARY
    | left=equation '*' right=equation #MULTIPLY 
    | left=equation '+' right=equation #PLUS 
    | left=equation '-' right=equation #MINUS 
    | left=equation '/' right=equation #DIVIDE
    | atom=(INT | FLOAT) #ATOM
    ;

//Lexer
INT : [0-9]+ ;
FLOAT : [0-9]+ '.' [0-9]+;

//Ignore Whitespace
WS : [ \t\r\n]+ -> skip ;
