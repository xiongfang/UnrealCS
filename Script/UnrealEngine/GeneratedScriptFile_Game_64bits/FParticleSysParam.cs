#if WITH_GAME
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	[StructLayout(LayoutKind.Explicit,Size=128)]
	public partial struct FParticleSysParam
	{
		[FieldOffset(0)]
		public FName Name;
		[FieldOffset(8)]
		public EParticleSysParamType ParamType;
		[FieldOffset(12)]
		public float Scalar;
		[FieldOffset(16)]
		public float Scalar_Low;
		[FieldOffset(20)]
		public FVector Vector;
		[FieldOffset(32)]
		public FVector Vector_Low;
		[FieldOffset(44)]
		public FColor Color;
		
	}
	
}
#endif
#endif
