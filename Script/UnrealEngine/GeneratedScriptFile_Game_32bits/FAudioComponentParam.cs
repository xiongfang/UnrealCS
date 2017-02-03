#if WITH_GAME
#if PLATFORM_32BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	[StructLayout(LayoutKind.Explicit,Size=24)]
	public partial struct FAudioComponentParam
	{
		[FieldOffset(0)]
		public FName ParamName;
		[FieldOffset(8)]
		public float FloatParam;
		public bool BoolParam
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 12, 1, 0, 1, 255); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 12, 1, 0, 1, 255); } }}
			
		}
		[FieldOffset(16)]
		public int IntParam;
		
	}
	
}
#endif
#endif
