<Query Kind="Program" />

void Main()
{
	OldWay();
	NewWay();
}


public static void OldWay()
{
	var system = new SolarSystem();
	system[1] = "Mercury";
	system[3] = "Earth";
	system[6] = "Saturn (I guess)";
	
	system.Dump("Old way");
}

public static void NewWay()
{
	var system = new SolarSystem()
	{
		[1] = "Mercury",
		[3] = "Earth",
		[6] = "Saturn (I guess)"
	};

	system.Dump("New way");
}



class SolarSystem
{
	private Dictionary<int, string> planets = new Dictionary<int, string>();

	public string this[int orderFromSun]
	{
		get
		{
			return planets[orderFromSun];
		}
		set
		{
			planets[orderFromSun] = value;
		}
	}

	public Dictionary<int, string> Planets
	{	
		get {return planets;}
	}
}