#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>A section for use with the movie scene level visibility track, which controls streamed level visibility.</summary>
	public partial class UMovieSceneLevelVisibilitySection
	{
		static readonly int LevelNames__Offset;
		/// <summary>The short names of the levels who's visibility is controlled by this section.</summary>
		public TStructArray<FName> LevelNames
		{
			get{ CheckIsValid();return new TStructArray<FName>((FScriptArray)Marshal.PtrToStructure(_this.Get()+LevelNames__Offset, typeof(FScriptArray)));}
					set{ CheckIsValid();Marshal.StructureToPtr(value.InterArray, _this.Get()+LevelNames__Offset, false);}
			
		}
		
		static UMovieSceneLevelVisibilitySection()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("MovieSceneLevelVisibilitySection");
			LevelNames__Offset=GetPropertyOffset(NativeClassPtr,"LevelNames");
			
		}
		
	}
	
}
#endif
#endif
