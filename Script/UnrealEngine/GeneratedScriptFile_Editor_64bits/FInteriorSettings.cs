#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>Struct encapsulating settings for interior areas.</summary>
	[StructLayout(LayoutKind.Explicit,Size=36)]
	public partial struct FInteriorSettings
	{
		/// <summary>Whether these interior settings are the default values for the world</summary>
		public bool bIsWorldSettings
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 0, 1, 0, 1, 1); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 0, 1, 0, 1, 1); } }}
			
		}
		/// <summary>The desired volume of sounds outside the volume when the player is inside the volume</summary>
		[FieldOffset(4)]
		public float ExteriorVolume;
		/// <summary>The time over which to interpolate from the current volume to the desired volume of sounds outside the volume when the player enters the volume</summary>
		[FieldOffset(8)]
		public float ExteriorTime;
		/// <summary>The desired LPF frequency cutoff in hertz of sounds outside the volume when the player is inside the volume</summary>
		[FieldOffset(12)]
		public float ExteriorLPF;
		/// <summary>The time over which to interpolate from the current LPF to the desired LPF of sounds outside the volume when the player enters the volume</summary>
		[FieldOffset(16)]
		public float ExteriorLPFTime;
		/// <summary>The desired volume of sounds inside the volume when the player is outside the volume</summary>
		[FieldOffset(20)]
		public float InteriorVolume;
		/// <summary>The time over which to interpolate from the current volume to the desired volume of sounds inside the volume when the player enters the volume</summary>
		[FieldOffset(24)]
		public float InteriorTime;
		/// <summary>The desired LPF frequency cutoff in hertz of sounds inside  the volume when the player is outside the volume</summary>
		[FieldOffset(28)]
		public float InteriorLPF;
		/// <summary>The time over which to interpolate from the current LPF to the desired LPF of sounds inside the volume when the player enters the volume</summary>
		[FieldOffset(32)]
		public float InteriorLPFTime;
		
	}
	
}
#endif
#endif
