#if WITH_GAME
#if PLATFORM_32BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	[StructLayout(LayoutKind.Explicit,Size=480)]
	public partial struct FConstraintInstance
	{
		[FieldOffset(16)]
		public FName JointName;
		[FieldOffset(24)]
		public FName ConstraintBone1;
		[FieldOffset(32)]
		public FName ConstraintBone2;
		[FieldOffset(40)]
		public FVector Pos1;
		[FieldOffset(52)]
		public FVector PriAxis1;
		[FieldOffset(64)]
		public FVector SecAxis1;
		[FieldOffset(76)]
		public FVector Pos2;
		[FieldOffset(88)]
		public FVector PriAxis2;
		[FieldOffset(100)]
		public FVector SecAxis2;
		[FieldOffset(112)]
		public FRotator AngularRotationOffset;
		public bool bScaleLinearLimits
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 124, 1, 0, 1, 1); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 124, 1, 0, 1, 1); } }}
			
		}
		[FieldOffset(132)]
		public FConstraintProfileProperties ProfileInstance;
		
	}
	
}
#endif
#endif
