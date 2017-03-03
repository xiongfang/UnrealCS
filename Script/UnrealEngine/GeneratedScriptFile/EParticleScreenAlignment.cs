using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public enum EParticleScreenAlignment:byte
	{
		PSA_FacingCameraPosition=0,
		PSA_Square=1,
		PSA_Rectangle=2,
		PSA_Velocity=3,
		PSA_AwayFromCenter=4,
		PSA_TypeSpecific=5,
		PSA_FacingCameraDistanceBlend=6,
		PSA_MAX=7,
		
	}
	
}
