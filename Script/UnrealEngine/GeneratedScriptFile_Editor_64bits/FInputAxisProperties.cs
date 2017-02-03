#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>Configurable properties for control axes, used to transform raw input into game ready values.</summary>
	[StructLayout(LayoutKind.Explicit,Size=16)]
	public partial struct FInputAxisProperties
	{
		/// <summary>What the dead zone of the axis is.  For control axes such as analog sticks.</summary>
		[FieldOffset(0)]
		public float DeadZone;
		/// <summary>Scaling factor to multiply raw value by.</summary>
		[FieldOffset(4)]
		public float Sensitivity;
		/// <summary>For applying curves to [0..1] axes, e.g. analog sticks</summary>
		[FieldOffset(8)]
		public float Exponent;
		/// <summary>Inverts reported values for this axis</summary>
		public bool bInvert
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 12, 1, 0, 1, 1); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 12, 1, 0, 1, 1); } }}
			
		}
		
	}
	
}
#endif
#endif
