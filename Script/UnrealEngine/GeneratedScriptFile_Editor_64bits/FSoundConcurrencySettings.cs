#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	[StructLayout(LayoutKind.Explicit,Size=16)]
	public partial struct FSoundConcurrencySettings
	{
		/// <summary>The max number of allowable concurrent active voices for voices playing in this concurrency group.</summary>
		[FieldOffset(0)]
		public int MaxCount;
		/// <summary>Whether or not to limit the concurrency to per sound owner (i.e. the actor that plays the sound). If the sound doesn't have an owner, it falls back to global concurrency.</summary>
		public bool bLimitToOwner
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 4, 1, 0, 1, 1); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 4, 1, 0, 1, 1); } }}
			
		}
		/// <summary>Which concurrency resolution policy to use if max voice count is reached.</summary>
		[FieldOffset(8)]
		public EMaxConcurrentResolutionRule ResolutionRule;
		/// <summary>
		/// The amount of attenuation to apply to older voice instances in this concurrency group. This reduces volume of older voices in a concurrency group as new voices play.
		/// AppliedVolumeScale = Math.Pow(DuckingScale, VoiceGeneration)
		/// </summary>
		[FieldOffset(12)]
		public float VolumeScale;
		
	}
	
}
#endif
#endif
