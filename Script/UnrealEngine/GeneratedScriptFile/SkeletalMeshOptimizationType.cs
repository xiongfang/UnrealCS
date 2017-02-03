using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>Enum specifying the reduction type to use when simplifying skeletal meshes.</summary>
	public enum SkeletalMeshOptimizationType:byte
	{
		SMOT_NumOfTriangles=0,
		SMOT_MaxDeviation=1,
		SMOT_MAX=2,
		
	}
	
}
