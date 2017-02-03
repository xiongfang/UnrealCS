using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public enum EFontHinting:byte
	{
		/// <summary>Use the default hinting specified in the font.</summary>
		Default=0,
		/// <summary>Force the use of an automatic hinting algorithm.</summary>
		Auto=1,
		/// <summary>Force the use of an automatic light hinting algorithm, optimized for non-monochrome displays.</summary>
		AutoLight=2,
		/// <summary>Force the use of an automatic hinting algorithm optimized for monochrome displays.</summary>
		Monochrome=3,
		/// <summary>Do not use hinting.</summary>
		None=4,
		EFontHinting_MAX=5,
		
	}
	
}
