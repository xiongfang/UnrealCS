#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>Struct containing mappings for legacy method of binding keys to exec commands.</summary>
	[StructLayout(LayoutKind.Explicit,Size=56)]
	public partial struct FKeyBind
	{
		/// <summary>The key to be bound to the command</summary>
		[FieldOffset(0)]
		public FKey Key;
		/// <summary>The command to execute when the key is pressed/released</summary>
		[FieldOffset(32)]
		public FString Command;
		/// <summary>Whether the control key needs to be held when the key event occurs</summary>
		public bool Control
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 48, 1, 0, 1, 1); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 48, 1, 0, 1, 1); } }}
			
		}
		/// <summary>Whether the shift key needs to be held when the key event occurs</summary>
		public bool Shift
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 48, 1, 0, 2, 2); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 48, 1, 0, 2, 2); } }}
			
		}
		/// <summary>Whether the alt key needs to be held when the key event occurs</summary>
		public bool Alt
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 48, 1, 0, 4, 4); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 48, 1, 0, 4, 4); } }}
			
		}
		/// <summary>Whether the command key needs to be held when the key event occurs</summary>
		public bool Cmd
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 48, 1, 0, 8, 8); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 48, 1, 0, 8, 8); } }}
			
		}
		/// <summary>Whether the control key must not be held when the key event occurs</summary>
		public bool bIgnoreCtrl
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 48, 1, 0, 16, 16); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 48, 1, 0, 16, 16); } }}
			
		}
		/// <summary>Whether the shift key must not be held when the key event occurs</summary>
		public bool bIgnoreShift
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 48, 1, 0, 32, 32); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 48, 1, 0, 32, 32); } }}
			
		}
		/// <summary>Whether the alt key must not be held when the key event occurs</summary>
		public bool bIgnoreAlt
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 48, 1, 0, 64, 64); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 48, 1, 0, 64, 64); } }}
			
		}
		/// <summary>Whether the command key must not be held when the key event occurs</summary>
		public bool bIgnoreCmd
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 48, 1, 0, 128, 128); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 48, 1, 0, 128, 128); } }}
			
		}
		public bool bDisabled
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 49, 1, 0, 1, 1); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 49, 1, 0, 1, 1); } }}
			
		}
		
	}
	
}
#endif
#endif
