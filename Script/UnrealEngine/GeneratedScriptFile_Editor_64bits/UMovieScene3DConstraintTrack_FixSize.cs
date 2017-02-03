#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>Base class for constraint tracks (tracks that are dependent upon other objects).</summary>
	public partial class UMovieScene3DConstraintTrack
	{
		static readonly int ConstraintSections__Offset;
		/// <summary>List of all constraint sections.</summary>
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
