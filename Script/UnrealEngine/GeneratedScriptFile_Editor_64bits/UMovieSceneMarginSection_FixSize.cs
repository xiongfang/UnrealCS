#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>A section in a Margin track</summary>
	public partial class UMovieSceneMarginSection
	{
		static readonly int TopCurve__Offset;
		/// <summary>Red curve data</summary>
		public FRichCurve TopCurve
		{
			get{ CheckIsValid();return (FRichCurve)Marshal.PtrToStructure(_this.Get()+TopCurve__Offset, typeof(FRichCurve));}
			
		}
		
		static readonly int LeftCurve__Offset;
		/// <summary>Green curve data</summary>
		public FRichCurve LeftCurve
		{
			get{ CheckIsValid();return (FRichCurve)Marshal.PtrToStructure(_this.Get()+LeftCurve__Offset, typeof(FRichCurve));}
			
		}
		
		static readonly int RightCurve__Offset;
		/// <summary>Blue curve data</summary>
		public FRichCurve RightCurve
		{
			get{ CheckIsValid();return (FRichCurve)Marshal.PtrToStructure(_this.Get()+RightCurve__Offset, typeof(FRichCurve));}
			
		}
		
		static readonly int BottomCurve__Offset;
		/// <summary>Alpha curve data</summary>
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
