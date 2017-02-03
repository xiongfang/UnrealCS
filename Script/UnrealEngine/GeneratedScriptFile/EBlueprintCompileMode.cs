using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>Compile modes.</summary>
	public enum EBlueprintCompileMode:byte
	{
		/// <summary>Use the default setting.</summary>
		Default=0,
		/// <summary>Always compile in development mode (even when cooking).</summary>
		Development=1,
		/// <summary>Always compile in final release mode.</summary>
		FinalRelease=2,
		EBlueprintCompileMode_MAX=3,
		
	}
	
}
