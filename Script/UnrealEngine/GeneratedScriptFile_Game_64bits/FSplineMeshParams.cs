#if WITH_GAME
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	[StructLayout(LayoutKind.Explicit,Size=88)]
	public partial struct FSplineMeshParams
	{
		[FieldOffset(0)]
		public FVector StartPos;
		[FieldOffset(12)]
		public FVector StartTangent;
		[FieldOffset(24)]
		public FVector2D StartScale;
		[FieldOffset(32)]
		public float StartRoll;
		[FieldOffset(36)]
		public FVector2D StartOffset;
		[FieldOffset(44)]
		public FVector EndPos;
		[FieldOffset(56)]
		public FVector EndTangent;
		[FieldOffset(68)]
		public FVector2D EndScale;
		[FieldOffset(76)]
		public float EndRoll;
		[FieldOffset(80)]
		public FVector2D EndOffset;
		
	}
	
}
#endif
#endif
