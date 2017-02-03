#if WITH_GAME
#if PLATFORM_32BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class UMovieSceneByteSection
	{
		static readonly int ByteCurve__Offset;
		public FIntegralCurve ByteCurve
		{
			get{ CheckIsValid();return (FIntegralCurve)Marshal.PtrToStructure(_this.Get()+ByteCurve__Offset, typeof(FIntegralCurve));}
			
		}
		
		static UMovieSceneByteSection()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("MovieSceneByteSection");
			ByteCurve__Offset=GetPropertyOffset(NativeClassPtr,"ByteCurve");
			
		}
		
	}
	
}
#endif
#endif
