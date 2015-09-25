<Query Kind="Program" />

void Main()
{
	var oldList = new OldWayCustomList { "this", "works" };
	oldList.Dump("Old way");
	
	var newList = new NewWayCustomList { "this", "works" };
	newList.Dump("New way");
}

// Define other methods and classes here
public class OldWayCustomList : IEnumerable
{
	private List<string> list = new List<string>();

	public IEnumerator GetEnumerator()
	{
		return list.GetEnumerator();
	}

	public List<string> List
	{
		get { return list; }
	}

	public void Add(string s)
	{
		list.Add(s);
	}
}

public class NewWayCustomList : IEnumerable
{
	private List<string> list = new List<string>();

	public IEnumerator GetEnumerator()
	{
		return list.GetEnumerator();
	}

	public List<string> List
	{
		get { return list; }
	}
}

public static class Extensions
{
	public static void Add(this NewWayCustomList list, string s)
	{
		list.List.Add(s);
	}
}