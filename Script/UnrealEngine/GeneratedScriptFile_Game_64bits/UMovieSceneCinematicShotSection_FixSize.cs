#if WITH_GAME
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class UMovieSceneCinematicShotSection
	{
		static readonly int DisplayName__Offset;
		public string DisplayName
		{
			get{ CheckIsValid(); return ((FText)Marshal.PtrToStructure(_this.Get()+DisplayName__Offset, typeof(FText))).ToString();}
			
		}
		
		static UMovieSceneCinematicShotSection()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("MovieSceneCinematicShotSection");
			DisplayName__Offset=GetPropertyOffset(NativeClassPtr,"DisplayName");
			
		}
		
	}
	
}
#endif
#endif
