using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>Enum specifying the importance of properties when simplifying skeletal meshes.</summary>
	public enum SkeletalMeshOptimizationImportance:byte
	{
		SMOI_Off=0,
		SMOI_Lowest=1,
		SMOI_Low=2,
		SMOI_Normal=3,
		SMOI_High=4,
		SMOI_Highest=5,
		SMOI_MAX=6,
		
	}
	
}
