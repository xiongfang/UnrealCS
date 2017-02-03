#if WITH_GAME
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	[StructLayout(LayoutKind.Explicit,Size=72)]
	public partial struct FVector2MaterialInput
	{
		public bool UseConstant
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 56, 1, 0, 1, 1); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 56, 1, 0, 1, 1); } }}
			
		}
		[FieldOffset(60)]
		public float ConstantX;
		[FieldOffset(64)]
		public float ConstantY;
		[FieldOffset(0)]
		public int OutputIndex;
		[FieldOffset(8)]
		public FString InputName;
		[FieldOffset(24)]
		public int Mask;
		[FieldOffset(28)]
		public int MaskR;
		[FieldOffset(32)]
		public int MaskG;
		[FieldOffset(36)]
		public int MaskB;
		[FieldOffset(40)]
		public int MaskA;
		[FieldOffset(48)]
		public FName ExpressionName;
		
	}
	
}
#endif
#endif
