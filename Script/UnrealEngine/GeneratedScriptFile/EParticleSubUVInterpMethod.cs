using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>SubUV-related</summary>
	public enum EParticleSubUVInterpMethod:byte
	{
		PSUVIM_None=0,
		PSUVIM_Linear=1,
		PSUVIM_Linear_Blend=2,
		PSUVIM_Random=3,
		PSUVIM_Random_Blend=4,
		PSUVIM_MAX=5,
		
	}
	
}
