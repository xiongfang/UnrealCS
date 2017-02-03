using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>A level of significance for a particle system. Used by game code to enable/disable emitters progressively as they move away from the camera or are occluded/off screen.</summary>
	public enum EParticleSignificanceLevel:byte
	{
		/// <summary>Low significance emitter. Culled first.</summary>
		Low=0,
		/// <summary>Medium significance emitter.</summary>
		Medium=1,
		/// <summary>High significance emitter. Culled last.</summary>
		High=2,
		/// <summary>Critical emitter. Never culled.</summary>
		Critical=3,
		Num=4,
		EParticleSignificanceLevel_MAX=5,
		
	}
	
}
