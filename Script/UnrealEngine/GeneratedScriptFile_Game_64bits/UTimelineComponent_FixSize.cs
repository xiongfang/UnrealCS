#if WITH_GAME
#if PLATFORM_64BITS
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
		
		static readonly int bIgnoreTimeDilation__Offset;
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
