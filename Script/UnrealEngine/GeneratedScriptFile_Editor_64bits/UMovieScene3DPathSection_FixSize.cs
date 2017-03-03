#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>A 3D Path section</summary>
	public partial class UMovieScene3DPathSection
	{
		static readonly int TimingCurve__Offset;
		/// <summary>Timing Curve</summary>
		public FRichCurve TimingCurve
		{
			get{ CheckIsValid();return (FRichCurve)Marshal.PtrToStructure(_this.Get()+TimingCurve__Offset, typeof(FRichCurve));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+TimingCurve__Offset, false);}
			
		}
		
		static readonly int bFollow__Offset;
		/// <summary>Follow Curve</summary>
		public bool bFollow
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bFollow__Offset, 1, 0, 1, 1);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bFollow__Offset, 1,0,1,1);}
			
		}
		
		static readonly int bReverse__Offset;
		/// <summary>Reverse Timing</summary>
		public bool bReverse
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bReverse__Offset, 1, 0, 2, 2);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bReverse__Offset, 1,0,2,2);}
			
		}
		
		static readonly int bForceUpright__Offset;
		/// <summary>Force Upright</summary>
		public bool bForceUpright
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bForceUpright__Offset, 1, 0, 4, 4);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bForceUpright__Offset, 1,0,4,4);}
			
		}
		
		static UMovieScene3DPathSection()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("MovieScene3DPathSection");
			TimingCurve__Offset=GetPropertyOffset(NativeClassPtr,"TimingCurve");
			bFollow__Offset=GetPropertyOffset(NativeClassPtr,"bFollow");
			bReverse__Offset=GetPropertyOffset(NativeClassPtr,"bReverse");
			bForceUpright__Offset=GetPropertyOffset(NativeClassPtr,"bForceUpright");
			
		}
		
	}
	
}
#endif
#endif
