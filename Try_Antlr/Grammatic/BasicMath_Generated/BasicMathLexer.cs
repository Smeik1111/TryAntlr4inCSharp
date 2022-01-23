//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 4.9.3
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from .\BasicMath.g4 by ANTLR 4.9.3

// Unreachable code detected
#pragma warning disable 0162
// The variable '...' is assigned but its value is never used
#pragma warning disable 0219
// Missing XML comment for publicly visible type or member '...'
#pragma warning disable 1591
// Ambiguous reference in cref attribute
#pragma warning disable 419

namespace BasicMath {
using System;
using System.IO;
using System.Text;
using Antlr4.Runtime;
using Antlr4.Runtime.Atn;
using Antlr4.Runtime.Misc;
using DFA = Antlr4.Runtime.Dfa.DFA;

[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.9.3")]
[System.CLSCompliant(false)]
public partial class BasicMathLexer : Lexer {
	protected static DFA[] decisionToDFA;
	protected static PredictionContextCache sharedContextCache = new PredictionContextCache();
	public const int
		T__0=1, T__1=2, T__2=3, T__3=4, T__4=5, T__5=6, INT=7, FLOAT=8, WS=9;
	public static string[] channelNames = {
		"DEFAULT_TOKEN_CHANNEL", "HIDDEN"
	};

	public static string[] modeNames = {
		"DEFAULT_MODE"
	};

	public static readonly string[] ruleNames = {
		"T__0", "T__1", "T__2", "T__3", "T__4", "T__5", "INT", "FLOAT", "WS"
	};


	public BasicMathLexer(ICharStream input)
	: this(input, Console.Out, Console.Error) { }

	public BasicMathLexer(ICharStream input, TextWriter output, TextWriter errorOutput)
	: base(input, output, errorOutput)
	{
		Interpreter = new LexerATNSimulator(this, _ATN, decisionToDFA, sharedContextCache);
	}

	private static readonly string[] _LiteralNames = {
		null, "'('", "')'", "'+'", "'-'", "'*'", "'/'"
	};
	private static readonly string[] _SymbolicNames = {
		null, null, null, null, null, null, null, "INT", "FLOAT", "WS"
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

	public override string GrammarFileName { get { return "BasicMath.g4"; } }

	public override string[] RuleNames { get { return ruleNames; } }

	public override string[] ChannelNames { get { return channelNames; } }

	public override string[] ModeNames { get { return modeNames; } }

	public override string SerializedAtn { get { return new string(_serializedATN); } }

	static BasicMathLexer() {
		decisionToDFA = new DFA[_ATN.NumberOfDecisions];
		for (int i = 0; i < _ATN.NumberOfDecisions; i++) {
			decisionToDFA[i] = new DFA(_ATN.GetDecisionState(i), i);
		}
	}
	private static char[] _serializedATN = {
		'\x3', '\x608B', '\xA72A', '\x8133', '\xB9ED', '\x417C', '\x3BE7', '\x7786', 
		'\x5964', '\x2', '\v', '\x38', '\b', '\x1', '\x4', '\x2', '\t', '\x2', 
		'\x4', '\x3', '\t', '\x3', '\x4', '\x4', '\t', '\x4', '\x4', '\x5', '\t', 
		'\x5', '\x4', '\x6', '\t', '\x6', '\x4', '\a', '\t', '\a', '\x4', '\b', 
		'\t', '\b', '\x4', '\t', '\t', '\t', '\x4', '\n', '\t', '\n', '\x3', '\x2', 
		'\x3', '\x2', '\x3', '\x3', '\x3', '\x3', '\x3', '\x4', '\x3', '\x4', 
		'\x3', '\x5', '\x3', '\x5', '\x3', '\x6', '\x3', '\x6', '\x3', '\a', '\x3', 
		'\a', '\x3', '\b', '\x6', '\b', '#', '\n', '\b', '\r', '\b', '\xE', '\b', 
		'$', '\x3', '\t', '\x6', '\t', '(', '\n', '\t', '\r', '\t', '\xE', '\t', 
		')', '\x3', '\t', '\x3', '\t', '\x6', '\t', '.', '\n', '\t', '\r', '\t', 
		'\xE', '\t', '/', '\x3', '\n', '\x6', '\n', '\x33', '\n', '\n', '\r', 
		'\n', '\xE', '\n', '\x34', '\x3', '\n', '\x3', '\n', '\x2', '\x2', '\v', 
		'\x3', '\x3', '\x5', '\x4', '\a', '\x5', '\t', '\x6', '\v', '\a', '\r', 
		'\b', '\xF', '\t', '\x11', '\n', '\x13', '\v', '\x3', '\x2', '\x4', '\x3', 
		'\x2', '\x32', ';', '\x5', '\x2', '\v', '\f', '\xF', '\xF', '\"', '\"', 
		'\x2', ';', '\x2', '\x3', '\x3', '\x2', '\x2', '\x2', '\x2', '\x5', '\x3', 
		'\x2', '\x2', '\x2', '\x2', '\a', '\x3', '\x2', '\x2', '\x2', '\x2', '\t', 
		'\x3', '\x2', '\x2', '\x2', '\x2', '\v', '\x3', '\x2', '\x2', '\x2', '\x2', 
		'\r', '\x3', '\x2', '\x2', '\x2', '\x2', '\xF', '\x3', '\x2', '\x2', '\x2', 
		'\x2', '\x11', '\x3', '\x2', '\x2', '\x2', '\x2', '\x13', '\x3', '\x2', 
		'\x2', '\x2', '\x3', '\x15', '\x3', '\x2', '\x2', '\x2', '\x5', '\x17', 
		'\x3', '\x2', '\x2', '\x2', '\a', '\x19', '\x3', '\x2', '\x2', '\x2', 
		'\t', '\x1B', '\x3', '\x2', '\x2', '\x2', '\v', '\x1D', '\x3', '\x2', 
		'\x2', '\x2', '\r', '\x1F', '\x3', '\x2', '\x2', '\x2', '\xF', '\"', '\x3', 
		'\x2', '\x2', '\x2', '\x11', '\'', '\x3', '\x2', '\x2', '\x2', '\x13', 
		'\x32', '\x3', '\x2', '\x2', '\x2', '\x15', '\x16', '\a', '*', '\x2', 
		'\x2', '\x16', '\x4', '\x3', '\x2', '\x2', '\x2', '\x17', '\x18', '\a', 
		'+', '\x2', '\x2', '\x18', '\x6', '\x3', '\x2', '\x2', '\x2', '\x19', 
		'\x1A', '\a', '-', '\x2', '\x2', '\x1A', '\b', '\x3', '\x2', '\x2', '\x2', 
		'\x1B', '\x1C', '\a', '/', '\x2', '\x2', '\x1C', '\n', '\x3', '\x2', '\x2', 
		'\x2', '\x1D', '\x1E', '\a', ',', '\x2', '\x2', '\x1E', '\f', '\x3', '\x2', 
		'\x2', '\x2', '\x1F', ' ', '\a', '\x31', '\x2', '\x2', ' ', '\xE', '\x3', 
		'\x2', '\x2', '\x2', '!', '#', '\t', '\x2', '\x2', '\x2', '\"', '!', '\x3', 
		'\x2', '\x2', '\x2', '#', '$', '\x3', '\x2', '\x2', '\x2', '$', '\"', 
		'\x3', '\x2', '\x2', '\x2', '$', '%', '\x3', '\x2', '\x2', '\x2', '%', 
		'\x10', '\x3', '\x2', '\x2', '\x2', '&', '(', '\t', '\x2', '\x2', '\x2', 
		'\'', '&', '\x3', '\x2', '\x2', '\x2', '(', ')', '\x3', '\x2', '\x2', 
		'\x2', ')', '\'', '\x3', '\x2', '\x2', '\x2', ')', '*', '\x3', '\x2', 
		'\x2', '\x2', '*', '+', '\x3', '\x2', '\x2', '\x2', '+', '-', '\a', '\x30', 
		'\x2', '\x2', ',', '.', '\t', '\x2', '\x2', '\x2', '-', ',', '\x3', '\x2', 
		'\x2', '\x2', '.', '/', '\x3', '\x2', '\x2', '\x2', '/', '-', '\x3', '\x2', 
		'\x2', '\x2', '/', '\x30', '\x3', '\x2', '\x2', '\x2', '\x30', '\x12', 
		'\x3', '\x2', '\x2', '\x2', '\x31', '\x33', '\t', '\x3', '\x2', '\x2', 
		'\x32', '\x31', '\x3', '\x2', '\x2', '\x2', '\x33', '\x34', '\x3', '\x2', 
		'\x2', '\x2', '\x34', '\x32', '\x3', '\x2', '\x2', '\x2', '\x34', '\x35', 
		'\x3', '\x2', '\x2', '\x2', '\x35', '\x36', '\x3', '\x2', '\x2', '\x2', 
		'\x36', '\x37', '\b', '\n', '\x2', '\x2', '\x37', '\x14', '\x3', '\x2', 
		'\x2', '\x2', '\a', '\x2', '$', ')', '/', '\x34', '\x3', '\b', '\x2', 
		'\x2',
	};

	public static readonly ATN _ATN =
		new ATNDeserializer().Deserialize(_serializedATN);


}
} // namespace BasicMath
