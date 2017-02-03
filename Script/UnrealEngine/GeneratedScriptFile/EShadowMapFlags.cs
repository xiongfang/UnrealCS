using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>Bit-field flags that affects storage (e.g. packing, streaming) and other info about a shadowmap.</summary>
	public enum EShadowMapFlags:byte
	{
		/// <summary>No flags.</summary>
		SMF_None=0,
		/// <summary>Shadowmap should be placed in a streaming texture.</summary>
		SMF_Streamed=1,
		SMF_MAX=2,
		
	}
	
}
