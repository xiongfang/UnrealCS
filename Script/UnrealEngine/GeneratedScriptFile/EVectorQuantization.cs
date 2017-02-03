using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public enum EVectorQuantization:byte
	{
		/// <summary>Each vector component will be rounded to the nearest whole number.</summary>
		RoundWholeNumber=0,
		/// <summary>Each vector component will be rounded, preserving one decimal place.</summary>
		RoundOneDecimal=1,
		/// <summary>Each vector component will be rounded, preserving two decimal places.</summary>
		RoundTwoDecimals=2,
		EVectorQuantization_MAX=3,
		
	}
	
}
