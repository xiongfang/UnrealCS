#if WITH_GAME
#if PLATFORM_32BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	[StructLayout(LayoutKind.Explicit,Size=44)]
	public partial struct FExpressionInput
	{
		[FieldOffset(0)]
		public int OutputIndex;
		[FieldOffset(4)]
		public FString InputName;
		[FieldOffset(16)]
		public int Mask;
		[FieldOffset(20)]
		public int MaskR;
		[FieldOffset(24)]
		public int MaskG;
		[FieldOffset(28)]
		public int MaskB;
		[FieldOffset(32)]
		public int MaskA;
		[FieldOffset(36)]
		public FName ExpressionName;
		
	}
	
}
#endif
#endif
