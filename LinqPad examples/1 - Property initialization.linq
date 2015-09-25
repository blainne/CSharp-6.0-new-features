<Query Kind="Program" />

void Main()
{
	var old = new OldWay();
	var @new = new NewWay();
	
	old.Dump("Old way");
	@new.Dump("New way");
}

public class OldWay
{
	public string Title { get; set; }
	public BookDetails Details { get; set; }

	public OldWay()
	{
		Title = "Dune";
        Details = BookDetails.ExampleData();
	}
}

public class NewWay
{
	public string Title { get; set; } = "Dune";
	
	public BookDetails Details { get; set; } = BookDetails.ExampleData();
}

public class BookDetails
{
	public string Author { get; set; }
	public int Pages { get; set;}

	public static BookDetails ExampleData()
	{
		return new BookDetails{ Pages = 544, Author = "Frank Herbert"};
	}
}

public class Experiments
{
//Error, doesn't compile
//	private string text;
//	public string Text
//	{
//		get { return text; }
//		set { text = value; }
//	} = "test";
}