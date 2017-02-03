using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>Defines the domain of a material.</summary>
	public enum EMaterialDomain:byte
	{
		/// <summary>The material's attributes describe a 3d surface.</summary>
		MD_Surface=0,
		/// <summary>The material's attributes describe a deferred decal, and will be mapped onto the decal's frustum.</summary>
		MD_DeferredDecal=1,
		/// <summary>The material's attributes describe a light's distribution.</summary>
		MD_LightFunction=2,
		/// <summary>The material will be used in a custom post process pass.</summary>
		MD_PostProcess=3,
		/// <summary>The material will be used for UMG or Slate UI</summary>
		MD_UI=4,
		MD_MAX=5,
		
	}
	
}
