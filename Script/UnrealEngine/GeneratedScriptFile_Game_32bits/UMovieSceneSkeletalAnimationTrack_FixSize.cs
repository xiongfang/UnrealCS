#if WITH_GAME
#if PLATFORM_32BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class UMovieSceneSkeletalAnimationTrack
	{
		static readonly int AnimationSections__Offset;
		public TObjectArray<UMovieSceneSection>  AnimationSections
		{
					get{ CheckIsValid();return new TObjectArray<UMovieSceneSection>((FScriptArray)Marshal.PtrToStructure(_this.Get()+AnimationSections__Offset, typeof(FScriptArray)));}
					set{ CheckIsValid();Marshal.StructureToPtr(value.InterArray, _this.Get()+AnimationSections__Offset, false);}
			
		}
		
		static UMovieSceneSkeletalAnimationTrack()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("MovieSceneSkeletalAnimationTrack");
			AnimationSections__Offset=GetPropertyOffset(NativeClassPtr,"AnimationSections");
			
		}
		
	}
	
}
#endif
#endif
