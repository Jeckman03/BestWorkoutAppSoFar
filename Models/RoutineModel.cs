using System;
using System.Collections.Generic;

public class RoutineModel
{
	public List<ILifts> Lifts { get; set; } = new List<ILifts>();

	public string NameOfRoutine { get; set; }

	public RoutineModel(string name)
	{
		NameOfRoutine = name;
	}
}