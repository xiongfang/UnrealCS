#if WITH_GAME
#if PLATFORM_32BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	[StructLayout(LayoutKind.Explicit,Size=32)]
	public partial struct FSoundClassProperties
	{
		[FieldOffset(0)]
		public float Volume;
		[FieldOffset(4)]
		public float Pitch;
		[FieldOffset(8)]
		public float StereoBleed;
		[FieldOffset(12)]
		public float LFEBleed;
		[FieldOffset(16)]
		public float VoiceCenterChannelVolume;
		[FieldOffset(20)]
		public float RadioFilterVolume;
		[FieldOffset(24)]
		public float RadioFilterVolumeThreshold;
		public bool bApplyEffects
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 28, 1, 0, 1, 1); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 28, 1, 0, 1, 1); } }}
			
		}
		public bool bAlwaysPlay
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 28, 1, 0, 2, 2); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 28, 1, 0, 2, 2); } }}
			
		}
		public bool bIsUISound
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 28, 1, 0, 4, 4); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 28, 1, 0, 4, 4); } }}
			
		}
		public bool bIsMusic
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 28, 1, 0, 8, 8); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 28, 1, 0, 8, 8); } }}
			
		}
		public bool bReverb
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 28, 1, 0, 16, 16); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 28, 1, 0, 16, 16); } }}
			
		}
		public bool bCenterChannelOnly
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 28, 1, 0, 32, 32); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 28, 1, 0, 32, 32); } }}
			
		}
		public bool bApplyAmbientVolumes
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 28, 1, 0, 64, 64); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 28, 1, 0, 64, 64); } }}
			
		}
		[FieldOffset(29)]
		public EAudioOutputTarget OutputTarget;
		
	}
	
}
#endif
#endif
