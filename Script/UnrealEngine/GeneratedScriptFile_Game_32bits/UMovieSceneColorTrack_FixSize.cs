#if WITH_GAME
#if PLATFORM_32BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class UMovieSceneColorTrack
	{
		static readonly int bIsSlateColor__Offset;
		public bool bIsSlateColor
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bIsSlateColor__Offset, 1, 0, 1, 255);}
			
		}
		
		static UMovieSceneColorTrack()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("MovieSceneColorTrack");
			bIsSlateColor__Offset=GetPropertyOffset(NativeClassPtr,"bIsSlateColor");
			
		}
		
	}
	
}
#endif
#endif
