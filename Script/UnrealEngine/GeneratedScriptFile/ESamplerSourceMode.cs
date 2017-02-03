using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public enum ESamplerSourceMode:byte
	{
		/// <summary>Get the sampler from the texture.  Every unique texture will consume a sampler slot, which are limited in number.</summary>
		SSM_FromTextureAsset=0,
		/// <summary>Shared sampler source that does not consume a sampler slot.  Uses wrap addressing and gets filter mode from the world texture group.</summary>
		SSM_Wrap_WorldGroupSettings=1,
		/// <summary>Shared sampler source that does not consume a sampler slot.  Uses clamp addressing and gets filter mode from the world texture group.</summary>
		SSM_Clamp_WorldGroupSettings=2,
		SSM_MAX=3,
		
	}
	
}
