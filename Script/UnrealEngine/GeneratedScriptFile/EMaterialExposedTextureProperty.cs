using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>Selects the texture property to output</summary>
	public enum EMaterialExposedTextureProperty:byte
	{
		/// <summary>The texture's size.</summary>
		TMTM_TextureSize=0,
		/// <summary>The texture's texel size in the UV space (1 / Texture Size)</summary>
		TMTM_TexelSize=1,
		TMTM_MAX=2,
		
	}
	
}
