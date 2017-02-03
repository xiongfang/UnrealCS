#if WITH_GAME
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	[StructLayout(LayoutKind.Explicit,Size=64)]
	public partial struct FColorMaterialInput
	{
		public bool UseConstant
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 56, 1, 0, 1, 1); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 56, 1, 0, 1, 1); } }}
			
		}
		[FieldOffset(60)]
		public FColor Constant;
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
