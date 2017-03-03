#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>Structure containing configurable properties of a sound class.</summary>
	[StructLayout(LayoutKind.Explicit,Size=44)]
	public partial struct FSoundClassProperties
	{
		/// <summary>Volume multiplier.</summary>
		[FieldOffset(0)]
		public float Volume;
		/// <summary>Pitch multiplier.</summary>
		[FieldOffset(4)]
		public float Pitch;
		/// <summary>The amount of stereo sounds to bleed to the rear speakers</summary>
		[FieldOffset(8)]
		public float StereoBleed;
		/// <summary>The amount of a sound to bleed to the LFE channel</summary>
		[FieldOffset(12)]
		public float LFEBleed;
		/// <summary>Voice center channel volume - Not a multiplier (no propagation)</summary>
		[FieldOffset(16)]
		public float VoiceCenterChannelVolume;
		/// <summary>Volume of the radio filter effect</summary>
		[FieldOffset(20)]
		public float RadioFilterVolume;
		/// <summary>Volume at which the radio filter kicks in</summary>
		[FieldOffset(24)]
		public float RadioFilterVolumeThreshold;
		/// <summary>Sound mix voice - whether to apply audio effects</summary>
		public bool bApplyEffects
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 28, 1, 0, 1, 1); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 28, 1, 0, 1, 1); } }}
			
		}
		/// <summary>Whether to artificially prioritise the component to play</summary>
		public bool bAlwaysPlay
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 28, 1, 0, 2, 2); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 28, 1, 0, 2, 2); } }}
			
		}
		/// <summary>Whether or not this sound plays when the game is paused in the UI</summary>
		public bool bIsUISound
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 28, 1, 0, 4, 4); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 28, 1, 0, 4, 4); } }}
			
		}
		/// <summary>Whether or not this is music (propagates only if parent is true)</summary>
		public bool bIsMusic
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 28, 1, 0, 8, 8); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 28, 1, 0, 8, 8); } }}
			
		}
		/// <summary>Whether or not this sound class has reverb applied</summary>
		public bool bReverb
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 28, 1, 0, 16, 16); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 28, 1, 0, 16, 16); } }}
			
		}
		/// <summary>Amount of audio to send to master reverb effect for 2D sounds played with this sound class.</summary>
		[FieldOffset(32)]
		public float Default2DReverbSendAmount;
		/// <summary>Whether or not this sound class forces sounds to the center channel</summary>
		public bool bCenterChannelOnly
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 36, 1, 0, 1, 1); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 36, 1, 0, 1, 1); } }}
			
		}
		/// <summary>Whether the Interior/Exterior volume and LPF modifiers should be applied</summary>
		public bool bApplyAmbientVolumes
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 36, 1, 0, 2, 2); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 36, 1, 0, 2, 2); } }}
			
		}
		/// <summary>Which output target the sound should be played through</summary>
		[FieldOffset(40)]
		public EAudioOutputTarget OutputTarget;
		
	}
	
}
#endif
#endif
