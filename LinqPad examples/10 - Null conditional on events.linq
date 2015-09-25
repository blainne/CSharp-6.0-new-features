<Query Kind="Program" />

void Main()
{
	EventOldWay();
	EventNewWay();
	"Done, no exceptions were thrown.".Dump();
}


event EventHandler someEvent;

public void EventOldWay()
{
	var eventCopy = someEvent;

	if(eventCopy != null)
		eventCopy(new Object(), new EventArgs());
}

public void EventNewWay()
{
	//below doesn't compile
	//someEvent?(this, null);	
	
	someEvent?.Invoke(new Object(), new EventArgs());
}