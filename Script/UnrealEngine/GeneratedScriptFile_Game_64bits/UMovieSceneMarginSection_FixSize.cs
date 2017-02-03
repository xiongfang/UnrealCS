#if WITH_GAME
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class UMovieSceneMarginSection
	{
		static readonly int TopCurve__Offset;
		public FRichCurve TopCurve
		{
			get{ CheckIsValid();return (FRichCurve)Marshal.PtrToStructure(_this.Get()+TopCurve__Offset, typeof(FRichCurve));}
			
		}
		
		static readonly int LeftCurve__Offset;
		public FRichCurve LeftCurve
		{
			get{ CheckIsValid();return (FRichCurve)Marshal.PtrToStructure(_this.Get()+LeftCurve__Offset, typeof(FRichCurve));}
			
		}
		
		static readonly int RightCurve__Offset;
		public FRichCurve RightCurve
		{
			get{ CheckIsValid();return (FRichCurve)Marshal.PtrToStructure(_this.Get()+RightCurve__Offset, typeof(FRichCurve));}
			
		}
		
		static readonly int BottomCurve__Offset;
		public FRichCurve BottomCurve
		{
			get{ CheckIsValid();return (FRichCurve)Marshal.PtrToStructure(_this.Get()+BottomCurve__Offset, typeof(FRichCurve));}
			
		}
		
		static UMovieSceneMarginSection()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("MovieSceneMarginSection");
			TopCurve__Offset=GetPropertyOffset(NativeClassPtr,"TopCurve");
			LeftCurve__Offset=GetPropertyOffset(NativeClassPtr,"LeftCurve");
			RightCurve__Offset=GetPropertyOffset(NativeClassPtr,"RightCurve");
			BottomCurve__Offset=GetPropertyOffset(NativeClassPtr,"BottomCurve");
			
		}
		
	}
	
}
#endif
#endif
