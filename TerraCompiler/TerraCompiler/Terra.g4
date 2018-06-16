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
	:	(T_Letter | T_CapitalLetter | '_')(T_Letter | T_CapitalLetter | T_Digit | '_')* ;

include				
	:	'include' path ;

path				
	:	T_StringBeginEnd pathExpression fileName T_StringBeginEnd ;

pathExpression		
	:	pathExpression T_Period T_Period T_PathSeparator
	|	pathExpression T_Period T_PathSeparator
	|	pathExpression identifier T_PathSeparator
	|	; // Intentionally left blank

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
	|	identifier ':' string
	|	identifier ':' number
	|	identifier ':' identifier 
	|	identifier ':' collection 
	|	identifier ':' point ;

string
	:	T_StringBeginEnd .*? T_StringBeginEnd ;

number
	:	'-'? T_Digit+
	|	'-'? T_Digit* '.' T_Digit+ ;

collection
	:	T_CollectionStart (identifier block)*? T_CollectionEnd ;

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




