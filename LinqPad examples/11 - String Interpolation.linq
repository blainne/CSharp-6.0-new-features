<Query Kind="Program" />

void Main()
{
	(OldWayWine()
	+ Environment.NewLine
	+ Environment.NewLine
	+ OldWayUrl())
	.Dump("Old way");


	(NewWayWine()
	+ Environment.NewLine
	+ Environment.NewLine
	+ NewWayUrl())
	.Dump("New way");
}

public string OldWayWine()
{
	return String.Format("My bottle of \"{0,30}\" is {1} year{2} old.",
						   wine,
						   age,
						   (age == 1)? "" : "s");
}


public string OldWayUrl()
{	
	return String.Format("https://{0}/ChangeTracker/api/Project/{1}/File/{2}?changeId={3}",
						  host,
						  projId,
						  fileId,
						  changeId);
	
}


public string NewWayWine()
{
	return $"My bottle of \"{wine,30}\" is {age} year{(age == 1 ? "" : "s")} old.";
}

public string NewWayUrl()
{
	return $"https://{host}/ChangeTracker/api/Project/{projId}/File/{fileId}?changeId={changeId}";
}

const string wine = "Leśny Dzban";
const int age = 4;
const string fileId = "73412b41-e86e-455f-b38d-15dba2014b95";
const string projId = "5d094650-9ba7-492b-96c1-176506e108db";
const string changeId = "32b6ffb0-4ef9-45f5-bbf8-f7e174ab7ad8";
const string host = "changeCloud002";