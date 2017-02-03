using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>Enum used to describe what type of collision is enabled on a body.</summary>
	public enum ECollisionEnabled:byte
	{
		/// <summary>Will not create any representation in the physics engine. Cannot be used for spatial queries (raycasts, sweeps, overlaps) or simulation (rigid body, constraints). Best performance possible (especially for moving objects)</summary>
		NoCollision=0,
		/// <summary>Only used for spatial queries (raycasts, sweeps, and overlaps). Cannot be used for simulation (rigid body, constraints). Useful for character movement and things that do not need physical simulation. Performance gains by keeping data out of simulation tree.</summary>
		QueryOnly=1,
		/// <summary>Only used only for physics simulation (rigid body, constraints). Cannot be used for spatial queries (raycasts, sweeps, overlaps). Useful for jiggly bits on characters that do not need per bone detection. Performance gains by keeping data out of query tree</summary>
		PhysicsOnly=2,
		/// <summary>Can be used for both spatial queries (raycasts, sweeps, overlaps) and simulation (rigid body, constraints).</summary>
		QueryAndPhysics=3,
		ECollisionEnabled_MAX=4,
		
	}
	
}
