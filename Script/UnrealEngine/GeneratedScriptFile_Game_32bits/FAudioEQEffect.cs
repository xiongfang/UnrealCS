#if WITH_GAME
#if PLATFORM_32BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	[StructLayout(LayoutKind.Explicit,Size=56)]
	public partial struct FAudioEQEffect
	{
		[FieldOffset(8)]
		public float FrequencyCenter0;
		[FieldOffset(12)]
		public float Gain0;
		[FieldOffset(16)]
		public float Bandwidth0;
		[FieldOffset(20)]
		public float FrequencyCenter1;
		[FieldOffset(24)]
		public float Gain1;
		[FieldOffset(28)]
		public float Bandwidth1;
		[FieldOffset(32)]
		public float FrequencyCenter2;
		[FieldOffset(36)]
		public float Gain2;
		[FieldOffset(40)]
		public float Bandwidth2;
		[FieldOffset(44)]
		public float FrequencyCenter3;
		[FieldOffset(48)]
		public float Gain3;
		[FieldOffset(52)]
		public float Bandwidth3;
		
	}
	
}
#endif
#endif
