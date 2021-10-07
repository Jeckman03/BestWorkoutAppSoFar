using System;
using System.Collections.Generic;

public class ChestModel : ILifts
{
	// public List<string> NameOfLifts { get; set; } = new List<string>();
	public List<Sets> SetList { get; set; } = new List<Sets>();
	public List<Sets> WarmUpSets { get; set; } = new List<Sets>();

	public string LiftName { get; set; }
	public LiftName Name { get; set; }

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