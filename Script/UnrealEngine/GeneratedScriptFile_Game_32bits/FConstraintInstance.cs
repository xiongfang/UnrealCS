#if WITH_GAME
#if PLATFORM_32BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	[StructLayout(LayoutKind.Explicit,Size=408)]
	public partial struct FConstraintInstance
	{
		[FieldOffset(12)]
		public FName JointName;
		[FieldOffset(20)]
		public FName ConstraintBone1;
		[FieldOffset(28)]
		public FName ConstraintBone2;
		[FieldOffset(36)]
		public FVector Pos1;
		[FieldOffset(48)]
		public FVector PriAxis1;
		[FieldOffset(60)]
		public FVector SecAxis1;
		[FieldOffset(72)]
		public FVector Pos2;
		[FieldOffset(84)]
		public FVector PriAxis2;
		[FieldOffset(96)]
		public FVector SecAxis2;
		[FieldOffset(108)]
		public FRotator AngularRotationOffset;
		public bool bScaleLinearLimits
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 120, 1, 0, 1, 1); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 120, 1, 0, 1, 1); } }}
			
		}
		[FieldOffset(128)]
		public FConstraintProfileProperties ProfileInstance;
		
	}
	
}
#endif
#endif
