using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public enum ETriangleSortOption:byte
	{
		TRISORT_None=0,
		TRISORT_CenterRadialDistance=1,
		TRISORT_Random=2,
		TRISORT_MergeContiguous=3,
		TRISORT_Custom=4,
		TRISORT_CustomLeftRight=5,
		TRISORT_MAX=6,
		
	}
	
}
