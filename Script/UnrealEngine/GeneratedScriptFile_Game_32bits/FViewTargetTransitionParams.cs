#if WITH_GAME
#if PLATFORM_32BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	[StructLayout(LayoutKind.Explicit,Size=16)]
	public partial struct FViewTargetTransitionParams
	{
		[FieldOffset(0)]
		public float BlendTime;
		[FieldOffset(4)]
		public EViewTargetBlendFunction BlendFunction;
		[FieldOffset(8)]
		public float BlendExp;
		public bool bLockOutgoing
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 12, 1, 0, 1, 1); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 12, 1, 0, 1, 1); } }}
			
		}
		
	}
	
}
#endif
#endif
