using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>Options for texture padding mode.</summary>
	public enum ETexturePowerOfTwoSetting:byte
	{
		/// <summary>Do not modify the texture dimensions.</summary>
		None=0,
		/// <summary>Pad the texture to the nearest power of two size.</summary>
		PadToPowerOfTwo=1,
		/// <summary>Pad the texture to the nearest square power of two size.</summary>
		PadToSquarePowerOfTwo=2,
		ETexturePowerOfTwoSetting_MAX=3,
		
	}
	
}
