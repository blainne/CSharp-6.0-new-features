<Query Kind="Program">
  <Namespace>System.Threading.Tasks</Namespace>
</Query>

void Main()
{
	DestroyTheWorld().Wait();
}

public static async Task DestroyTheWorld()
{
	var primeval = await ThePrimeval.WakeUp();
	try
	{
		"Mage: I will use You for my own purpose!".Dump();
		await primeval.MindControl();
	}
	catch (Exception e)
	{
		e.Message.Dump();
		await HideSomewhere();
	}
	finally
	{
		"Mage: I will send You to other dimension!".Dump();
		await primeval.SendToVoid();
	}
}

public class ThePrimeval
{
	public static Task<ThePrimeval> WakeUp()
	{
		"Primeval: Why did You break my long rest?".Dump();
		return Task.FromResult(new ThePrimeval());
	}
	
	public Task<string> MindControl()
	{
		throw new InvalidOperationException("Primeval: Not enough mana, pitiful mage!");
	}

	public Task SendToVoid()
	{
		var t = new Task(() => "Primeval: I'll be back.".Dump());
		t.RunSynchronously();
		return t;
	}
}

public static Task HideSomewhere()
{
	var t = new Task(() => "Mage: I need to hide.".Dump());
	t.RunSynchronously();
	return t;
}
