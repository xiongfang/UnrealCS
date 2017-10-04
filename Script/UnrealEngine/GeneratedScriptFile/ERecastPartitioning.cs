using System;
namespace UnrealEngine
{
	/// <summary>keep in sync with rcRegionPartitioning enum!</summary>
	public enum ERecastPartitioning:byte
	{
		Monotone=0,
		Watershed=1,
		ChunkyMonotone=2,
		ERecastPartitioning_MAX=3,
		
	}
	
}
