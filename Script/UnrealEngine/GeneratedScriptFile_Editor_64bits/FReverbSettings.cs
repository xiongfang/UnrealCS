#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>Struct encapsulating settings for reverb effects.</summary>
	[StructLayout(LayoutKind.Explicit,Size=24)]
	public partial struct FReverbSettings
	{
		/// <summary>Whether to apply the reverb settings below.</summary>
		public bool bApplyReverb
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 0, 1, 0, 1, 1); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 0, 1, 0, 1, 1); } }}
			
		}
		/// <summary>The reverb preset to employ.</summary>
		[FieldOffset(4)]
		public ReverbPreset ReverbType;
		/// <summary>The reverb asset to employ.</summary>
		/// <summary>Volume level of the reverb affect.</summary>
		[FieldOffset(16)]
		public float Volume;
		/// <summary>Time to fade from the current reverb settings into this setting, in seconds.</summary>
		[FieldOffset(20)]
		public float FadeTime;
		
	}
	
}
#endif
#endif
