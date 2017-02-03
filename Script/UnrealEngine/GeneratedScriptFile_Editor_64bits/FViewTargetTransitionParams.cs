#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>A set of parameters to describe how to transition between view targets.</summary>
	[StructLayout(LayoutKind.Explicit,Size=16)]
	public partial struct FViewTargetTransitionParams
	{
		/// <summary>Total duration of blend to pending view target. 0 means no blending.</summary>
		[FieldOffset(0)]
		public float BlendTime;
		/// <summary>Function to apply to the blend parameter.</summary>
		[FieldOffset(4)]
		public EViewTargetBlendFunction BlendFunction;
		/// <summary>Exponent, used by certain blend functions to control the shape of the curve.</summary>
		[FieldOffset(8)]
		public float BlendExp;
		/// <summary>
		/// If true, lock outgoing viewtarget to last frame's camera POV for the remainder of the blend.
		/// This is useful if you plan to teleport the old viewtarget, but don't want to affect the blend.
		/// </summary>
		public bool bLockOutgoing
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 12, 1, 0, 1, 1); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 12, 1, 0, 1, 1); } }}
			
		}
		
	}
	
}
#endif
#endif
