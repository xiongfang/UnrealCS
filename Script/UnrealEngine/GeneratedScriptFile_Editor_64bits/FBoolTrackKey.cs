#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>Information for one event in the track.</summary>
	[StructLayout(LayoutKind.Explicit,Size=8)]
	public partial struct FBoolTrackKey
	{
		[FieldOffset(0)]
		public float Time;
		public bool Value
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 4, 1, 0, 1, 1); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 4, 1, 0, 1, 1); } }}
			
		}
		
	}
	
}
#endif
#endif
