#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	[StructLayout(LayoutKind.Explicit,Size=28)]
	public partial struct FInterpControlPoint
	{
		/// <summary>The position of the point</summary>
		[FieldOffset(0)]
		public FVector PositionControlPoint;
		/// <summary>Is the location relative to the root components initial location</summary>
		public bool bPositionIsRelative
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 12, 1, 0, 1, 255); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 12, 1, 0, 1, 255); } }}
			
		}
		
	}
	
}
#endif
#endif
