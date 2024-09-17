using Antlr4.Runtime.Misc;
using Godot;
using Hello_World;

public partial class SimpleVisitor : HelloWorldBaseVisitor<string>
{

	public override string VisitHello([NotNull] HelloWorldParser.HelloContext context)
	{
		var text = context?.GetText()?.ToLower() ?? "Disappointing";
		return text.Contains("hello") || text.Contains("world") ? "Hello To You Too!" : "I'm Dumb Dumb";
	}
}
