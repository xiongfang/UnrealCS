using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>How particles respond to collision events.</summary>
	public enum EParticleCollisionResponse:byte
	{
		/// <summary>The particle will bounce off of the surface.</summary>
		Bounce=0,
		/// <summary>The particle will stop on the surface.</summary>
		Stop=1,
		/// <summary>The particle will be killed.</summary>
		Kill=2,
		EParticleCollisionResponse_MAX=3,
		
	}
	
}
