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

// -- Keywords

KW_Include			:	'include' ;
KW_Define			:	'define' ;
KW_Window			:	'Window' ;
KW_As				:	'as' ;

// --------
// -- Rules
// --------

WS : (' ' | '\r' | '\t' | '\n')+ -> skip ;

start				:	include*? definition*? window EOF ;


identifier		:	(T_Letter | T_CapitalLetter | '_')(T_Letter | T_CapitalLetter | T_Digit | '_')* ;

include				
	:	KW_Include path ;

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
	:	KW_Define identifier KW_As identifier block
	|	KW_Define identifier block ;

window				
	:	KW_Window block ;

block 				
	:	T_BlockStart statement*? T_BlockEnd ;

statement 			
	:	'Test' ;
