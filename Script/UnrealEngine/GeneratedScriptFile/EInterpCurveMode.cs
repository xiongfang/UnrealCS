using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>Interpolation data types.</summary>
	public enum EInterpCurveMode:byte
	{
		CIM_Linear=0,
		CIM_CurveAuto=1,
		CIM_Constant=2,
		CIM_CurveUser=3,
		CIM_CurveBreak=4,
		CIM_CurveAutoClamped=5,
		CIM_MAX=6,
		
	}
	
}
