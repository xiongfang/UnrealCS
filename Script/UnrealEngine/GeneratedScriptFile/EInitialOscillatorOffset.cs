using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>Shake start offset parameter</summary>
	public enum EInitialOscillatorOffset:byte
	{
		/// <summary>Start with random offset (default).</summary>
		EOO_OffsetRandom=0,
		/// <summary>Start with zero offset.</summary>
		EOO_OffsetZero=1,
		EOO_MAX=2,
		
	}
	
}
