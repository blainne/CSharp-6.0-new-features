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
	private string title = "Dune";
	public string Title { get { return title; }  }

	private BookDetails details;
	public BookDetails Details { get { return details; } }

	public OldWay()
	{
		details = BookDetails.ExampleData();
	}
}

public class NewWay
{
	public string Title { get; } = "Dune";
	public BookDetails Details { get; }

	public NewWay()
	{
		Details = BookDetails.ExampleData();
	}
}

public class BookDetails
{
	public string Author { get; set; }
	public int Pages { get; set; }

	public static BookDetails ExampleData()
	{ 
		return new BookDetails { Pages = 544, Author = "Frank Herbert" }; 
	}
}