#if WITH_GAME
#if PLATFORM_32BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	[StructLayout(LayoutKind.Explicit,Size=96)]
	public partial struct FCanvasUVTri
	{
		[FieldOffset(0)]
		public FVector2D V0_Pos;
		[FieldOffset(8)]
		public FVector2D V0_UV;
		[FieldOffset(16)]
		public FLinearColor V0_Color;
		[FieldOffset(32)]
		public FVector2D V1_Pos;
		[FieldOffset(40)]
		public FVector2D V1_UV;
		[FieldOffset(48)]
		public FLinearColor V1_Color;
		[FieldOffset(64)]
		public FVector2D V2_Pos;
		[FieldOffset(72)]
		public FVector2D V2_UV;
		[FieldOffset(80)]
		public FLinearColor V2_Color;
		
	}
	
}
#endif
#endif
