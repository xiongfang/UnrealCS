#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>Elements of data for sound group volume control</summary>
	[StructLayout(LayoutKind.Explicit,Size=24)]
	public partial struct FSoundClassAdjuster
	{
		/// <summary>The sound class this adjuster affects.</summary>
		/// <summary>A multiplier applied to the volume.</summary>
		[FieldOffset(8)]
		public float VolumeAdjuster;
		/// <summary>A multiplier applied to the pitch.</summary>
		[FieldOffset(12)]
		public float PitchAdjuster;
		/// <summary>Set to true to apply this adjuster to all children of the sound class.</summary>
		public bool bApplyToChildren
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 16, 1, 0, 1, 1); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 16, 1, 0, 1, 1); } }}
			
		}
		/// <summary>A multiplier applied to VoiceCenterChannelVolume.</summary>
		[FieldOffset(20)]
		public float VoiceCenterChannelVolumeAdjuster;
		
	}
	
}
#endif
#endif
