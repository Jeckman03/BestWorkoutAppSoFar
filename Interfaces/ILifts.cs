using System;
using System.Collections.Generic;

// INTERFACE
public interface ILifts
{
	LiftName Name { get; set; }
	List<Sets> SetList { get; set; }
	List<Sets> WarmUpSets { get; set; }

}