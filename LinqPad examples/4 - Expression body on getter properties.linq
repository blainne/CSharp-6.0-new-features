<Query Kind="Program" />

void Main()
{
	OldWayNiceDate.Dump("Old way");
	NewWayNiceDate.Dump("New way");
}


string OldWayNiceDate
{
	get { return GetDate(); }
}

string NewWayNiceDate =>
	GetDate();



private string GetDate()
{
	return String.Format("{0} {1}",
						 DateTime.Now.ToShortDateString(),
						 DateTime.Now.ToShortTimeString());
}