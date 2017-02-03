#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>An Input Chord is a key and the modifier keys that are to be held with it.</summary>
	[StructLayout(LayoutKind.Explicit,Size=40)]
	public partial struct FInputChord
	{
		/// <summary>The Key is the core of the chord.</summary>
		[FieldOffset(0)]
		public FKey Key;
		/// <summary>Whether the shift key is part of the chord.</summary>
		public bool bShift
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 32, 1, 0, 1, 1); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 32, 1, 0, 1, 1); } }}
			
		}
		/// <summary>Whether the control key is part of the chord.</summary>
		public bool bCtrl
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 32, 1, 0, 2, 2); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 32, 1, 0, 2, 2); } }}
			
		}
		/// <summary>Whether the alt key is part of the chord.</summary>
		public bool bAlt
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 32, 1, 0, 4, 4); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 32, 1, 0, 4, 4); } }}
			
		}
		/// <summary>Whether the command key is part of the chord.</summary>
		public bool bCmd
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 32, 1, 0, 8, 8); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 32, 1, 0, 8, 8); } }}
			
		}
		
	}
	
}
#endif
#endif
