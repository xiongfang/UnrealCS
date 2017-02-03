#if WITH_GAME
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class UMovieSceneColorSection
	{
		static readonly int RedCurve__Offset;
		public FRichCurve RedCurve
		{
			get{ CheckIsValid();return (FRichCurve)Marshal.PtrToStructure(_this.Get()+RedCurve__Offset, typeof(FRichCurve));}
			
		}
		
		static readonly int GreenCurve__Offset;
		public FRichCurve GreenCurve
		{
			get{ CheckIsValid();return (FRichCurve)Marshal.PtrToStructure(_this.Get()+GreenCurve__Offset, typeof(FRichCurve));}
			
		}
		
		static readonly int BlueCurve__Offset;
		public FRichCurve BlueCurve
		{
			get{ CheckIsValid();return (FRichCurve)Marshal.PtrToStructure(_this.Get()+BlueCurve__Offset, typeof(FRichCurve));}
			
		}
		
		static readonly int AlphaCurve__Offset;
		public FRichCurve AlphaCurve
		{
			get{ CheckIsValid();return (FRichCurve)Marshal.PtrToStructure(_this.Get()+AlphaCurve__Offset, typeof(FRichCurve));}
			
		}
		
		static UMovieSceneColorSection()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("MovieSceneColorSection");
			RedCurve__Offset=GetPropertyOffset(NativeClassPtr,"RedCurve");
			GreenCurve__Offset=GetPropertyOffset(NativeClassPtr,"GreenCurve");
			BlueCurve__Offset=GetPropertyOffset(NativeClassPtr,"BlueCurve");
			AlphaCurve__Offset=GetPropertyOffset(NativeClassPtr,"AlphaCurve");
			
		}
		
	}
	
}
#endif
#endif
