<Query Kind="Program" />

void Main()
{
	var oldNotes = new OldWaySchoolNotes();
	var newNotes = new NewWaySchoolNotes();
	
	oldNotes["GS"].Dump("Old way");
	newNotes["GS"].Dump("New way");
}

class OldWaySchoolNotes
{
	private List<Note> Notes = InitNotes();

	public IEnumerable<int> this[string person]
	{
		get
		{
			return Notes
				.Where(n => n.Person == person)
				.Select(n => n.Score);
		}
	}
}

class NewWaySchoolNotes
{
	private List<Note> Notes = InitNotes();

	public IEnumerable<int> this[string person] =>
		Notes
		.Where(n => n.Person == person)
		.Select(n => n.Score);
}

static List<Note> InitNotes()
{
	return new List<Note>()
	{
		new Note("GS", 1),
		new Note("Kujon", 6),
		new Note("GS", 3),
		new Note("Kujon", 5)
	};
}

class Note
{
	public string Person;
	public int Score;

	public Note(string person, int score)
	{
		Person = person;
		Score = score;
	}
}