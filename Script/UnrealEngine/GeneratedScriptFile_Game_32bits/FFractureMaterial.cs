#if WITH_GAME
#if PLATFORM_32BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	[StructLayout(LayoutKind.Explicit,Size=36)]
	public partial struct FFractureMaterial
	{
		[FieldOffset(0)]
		public FVector2D UVScale;
		[FieldOffset(8)]
		public FVector2D UVOffset;
		[FieldOffset(16)]
		public FVector Tangent;
		[FieldOffset(28)]
		public float UAngle;
		[FieldOffset(32)]
		public int InteriorElementIndex;
		
	}
	
}
#endif
#endif
