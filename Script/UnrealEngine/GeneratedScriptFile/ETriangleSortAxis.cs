using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>Enum to specify which axis to use for the forward vector when using TRISORT_CustomLeftRight sort mode.</summary>
	public enum ETriangleSortAxis:byte
	{
		TSA_X_Axis=0,
		TSA_Y_Axis=1,
		TSA_Z_Axis=2,
		TSA_MAX=3,
		
	}
	
}
