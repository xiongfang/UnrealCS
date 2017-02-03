using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public enum EAngularDriveMode:byte
	{
		/// <summary>Spherical lerp between the current orientation/velocity and the target orientation/velocity. NOTE: This will NOT work if any angular constraints are set to Locked.</summary>
		SLERP=0,
		/// <summary>Path is decomposed into twist (roll constraint) and swing (cone constraint). Doesn't follow shortest arc and may experience gimbal lock. Does work with locked angular constraints.</summary>
		TwistAndSwing=1,
		EAngularDriveMode_MAX=2,
		
	}
	
}
