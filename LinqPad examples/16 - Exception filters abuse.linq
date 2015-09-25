<Query Kind="Program" />

void Main()
{
	"".Dump("Old Way");
	try
	{
		OldWay();
	}
	catch (Exception e)
	{
		e.StackTrace.Dump("Stack trace in main");
	}


	"".Dump("New Way");
	try
	{
		NewWay();
	}
	catch (Exception e)
	{
		e.StackTrace.Dump("Stack trace in main");
	}
}

public static void OldWay()
{
	try
	{
		throw new InvalidOperationException();
	}
	catch (InvalidOperationException e)
	{
		Log(e); 
		throw;
	}
}

public static void NewWay()
{
	try
	{
		throw new InvalidOperationException();
	}
	catch (InvalidOperationException e) when (Log(e)) {}

}

public static bool Log(Exception e)
{
	e.Dump();
	return false;
}