using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public enum EMontagePlayReturnType:byte
	{
		/// <summary>Return value is the length of the montage (in seconds)</summary>
		MontageLength=0,
		/// <summary>Return value is the play duration of the montage (length / play rate, in seconds)</summary>
		Duration=1,
		EMontagePlayReturnType_MAX=2,
		
	}
	
}
