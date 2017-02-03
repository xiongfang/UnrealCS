using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public enum EPhysicsType:byte
	{
		/// <summary>Follow owner.</summary>
		PhysType_Default=0,
		/// <summary>Do not follow owner, but make kinematic.</summary>
		PhysType_Kinematic=1,
		/// <summary>Do not follow owner, but simulate.</summary>
		PhysType_Simulated=2,
		PhysType_MAX=3,
		
	}
	
}
