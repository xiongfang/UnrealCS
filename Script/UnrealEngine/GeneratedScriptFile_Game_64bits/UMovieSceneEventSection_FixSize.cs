#if WITH_GAME
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class UMovieSceneEventSection
	{
		static readonly int Events__Offset;
		public FNameCurve Events
		{
			get{ CheckIsValid();return (FNameCurve)Marshal.PtrToStructure(_this.Get()+Events__Offset, typeof(FNameCurve));}
			
		}
		
		static UMovieSceneEventSection()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("MovieSceneEventSection");
			Events__Offset=GetPropertyOffset(NativeClassPtr,"Events");
			
		}
		
	}
	
}
#endif
#endif
