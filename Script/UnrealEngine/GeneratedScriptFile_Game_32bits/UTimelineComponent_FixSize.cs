#if WITH_GAME
#if PLATFORM_32BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class UTimelineComponent
	{
		static readonly int TheTimeline__Offset;
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
