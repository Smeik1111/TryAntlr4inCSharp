//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 4.9.3
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from .\IMP.g4 by ANTLR 4.9.3

// Unreachable code detected
#pragma warning disable 0162
// The variable '...' is assigned but its value is never used
#pragma warning disable 0219
// Missing XML comment for publicly visible type or member '...'
#pragma warning disable 1591
// Ambiguous reference in cref attribute
#pragma warning disable 419

namespace IMP {
using System;
using System.IO;
using System.Text;
using Antlr4.Runtime;
using Antlr4.Runtime.Atn;
using Antlr4.Runtime.Misc;
using DFA = Antlr4.Runtime.Dfa.DFA;

[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.9.3")]
[System.CLSCompliant(false)]
public partial class IMPLexer : Lexer {
	protected static DFA[] decisionToDFA;
	protected static PredictionContextCache sharedContextCache = new PredictionContextCache();
	public const int
		T__0=1, T__1=2, T__2=3, T__3=4, T__4=5, T__5=6, T__6=7, T__7=8, T__8=9, 
		T__9=10, T__10=11, T__11=12, T__12=13, T__13=14, T__14=15, T__15=16, T__16=17, 
		T__17=18, INT=19, BOOL=20, VAR=21, WS=22;
	public static string[] channelNames = {
		"DEFAULT_TOKEN_CHANNEL", "HIDDEN"
	};

	public static string[] modeNames = {
		"DEFAULT_MODE"
	};

	public static readonly string[] ruleNames = {
		"T__0", "T__1", "T__2", "T__3", "T__4", "T__5", "T__6", "T__7", "T__8", 
		"T__9", "T__10", "T__11", "T__12", "T__13", "T__14", "T__15", "T__16", 
		"T__17", "INT", "BOOL", "VAR", "WS"
	};


	public IMPLexer(ICharStream input)
	: this(input, Console.Out, Console.Error) { }

	public IMPLexer(ICharStream input, TextWriter output, TextWriter errorOutput)
	: base(input, output, errorOutput)
	{
		Interpreter = new LexerATNSimulator(this, _ATN, decisionToDFA, sharedContextCache);
	}

	private static readonly string[] _LiteralNames = {
		null, "'{'", "'}'", "';'", "'while'", "'if'", "'else'", "':='", "'='", 
		"'print'", "'+'", "'*'", "'||'", "'&&'", "'!'", "'=='", "'<'", "'('", 
		"')'"
	};
	private static readonly string[] _SymbolicNames = {
		null, null, null, null, null, null, null, null, null, null, null, null, 
		null, null, null, null, null, null, null, "INT", "BOOL", "VAR", "WS"
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

	public override string GrammarFileName { get { return "IMP.g4"; } }

	public override string[] RuleNames { get { return ruleNames; } }

	public override string[] ChannelNames { get { return channelNames; } }

	public override string[] ModeNames { get { return modeNames; } }

	public override string SerializedAtn { get { return new string(_serializedATN); } }

	static IMPLexer() {
		decisionToDFA = new DFA[_ATN.NumberOfDecisions];
		for (int i = 0; i < _ATN.NumberOfDecisions; i++) {
			decisionToDFA[i] = new DFA(_ATN.GetDecisionState(i), i);
		}
	}
	private static char[] _serializedATN = {
		'\x3', '\x608B', '\xA72A', '\x8133', '\xB9ED', '\x417C', '\x3BE7', '\x7786', 
		'\x5964', '\x2', '\x18', '\x88', '\b', '\x1', '\x4', '\x2', '\t', '\x2', 
		'\x4', '\x3', '\t', '\x3', '\x4', '\x4', '\t', '\x4', '\x4', '\x5', '\t', 
		'\x5', '\x4', '\x6', '\t', '\x6', '\x4', '\a', '\t', '\a', '\x4', '\b', 
		'\t', '\b', '\x4', '\t', '\t', '\t', '\x4', '\n', '\t', '\n', '\x4', '\v', 
		'\t', '\v', '\x4', '\f', '\t', '\f', '\x4', '\r', '\t', '\r', '\x4', '\xE', 
		'\t', '\xE', '\x4', '\xF', '\t', '\xF', '\x4', '\x10', '\t', '\x10', '\x4', 
		'\x11', '\t', '\x11', '\x4', '\x12', '\t', '\x12', '\x4', '\x13', '\t', 
		'\x13', '\x4', '\x14', '\t', '\x14', '\x4', '\x15', '\t', '\x15', '\x4', 
		'\x16', '\t', '\x16', '\x4', '\x17', '\t', '\x17', '\x3', '\x2', '\x3', 
		'\x2', '\x3', '\x3', '\x3', '\x3', '\x3', '\x4', '\x3', '\x4', '\x3', 
		'\x5', '\x3', '\x5', '\x3', '\x5', '\x3', '\x5', '\x3', '\x5', '\x3', 
		'\x5', '\x3', '\x6', '\x3', '\x6', '\x3', '\x6', '\x3', '\a', '\x3', '\a', 
		'\x3', '\a', '\x3', '\a', '\x3', '\a', '\x3', '\b', '\x3', '\b', '\x3', 
		'\b', '\x3', '\t', '\x3', '\t', '\x3', '\n', '\x3', '\n', '\x3', '\n', 
		'\x3', '\n', '\x3', '\n', '\x3', '\n', '\x3', '\v', '\x3', '\v', '\x3', 
		'\f', '\x3', '\f', '\x3', '\r', '\x3', '\r', '\x3', '\r', '\x3', '\xE', 
		'\x3', '\xE', '\x3', '\xE', '\x3', '\xF', '\x3', '\xF', '\x3', '\x10', 
		'\x3', '\x10', '\x3', '\x10', '\x3', '\x11', '\x3', '\x11', '\x3', '\x12', 
		'\x3', '\x12', '\x3', '\x13', '\x3', '\x13', '\x3', '\x14', '\x3', '\x14', 
		'\x6', '\x14', '\x66', '\n', '\x14', '\r', '\x14', '\xE', '\x14', 'g', 
		'\x3', '\x14', '\x6', '\x14', 'k', '\n', '\x14', '\r', '\x14', '\xE', 
		'\x14', 'l', '\x5', '\x14', 'o', '\n', '\x14', '\x3', '\x15', '\x3', '\x15', 
		'\x3', '\x15', '\x3', '\x15', '\x3', '\x15', '\x3', '\x15', '\x3', '\x15', 
		'\x3', '\x15', '\x3', '\x15', '\x5', '\x15', 'z', '\n', '\x15', '\x3', 
		'\x16', '\x3', '\x16', '\x6', '\x16', '~', '\n', '\x16', '\r', '\x16', 
		'\xE', '\x16', '\x7F', '\x3', '\x17', '\x6', '\x17', '\x83', '\n', '\x17', 
		'\r', '\x17', '\xE', '\x17', '\x84', '\x3', '\x17', '\x3', '\x17', '\x2', 
		'\x2', '\x18', '\x3', '\x3', '\x5', '\x4', '\a', '\x5', '\t', '\x6', '\v', 
		'\a', '\r', '\b', '\xF', '\t', '\x11', '\n', '\x13', '\v', '\x15', '\f', 
		'\x17', '\r', '\x19', '\xE', '\x1B', '\xF', '\x1D', '\x10', '\x1F', '\x11', 
		'!', '\x12', '#', '\x13', '%', '\x14', '\'', '\x15', ')', '\x16', '+', 
		'\x17', '-', '\x18', '\x3', '\x2', '\x6', '\x3', '\x2', '\x32', ';', '\x3', 
		'\x2', '\x63', '|', '\x4', '\x2', '\x43', '\\', '\x63', '|', '\x5', '\x2', 
		'\v', '\f', '\xF', '\xF', '\"', '\"', '\x2', '\x8D', '\x2', '\x3', '\x3', 
		'\x2', '\x2', '\x2', '\x2', '\x5', '\x3', '\x2', '\x2', '\x2', '\x2', 
		'\a', '\x3', '\x2', '\x2', '\x2', '\x2', '\t', '\x3', '\x2', '\x2', '\x2', 
		'\x2', '\v', '\x3', '\x2', '\x2', '\x2', '\x2', '\r', '\x3', '\x2', '\x2', 
		'\x2', '\x2', '\xF', '\x3', '\x2', '\x2', '\x2', '\x2', '\x11', '\x3', 
		'\x2', '\x2', '\x2', '\x2', '\x13', '\x3', '\x2', '\x2', '\x2', '\x2', 
		'\x15', '\x3', '\x2', '\x2', '\x2', '\x2', '\x17', '\x3', '\x2', '\x2', 
		'\x2', '\x2', '\x19', '\x3', '\x2', '\x2', '\x2', '\x2', '\x1B', '\x3', 
		'\x2', '\x2', '\x2', '\x2', '\x1D', '\x3', '\x2', '\x2', '\x2', '\x2', 
		'\x1F', '\x3', '\x2', '\x2', '\x2', '\x2', '!', '\x3', '\x2', '\x2', '\x2', 
		'\x2', '#', '\x3', '\x2', '\x2', '\x2', '\x2', '%', '\x3', '\x2', '\x2', 
		'\x2', '\x2', '\'', '\x3', '\x2', '\x2', '\x2', '\x2', ')', '\x3', '\x2', 
		'\x2', '\x2', '\x2', '+', '\x3', '\x2', '\x2', '\x2', '\x2', '-', '\x3', 
		'\x2', '\x2', '\x2', '\x3', '/', '\x3', '\x2', '\x2', '\x2', '\x5', '\x31', 
		'\x3', '\x2', '\x2', '\x2', '\a', '\x33', '\x3', '\x2', '\x2', '\x2', 
		'\t', '\x35', '\x3', '\x2', '\x2', '\x2', '\v', ';', '\x3', '\x2', '\x2', 
		'\x2', '\r', '>', '\x3', '\x2', '\x2', '\x2', '\xF', '\x43', '\x3', '\x2', 
		'\x2', '\x2', '\x11', '\x46', '\x3', '\x2', '\x2', '\x2', '\x13', 'H', 
		'\x3', '\x2', '\x2', '\x2', '\x15', 'N', '\x3', '\x2', '\x2', '\x2', '\x17', 
		'P', '\x3', '\x2', '\x2', '\x2', '\x19', 'R', '\x3', '\x2', '\x2', '\x2', 
		'\x1B', 'U', '\x3', '\x2', '\x2', '\x2', '\x1D', 'X', '\x3', '\x2', '\x2', 
		'\x2', '\x1F', 'Z', '\x3', '\x2', '\x2', '\x2', '!', ']', '\x3', '\x2', 
		'\x2', '\x2', '#', '_', '\x3', '\x2', '\x2', '\x2', '%', '\x61', '\x3', 
		'\x2', '\x2', '\x2', '\'', 'n', '\x3', '\x2', '\x2', '\x2', ')', 'y', 
		'\x3', '\x2', '\x2', '\x2', '+', '{', '\x3', '\x2', '\x2', '\x2', '-', 
		'\x82', '\x3', '\x2', '\x2', '\x2', '/', '\x30', '\a', '}', '\x2', '\x2', 
		'\x30', '\x4', '\x3', '\x2', '\x2', '\x2', '\x31', '\x32', '\a', '\x7F', 
		'\x2', '\x2', '\x32', '\x6', '\x3', '\x2', '\x2', '\x2', '\x33', '\x34', 
		'\a', '=', '\x2', '\x2', '\x34', '\b', '\x3', '\x2', '\x2', '\x2', '\x35', 
		'\x36', '\a', 'y', '\x2', '\x2', '\x36', '\x37', '\a', 'j', '\x2', '\x2', 
		'\x37', '\x38', '\a', 'k', '\x2', '\x2', '\x38', '\x39', '\a', 'n', '\x2', 
		'\x2', '\x39', ':', '\a', 'g', '\x2', '\x2', ':', '\n', '\x3', '\x2', 
		'\x2', '\x2', ';', '<', '\a', 'k', '\x2', '\x2', '<', '=', '\a', 'h', 
		'\x2', '\x2', '=', '\f', '\x3', '\x2', '\x2', '\x2', '>', '?', '\a', 'g', 
		'\x2', '\x2', '?', '@', '\a', 'n', '\x2', '\x2', '@', '\x41', '\a', 'u', 
		'\x2', '\x2', '\x41', '\x42', '\a', 'g', '\x2', '\x2', '\x42', '\xE', 
		'\x3', '\x2', '\x2', '\x2', '\x43', '\x44', '\a', '<', '\x2', '\x2', '\x44', 
		'\x45', '\a', '?', '\x2', '\x2', '\x45', '\x10', '\x3', '\x2', '\x2', 
		'\x2', '\x46', 'G', '\a', '?', '\x2', '\x2', 'G', '\x12', '\x3', '\x2', 
		'\x2', '\x2', 'H', 'I', '\a', 'r', '\x2', '\x2', 'I', 'J', '\a', 't', 
		'\x2', '\x2', 'J', 'K', '\a', 'k', '\x2', '\x2', 'K', 'L', '\a', 'p', 
		'\x2', '\x2', 'L', 'M', '\a', 'v', '\x2', '\x2', 'M', '\x14', '\x3', '\x2', 
		'\x2', '\x2', 'N', 'O', '\a', '-', '\x2', '\x2', 'O', '\x16', '\x3', '\x2', 
		'\x2', '\x2', 'P', 'Q', '\a', ',', '\x2', '\x2', 'Q', '\x18', '\x3', '\x2', 
		'\x2', '\x2', 'R', 'S', '\a', '~', '\x2', '\x2', 'S', 'T', '\a', '~', 
		'\x2', '\x2', 'T', '\x1A', '\x3', '\x2', '\x2', '\x2', 'U', 'V', '\a', 
		'(', '\x2', '\x2', 'V', 'W', '\a', '(', '\x2', '\x2', 'W', '\x1C', '\x3', 
		'\x2', '\x2', '\x2', 'X', 'Y', '\a', '#', '\x2', '\x2', 'Y', '\x1E', '\x3', 
		'\x2', '\x2', '\x2', 'Z', '[', '\a', '?', '\x2', '\x2', '[', '\\', '\a', 
		'?', '\x2', '\x2', '\\', ' ', '\x3', '\x2', '\x2', '\x2', ']', '^', '\a', 
		'>', '\x2', '\x2', '^', '\"', '\x3', '\x2', '\x2', '\x2', '_', '`', '\a', 
		'*', '\x2', '\x2', '`', '$', '\x3', '\x2', '\x2', '\x2', '\x61', '\x62', 
		'\a', '+', '\x2', '\x2', '\x62', '&', '\x3', '\x2', '\x2', '\x2', '\x63', 
		'\x65', '\a', '/', '\x2', '\x2', '\x64', '\x66', '\t', '\x2', '\x2', '\x2', 
		'\x65', '\x64', '\x3', '\x2', '\x2', '\x2', '\x66', 'g', '\x3', '\x2', 
		'\x2', '\x2', 'g', '\x65', '\x3', '\x2', '\x2', '\x2', 'g', 'h', '\x3', 
		'\x2', '\x2', '\x2', 'h', 'o', '\x3', '\x2', '\x2', '\x2', 'i', 'k', '\t', 
		'\x2', '\x2', '\x2', 'j', 'i', '\x3', '\x2', '\x2', '\x2', 'k', 'l', '\x3', 
		'\x2', '\x2', '\x2', 'l', 'j', '\x3', '\x2', '\x2', '\x2', 'l', 'm', '\x3', 
		'\x2', '\x2', '\x2', 'm', 'o', '\x3', '\x2', '\x2', '\x2', 'n', '\x63', 
		'\x3', '\x2', '\x2', '\x2', 'n', 'j', '\x3', '\x2', '\x2', '\x2', 'o', 
		'(', '\x3', '\x2', '\x2', '\x2', 'p', 'q', '\a', 'h', '\x2', '\x2', 'q', 
		'r', '\a', '\x63', '\x2', '\x2', 'r', 's', '\a', 'n', '\x2', '\x2', 's', 
		't', '\a', 'u', '\x2', '\x2', 't', 'z', '\a', 'g', '\x2', '\x2', 'u', 
		'v', '\a', 'v', '\x2', '\x2', 'v', 'w', '\a', 't', '\x2', '\x2', 'w', 
		'x', '\a', 'w', '\x2', '\x2', 'x', 'z', '\a', 'g', '\x2', '\x2', 'y', 
		'p', '\x3', '\x2', '\x2', '\x2', 'y', 'u', '\x3', '\x2', '\x2', '\x2', 
		'z', '*', '\x3', '\x2', '\x2', '\x2', '{', '}', '\t', '\x3', '\x2', '\x2', 
		'|', '~', '\t', '\x4', '\x2', '\x2', '}', '|', '\x3', '\x2', '\x2', '\x2', 
		'~', '\x7F', '\x3', '\x2', '\x2', '\x2', '\x7F', '}', '\x3', '\x2', '\x2', 
		'\x2', '\x7F', '\x80', '\x3', '\x2', '\x2', '\x2', '\x80', ',', '\x3', 
		'\x2', '\x2', '\x2', '\x81', '\x83', '\t', '\x5', '\x2', '\x2', '\x82', 
		'\x81', '\x3', '\x2', '\x2', '\x2', '\x83', '\x84', '\x3', '\x2', '\x2', 
		'\x2', '\x84', '\x82', '\x3', '\x2', '\x2', '\x2', '\x84', '\x85', '\x3', 
		'\x2', '\x2', '\x2', '\x85', '\x86', '\x3', '\x2', '\x2', '\x2', '\x86', 
		'\x87', '\b', '\x17', '\x2', '\x2', '\x87', '.', '\x3', '\x2', '\x2', 
		'\x2', '\n', '\x2', 'g', 'l', 'n', 'y', '}', '\x7F', '\x84', '\x3', '\b', 
		'\x2', '\x2',
	};

	public static readonly ATN _ATN =
		new ATNDeserializer().Deserialize(_serializedATN);


}
} // namespace IMP
