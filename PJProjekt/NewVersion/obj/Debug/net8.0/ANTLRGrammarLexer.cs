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
		STRING_KEYWORD=8, IF=9, ELSE=10, READ=11, WRITE=12, DO=13, WHILE=14, SEMI=15, 
		COMMA=16, DOT=17, NOT=18, MOD=19, MUL=20, DIV=21, ADD=22, SUB=23, ASSIGNMENT=24, 
		COMPARER=25, EQUALITY=26, LOGICALOR=27, LOGICALAND=28, BOOL=29, STRING=30, 
		IDENTIFIER=31, FLOAT=32, INT=33, WS=34, COMMENT=35, LINE_COMMENT=36;
	public static string[] modeNames = {
		"DEFAULT_MODE"
	};

	public static readonly string[] ruleNames = {
		"T__0", "T__1", "T__2", "T__3", "INT_KEYWORD", "FLOAT_KEYWORD", "BOOL_KEYWORD", 
		"STRING_KEYWORD", "IF", "ELSE", "READ", "WRITE", "DO", "WHILE", "SEMI", 
		"COMMA", "DOT", "NOT", "MOD", "MUL", "DIV", "ADD", "SUB", "ASSIGNMENT", 
		"COMPARER", "EQUALITY", "LOGICALOR", "LOGICALAND", "BOOL", "STRING", "IDENTIFIER", 
		"FLOAT", "INT", "WS", "COMMENT", "LINE_COMMENT"
	};


	public ANTLRGrammarLexer(ICharStream input)
		: base(input)
	{
		_interp = new LexerATNSimulator(this,_ATN);
	}

	private static readonly string[] _LiteralNames = {
		null, "'{'", "'}'", "'('", "')'", "'int'", "'float'", "'bool'", "'string'", 
		"'if'", "'else'", "'read'", "'write'", "'do'", "'while'", "';'", "','", 
		"'.'", "'!'", "'%'", "'*'", "'/'", "'+'", "'-'", "'='", null, null, "'||'", 
		"'&&'"
	};
	private static readonly string[] _SymbolicNames = {
		null, null, null, null, null, "INT_KEYWORD", "FLOAT_KEYWORD", "BOOL_KEYWORD", 
		"STRING_KEYWORD", "IF", "ELSE", "READ", "WRITE", "DO", "WHILE", "SEMI", 
		"COMMA", "DOT", "NOT", "MOD", "MUL", "DIV", "ADD", "SUB", "ASSIGNMENT", 
		"COMPARER", "EQUALITY", "LOGICALOR", "LOGICALAND", "BOOL", "STRING", "IDENTIFIER", 
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
		"\x3\xAF6F\x8320\x479D\xB75C\x4880\x1605\x191C\xAB37\x2&\xF2\b\x1\x4\x2"+
		"\t\x2\x4\x3\t\x3\x4\x4\t\x4\x4\x5\t\x5\x4\x6\t\x6\x4\a\t\a\x4\b\t\b\x4"+
		"\t\t\t\x4\n\t\n\x4\v\t\v\x4\f\t\f\x4\r\t\r\x4\xE\t\xE\x4\xF\t\xF\x4\x10"+
		"\t\x10\x4\x11\t\x11\x4\x12\t\x12\x4\x13\t\x13\x4\x14\t\x14\x4\x15\t\x15"+
		"\x4\x16\t\x16\x4\x17\t\x17\x4\x18\t\x18\x4\x19\t\x19\x4\x1A\t\x1A\x4\x1B"+
		"\t\x1B\x4\x1C\t\x1C\x4\x1D\t\x1D\x4\x1E\t\x1E\x4\x1F\t\x1F\x4 \t \x4!"+
		"\t!\x4\"\t\"\x4#\t#\x4$\t$\x4%\t%\x3\x2\x3\x2\x3\x3\x3\x3\x3\x4\x3\x4"+
		"\x3\x5\x3\x5\x3\x6\x3\x6\x3\x6\x3\x6\x3\a\x3\a\x3\a\x3\a\x3\a\x3\a\x3"+
		"\b\x3\b\x3\b\x3\b\x3\b\x3\t\x3\t\x3\t\x3\t\x3\t\x3\t\x3\t\x3\n\x3\n\x3"+
		"\n\x3\v\x3\v\x3\v\x3\v\x3\v\x3\f\x3\f\x3\f\x3\f\x3\f\x3\r\x3\r\x3\r\x3"+
		"\r\x3\r\x3\r\x3\xE\x3\xE\x3\xE\x3\xF\x3\xF\x3\xF\x3\xF\x3\xF\x3\xF\x3"+
		"\x10\x3\x10\x3\x11\x3\x11\x3\x12\x3\x12\x3\x13\x3\x13\x3\x14\x3\x14\x3"+
		"\x15\x3\x15\x3\x16\x3\x16\x3\x17\x3\x17\x3\x18\x3\x18\x3\x19\x3\x19\x3"+
		"\x1A\x3\x1A\x3\x1B\x3\x1B\x3\x1B\x3\x1B\x5\x1B\xA0\n\x1B\x3\x1C\x3\x1C"+
		"\x3\x1C\x3\x1D\x3\x1D\x3\x1D\x3\x1E\x3\x1E\x3\x1E\x3\x1E\x3\x1E\x3\x1E"+
		"\x3\x1E\x3\x1E\x3\x1E\x5\x1E\xB1\n\x1E\x3\x1F\x3\x1F\a\x1F\xB5\n\x1F\f"+
		"\x1F\xE\x1F\xB8\v\x1F\x3\x1F\x3\x1F\x3 \x3 \a \xBE\n \f \xE \xC1\v \x3"+
		"!\x6!\xC4\n!\r!\xE!\xC5\x3!\x3!\x6!\xCA\n!\r!\xE!\xCB\x3\"\x6\"\xCF\n"+
		"\"\r\"\xE\"\xD0\x3#\x6#\xD4\n#\r#\xE#\xD5\x3#\x3#\x3$\x3$\x3$\x3$\a$\xDE"+
		"\n$\f$\xE$\xE1\v$\x3$\x3$\x3$\x3$\x3$\x3%\x3%\x3%\x3%\a%\xEC\n%\f%\xE"+
		"%\xEF\v%\x3%\x3%\x4\xB6\xDF\x2\x2&\x3\x2\x3\x5\x2\x4\a\x2\x5\t\x2\x6\v"+
		"\x2\a\r\x2\b\xF\x2\t\x11\x2\n\x13\x2\v\x15\x2\f\x17\x2\r\x19\x2\xE\x1B"+
		"\x2\xF\x1D\x2\x10\x1F\x2\x11!\x2\x12#\x2\x13%\x2\x14\'\x2\x15)\x2\x16"+
		"+\x2\x17-\x2\x18/\x2\x19\x31\x2\x1A\x33\x2\x1B\x35\x2\x1C\x37\x2\x1D\x39"+
		"\x2\x1E;\x2\x1F=\x2 ?\x2!\x41\x2\"\x43\x2#\x45\x2$G\x2%I\x2&\x3\x2\b\x4"+
		"\x2>>@@\x4\x2\x43\\\x63|\x5\x2\x32;\x43\\\x63|\x3\x2\x32;\x5\x2\v\f\xF"+
		"\xF\"\"\x4\x2\f\f\xF\xF\xFB\x2\x3\x3\x2\x2\x2\x2\x5\x3\x2\x2\x2\x2\a\x3"+
		"\x2\x2\x2\x2\t\x3\x2\x2\x2\x2\v\x3\x2\x2\x2\x2\r\x3\x2\x2\x2\x2\xF\x3"+
		"\x2\x2\x2\x2\x11\x3\x2\x2\x2\x2\x13\x3\x2\x2\x2\x2\x15\x3\x2\x2\x2\x2"+
		"\x17\x3\x2\x2\x2\x2\x19\x3\x2\x2\x2\x2\x1B\x3\x2\x2\x2\x2\x1D\x3\x2\x2"+
		"\x2\x2\x1F\x3\x2\x2\x2\x2!\x3\x2\x2\x2\x2#\x3\x2\x2\x2\x2%\x3\x2\x2\x2"+
		"\x2\'\x3\x2\x2\x2\x2)\x3\x2\x2\x2\x2+\x3\x2\x2\x2\x2-\x3\x2\x2\x2\x2/"+
		"\x3\x2\x2\x2\x2\x31\x3\x2\x2\x2\x2\x33\x3\x2\x2\x2\x2\x35\x3\x2\x2\x2"+
		"\x2\x37\x3\x2\x2\x2\x2\x39\x3\x2\x2\x2\x2;\x3\x2\x2\x2\x2=\x3\x2\x2\x2"+
		"\x2?\x3\x2\x2\x2\x2\x41\x3\x2\x2\x2\x2\x43\x3\x2\x2\x2\x2\x45\x3\x2\x2"+
		"\x2\x2G\x3\x2\x2\x2\x2I\x3\x2\x2\x2\x3K\x3\x2\x2\x2\x5M\x3\x2\x2\x2\a"+
		"O\x3\x2\x2\x2\tQ\x3\x2\x2\x2\vS\x3\x2\x2\x2\rW\x3\x2\x2\x2\xF]\x3\x2\x2"+
		"\x2\x11\x62\x3\x2\x2\x2\x13i\x3\x2\x2\x2\x15l\x3\x2\x2\x2\x17q\x3\x2\x2"+
		"\x2\x19v\x3\x2\x2\x2\x1B|\x3\x2\x2\x2\x1D\x7F\x3\x2\x2\x2\x1F\x85\x3\x2"+
		"\x2\x2!\x87\x3\x2\x2\x2#\x89\x3\x2\x2\x2%\x8B\x3\x2\x2\x2\'\x8D\x3\x2"+
		"\x2\x2)\x8F\x3\x2\x2\x2+\x91\x3\x2\x2\x2-\x93\x3\x2\x2\x2/\x95\x3\x2\x2"+
		"\x2\x31\x97\x3\x2\x2\x2\x33\x99\x3\x2\x2\x2\x35\x9F\x3\x2\x2\x2\x37\xA1"+
		"\x3\x2\x2\x2\x39\xA4\x3\x2\x2\x2;\xB0\x3\x2\x2\x2=\xB2\x3\x2\x2\x2?\xBB"+
		"\x3\x2\x2\x2\x41\xC3\x3\x2\x2\x2\x43\xCE\x3\x2\x2\x2\x45\xD3\x3\x2\x2"+
		"\x2G\xD9\x3\x2\x2\x2I\xE7\x3\x2\x2\x2KL\a}\x2\x2L\x4\x3\x2\x2\x2MN\a\x7F"+
		"\x2\x2N\x6\x3\x2\x2\x2OP\a*\x2\x2P\b\x3\x2\x2\x2QR\a+\x2\x2R\n\x3\x2\x2"+
		"\x2ST\ak\x2\x2TU\ap\x2\x2UV\av\x2\x2V\f\x3\x2\x2\x2WX\ah\x2\x2XY\an\x2"+
		"\x2YZ\aq\x2\x2Z[\a\x63\x2\x2[\\\av\x2\x2\\\xE\x3\x2\x2\x2]^\a\x64\x2\x2"+
		"^_\aq\x2\x2_`\aq\x2\x2`\x61\an\x2\x2\x61\x10\x3\x2\x2\x2\x62\x63\au\x2"+
		"\x2\x63\x64\av\x2\x2\x64\x65\at\x2\x2\x65\x66\ak\x2\x2\x66g\ap\x2\x2g"+
		"h\ai\x2\x2h\x12\x3\x2\x2\x2ij\ak\x2\x2jk\ah\x2\x2k\x14\x3\x2\x2\x2lm\a"+
		"g\x2\x2mn\an\x2\x2no\au\x2\x2op\ag\x2\x2p\x16\x3\x2\x2\x2qr\at\x2\x2r"+
		"s\ag\x2\x2st\a\x63\x2\x2tu\a\x66\x2\x2u\x18\x3\x2\x2\x2vw\ay\x2\x2wx\a"+
		"t\x2\x2xy\ak\x2\x2yz\av\x2\x2z{\ag\x2\x2{\x1A\x3\x2\x2\x2|}\a\x66\x2\x2"+
		"}~\aq\x2\x2~\x1C\x3\x2\x2\x2\x7F\x80\ay\x2\x2\x80\x81\aj\x2\x2\x81\x82"+
		"\ak\x2\x2\x82\x83\an\x2\x2\x83\x84\ag\x2\x2\x84\x1E\x3\x2\x2\x2\x85\x86"+
		"\a=\x2\x2\x86 \x3\x2\x2\x2\x87\x88\a.\x2\x2\x88\"\x3\x2\x2\x2\x89\x8A"+
		"\a\x30\x2\x2\x8A$\x3\x2\x2\x2\x8B\x8C\a#\x2\x2\x8C&\x3\x2\x2\x2\x8D\x8E"+
		"\a\'\x2\x2\x8E(\x3\x2\x2\x2\x8F\x90\a,\x2\x2\x90*\x3\x2\x2\x2\x91\x92"+
		"\a\x31\x2\x2\x92,\x3\x2\x2\x2\x93\x94\a-\x2\x2\x94.\x3\x2\x2\x2\x95\x96"+
		"\a/\x2\x2\x96\x30\x3\x2\x2\x2\x97\x98\a?\x2\x2\x98\x32\x3\x2\x2\x2\x99"+
		"\x9A\t\x2\x2\x2\x9A\x34\x3\x2\x2\x2\x9B\x9C\a?\x2\x2\x9C\xA0\a?\x2\x2"+
		"\x9D\x9E\a#\x2\x2\x9E\xA0\a?\x2\x2\x9F\x9B\x3\x2\x2\x2\x9F\x9D\x3\x2\x2"+
		"\x2\xA0\x36\x3\x2\x2\x2\xA1\xA2\a~\x2\x2\xA2\xA3\a~\x2\x2\xA3\x38\x3\x2"+
		"\x2\x2\xA4\xA5\a(\x2\x2\xA5\xA6\a(\x2\x2\xA6:\x3\x2\x2\x2\xA7\xA8\av\x2"+
		"\x2\xA8\xA9\at\x2\x2\xA9\xAA\aw\x2\x2\xAA\xB1\ag\x2\x2\xAB\xAC\ah\x2\x2"+
		"\xAC\xAD\a\x63\x2\x2\xAD\xAE\an\x2\x2\xAE\xAF\au\x2\x2\xAF\xB1\ag\x2\x2"+
		"\xB0\xA7\x3\x2\x2\x2\xB0\xAB\x3\x2\x2\x2\xB1<\x3\x2\x2\x2\xB2\xB6\a$\x2"+
		"\x2\xB3\xB5\v\x2\x2\x2\xB4\xB3\x3\x2\x2\x2\xB5\xB8\x3\x2\x2\x2\xB6\xB7"+
		"\x3\x2\x2\x2\xB6\xB4\x3\x2\x2\x2\xB7\xB9\x3\x2\x2\x2\xB8\xB6\x3\x2\x2"+
		"\x2\xB9\xBA\a$\x2\x2\xBA>\x3\x2\x2\x2\xBB\xBF\t\x3\x2\x2\xBC\xBE\t\x4"+
		"\x2\x2\xBD\xBC\x3\x2\x2\x2\xBE\xC1\x3\x2\x2\x2\xBF\xBD\x3\x2\x2\x2\xBF"+
		"\xC0\x3\x2\x2\x2\xC0@\x3\x2\x2\x2\xC1\xBF\x3\x2\x2\x2\xC2\xC4\t\x5\x2"+
		"\x2\xC3\xC2\x3\x2\x2\x2\xC4\xC5\x3\x2\x2\x2\xC5\xC3\x3\x2\x2\x2\xC5\xC6"+
		"\x3\x2\x2\x2\xC6\xC7\x3\x2\x2\x2\xC7\xC9\a\x30\x2\x2\xC8\xCA\t\x5\x2\x2"+
		"\xC9\xC8\x3\x2\x2\x2\xCA\xCB\x3\x2\x2\x2\xCB\xC9\x3\x2\x2\x2\xCB\xCC\x3"+
		"\x2\x2\x2\xCC\x42\x3\x2\x2\x2\xCD\xCF\t\x5\x2\x2\xCE\xCD\x3\x2\x2\x2\xCF"+
		"\xD0\x3\x2\x2\x2\xD0\xCE\x3\x2\x2\x2\xD0\xD1\x3\x2\x2\x2\xD1\x44\x3\x2"+
		"\x2\x2\xD2\xD4\t\x6\x2\x2\xD3\xD2\x3\x2\x2\x2\xD4\xD5\x3\x2\x2\x2\xD5"+
		"\xD3\x3\x2\x2\x2\xD5\xD6\x3\x2\x2\x2\xD6\xD7\x3\x2\x2\x2\xD7\xD8\b#\x2"+
		"\x2\xD8\x46\x3\x2\x2\x2\xD9\xDA\a\x31\x2\x2\xDA\xDB\a,\x2\x2\xDB\xDF\x3"+
		"\x2\x2\x2\xDC\xDE\v\x2\x2\x2\xDD\xDC\x3\x2\x2\x2\xDE\xE1\x3\x2\x2\x2\xDF"+
		"\xE0\x3\x2\x2\x2\xDF\xDD\x3\x2\x2\x2\xE0\xE2\x3\x2\x2\x2\xE1\xDF\x3\x2"+
		"\x2\x2\xE2\xE3\a,\x2\x2\xE3\xE4\a\x31\x2\x2\xE4\xE5\x3\x2\x2\x2\xE5\xE6"+
		"\b$\x2\x2\xE6H\x3\x2\x2\x2\xE7\xE8\a\x31\x2\x2\xE8\xE9\a\x31\x2\x2\xE9"+
		"\xED\x3\x2\x2\x2\xEA\xEC\n\a\x2\x2\xEB\xEA\x3\x2\x2\x2\xEC\xEF\x3\x2\x2"+
		"\x2\xED\xEB\x3\x2\x2\x2\xED\xEE\x3\x2\x2\x2\xEE\xF0\x3\x2\x2\x2\xEF\xED"+
		"\x3\x2\x2\x2\xF0\xF1\b%\x2\x2\xF1J\x3\x2\x2\x2\r\x2\x9F\xB0\xB6\xBF\xC5"+
		"\xCB\xD0\xD5\xDF\xED\x3\b\x2\x2";
	public static readonly ATN _ATN =
		new ATNDeserializer().Deserialize(_serializedATN.ToCharArray());
}
} // namespace NewVersion
