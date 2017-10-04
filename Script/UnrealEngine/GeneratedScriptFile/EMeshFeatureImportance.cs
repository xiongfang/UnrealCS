using System;
namespace UnrealEngine
{
	/// <summary>The importance of a mesh feature when automatically generating mesh LODs.</summary>
	public enum EMeshFeatureImportance:byte
	{
		Off=0,
		Lowest=1,
		Low=2,
		Normal=3,
		High=4,
		Highest=5,
		EMeshFeatureImportance_MAX=6,
		
	}
	
}
