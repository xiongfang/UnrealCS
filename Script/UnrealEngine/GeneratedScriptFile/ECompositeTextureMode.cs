using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public enum ECompositeTextureMode:byte
	{
		CTM_Disabled=0,
		/// <summary>CompositingTexture needs to be a normal map with the same or larger size.</summary>
		CTM_NormalRoughnessToRed=1,
		/// <summary>CompositingTexture needs to be a normal map with the same or larger size.</summary>
		CTM_NormalRoughnessToGreen=2,
		/// <summary>CompositingTexture needs to be a normal map with the same or larger size.</summary>
		CTM_NormalRoughnessToBlue=3,
		/// <summary>CompositingTexture needs to be a normal map with the same or larger size.</summary>
		CTM_NormalRoughnessToAlpha=4,
		CTM_MAX=5,
		
	}
	
}
