// Define a grammar called Hello
//
//r  : 'hello' ID ;         // match keyword hello followed by an identifier
//ID : [a-z]+ ;             // match lower-case identifiers
//WS : [ \t\r\n]+ -> skip ; // skip spaces, tabs, newlines


grammar Terra;

// ----------
// -- Helpers
// ----------



// -------------------
// -- Terminal symbols
// -------------------

T_Digit				:	'0' .. '9' ;
T_CapitalLetter		:	'A' .. 'Z' ;
T_Letter 			:	'a' .. 'z' ;
T_BlockStart		:	'{' ;
T_BlockEnd			:	'}'	;
T_StringBeginEnd	:	'"'	;
T_Period			:	'.' ;
T_PathSeparator		:	'/' ;
T_CollectionStart	:	'[' ;
T_CollectionEnd		:	']' ;

// --------
// -- Rules
// --------

WS : (' ' | '\r' | '\t' | '\n')+ -> skip ;

start				
	:	include*? definition*? window EOF ;

identifier		
	:	(T_Letter | '_')(T_Letter | T_CapitalLetter | T_Digit | '_')* ;

frameIdentifier
	:	T_CapitalLEtter (T_Letter | T_CapitalLetter | T_Digit | '_')* ;

identifierChain
	:	identifierChainExpr identifier ;

identifierChainExpr
	:	identifierChainExpr identifier '.'
	| ; // Intentionally left blank

include				
	:	'include' path ;

fileName			
	:	identifier T_Period identifier
	|	identifier ;

definition			
	:	'define' identifier 'as' identifier block
	|	'define' identifier block ;

window				
	:	'Window' block ;

block 				
	:	T_BlockStart statement*? T_BlockEnd ;

statement 			
	:	identifier block
	|	assignment ;

assignment
	:	identifier ':' identifier
	|	identifier ':' identifierChain
	|	identifier ':' frameIdentifier
	|	identifier ':' string
	|	identifier ':' integer
	|	identifier ':' float
	|	identifier ':' boolean
	|	identifier ':' collection 
	|	identifier ':' point ;

collection
	:	T_CollectionStart (frameIdentifier block)*? T_CollectionEnd ;

// -- Types

path				
	:	T_StringBeginEnd pathExpression fileName T_StringBeginEnd ;

pathFolder
	:	

pathExpression		
	:	pathExpression T_Period T_Period T_PathSeparator
	|	pathExpression T_Period T_PathSeparator
	|	pathExpression identifier T_PathSeparator
	|	; // Intentionally left blank

string
	:	T_StringBeginEnd .*? T_StringBeginEnd ;

integer
	:	'-'? T_Digit+ ;

float
	:	'-'? T_Digit* '.' T_Digit+ ;

boolean
	:	'true' | 'false'
	|	'True' | 'False'
	|	'TRUE' | 'FALSE' ;

point
	:	'top' 			|	'TOP' 			| 	'Top'
	|	'topleft' 		|	'TOPLEFT' 		|	'Topleft'		|	'TopLeft'
	|	'topright'		|	'TOPRIGHT'		|	'Topright'		|	'TopRight'
	|	'bottom'		|	'BOTTOM'		|	'Bottom'
	|	'bottomleft'	|	'BOTTOMLEFT'	|	'Bottomleft'	|	'BottomLeft'
	|	'bottomright'	|	'BOTTOMRIGHT'	|	'Bottomright'	|	'BottomRight'
	|	'left'			|	'LEFT'			|	'Left'
	|	'right'			|	'RIGHT'			|	'Right'
	|	'center'		|	'CENTER'		|	'Center' ;




