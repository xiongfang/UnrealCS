#if WITH_GAME
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class UMovieSceneSection
	{
		static readonly int EvalOptions__Offset;
		public FMovieSceneSectionEvalOptions EvalOptions
		{
			get{ CheckIsValid();return (FMovieSceneSectionEvalOptions)Marshal.PtrToStructure(_this.Get()+EvalOptions__Offset, typeof(FMovieSceneSectionEvalOptions));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+EvalOptions__Offset, false);}
			
		}
		
		static readonly int StartTime__Offset;
		public float StartTime
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+StartTime__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+StartTime__Offset, false);}
			
		}
		
		static readonly int EndTime__Offset;
		public float EndTime
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+EndTime__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+EndTime__Offset, false);}
			
		}
		
		static readonly int RowIndex__Offset;
		public int RowIndex
		{
			get{ CheckIsValid();return (int)Marshal.PtrToStructure(_this.Get()+RowIndex__Offset, typeof(int));}
			
		}
		
		static readonly int OverlapPriority__Offset;
		public int OverlapPriority
		{
			get{ CheckIsValid();return (int)Marshal.PtrToStructure(_this.Get()+OverlapPriority__Offset, typeof(int));}
			
		}
		
		static readonly int bIsActive__Offset;
		public bool bIsActive
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bIsActive__Offset, 1, 0, 1, 1);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bIsActive__Offset, 1,0,1,1);}
			
		}
		
		static readonly int bIsLocked__Offset;
		public bool bIsLocked
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bIsLocked__Offset, 1, 0, 2, 2);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bIsLocked__Offset, 1,0,2,2);}
			
		}
		
		static readonly int bIsInfinite__Offset;
		public bool bIsInfinite
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bIsInfinite__Offset, 1, 0, 4, 4);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bIsInfinite__Offset, 1,0,4,4);}
			
		}
		
		static UMovieSceneSection()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("MovieSceneSection");
			EvalOptions__Offset=GetPropertyOffset(NativeClassPtr,"EvalOptions");
			StartTime__Offset=GetPropertyOffset(NativeClassPtr,"StartTime");
			EndTime__Offset=GetPropertyOffset(NativeClassPtr,"EndTime");
			RowIndex__Offset=GetPropertyOffset(NativeClassPtr,"RowIndex");
			OverlapPriority__Offset=GetPropertyOffset(NativeClassPtr,"OverlapPriority");
			bIsActive__Offset=GetPropertyOffset(NativeClassPtr,"bIsActive");
			bIsLocked__Offset=GetPropertyOffset(NativeClassPtr,"bIsLocked");
			bIsInfinite__Offset=GetPropertyOffset(NativeClassPtr,"bIsInfinite");
			
		}
		
	}
	
}
#endif
#endif
