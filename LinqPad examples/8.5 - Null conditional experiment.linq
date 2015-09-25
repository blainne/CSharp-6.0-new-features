<Query Kind="Program" />

static void Main()
{
	Test(null);
	Test("cat"); // True.
	Test("x");
	Test("parrot"); // True.
}


static void Test(string name)
{
	if (name?.Length >= 3)
	{
		name.Dump();
	}
}