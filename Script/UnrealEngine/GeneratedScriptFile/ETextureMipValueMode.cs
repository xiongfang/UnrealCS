using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>defines how MipValue is used</summary>
	public enum ETextureMipValueMode:byte
	{
		/// <summary>Use hardware computed sample's mip level with automatic anisotropic filtering support.</summary>
		TMVM_None=0,
		/// <summary>Explicitly compute the sample's mip level. Disables anisotropic filtering.</summary>
		TMVM_MipLevel=1,
		/// <summary>Bias the hardware computed sample's mip level. Disables anisotropic filtering.</summary>
		TMVM_MipBias=2,
		/// <summary>Explicitly compute the sample's DDX and DDY for anisotropic filtering.</summary>
		TMVM_Derivative=3,
		TMVM_MAX=4,
		
	}
	
}
