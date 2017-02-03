using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>The different methods that can be used if a word is too long to be broken by the default line-break iterator.</summary>
	public enum ETextWrappingPolicy:byte
	{
		/// <summary>No fallback, just use the given line-break iterator</summary>
		DefaultWrapping=0,
		/// <summary>Fallback to per-character wrapping if a word is too long</summary>
		AllowPerCharacterWrapping=1,
		ETextWrappingPolicy_MAX=2,
		
	}
	
}
