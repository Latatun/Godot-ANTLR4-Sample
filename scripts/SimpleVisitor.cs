using Antlr4.Runtime.Misc;
using Hello_World;

public partial class SimpleVisitor : HelloWorldBaseVisitor<string>
{

	public override string VisitHello([NotNull] HelloWorldParser.HelloContext context)
	{
		var text = context.GetText();
		if (text.ToLower().Contains("hello") || text.ToLower().Contains("world"))
		{
			return "Hello To You Too!";
		}

		return "I'm Dumb Dumb";
	}
}
