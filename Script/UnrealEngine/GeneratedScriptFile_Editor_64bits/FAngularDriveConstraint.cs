#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>Angular Drive</summary>
	[StructLayout(LayoutKind.Explicit,Size=76)]
	public partial struct FAngularDriveConstraint
	{
		/// <summary>Controls the twist (roll) constraint drive between current orientation/velocity and target orientation/velocity. This is available as long as the twist limit is set to free or limited.</summary>
		[FieldOffset(0)]
		public FConstraintDrive TwistDrive;
		/// <summary>Controls the cone constraint drive between current orientation/velocity and target orientation/velocity. This is available as long as there is at least one swing limit set to free or limited.</summary>
		[FieldOffset(16)]
		public FConstraintDrive SwingDrive;
		/// <summary>Controls the SLERP (spherical lerp) drive between current orientation/velocity and target orientation/velocity. NOTE: This is only available when all three angular limits are either free or limited. Locking any angular limit will turn off the drive implicitly.</summary>
		[FieldOffset(32)]
		public FConstraintDrive SlerpDrive;
		/// <summary>Target orientation relative to the the body reference frame.</summary>
		[FieldOffset(48)]
		public FRotator OrientationTarget;
		/// <summary>Target angular velocity relative to the body reference frame.</summary>
		[FieldOffset(60)]
		public FVector AngularVelocityTarget;
		/// <summary>Whether motors use SLERP (spherical lerp) or decompose into a Swing motor (cone constraints) and Twist motor (roll constraints). NOTE: SLERP will NOT work if any of the angular constraints are locked.</summary>
		[FieldOffset(72)]
		public EAngularDriveMode AngularDriveMode;
		
	}
	
}
#endif
#endif
