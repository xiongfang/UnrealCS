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
		
		static UTimelineComponent()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("TimelineComponent");
			TheTimeline__Offset=GetPropertyOffset(NativeClassPtr,"TheTimeline");
			
		}
		
	}
	
}
#endif
#endif
