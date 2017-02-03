#if WITH_GAME
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class UMovieSceneStringSection
	{
		static readonly int StringCurve__Offset;
		public FStringCurve StringCurve
		{
			get{ CheckIsValid();return (FStringCurve)Marshal.PtrToStructure(_this.Get()+StringCurve__Offset, typeof(FStringCurve));}
			
		}
		
		static UMovieSceneStringSection()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("MovieSceneStringSection");
			StringCurve__Offset=GetPropertyOffset(NativeClassPtr,"StringCurve");
			
		}
		
	}
	
}
#endif
#endif
