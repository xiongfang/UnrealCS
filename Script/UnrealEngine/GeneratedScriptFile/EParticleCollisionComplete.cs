using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>Flags indicating what to do with the particle when MaxCollisions is reached</summary>
	public enum EParticleCollisionComplete:byte
	{
		/// <summary>Kill the particle when MaxCollisions is reached</summary>
		EPCC_Kill=0,
		/// <summary>Freeze the particle in place</summary>
		EPCC_Freeze=1,
		/// <summary>Stop collision checks, but keep updating</summary>
		EPCC_HaltCollisions=2,
		/// <summary>Stop translations of the particle</summary>
		EPCC_FreezeTranslation=3,
		/// <summary>Stop rotations of the particle</summary>
		EPCC_FreezeRotation=4,
		/// <summary>Stop all movement of the particle</summary>
		EPCC_FreezeMovement=5,
		EPCC_MAX=6,
		
	}
	
}
