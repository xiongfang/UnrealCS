#if WITH_GAME
#if PLATFORM_32BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	[StructLayout(LayoutKind.Explicit,Size=76)]
	public partial struct FAngularDriveConstraint
	{
		[FieldOffset(0)]
		public FConstraintDrive TwistDrive;
		[FieldOffset(16)]
		public FConstraintDrive SwingDrive;
		[FieldOffset(32)]
		public FConstraintDrive SlerpDrive;
		[FieldOffset(48)]
		public FRotator OrientationTarget;
		[FieldOffset(60)]
		public FVector AngularVelocityTarget;
		[FieldOffset(72)]
		public EAngularDriveMode AngularDriveMode;
		
	}
	
}
#endif
#endif
