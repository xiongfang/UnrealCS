#if WITH_GAME
#if PLATFORM_32BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class UMovieScene3DConstraintTrack
	{
		static readonly int ConstraintSections__Offset;
		public TObjectArray<UMovieSceneSection>  ConstraintSections
		{
					get{ CheckIsValid();return new TObjectArray<UMovieSceneSection>((FScriptArray)Marshal.PtrToStructure(_this.Get()+ConstraintSections__Offset, typeof(FScriptArray)));}
					set{ CheckIsValid();Marshal.StructureToPtr(value.InterArray, _this.Get()+ConstraintSections__Offset, false);}
			
		}
		
		static UMovieScene3DConstraintTrack()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("MovieScene3DConstraintTrack");
			ConstraintSections__Offset=GetPropertyOffset(NativeClassPtr,"ConstraintSections");
			
		}
		
	}
	
}
#endif
#endif
