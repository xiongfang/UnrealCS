#if WITH_GAME
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class UMovieSceneFloatSection
	{
		static readonly int FloatCurve__Offset;
		public FRichCurve FloatCurve
		{
			get{ CheckIsValid();return (FRichCurve)Marshal.PtrToStructure(_this.Get()+FloatCurve__Offset, typeof(FRichCurve));}
			
		}
		
		static UMovieSceneFloatSection()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("MovieSceneFloatSection");
			FloatCurve__Offset=GetPropertyOffset(NativeClassPtr,"FloatCurve");
			
		}
		
	}
	
}
#endif
#endif
