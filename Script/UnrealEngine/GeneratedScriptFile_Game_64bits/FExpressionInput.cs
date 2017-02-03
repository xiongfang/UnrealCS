#if WITH_GAME
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	[StructLayout(LayoutKind.Explicit,Size=56)]
	public partial struct FExpressionInput
	{
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
