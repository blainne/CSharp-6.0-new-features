<Query Kind="Program">
  <Namespace>static System.Linq.Enumerable</Namespace>
</Query>

//using static System.Linq.Enumerable

void Main()
{
	var data = Range(0, 10);
	
	Enumerable.Where(data, x => x%2 == 0).Dump("Old way");
	
	//Does not compile.
	//Where(data, x => x%2 == 0).Dump("New way");  
	
	data.Where(x => x%2 == 0).Dump("Works both ways");
}