using Godot;
using Antlr4.Runtime;
using Hello_World;

public partial class ParserExample : Node
{
	SimpleVisitor visitor;
	public ParserExample()
	{
		visitor = new SimpleVisitor();
	}

	public string GetResult(string txt)
	{
		var stream = new AntlrInputStream(txt);
		var lexer = new HelloWorldLexer(stream);
		var tokenStream = new CommonTokenStream(lexer);
		var parser = new HelloWorldParser(tokenStream);
		var tree = parser.hello();
		return visitor.VisitHello(tree);
	}
}
