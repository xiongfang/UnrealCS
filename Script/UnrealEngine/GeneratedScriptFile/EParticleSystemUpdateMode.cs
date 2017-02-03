using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>
	/// ParticleSystemUpdateMode
	/// Enumeration indicating the method by which the system should be updated
	/// </summary>
	public enum EParticleSystemUpdateMode:byte
	{
		/// <summary>RealTime       - update via the delta time passed in</summary>
		EPSUM_RealTime=0,
		/// <summary>FixedTime      - update via a fixed time step</summary>
		EPSUM_FixedTime=1,
		EPSUM_MAX=2,
		
	}
	
}
