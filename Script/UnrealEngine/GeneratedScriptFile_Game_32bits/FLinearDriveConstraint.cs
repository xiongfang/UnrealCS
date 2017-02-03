#if WITH_GAME
#if PLATFORM_32BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	[StructLayout(LayoutKind.Explicit,Size=76)]
	public partial struct FLinearDriveConstraint
	{
		[FieldOffset(0)]
		public FVector PositionTarget;
		[FieldOffset(12)]
		public FVector VelocityTarget;
		[FieldOffset(24)]
		public FConstraintDrive XDrive;
		[FieldOffset(40)]
		public FConstraintDrive YDrive;
		[FieldOffset(56)]
		public FConstraintDrive ZDrive;
		public bool bEnablePositionDrive
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 72, 1, 0, 1, 1); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 72, 1, 0, 1, 1); } }}
			
		}
		
	}
	
}
#endif
#endif
