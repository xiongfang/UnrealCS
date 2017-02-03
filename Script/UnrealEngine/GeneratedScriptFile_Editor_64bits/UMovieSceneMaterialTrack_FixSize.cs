#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>Handles manipulation of material parameters in a movie scene.</summary>
	public partial class UMovieSceneMaterialTrack
	{
		static readonly int Sections__Offset;
		/// <summary>The sections owned by this track .</summary>
		public TObjectArray<UMovieSceneSection>  Sections
		{
					get{ CheckIsValid();return new TObjectArray<UMovieSceneSection>((FScriptArray)Marshal.PtrToStructure(_this.Get()+Sections__Offset, typeof(FScriptArray)));}
					set{ CheckIsValid();Marshal.StructureToPtr(value.InterArray, _this.Get()+Sections__Offset, false);}
			
		}
		
		static UMovieSceneMaterialTrack()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("MovieSceneMaterialTrack");
			Sections__Offset=GetPropertyOffset(NativeClassPtr,"Sections");
			
		}
		
	}
	
}
#endif
#endif
