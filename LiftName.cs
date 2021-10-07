using System;
using System.Collections.Generic;

public class LiftName
{
	public List<string> ChestNames = new List<string> {
		"Bench", "Incline Bench", "Dumbbell Flys"
	};

	public List<string> BackNames = new List<string> {
		"Deadlift", "Bent Over Rows", "Seated Rows"
	};

	public List<string> ShoulderNames = new List<string> {
		"Military Press", "Lateral Raises", "Front Raises"
	};

	public static string ShowListOfNames(this List<string> names)
	{
		string output = "";

		foreach (var lift in names)
		{
			output += $"{ lift }, ";
		}

		return output;
	}
}