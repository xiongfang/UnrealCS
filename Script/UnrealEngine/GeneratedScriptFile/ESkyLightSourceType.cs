using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public enum ESkyLightSourceType:byte
	{
		/// <summary>Construct the sky light from the captured scene, anything further than SkyDistanceThreshold from the sky light position will be included.</summary>
		SLS_CapturedScene=0,
		/// <summary>Construct the sky light from the specified cubemap.</summary>
		SLS_SpecifiedCubemap=1,
		SLS_MAX=2,
		
	}
	
}
