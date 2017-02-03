#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	[StructLayout(LayoutKind.Explicit,Size=24)]
	public partial struct FSingleAnimationPlayData
	{
		/// <summary>
		/// @todo in the future, we should make this one UObject
		/// and have detail customization to display different things
		/// The default sequence to play on this skeletal mesh
		/// </summary>
		/// <summary>Default setting for looping for SequenceToPlay. This is not current state of looping.</summary>
		public bool bSavedLooping
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 8, 1, 0, 1, 1); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 8, 1, 0, 1, 1); } }}
			
		}
		/// <summary>Default setting for playing for SequenceToPlay. This is not current state of playing.</summary>
		public bool bSavedPlaying
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 8, 1, 0, 2, 2); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 8, 1, 0, 2, 2); } }}
			
		}
		/// <summary>Default setting for position of SequenceToPlay to play.</summary>
		[FieldOffset(12)]
		public float SavedPosition;
		/// <summary>Default setting for play rate of SequenceToPlay to play.</summary>
		[FieldOffset(16)]
		public float SavedPlayRate;
		
	}
	
}
#endif
#endif
