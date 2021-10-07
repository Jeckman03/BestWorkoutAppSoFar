using System;
using System.Collections.Generic;

// SET CLASS
public class Sets
{
	public int RepGoal { get; set; }
	public int RepsCompleted { get; set; }

	public int Weight { get; set; }

	public Sets(int reps)
	{
		RepGoal = reps;
	}

	public override string ToString()
	{
		string output = "";

		output = $"|{ RepGoal } / { Weight }| ";

		return output;
	}
}