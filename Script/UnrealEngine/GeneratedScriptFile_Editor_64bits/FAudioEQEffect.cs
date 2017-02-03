#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	[StructLayout(LayoutKind.Explicit,Size=56)]
	public partial struct FAudioEQEffect
	{
		/// <summary>Center frequency in Hz for band 0</summary>
		[FieldOffset(8)]
		public float FrequencyCenter0;
		/// <summary>Boost/cut of band 0</summary>
		[FieldOffset(12)]
		public float Gain0;
		/// <summary>Bandwidth of band 0. Region is center frequency +/- Bandwidth /2</summary>
		[FieldOffset(16)]
		public float Bandwidth0;
		/// <summary>Center frequency in Hz for band 1</summary>
		[FieldOffset(20)]
		public float FrequencyCenter1;
		/// <summary>Boost/cut of band 1</summary>
		[FieldOffset(24)]
		public float Gain1;
		/// <summary>Bandwidth of band 1. Region is center frequency +/- Bandwidth /2</summary>
		[FieldOffset(28)]
		public float Bandwidth1;
		/// <summary>Center frequency in Hz for band 2</summary>
		[FieldOffset(32)]
		public float FrequencyCenter2;
		/// <summary>Boost/cut of band 2</summary>
		[FieldOffset(36)]
		public float Gain2;
		/// <summary>Bandwidth of band 2. Region is center frequency +/- Bandwidth /2</summary>
		[FieldOffset(40)]
		public float Bandwidth2;
		/// <summary>Center frequency in Hz for band 3</summary>
		[FieldOffset(44)]
		public float FrequencyCenter3;
		/// <summary>Boost/cut of band 3</summary>
		[FieldOffset(48)]
		public float Gain3;
		/// <summary>Bandwidth of band 3. Region is center frequency +/- Bandwidth /2</summary>
		[FieldOffset(52)]
		public float Bandwidth3;
		
	}
	
}
#endif
#endif
