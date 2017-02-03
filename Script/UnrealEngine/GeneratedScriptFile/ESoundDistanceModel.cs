using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public enum ESoundDistanceModel:byte
	{
		ATTENUATION_Linear=0,
		ATTENUATION_Logarithmic=1,
		ATTENUATION_Inverse=2,
		ATTENUATION_LogReverse=3,
		ATTENUATION_NaturalSound=4,
		ATTENUATION_Custom=5,
		ATTENUATION_MAX=6,
		
	}
	
}
