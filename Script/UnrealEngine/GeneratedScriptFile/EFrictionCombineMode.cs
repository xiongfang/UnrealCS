using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public enum EFrictionCombineMode:byte
	{
		/// <summary>Uses the average value of the materials touching: (a+b)/2</summary>
		Average=0,
		/// <summary>Uses the minimum value of the materials touching: min(a,b)</summary>
		Min=1,
		/// <summary>Uses the product of the values of the materials touching: a*b</summary>
		Multiply=2,
		/// <summary>Uses the maximum value of materials touching: max(a,b)</summary>
		Max=3,
		EFrictionCombineMode_MAX=4,
		
	}
	
}
