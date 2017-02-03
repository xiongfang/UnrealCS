using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>Enumerates supported font caching types.</summary>
	public enum EFontCacheType:byte
	{
		/// <summary>The font is using offline caching (this is how UFont traditionally worked).</summary>
		Offline=0,
		/// <summary>The font is using runtime caching (this is how Slate fonts work).</summary>
		Runtime=1,
		EFontCacheType_MAX=2,
		
	}
	
}
