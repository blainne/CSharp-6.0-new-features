<Query Kind="Program" />

void Main()
{
	int someVariable;
	
	nameof(someVariable).Dump();
	nameof(NewWay).Dump();
	nameof(System.Console.WriteLine).Dump();
	nameof(Main).GetType().Dump();

	DumpException(OldWay);
	DumpException(AlternativeOldWay);
	DumpException(NewWay);
	
}

public static void OldWay(float someArgument)
{
	throw new ArgumentException("someArgument");
}

public static void AlternativeOldWay(float someArgument)
{
	var argName = GetMemberName(() => someArgument);
	throw new ArgumentException(argName);
}

public static void NewWay(float someArgument)
{
	throw new ArgumentException(nameof(someArgument));
}


///From http://stackoverflow.com/questions/9801624/get-name-of-a-variable-or-parameter
public static string GetMemberName<T>(Expression<Func<T>> memberExpression)
{
	MemberExpression expressionBody = (MemberExpression)memberExpression.Body;
	return expressionBody.Member.Name;
}

public static void DumpException(Action<float> action)
{
	try
	{
		action(0.0f);
	}
	catch (Exception e)
	{
		e.Dump();
	}
}