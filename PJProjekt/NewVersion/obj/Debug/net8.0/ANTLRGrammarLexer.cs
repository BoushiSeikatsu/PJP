//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 4.6.6
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from C:\Users\msi pc\Documents\PythonProjects\PJP\PJProjekt\NewVersion\ANTLRGrammar.g4 by ANTLR 4.6.6

// Unreachable code detected
#pragma warning disable 0162
// The variable '...' is assigned but its value is never used
#pragma warning disable 0219
// Missing XML comment for publicly visible type or member '...'
#pragma warning disable 1591
// Ambiguous reference in cref attribute
#pragma warning disable 419

namespace NewVersion {
using Antlr4.Runtime;
using Antlr4.Runtime.Atn;
using Antlr4.Runtime.Misc;
using DFA = Antlr4.Runtime.Dfa.DFA;

[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.6.6")]
[System.CLSCompliant(false)]
public partial class ANTLRGrammarLexer : Lexer {
	public const int
		T__0=1, T__1=2, T__2=3, T__3=4, INT_KEYWORD=5, FLOAT_KEYWORD=6, BOOL_KEYWORD=7, 
		STRING_KEYWORD=8, IF=9, ELSE=10, READ=11, WRITE=12, WHILE=13, SEMI=14, 
		COMMA=15, DOT=16, NOT=17, MOD=18, MUL=19, DIV=20, ADD=21, SUB=22, ASSIGNMENT=23, 
		COMPARER=24, EQUALITY=25, LOGICALOR=26, LOGICALAND=27, BOOL=28, STRING=29, 
		IDENTIFIER=30, FLOAT=31, INT=32, WS=33, COMMENT=34, LINE_COMMENT=35;
	public static string[] modeNames = {
		"DEFAULT_MODE"
	};

	public static readonly string[] ruleNames = {
		"T__0", "T__1", "T__2", "T__3", "INT_KEYWORD", "FLOAT_KEYWORD", "BOOL_KEYWORD", 
		"STRING_KEYWORD", "IF", "ELSE", "READ", "WRITE", "WHILE", "SEMI", "COMMA", 
		"DOT", "NOT", "MOD", "MUL", "DIV", "ADD", "SUB", "ASSIGNMENT", "COMPARER", 
		"EQUALITY", "LOGICALOR", "LOGICALAND", "BOOL", "STRING", "IDENTIFIER", 
		"FLOAT", "INT", "WS", "COMMENT", "LINE_COMMENT"
	};


	public ANTLRGrammarLexer(ICharStream input)
		: base(input)
	{
		_interp = new LexerATNSimulator(this,_ATN);
	}

	private static readonly string[] _LiteralNames = {
		null, "'{'", "'}'", "'('", "')'", "'int'", "'float'", "'bool'", "'string'", 
		"'if'", "'else'", "'read'", "'write'", "'while'", "';'", "','", "'.'", 
		"'!'", "'%'", "'*'", "'/'", "'+'", "'-'", "'='", null, null, "'||'", "'&&'"
	};
	private static readonly string[] _SymbolicNames = {
		null, null, null, null, null, "INT_KEYWORD", "FLOAT_KEYWORD", "BOOL_KEYWORD", 
		"STRING_KEYWORD", "IF", "ELSE", "READ", "WRITE", "WHILE", "SEMI", "COMMA", 
		"DOT", "NOT", "MOD", "MUL", "DIV", "ADD", "SUB", "ASSIGNMENT", "COMPARER", 
		"EQUALITY", "LOGICALOR", "LOGICALAND", "BOOL", "STRING", "IDENTIFIER", 
		"FLOAT", "INT", "WS", "COMMENT", "LINE_COMMENT"
	};
	public static readonly IVocabulary DefaultVocabulary = new Vocabulary(_LiteralNames, _SymbolicNames);

	[System.Obsolete("Use Vocabulary instead.")]
	public static readonly string[] tokenNames = GenerateTokenNames(DefaultVocabulary, _SymbolicNames.Length);

	private static string[] GenerateTokenNames(IVocabulary vocabulary, int length) {
		string[] tokenNames = new string[length];
		for (int i = 0; i < tokenNames.Length; i++) {
			tokenNames[i] = vocabulary.GetLiteralName(i);
			if (tokenNames[i] == null) {
				tokenNames[i] = vocabulary.GetSymbolicName(i);
			}

			if (tokenNames[i] == null) {
				tokenNames[i] = "<INVALID>";
			}
		}

		return tokenNames;
	}

	[System.Obsolete("Use IRecognizer.Vocabulary instead.")]
	public override string[] TokenNames
	{
		get
		{
			return tokenNames;
		}
	}

	[NotNull]
	public override IVocabulary Vocabulary
	{
		get
		{
			return DefaultVocabulary;
		}
	}

	public override string GrammarFileName { get { return "ANTLRGrammar.g4"; } }

	public override string[] RuleNames { get { return ruleNames; } }

	public override string[] ModeNames { get { return modeNames; } }

	public override string SerializedAtn { get { return _serializedATN; } }

	public static readonly string _serializedATN =
		"\x3\xAF6F\x8320\x479D\xB75C\x4880\x1605\x191C\xAB37\x2%\xED\b\x1\x4\x2"+
		"\t\x2\x4\x3\t\x3\x4\x4\t\x4\x4\x5\t\x5\x4\x6\t\x6\x4\a\t\a\x4\b\t\b\x4"+
		"\t\t\t\x4\n\t\n\x4\v\t\v\x4\f\t\f\x4\r\t\r\x4\xE\t\xE\x4\xF\t\xF\x4\x10"+
		"\t\x10\x4\x11\t\x11\x4\x12\t\x12\x4\x13\t\x13\x4\x14\t\x14\x4\x15\t\x15"+
		"\x4\x16\t\x16\x4\x17\t\x17\x4\x18\t\x18\x4\x19\t\x19\x4\x1A\t\x1A\x4\x1B"+
		"\t\x1B\x4\x1C\t\x1C\x4\x1D\t\x1D\x4\x1E\t\x1E\x4\x1F\t\x1F\x4 \t \x4!"+
		"\t!\x4\"\t\"\x4#\t#\x4$\t$\x3\x2\x3\x2\x3\x3\x3\x3\x3\x4\x3\x4\x3\x5\x3"+
		"\x5\x3\x6\x3\x6\x3\x6\x3\x6\x3\a\x3\a\x3\a\x3\a\x3\a\x3\a\x3\b\x3\b\x3"+
		"\b\x3\b\x3\b\x3\t\x3\t\x3\t\x3\t\x3\t\x3\t\x3\t\x3\n\x3\n\x3\n\x3\v\x3"+
		"\v\x3\v\x3\v\x3\v\x3\f\x3\f\x3\f\x3\f\x3\f\x3\r\x3\r\x3\r\x3\r\x3\r\x3"+
		"\r\x3\xE\x3\xE\x3\xE\x3\xE\x3\xE\x3\xE\x3\xF\x3\xF\x3\x10\x3\x10\x3\x11"+
		"\x3\x11\x3\x12\x3\x12\x3\x13\x3\x13\x3\x14\x3\x14\x3\x15\x3\x15\x3\x16"+
		"\x3\x16\x3\x17\x3\x17\x3\x18\x3\x18\x3\x19\x3\x19\x3\x1A\x3\x1A\x3\x1A"+
		"\x3\x1A\x5\x1A\x9B\n\x1A\x3\x1B\x3\x1B\x3\x1B\x3\x1C\x3\x1C\x3\x1C\x3"+
		"\x1D\x3\x1D\x3\x1D\x3\x1D\x3\x1D\x3\x1D\x3\x1D\x3\x1D\x3\x1D\x5\x1D\xAC"+
		"\n\x1D\x3\x1E\x3\x1E\a\x1E\xB0\n\x1E\f\x1E\xE\x1E\xB3\v\x1E\x3\x1E\x3"+
		"\x1E\x3\x1F\x3\x1F\a\x1F\xB9\n\x1F\f\x1F\xE\x1F\xBC\v\x1F\x3 \x6 \xBF"+
		"\n \r \xE \xC0\x3 \x3 \x6 \xC5\n \r \xE \xC6\x3!\x6!\xCA\n!\r!\xE!\xCB"+
		"\x3\"\x6\"\xCF\n\"\r\"\xE\"\xD0\x3\"\x3\"\x3#\x3#\x3#\x3#\a#\xD9\n#\f"+
		"#\xE#\xDC\v#\x3#\x3#\x3#\x3#\x3#\x3$\x3$\x3$\x3$\a$\xE7\n$\f$\xE$\xEA"+
		"\v$\x3$\x3$\x4\xB1\xDA\x2\x2%\x3\x2\x3\x5\x2\x4\a\x2\x5\t\x2\x6\v\x2\a"+
		"\r\x2\b\xF\x2\t\x11\x2\n\x13\x2\v\x15\x2\f\x17\x2\r\x19\x2\xE\x1B\x2\xF"+
		"\x1D\x2\x10\x1F\x2\x11!\x2\x12#\x2\x13%\x2\x14\'\x2\x15)\x2\x16+\x2\x17"+
		"-\x2\x18/\x2\x19\x31\x2\x1A\x33\x2\x1B\x35\x2\x1C\x37\x2\x1D\x39\x2\x1E"+
		";\x2\x1F=\x2 ?\x2!\x41\x2\"\x43\x2#\x45\x2$G\x2%\x3\x2\b\x4\x2>>@@\x4"+
		"\x2\x43\\\x63|\x5\x2\x32;\x43\\\x63|\x3\x2\x32;\x5\x2\v\f\xF\xF\"\"\x4"+
		"\x2\f\f\xF\xF\xF6\x2\x3\x3\x2\x2\x2\x2\x5\x3\x2\x2\x2\x2\a\x3\x2\x2\x2"+
		"\x2\t\x3\x2\x2\x2\x2\v\x3\x2\x2\x2\x2\r\x3\x2\x2\x2\x2\xF\x3\x2\x2\x2"+
		"\x2\x11\x3\x2\x2\x2\x2\x13\x3\x2\x2\x2\x2\x15\x3\x2\x2\x2\x2\x17\x3\x2"+
		"\x2\x2\x2\x19\x3\x2\x2\x2\x2\x1B\x3\x2\x2\x2\x2\x1D\x3\x2\x2\x2\x2\x1F"+
		"\x3\x2\x2\x2\x2!\x3\x2\x2\x2\x2#\x3\x2\x2\x2\x2%\x3\x2\x2\x2\x2\'\x3\x2"+
		"\x2\x2\x2)\x3\x2\x2\x2\x2+\x3\x2\x2\x2\x2-\x3\x2\x2\x2\x2/\x3\x2\x2\x2"+
		"\x2\x31\x3\x2\x2\x2\x2\x33\x3\x2\x2\x2\x2\x35\x3\x2\x2\x2\x2\x37\x3\x2"+
		"\x2\x2\x2\x39\x3\x2\x2\x2\x2;\x3\x2\x2\x2\x2=\x3\x2\x2\x2\x2?\x3\x2\x2"+
		"\x2\x2\x41\x3\x2\x2\x2\x2\x43\x3\x2\x2\x2\x2\x45\x3\x2\x2\x2\x2G\x3\x2"+
		"\x2\x2\x3I\x3\x2\x2\x2\x5K\x3\x2\x2\x2\aM\x3\x2\x2\x2\tO\x3\x2\x2\x2\v"+
		"Q\x3\x2\x2\x2\rU\x3\x2\x2\x2\xF[\x3\x2\x2\x2\x11`\x3\x2\x2\x2\x13g\x3"+
		"\x2\x2\x2\x15j\x3\x2\x2\x2\x17o\x3\x2\x2\x2\x19t\x3\x2\x2\x2\x1Bz\x3\x2"+
		"\x2\x2\x1D\x80\x3\x2\x2\x2\x1F\x82\x3\x2\x2\x2!\x84\x3\x2\x2\x2#\x86\x3"+
		"\x2\x2\x2%\x88\x3\x2\x2\x2\'\x8A\x3\x2\x2\x2)\x8C\x3\x2\x2\x2+\x8E\x3"+
		"\x2\x2\x2-\x90\x3\x2\x2\x2/\x92\x3\x2\x2\x2\x31\x94\x3\x2\x2\x2\x33\x9A"+
		"\x3\x2\x2\x2\x35\x9C\x3\x2\x2\x2\x37\x9F\x3\x2\x2\x2\x39\xAB\x3\x2\x2"+
		"\x2;\xAD\x3\x2\x2\x2=\xB6\x3\x2\x2\x2?\xBE\x3\x2\x2\x2\x41\xC9\x3\x2\x2"+
		"\x2\x43\xCE\x3\x2\x2\x2\x45\xD4\x3\x2\x2\x2G\xE2\x3\x2\x2\x2IJ\a}\x2\x2"+
		"J\x4\x3\x2\x2\x2KL\a\x7F\x2\x2L\x6\x3\x2\x2\x2MN\a*\x2\x2N\b\x3\x2\x2"+
		"\x2OP\a+\x2\x2P\n\x3\x2\x2\x2QR\ak\x2\x2RS\ap\x2\x2ST\av\x2\x2T\f\x3\x2"+
		"\x2\x2UV\ah\x2\x2VW\an\x2\x2WX\aq\x2\x2XY\a\x63\x2\x2YZ\av\x2\x2Z\xE\x3"+
		"\x2\x2\x2[\\\a\x64\x2\x2\\]\aq\x2\x2]^\aq\x2\x2^_\an\x2\x2_\x10\x3\x2"+
		"\x2\x2`\x61\au\x2\x2\x61\x62\av\x2\x2\x62\x63\at\x2\x2\x63\x64\ak\x2\x2"+
		"\x64\x65\ap\x2\x2\x65\x66\ai\x2\x2\x66\x12\x3\x2\x2\x2gh\ak\x2\x2hi\a"+
		"h\x2\x2i\x14\x3\x2\x2\x2jk\ag\x2\x2kl\an\x2\x2lm\au\x2\x2mn\ag\x2\x2n"+
		"\x16\x3\x2\x2\x2op\at\x2\x2pq\ag\x2\x2qr\a\x63\x2\x2rs\a\x66\x2\x2s\x18"+
		"\x3\x2\x2\x2tu\ay\x2\x2uv\at\x2\x2vw\ak\x2\x2wx\av\x2\x2xy\ag\x2\x2y\x1A"+
		"\x3\x2\x2\x2z{\ay\x2\x2{|\aj\x2\x2|}\ak\x2\x2}~\an\x2\x2~\x7F\ag\x2\x2"+
		"\x7F\x1C\x3\x2\x2\x2\x80\x81\a=\x2\x2\x81\x1E\x3\x2\x2\x2\x82\x83\a.\x2"+
		"\x2\x83 \x3\x2\x2\x2\x84\x85\a\x30\x2\x2\x85\"\x3\x2\x2\x2\x86\x87\a#"+
		"\x2\x2\x87$\x3\x2\x2\x2\x88\x89\a\'\x2\x2\x89&\x3\x2\x2\x2\x8A\x8B\a,"+
		"\x2\x2\x8B(\x3\x2\x2\x2\x8C\x8D\a\x31\x2\x2\x8D*\x3\x2\x2\x2\x8E\x8F\a"+
		"-\x2\x2\x8F,\x3\x2\x2\x2\x90\x91\a/\x2\x2\x91.\x3\x2\x2\x2\x92\x93\a?"+
		"\x2\x2\x93\x30\x3\x2\x2\x2\x94\x95\t\x2\x2\x2\x95\x32\x3\x2\x2\x2\x96"+
		"\x97\a?\x2\x2\x97\x9B\a?\x2\x2\x98\x99\a#\x2\x2\x99\x9B\a?\x2\x2\x9A\x96"+
		"\x3\x2\x2\x2\x9A\x98\x3\x2\x2\x2\x9B\x34\x3\x2\x2\x2\x9C\x9D\a~\x2\x2"+
		"\x9D\x9E\a~\x2\x2\x9E\x36\x3\x2\x2\x2\x9F\xA0\a(\x2\x2\xA0\xA1\a(\x2\x2"+
		"\xA1\x38\x3\x2\x2\x2\xA2\xA3\av\x2\x2\xA3\xA4\at\x2\x2\xA4\xA5\aw\x2\x2"+
		"\xA5\xAC\ag\x2\x2\xA6\xA7\ah\x2\x2\xA7\xA8\a\x63\x2\x2\xA8\xA9\an\x2\x2"+
		"\xA9\xAA\au\x2\x2\xAA\xAC\ag\x2\x2\xAB\xA2\x3\x2\x2\x2\xAB\xA6\x3\x2\x2"+
		"\x2\xAC:\x3\x2\x2\x2\xAD\xB1\a$\x2\x2\xAE\xB0\v\x2\x2\x2\xAF\xAE\x3\x2"+
		"\x2\x2\xB0\xB3\x3\x2\x2\x2\xB1\xB2\x3\x2\x2\x2\xB1\xAF\x3\x2\x2\x2\xB2"+
		"\xB4\x3\x2\x2\x2\xB3\xB1\x3\x2\x2\x2\xB4\xB5\a$\x2\x2\xB5<\x3\x2\x2\x2"+
		"\xB6\xBA\t\x3\x2\x2\xB7\xB9\t\x4\x2\x2\xB8\xB7\x3\x2\x2\x2\xB9\xBC\x3"+
		"\x2\x2\x2\xBA\xB8\x3\x2\x2\x2\xBA\xBB\x3\x2\x2\x2\xBB>\x3\x2\x2\x2\xBC"+
		"\xBA\x3\x2\x2\x2\xBD\xBF\t\x5\x2\x2\xBE\xBD\x3\x2\x2\x2\xBF\xC0\x3\x2"+
		"\x2\x2\xC0\xBE\x3\x2\x2\x2\xC0\xC1\x3\x2\x2\x2\xC1\xC2\x3\x2\x2\x2\xC2"+
		"\xC4\a\x30\x2\x2\xC3\xC5\t\x5\x2\x2\xC4\xC3\x3\x2\x2\x2\xC5\xC6\x3\x2"+
		"\x2\x2\xC6\xC4\x3\x2\x2\x2\xC6\xC7\x3\x2\x2\x2\xC7@\x3\x2\x2\x2\xC8\xCA"+
		"\t\x5\x2\x2\xC9\xC8\x3\x2\x2\x2\xCA\xCB\x3\x2\x2\x2\xCB\xC9\x3\x2\x2\x2"+
		"\xCB\xCC\x3\x2\x2\x2\xCC\x42\x3\x2\x2\x2\xCD\xCF\t\x6\x2\x2\xCE\xCD\x3"+
		"\x2\x2\x2\xCF\xD0\x3\x2\x2\x2\xD0\xCE\x3\x2\x2\x2\xD0\xD1\x3\x2\x2\x2"+
		"\xD1\xD2\x3\x2\x2\x2\xD2\xD3\b\"\x2\x2\xD3\x44\x3\x2\x2\x2\xD4\xD5\a\x31"+
		"\x2\x2\xD5\xD6\a,\x2\x2\xD6\xDA\x3\x2\x2\x2\xD7\xD9\v\x2\x2\x2\xD8\xD7"+
		"\x3\x2\x2\x2\xD9\xDC\x3\x2\x2\x2\xDA\xDB\x3\x2\x2\x2\xDA\xD8\x3\x2\x2"+
		"\x2\xDB\xDD\x3\x2\x2\x2\xDC\xDA\x3\x2\x2\x2\xDD\xDE\a,\x2\x2\xDE\xDF\a"+
		"\x31\x2\x2\xDF\xE0\x3\x2\x2\x2\xE0\xE1\b#\x2\x2\xE1\x46\x3\x2\x2\x2\xE2"+
		"\xE3\a\x31\x2\x2\xE3\xE4\a\x31\x2\x2\xE4\xE8\x3\x2\x2\x2\xE5\xE7\n\a\x2"+
		"\x2\xE6\xE5\x3\x2\x2\x2\xE7\xEA\x3\x2\x2\x2\xE8\xE6\x3\x2\x2\x2\xE8\xE9"+
		"\x3\x2\x2\x2\xE9\xEB\x3\x2\x2\x2\xEA\xE8\x3\x2\x2\x2\xEB\xEC\b$\x2\x2"+
		"\xECH\x3\x2\x2\x2\r\x2\x9A\xAB\xB1\xBA\xC0\xC6\xCB\xD0\xDA\xE8\x3\b\x2"+
		"\x2";
	public static readonly ATN _ATN =
		new ATNDeserializer().Deserialize(_serializedATN.ToCharArray());
}
} // namespace NewVersion
