#if WITH_GAME
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	[StructLayout(LayoutKind.Explicit,Size=40)]
	public partial struct FExpressionOutput
	{
		[FieldOffset(0)]
		public FString OutputName;
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
		
	}
	
}
#endif
#endif
