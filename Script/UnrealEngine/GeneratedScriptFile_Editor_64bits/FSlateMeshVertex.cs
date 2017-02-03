#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	[StructLayout(LayoutKind.Explicit,Size=60)]
	public partial struct FSlateMeshVertex
	{
		[FieldOffset(0)]
		public FVector2D Position;
		[FieldOffset(8)]
		public FColor Color;
		[FieldOffset(12)]
		public FVector2D UV0;
		[FieldOffset(20)]
		public FVector2D UV1;
		[FieldOffset(28)]
		public FVector2D UV2;
		[FieldOffset(36)]
		public FVector2D UV3;
		[FieldOffset(44)]
		public FVector2D UV4;
		[FieldOffset(52)]
		public FVector2D UV5;
		
	}
	
}
#endif
#endif
