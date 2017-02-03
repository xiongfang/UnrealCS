#if WITH_GAME
#if PLATFORM_32BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	[StructLayout(LayoutKind.Explicit,Size=32)]
	public partial struct FExpressionOutput
	{
		[FieldOffset(0)]
		public FString OutputName;
		[FieldOffset(12)]
		public int Mask;
		[FieldOffset(16)]
		public int MaskR;
		[FieldOffset(20)]
		public int MaskG;
		[FieldOffset(24)]
		public int MaskB;
		[FieldOffset(28)]
		public int MaskA;
		
	}
	
}
#endif
#endif
