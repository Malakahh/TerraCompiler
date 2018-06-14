//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 4.7.1
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from Terra.g4 by ANTLR 4.7.1

// Unreachable code detected
#pragma warning disable 0162
// The variable '...' is assigned but its value is never used
#pragma warning disable 0219
// Missing XML comment for publicly visible type or member '...'
#pragma warning disable 1591
// Ambiguous reference in cref attribute
#pragma warning disable 419

using System;
using System.IO;
using System.Text;
using System.Diagnostics;
using System.Collections.Generic;
using Antlr4.Runtime;
using Antlr4.Runtime.Atn;
using Antlr4.Runtime.Misc;
using Antlr4.Runtime.Tree;
using DFA = Antlr4.Runtime.Dfa.DFA;

[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.7.1")]
[System.CLSCompliant(false)]
public partial class TerraParser : Parser {
	protected static DFA[] decisionToDFA;
	protected static PredictionContextCache sharedContextCache = new PredictionContextCache();
	public const int
		T__0=1, T__1=2, T_Digit=3, T_CapitalLetter=4, T_Letter=5, T_BlockStart=6, 
		T_BlockEnd=7, T_StringBeginEnd=8, T_Period=9, T_PathSeparator=10, KW_Include=11, 
		KW_Define=12, KW_Window=13, KW_As=14, WS=15;
	public const int
		RULE_start = 0, RULE_identifier = 1, RULE_include = 2, RULE_path = 3, 
		RULE_pathExpression = 4, RULE_fileName = 5, RULE_definition = 6, RULE_window = 7, 
		RULE_block = 8, RULE_statement = 9;
	public static readonly string[] ruleNames = {
		"start", "identifier", "include", "path", "pathExpression", "fileName", 
		"definition", "window", "block", "statement"
	};

	private static readonly string[] _LiteralNames = {
		null, "'_'", "'Test'", null, null, null, "'{'", "'}'", "'\"'", "'.'", 
		"'/'", "'include'", "'define'", "'Window'", "'as'"
	};
	private static readonly string[] _SymbolicNames = {
		null, null, null, "T_Digit", "T_CapitalLetter", "T_Letter", "T_BlockStart", 
		"T_BlockEnd", "T_StringBeginEnd", "T_Period", "T_PathSeparator", "KW_Include", 
		"KW_Define", "KW_Window", "KW_As", "WS"
	};
	public static readonly IVocabulary DefaultVocabulary = new Vocabulary(_LiteralNames, _SymbolicNames);

	[NotNull]
	public override IVocabulary Vocabulary
	{
		get
		{
			return DefaultVocabulary;
		}
	}

	public override string GrammarFileName { get { return "Terra.g4"; } }

	public override string[] RuleNames { get { return ruleNames; } }

	public override string SerializedAtn { get { return new string(_serializedATN); } }

	static TerraParser() {
		decisionToDFA = new DFA[_ATN.NumberOfDecisions];
		for (int i = 0; i < _ATN.NumberOfDecisions; i++) {
			decisionToDFA[i] = new DFA(_ATN.GetDecisionState(i), i);
		}
	}

		public TerraParser(ITokenStream input) : this(input, Console.Out, Console.Error) { }

		public TerraParser(ITokenStream input, TextWriter output, TextWriter errorOutput)
		: base(input, output, errorOutput)
	{
		Interpreter = new ParserATNSimulator(this, _ATN, decisionToDFA, sharedContextCache);
	}
	public partial class StartContext : ParserRuleContext {
		public WindowContext window() {
			return GetRuleContext<WindowContext>(0);
		}
		public ITerminalNode Eof() { return GetToken(TerraParser.Eof, 0); }
		public IncludeContext[] include() {
			return GetRuleContexts<IncludeContext>();
		}
		public IncludeContext include(int i) {
			return GetRuleContext<IncludeContext>(i);
		}
		public DefinitionContext[] definition() {
			return GetRuleContexts<DefinitionContext>();
		}
		public DefinitionContext definition(int i) {
			return GetRuleContext<DefinitionContext>(i);
		}
		public StartContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_start; } }
		public override void EnterRule(IParseTreeListener listener) {
			ITerraListener typedListener = listener as ITerraListener;
			if (typedListener != null) typedListener.EnterStart(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			ITerraListener typedListener = listener as ITerraListener;
			if (typedListener != null) typedListener.ExitStart(this);
		}
	}

	[RuleVersion(0)]
	public StartContext start() {
		StartContext _localctx = new StartContext(Context, State);
		EnterRule(_localctx, 0, RULE_start);
		try {
			int _alt;
			EnterOuterAlt(_localctx, 1);
			{
			State = 23;
			ErrorHandler.Sync(this);
			_alt = Interpreter.AdaptivePredict(TokenStream,0,Context);
			while ( _alt!=1 && _alt!=global::Antlr4.Runtime.Atn.ATN.INVALID_ALT_NUMBER ) {
				if ( _alt==1+1 ) {
					{
					{
					State = 20; include();
					}
					} 
				}
				State = 25;
				ErrorHandler.Sync(this);
				_alt = Interpreter.AdaptivePredict(TokenStream,0,Context);
			}
			State = 29;
			ErrorHandler.Sync(this);
			_alt = Interpreter.AdaptivePredict(TokenStream,1,Context);
			while ( _alt!=1 && _alt!=global::Antlr4.Runtime.Atn.ATN.INVALID_ALT_NUMBER ) {
				if ( _alt==1+1 ) {
					{
					{
					State = 26; definition();
					}
					} 
				}
				State = 31;
				ErrorHandler.Sync(this);
				_alt = Interpreter.AdaptivePredict(TokenStream,1,Context);
			}
			State = 32; window();
			State = 33; Match(Eof);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class IdentifierContext : ParserRuleContext {
		public ITerminalNode[] T_Letter() { return GetTokens(TerraParser.T_Letter); }
		public ITerminalNode T_Letter(int i) {
			return GetToken(TerraParser.T_Letter, i);
		}
		public ITerminalNode[] T_CapitalLetter() { return GetTokens(TerraParser.T_CapitalLetter); }
		public ITerminalNode T_CapitalLetter(int i) {
			return GetToken(TerraParser.T_CapitalLetter, i);
		}
		public ITerminalNode[] T_Digit() { return GetTokens(TerraParser.T_Digit); }
		public ITerminalNode T_Digit(int i) {
			return GetToken(TerraParser.T_Digit, i);
		}
		public IdentifierContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_identifier; } }
		public override void EnterRule(IParseTreeListener listener) {
			ITerraListener typedListener = listener as ITerraListener;
			if (typedListener != null) typedListener.EnterIdentifier(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			ITerraListener typedListener = listener as ITerraListener;
			if (typedListener != null) typedListener.ExitIdentifier(this);
		}
	}

	[RuleVersion(0)]
	public IdentifierContext identifier() {
		IdentifierContext _localctx = new IdentifierContext(Context, State);
		EnterRule(_localctx, 2, RULE_identifier);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 35;
			_la = TokenStream.LA(1);
			if ( !((((_la) & ~0x3f) == 0 && ((1L << _la) & ((1L << T__0) | (1L << T_CapitalLetter) | (1L << T_Letter))) != 0)) ) {
			ErrorHandler.RecoverInline(this);
			}
			else {
				ErrorHandler.ReportMatch(this);
			    Consume();
			}
			State = 39;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			while ((((_la) & ~0x3f) == 0 && ((1L << _la) & ((1L << T__0) | (1L << T_Digit) | (1L << T_CapitalLetter) | (1L << T_Letter))) != 0)) {
				{
				{
				State = 36;
				_la = TokenStream.LA(1);
				if ( !((((_la) & ~0x3f) == 0 && ((1L << _la) & ((1L << T__0) | (1L << T_Digit) | (1L << T_CapitalLetter) | (1L << T_Letter))) != 0)) ) {
				ErrorHandler.RecoverInline(this);
				}
				else {
					ErrorHandler.ReportMatch(this);
				    Consume();
				}
				}
				}
				State = 41;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
			}
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class IncludeContext : ParserRuleContext {
		public ITerminalNode KW_Include() { return GetToken(TerraParser.KW_Include, 0); }
		public PathContext path() {
			return GetRuleContext<PathContext>(0);
		}
		public IncludeContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_include; } }
		public override void EnterRule(IParseTreeListener listener) {
			ITerraListener typedListener = listener as ITerraListener;
			if (typedListener != null) typedListener.EnterInclude(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			ITerraListener typedListener = listener as ITerraListener;
			if (typedListener != null) typedListener.ExitInclude(this);
		}
	}

	[RuleVersion(0)]
	public IncludeContext include() {
		IncludeContext _localctx = new IncludeContext(Context, State);
		EnterRule(_localctx, 4, RULE_include);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 42; Match(KW_Include);
			State = 43; path();
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class PathContext : ParserRuleContext {
		public ITerminalNode[] T_StringBeginEnd() { return GetTokens(TerraParser.T_StringBeginEnd); }
		public ITerminalNode T_StringBeginEnd(int i) {
			return GetToken(TerraParser.T_StringBeginEnd, i);
		}
		public PathExpressionContext pathExpression() {
			return GetRuleContext<PathExpressionContext>(0);
		}
		public FileNameContext fileName() {
			return GetRuleContext<FileNameContext>(0);
		}
		public PathContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_path; } }
		public override void EnterRule(IParseTreeListener listener) {
			ITerraListener typedListener = listener as ITerraListener;
			if (typedListener != null) typedListener.EnterPath(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			ITerraListener typedListener = listener as ITerraListener;
			if (typedListener != null) typedListener.ExitPath(this);
		}
	}

	[RuleVersion(0)]
	public PathContext path() {
		PathContext _localctx = new PathContext(Context, State);
		EnterRule(_localctx, 6, RULE_path);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 45; Match(T_StringBeginEnd);
			State = 46; pathExpression(0);
			State = 47; fileName();
			State = 48; Match(T_StringBeginEnd);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class PathExpressionContext : ParserRuleContext {
		public PathExpressionContext pathExpression() {
			return GetRuleContext<PathExpressionContext>(0);
		}
		public ITerminalNode[] T_Period() { return GetTokens(TerraParser.T_Period); }
		public ITerminalNode T_Period(int i) {
			return GetToken(TerraParser.T_Period, i);
		}
		public ITerminalNode T_PathSeparator() { return GetToken(TerraParser.T_PathSeparator, 0); }
		public IdentifierContext identifier() {
			return GetRuleContext<IdentifierContext>(0);
		}
		public PathExpressionContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_pathExpression; } }
		public override void EnterRule(IParseTreeListener listener) {
			ITerraListener typedListener = listener as ITerraListener;
			if (typedListener != null) typedListener.EnterPathExpression(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			ITerraListener typedListener = listener as ITerraListener;
			if (typedListener != null) typedListener.ExitPathExpression(this);
		}
	}

	[RuleVersion(0)]
	public PathExpressionContext pathExpression() {
		return pathExpression(0);
	}

	private PathExpressionContext pathExpression(int _p) {
		ParserRuleContext _parentctx = Context;
		int _parentState = State;
		PathExpressionContext _localctx = new PathExpressionContext(Context, _parentState);
		PathExpressionContext _prevctx = _localctx;
		int _startState = 8;
		EnterRecursionRule(_localctx, 8, RULE_pathExpression, _p);
		try {
			int _alt;
			EnterOuterAlt(_localctx, 1);
			{
			{
			}
			Context.Stop = TokenStream.LT(-1);
			State = 64;
			ErrorHandler.Sync(this);
			_alt = Interpreter.AdaptivePredict(TokenStream,4,Context);
			while ( _alt!=2 && _alt!=global::Antlr4.Runtime.Atn.ATN.INVALID_ALT_NUMBER ) {
				if ( _alt==1 ) {
					if ( ParseListeners!=null )
						TriggerExitRuleEvent();
					_prevctx = _localctx;
					{
					State = 62;
					ErrorHandler.Sync(this);
					switch ( Interpreter.AdaptivePredict(TokenStream,3,Context) ) {
					case 1:
						{
						_localctx = new PathExpressionContext(_parentctx, _parentState);
						PushNewRecursionContext(_localctx, _startState, RULE_pathExpression);
						State = 51;
						if (!(Precpred(Context, 4))) throw new FailedPredicateException(this, "Precpred(Context, 4)");
						State = 52; Match(T_Period);
						State = 53; Match(T_Period);
						State = 54; Match(T_PathSeparator);
						}
						break;
					case 2:
						{
						_localctx = new PathExpressionContext(_parentctx, _parentState);
						PushNewRecursionContext(_localctx, _startState, RULE_pathExpression);
						State = 55;
						if (!(Precpred(Context, 3))) throw new FailedPredicateException(this, "Precpred(Context, 3)");
						State = 56; Match(T_Period);
						State = 57; Match(T_PathSeparator);
						}
						break;
					case 3:
						{
						_localctx = new PathExpressionContext(_parentctx, _parentState);
						PushNewRecursionContext(_localctx, _startState, RULE_pathExpression);
						State = 58;
						if (!(Precpred(Context, 2))) throw new FailedPredicateException(this, "Precpred(Context, 2)");
						State = 59; identifier();
						State = 60; Match(T_PathSeparator);
						}
						break;
					}
					} 
				}
				State = 66;
				ErrorHandler.Sync(this);
				_alt = Interpreter.AdaptivePredict(TokenStream,4,Context);
			}
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			UnrollRecursionContexts(_parentctx);
		}
		return _localctx;
	}

	public partial class FileNameContext : ParserRuleContext {
		public IdentifierContext[] identifier() {
			return GetRuleContexts<IdentifierContext>();
		}
		public IdentifierContext identifier(int i) {
			return GetRuleContext<IdentifierContext>(i);
		}
		public ITerminalNode T_Period() { return GetToken(TerraParser.T_Period, 0); }
		public FileNameContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_fileName; } }
		public override void EnterRule(IParseTreeListener listener) {
			ITerraListener typedListener = listener as ITerraListener;
			if (typedListener != null) typedListener.EnterFileName(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			ITerraListener typedListener = listener as ITerraListener;
			if (typedListener != null) typedListener.ExitFileName(this);
		}
	}

	[RuleVersion(0)]
	public FileNameContext fileName() {
		FileNameContext _localctx = new FileNameContext(Context, State);
		EnterRule(_localctx, 10, RULE_fileName);
		try {
			State = 72;
			ErrorHandler.Sync(this);
			switch ( Interpreter.AdaptivePredict(TokenStream,5,Context) ) {
			case 1:
				EnterOuterAlt(_localctx, 1);
				{
				State = 67; identifier();
				State = 68; Match(T_Period);
				State = 69; identifier();
				}
				break;
			case 2:
				EnterOuterAlt(_localctx, 2);
				{
				State = 71; identifier();
				}
				break;
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class DefinitionContext : ParserRuleContext {
		public ITerminalNode KW_Define() { return GetToken(TerraParser.KW_Define, 0); }
		public IdentifierContext[] identifier() {
			return GetRuleContexts<IdentifierContext>();
		}
		public IdentifierContext identifier(int i) {
			return GetRuleContext<IdentifierContext>(i);
		}
		public ITerminalNode KW_As() { return GetToken(TerraParser.KW_As, 0); }
		public BlockContext block() {
			return GetRuleContext<BlockContext>(0);
		}
		public DefinitionContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_definition; } }
		public override void EnterRule(IParseTreeListener listener) {
			ITerraListener typedListener = listener as ITerraListener;
			if (typedListener != null) typedListener.EnterDefinition(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			ITerraListener typedListener = listener as ITerraListener;
			if (typedListener != null) typedListener.ExitDefinition(this);
		}
	}

	[RuleVersion(0)]
	public DefinitionContext definition() {
		DefinitionContext _localctx = new DefinitionContext(Context, State);
		EnterRule(_localctx, 12, RULE_definition);
		try {
			State = 84;
			ErrorHandler.Sync(this);
			switch ( Interpreter.AdaptivePredict(TokenStream,6,Context) ) {
			case 1:
				EnterOuterAlt(_localctx, 1);
				{
				State = 74; Match(KW_Define);
				State = 75; identifier();
				State = 76; Match(KW_As);
				State = 77; identifier();
				State = 78; block();
				}
				break;
			case 2:
				EnterOuterAlt(_localctx, 2);
				{
				State = 80; Match(KW_Define);
				State = 81; identifier();
				State = 82; block();
				}
				break;
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class WindowContext : ParserRuleContext {
		public ITerminalNode KW_Window() { return GetToken(TerraParser.KW_Window, 0); }
		public BlockContext block() {
			return GetRuleContext<BlockContext>(0);
		}
		public WindowContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_window; } }
		public override void EnterRule(IParseTreeListener listener) {
			ITerraListener typedListener = listener as ITerraListener;
			if (typedListener != null) typedListener.EnterWindow(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			ITerraListener typedListener = listener as ITerraListener;
			if (typedListener != null) typedListener.ExitWindow(this);
		}
	}

	[RuleVersion(0)]
	public WindowContext window() {
		WindowContext _localctx = new WindowContext(Context, State);
		EnterRule(_localctx, 14, RULE_window);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 86; Match(KW_Window);
			State = 87; block();
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class BlockContext : ParserRuleContext {
		public ITerminalNode T_BlockStart() { return GetToken(TerraParser.T_BlockStart, 0); }
		public ITerminalNode T_BlockEnd() { return GetToken(TerraParser.T_BlockEnd, 0); }
		public StatementContext[] statement() {
			return GetRuleContexts<StatementContext>();
		}
		public StatementContext statement(int i) {
			return GetRuleContext<StatementContext>(i);
		}
		public BlockContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_block; } }
		public override void EnterRule(IParseTreeListener listener) {
			ITerraListener typedListener = listener as ITerraListener;
			if (typedListener != null) typedListener.EnterBlock(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			ITerraListener typedListener = listener as ITerraListener;
			if (typedListener != null) typedListener.ExitBlock(this);
		}
	}

	[RuleVersion(0)]
	public BlockContext block() {
		BlockContext _localctx = new BlockContext(Context, State);
		EnterRule(_localctx, 16, RULE_block);
		try {
			int _alt;
			EnterOuterAlt(_localctx, 1);
			{
			State = 89; Match(T_BlockStart);
			State = 93;
			ErrorHandler.Sync(this);
			_alt = Interpreter.AdaptivePredict(TokenStream,7,Context);
			while ( _alt!=1 && _alt!=global::Antlr4.Runtime.Atn.ATN.INVALID_ALT_NUMBER ) {
				if ( _alt==1+1 ) {
					{
					{
					State = 90; statement();
					}
					} 
				}
				State = 95;
				ErrorHandler.Sync(this);
				_alt = Interpreter.AdaptivePredict(TokenStream,7,Context);
			}
			State = 96; Match(T_BlockEnd);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class StatementContext : ParserRuleContext {
		public StatementContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_statement; } }
		public override void EnterRule(IParseTreeListener listener) {
			ITerraListener typedListener = listener as ITerraListener;
			if (typedListener != null) typedListener.EnterStatement(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			ITerraListener typedListener = listener as ITerraListener;
			if (typedListener != null) typedListener.ExitStatement(this);
		}
	}

	[RuleVersion(0)]
	public StatementContext statement() {
		StatementContext _localctx = new StatementContext(Context, State);
		EnterRule(_localctx, 18, RULE_statement);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 98; Match(T__1);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public override bool Sempred(RuleContext _localctx, int ruleIndex, int predIndex) {
		switch (ruleIndex) {
		case 4: return pathExpression_sempred((PathExpressionContext)_localctx, predIndex);
		}
		return true;
	}
	private bool pathExpression_sempred(PathExpressionContext _localctx, int predIndex) {
		switch (predIndex) {
		case 0: return Precpred(Context, 4);
		case 1: return Precpred(Context, 3);
		case 2: return Precpred(Context, 2);
		}
		return true;
	}

	private static char[] _serializedATN = {
		'\x3', '\x608B', '\xA72A', '\x8133', '\xB9ED', '\x417C', '\x3BE7', '\x7786', 
		'\x5964', '\x3', '\x11', 'g', '\x4', '\x2', '\t', '\x2', '\x4', '\x3', 
		'\t', '\x3', '\x4', '\x4', '\t', '\x4', '\x4', '\x5', '\t', '\x5', '\x4', 
		'\x6', '\t', '\x6', '\x4', '\a', '\t', '\a', '\x4', '\b', '\t', '\b', 
		'\x4', '\t', '\t', '\t', '\x4', '\n', '\t', '\n', '\x4', '\v', '\t', '\v', 
		'\x3', '\x2', '\a', '\x2', '\x18', '\n', '\x2', '\f', '\x2', '\xE', '\x2', 
		'\x1B', '\v', '\x2', '\x3', '\x2', '\a', '\x2', '\x1E', '\n', '\x2', '\f', 
		'\x2', '\xE', '\x2', '!', '\v', '\x2', '\x3', '\x2', '\x3', '\x2', '\x3', 
		'\x2', '\x3', '\x3', '\x3', '\x3', '\a', '\x3', '(', '\n', '\x3', '\f', 
		'\x3', '\xE', '\x3', '+', '\v', '\x3', '\x3', '\x4', '\x3', '\x4', '\x3', 
		'\x4', '\x3', '\x5', '\x3', '\x5', '\x3', '\x5', '\x3', '\x5', '\x3', 
		'\x5', '\x3', '\x6', '\x3', '\x6', '\x3', '\x6', '\x3', '\x6', '\x3', 
		'\x6', '\x3', '\x6', '\x3', '\x6', '\x3', '\x6', '\x3', '\x6', '\x3', 
		'\x6', '\x3', '\x6', '\x3', '\x6', '\a', '\x6', '\x41', '\n', '\x6', '\f', 
		'\x6', '\xE', '\x6', '\x44', '\v', '\x6', '\x3', '\a', '\x3', '\a', '\x3', 
		'\a', '\x3', '\a', '\x3', '\a', '\x5', '\a', 'K', '\n', '\a', '\x3', '\b', 
		'\x3', '\b', '\x3', '\b', '\x3', '\b', '\x3', '\b', '\x3', '\b', '\x3', 
		'\b', '\x3', '\b', '\x3', '\b', '\x3', '\b', '\x5', '\b', 'W', '\n', '\b', 
		'\x3', '\t', '\x3', '\t', '\x3', '\t', '\x3', '\n', '\x3', '\n', '\a', 
		'\n', '^', '\n', '\n', '\f', '\n', '\xE', '\n', '\x61', '\v', '\n', '\x3', 
		'\n', '\x3', '\n', '\x3', '\v', '\x3', '\v', '\x3', '\v', '\x5', '\x19', 
		'\x1F', '_', '\x3', '\n', '\f', '\x2', '\x4', '\x6', '\b', '\n', '\f', 
		'\xE', '\x10', '\x12', '\x14', '\x2', '\x4', '\x4', '\x2', '\x3', '\x3', 
		'\x6', '\a', '\x4', '\x2', '\x3', '\x3', '\x5', '\a', '\x2', '\x65', '\x2', 
		'\x19', '\x3', '\x2', '\x2', '\x2', '\x4', '%', '\x3', '\x2', '\x2', '\x2', 
		'\x6', ',', '\x3', '\x2', '\x2', '\x2', '\b', '/', '\x3', '\x2', '\x2', 
		'\x2', '\n', '\x34', '\x3', '\x2', '\x2', '\x2', '\f', 'J', '\x3', '\x2', 
		'\x2', '\x2', '\xE', 'V', '\x3', '\x2', '\x2', '\x2', '\x10', 'X', '\x3', 
		'\x2', '\x2', '\x2', '\x12', '[', '\x3', '\x2', '\x2', '\x2', '\x14', 
		'\x64', '\x3', '\x2', '\x2', '\x2', '\x16', '\x18', '\x5', '\x6', '\x4', 
		'\x2', '\x17', '\x16', '\x3', '\x2', '\x2', '\x2', '\x18', '\x1B', '\x3', 
		'\x2', '\x2', '\x2', '\x19', '\x1A', '\x3', '\x2', '\x2', '\x2', '\x19', 
		'\x17', '\x3', '\x2', '\x2', '\x2', '\x1A', '\x1F', '\x3', '\x2', '\x2', 
		'\x2', '\x1B', '\x19', '\x3', '\x2', '\x2', '\x2', '\x1C', '\x1E', '\x5', 
		'\xE', '\b', '\x2', '\x1D', '\x1C', '\x3', '\x2', '\x2', '\x2', '\x1E', 
		'!', '\x3', '\x2', '\x2', '\x2', '\x1F', ' ', '\x3', '\x2', '\x2', '\x2', 
		'\x1F', '\x1D', '\x3', '\x2', '\x2', '\x2', ' ', '\"', '\x3', '\x2', '\x2', 
		'\x2', '!', '\x1F', '\x3', '\x2', '\x2', '\x2', '\"', '#', '\x5', '\x10', 
		'\t', '\x2', '#', '$', '\a', '\x2', '\x2', '\x3', '$', '\x3', '\x3', '\x2', 
		'\x2', '\x2', '%', ')', '\t', '\x2', '\x2', '\x2', '&', '(', '\t', '\x3', 
		'\x2', '\x2', '\'', '&', '\x3', '\x2', '\x2', '\x2', '(', '+', '\x3', 
		'\x2', '\x2', '\x2', ')', '\'', '\x3', '\x2', '\x2', '\x2', ')', '*', 
		'\x3', '\x2', '\x2', '\x2', '*', '\x5', '\x3', '\x2', '\x2', '\x2', '+', 
		')', '\x3', '\x2', '\x2', '\x2', ',', '-', '\a', '\r', '\x2', '\x2', '-', 
		'.', '\x5', '\b', '\x5', '\x2', '.', '\a', '\x3', '\x2', '\x2', '\x2', 
		'/', '\x30', '\a', '\n', '\x2', '\x2', '\x30', '\x31', '\x5', '\n', '\x6', 
		'\x2', '\x31', '\x32', '\x5', '\f', '\a', '\x2', '\x32', '\x33', '\a', 
		'\n', '\x2', '\x2', '\x33', '\t', '\x3', '\x2', '\x2', '\x2', '\x34', 
		'\x42', '\b', '\x6', '\x1', '\x2', '\x35', '\x36', '\f', '\x6', '\x2', 
		'\x2', '\x36', '\x37', '\a', '\v', '\x2', '\x2', '\x37', '\x38', '\a', 
		'\v', '\x2', '\x2', '\x38', '\x41', '\a', '\f', '\x2', '\x2', '\x39', 
		':', '\f', '\x5', '\x2', '\x2', ':', ';', '\a', '\v', '\x2', '\x2', ';', 
		'\x41', '\a', '\f', '\x2', '\x2', '<', '=', '\f', '\x4', '\x2', '\x2', 
		'=', '>', '\x5', '\x4', '\x3', '\x2', '>', '?', '\a', '\f', '\x2', '\x2', 
		'?', '\x41', '\x3', '\x2', '\x2', '\x2', '@', '\x35', '\x3', '\x2', '\x2', 
		'\x2', '@', '\x39', '\x3', '\x2', '\x2', '\x2', '@', '<', '\x3', '\x2', 
		'\x2', '\x2', '\x41', '\x44', '\x3', '\x2', '\x2', '\x2', '\x42', '@', 
		'\x3', '\x2', '\x2', '\x2', '\x42', '\x43', '\x3', '\x2', '\x2', '\x2', 
		'\x43', '\v', '\x3', '\x2', '\x2', '\x2', '\x44', '\x42', '\x3', '\x2', 
		'\x2', '\x2', '\x45', '\x46', '\x5', '\x4', '\x3', '\x2', '\x46', 'G', 
		'\a', '\v', '\x2', '\x2', 'G', 'H', '\x5', '\x4', '\x3', '\x2', 'H', 'K', 
		'\x3', '\x2', '\x2', '\x2', 'I', 'K', '\x5', '\x4', '\x3', '\x2', 'J', 
		'\x45', '\x3', '\x2', '\x2', '\x2', 'J', 'I', '\x3', '\x2', '\x2', '\x2', 
		'K', '\r', '\x3', '\x2', '\x2', '\x2', 'L', 'M', '\a', '\xE', '\x2', '\x2', 
		'M', 'N', '\x5', '\x4', '\x3', '\x2', 'N', 'O', '\a', '\x10', '\x2', '\x2', 
		'O', 'P', '\x5', '\x4', '\x3', '\x2', 'P', 'Q', '\x5', '\x12', '\n', '\x2', 
		'Q', 'W', '\x3', '\x2', '\x2', '\x2', 'R', 'S', '\a', '\xE', '\x2', '\x2', 
		'S', 'T', '\x5', '\x4', '\x3', '\x2', 'T', 'U', '\x5', '\x12', '\n', '\x2', 
		'U', 'W', '\x3', '\x2', '\x2', '\x2', 'V', 'L', '\x3', '\x2', '\x2', '\x2', 
		'V', 'R', '\x3', '\x2', '\x2', '\x2', 'W', '\xF', '\x3', '\x2', '\x2', 
		'\x2', 'X', 'Y', '\a', '\xF', '\x2', '\x2', 'Y', 'Z', '\x5', '\x12', '\n', 
		'\x2', 'Z', '\x11', '\x3', '\x2', '\x2', '\x2', '[', '_', '\a', '\b', 
		'\x2', '\x2', '\\', '^', '\x5', '\x14', '\v', '\x2', ']', '\\', '\x3', 
		'\x2', '\x2', '\x2', '^', '\x61', '\x3', '\x2', '\x2', '\x2', '_', '`', 
		'\x3', '\x2', '\x2', '\x2', '_', ']', '\x3', '\x2', '\x2', '\x2', '`', 
		'\x62', '\x3', '\x2', '\x2', '\x2', '\x61', '_', '\x3', '\x2', '\x2', 
		'\x2', '\x62', '\x63', '\a', '\t', '\x2', '\x2', '\x63', '\x13', '\x3', 
		'\x2', '\x2', '\x2', '\x64', '\x65', '\a', '\x4', '\x2', '\x2', '\x65', 
		'\x15', '\x3', '\x2', '\x2', '\x2', '\n', '\x19', '\x1F', ')', '@', '\x42', 
		'J', 'V', '_',
	};

	public static readonly ATN _ATN =
		new ATNDeserializer().Deserialize(_serializedATN);


}
