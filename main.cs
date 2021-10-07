using System;
using System.Collections.Generic;

class Program {
  public static void Main (string[] args) {


		LiftName nameOfLift = new LiftName();

		Console.WriteLine(nameOfLift.ChestNames.ShowListOfNames());

		// CREATE A ROUTINE
		/*RoutineModel myRoutine = new RoutineModel("Chest Day");

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
		*/

    Console.ReadLine();
  }
}













