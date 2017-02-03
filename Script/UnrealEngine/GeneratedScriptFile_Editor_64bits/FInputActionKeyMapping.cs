#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>
	/// Defines a mapping between an action and key
	/// @see https://docs.unrealengine.com/latest/INT/Gameplay/Input/index.html
	/// </summary>
	[StructLayout(LayoutKind.Explicit,Size=56)]
	public partial struct FInputActionKeyMapping
	{
		/// <summary>Friendly name of action, e.g "jump"</summary>
		[FieldOffset(0)]
		public FName ActionName;
		/// <summary>Key to bind it to.</summary>
		[FieldOffset(16)]
		public FKey Key;
		/// <summary>true if one of the Shift keys must be down when the KeyEvent is received to be acknowledged</summary>
		public bool bShift
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 48, 1, 0, 1, 1); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 48, 1, 0, 1, 1); } }}
			
		}
		/// <summary>true if one of the Ctrl keys must be down when the KeyEvent is received to be acknowledged</summary>
		public bool bCtrl
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 48, 1, 0, 2, 2); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 48, 1, 0, 2, 2); } }}
			
		}
		/// <summary>true if one of the Alt keys must be down when the KeyEvent is received to be acknowledged</summary>
		public bool bAlt
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 48, 1, 0, 4, 4); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 48, 1, 0, 4, 4); } }}
			
		}
		/// <summary>true if one of the Cmd keys must be down when the KeyEvent is received to be acknowledged</summary>
		public bool bCmd
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 48, 1, 0, 8, 8); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 48, 1, 0, 8, 8); } }}
			
		}
		
	}
	
}
#endif
#endif
