using System;
using System.Collections.Generic;

public class ShoulderModel : ILifts
{
	public List<Sets> SetList { get; set; } = new List<Sets>();
	public List<Sets> WarmUpSets { get; set; } = new List<Sets>();

	public string LiftName { get; set; }
	public LiftName Name { get; set; }

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