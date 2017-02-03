#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>Linear Drive</summary>
	[StructLayout(LayoutKind.Explicit,Size=76)]
	public partial struct FLinearDriveConstraint
	{
		/// <summary>Target position the linear drive.</summary>
		[FieldOffset(0)]
		public FVector PositionTarget;
		/// <summary>Target velocity the linear drive.</summary>
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
