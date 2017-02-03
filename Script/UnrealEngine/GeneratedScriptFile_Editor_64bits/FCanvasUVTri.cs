#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>Simple 2d triangle with UVs</summary>
	[StructLayout(LayoutKind.Explicit,Size=96)]
	public partial struct FCanvasUVTri
	{
		/// <summary>Position of first vertex</summary>
		[FieldOffset(0)]
		public FVector2D V0_Pos;
		/// <summary>UV of first vertex</summary>
		[FieldOffset(8)]
		public FVector2D V0_UV;
		/// <summary>Color of first vertex</summary>
		[FieldOffset(16)]
		public FLinearColor V0_Color;
		/// <summary>Position of second vertex</summary>
		[FieldOffset(32)]
		public FVector2D V1_Pos;
		/// <summary>UV of second vertex</summary>
		[FieldOffset(40)]
		public FVector2D V1_UV;
		/// <summary>Color of second vertex</summary>
		[FieldOffset(48)]
		public FLinearColor V1_Color;
		/// <summary>Position of third vertex</summary>
		[FieldOffset(64)]
		public FVector2D V2_Pos;
		/// <summary>UV of third vertex</summary>
		[FieldOffset(72)]
		public FVector2D V2_UV;
		/// <summary>Color of third vertex</summary>
		[FieldOffset(80)]
		public FLinearColor V2_Color;
		
	}
	
}
#endif
#endif
