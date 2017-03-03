#if WITH_GAME
#if PLATFORM_32BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class UMovieSceneIntegerSection
	{
		static readonly int IntegerCurve__Offset;
		public FIntegralCurve IntegerCurve
		{
			get{ CheckIsValid();return (FIntegralCurve)Marshal.PtrToStructure(_this.Get()+IntegerCurve__Offset, typeof(FIntegralCurve));}
			
		}
		
		static UMovieSceneIntegerSection()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("MovieSceneIntegerSection");
			IntegerCurve__Offset=GetPropertyOffset(NativeClassPtr,"IntegerCurve");
			
		}
		
	}
	
}
#endif
#endif
