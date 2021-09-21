using System;
using System.Collections.Generic;

class Program {
  public static void Main (string[] args) {

		// CREATE A ROUTINE
		RoutineModel myRoutine = new RoutineModel("Chest Day");

		myRoutine.Lifts.Add(new ChestModel("Bench", true, 1, 12, 3, 6));
		myRoutine.Lifts.Add(new BackModel("Deadlift", true, 3, 12, 4, 8));
		myRoutine.Lifts.Add(new ShoulderModel("Military Press", 3, 12));

		foreach (var lift in myRoutine.Lifts)
		{
			Console.WriteLine($"{ lift.ToString() }");
			if (lift.WarmUpSets.Count != 0)
			{
				Console.WriteLine("Warmup:");
				foreach (var sets in lift.WarmUpSets)
				{
					Console.WriteLine($"{ sets.ToString() }");
				}
				Console.WriteLine();
			}
			
			Console.WriteLine("Workout:");
			foreach (var sets in lift.SetList)
			{
				Console.WriteLine($"{ sets.ToString() }");
			}
			Console.WriteLine();
		}

    Console.ReadLine();
  }
}

public class RoutineModel
{
	public List<ILifts> Lifts { get; set; } = new List<ILifts>();

	public string NameOfRoutine { get; set; }

	public RoutineModel(string name)
	{
		NameOfRoutine = name;
	}
}

// INTERFACE
public interface ILifts
{
	List<string> NameOfLifts { get; set; }
	List<Sets> SetList { get; set; }
	List<Sets> WarmUpSets { get; set; }

}

// LIFT MODELS
public class ChestModel : ILifts
{
	public List<string> NameOfLifts { get; set; } = new List<string>();
	public List<Sets> SetList { get; set; } = new List<Sets>();
	public List<Sets> WarmUpSets { get; set; } = new List<Sets>();

	public string LiftName { get; set; }

	public ChestModel(string name, bool warmUp, int numberOfWarmUpSets, int numberOfWarmUpReps,  int numberOfSets, int numberOfReps)
	{
		LiftName = name;

		if (warmUp == true)
		{
			for (var i = 0; i < numberOfWarmUpSets; i++)
			{
				WarmUpSets.Add(new Sets(numberOfWarmUpReps));
			}
		}
		
		for (var i = 0; i < numberOfSets; i++)
		{
			SetList.Add(new Sets(numberOfReps));
		}
	}

	public override string ToString()
	{
		string output = "";

		output = $"{ LiftName }";

		return output;
	}
}

public class BackModel : ILifts
{
	public List<string> NameOfLifts { get; set; } = new List<string>();
	public List<Sets> SetList { get; set; } = new List<Sets>();
	public List<Sets> WarmUpSets { get; set; } = new List<Sets>();

	public string LiftName { get; set; }

	// CONSTRUCTOR WITHOUT WARMUP
	public BackModel(string name, int numberOfSets, int numberOfReps)
	{
		LiftName = name;
		
		for (var i = 0; i < numberOfSets; i++)
		{
			SetList.Add(new Sets(numberOfReps));
		}
	}

	// CONSTRUCTOR WITH WARMUP
	public BackModel(string name, bool warmUp, int numberOfWarmUpSets, int numberOfWarmUpReps, int numberOfSets, int numberOfReps) : this(name, numberOfSets, numberOfReps)
	{
		if (warmUp == true)
		{
			for (var i = 0; i < numberOfWarmUpSets; i++)
			{
				WarmUpSets.Add(new Sets(numberOfWarmUpReps));
			}
		}
	}

	public override string ToString()
	{
		string output = "";

		output = $"{ LiftName }";

		return output;
	}
}

public class ShoulderModel : ILifts
{
	public List<string> NameOfLifts { get; set; } = new List<string>();
	public List<Sets> SetList { get; set; } = new List<Sets>();
	public List<Sets> WarmUpSets { get; set; } = new List<Sets>();

	public string LiftName { get; set; }

	// CONSTRUCTOR WITHOUT WARMUP
	public ShoulderModel(string name, int numberOfSets, int numberOfReps)
	{
		LiftName = name;
		
		for (var i = 0; i < numberOfSets; i++)
		{
			SetList.Add(new Sets(numberOfReps));
		}
	}

	// CONSTRUCTOR WITH WARMUP
	public ShoulderModel(string name, bool warmUp, int numberOfWarmUpSets, int numberOfWarmUpReps, int numberOfSets, int numberOfReps) : this(name, numberOfSets, numberOfReps)
	{
		if (warmUp == true)
		{
			for (var i = 0; i < numberOfWarmUpSets; i++)
			{
				WarmUpSets.Add(new Sets(numberOfWarmUpReps));
			}
		}
	}

	public override string ToString()
	{
		string output = "";

		output = $"{ LiftName }";

		return output;
	}
}


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

