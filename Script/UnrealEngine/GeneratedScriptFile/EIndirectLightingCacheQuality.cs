using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public enum EIndirectLightingCacheQuality:byte
	{
		/// <summary>The indirect lighting cache will be disabled for this object, so no GI from stationary lights on movable objects.</summary>
		ILCQ_Off=0,
		/// <summary>A single indirect lighting sample computed at the bounds origin will be interpolated which fades over time to newer results.</summary>
		ILCQ_Point=1,
		/// <summary>The object will get a 5x5x5 stable volume of interpolated indirect lighting, which allows gradients of lighting intensity across the receiving object.</summary>
		ILCQ_Volume=2,
		ILCQ_MAX=3,
		
	}
	
}
