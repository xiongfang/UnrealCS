#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	[StructLayout(LayoutKind.Explicit,Size=68)]
	public partial struct FSplinePoint
	{
		[FieldOffset(0)]
		public float InputKey;
		[FieldOffset(4)]
		public FVector Position;
		[FieldOffset(16)]
		public FVector ArriveTangent;
		[FieldOffset(28)]
		public FVector LeaveTangent;
		[FieldOffset(40)]
		public FRotator Rotation;
		[FieldOffset(52)]
		public FVector Scale;
		[FieldOffset(64)]
		public ESplinePointType Type;
		
	}
	
}
#endif
#endif
