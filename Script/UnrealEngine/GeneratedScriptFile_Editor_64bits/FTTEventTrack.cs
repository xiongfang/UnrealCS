#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>Structure storing information about one event track</summary>
	[StructLayout(LayoutKind.Explicit,Size=24)]
	public partial struct FTTEventTrack
	{
		/// <summary>Curve object used to store keys</summary>
		/// <summary>Name of this track</summary>
		[FieldOffset(0)]
		public FName TrackName;
		/// <summary>Flag to identify internal/external curve</summary>
		public bool bIsExternalCurve
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 12, 1, 0, 1, 255); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 12, 1, 0, 1, 255); } }}
			
		}
		
	}
	
}
#endif
#endif
