#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>
	/// TimelineComponent holds a series of events, floats, vectors or colors with associated keyframes.
	/// Events can be triggered at keyframes along the timeline.
	/// Floats, vectors, and colors are interpolated between keyframes along the timeline.
	/// </summary>
	public partial class UTimelineComponent
	{
		static readonly int TheTimeline__Offset;
		/// <summary>The actual timeline structure</summary>
		public FTimeline TheTimeline
		{
			get{ CheckIsValid();return (FTimeline)Marshal.PtrToStructure(_this.Get()+TheTimeline__Offset, typeof(FTimeline));}
			
		}
		
		static readonly int bIgnoreTimeDilation__Offset;
		/// <summary>True if global time dilation should be ignored by this timeline, false otherwise.</summary>
		public bool bIgnoreTimeDilation
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bIgnoreTimeDilation__Offset, 1, 0, 1, 1);}
			
		}
		
		static UTimelineComponent()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("TimelineComponent");
			TheTimeline__Offset=GetPropertyOffset(NativeClassPtr,"TheTimeline");
			bIgnoreTimeDilation__Offset=GetPropertyOffset(NativeClassPtr,"bIgnoreTimeDilation");
			
		}
		
	}
	
}
#endif
#endif
