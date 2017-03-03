#if WITH_GAME
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class UMovieSceneSubSection
	{
		static readonly int Parameters__Offset;
		public FMovieSceneSectionParameters Parameters
		{
			get{ CheckIsValid();return (FMovieSceneSectionParameters)Marshal.PtrToStructure(_this.Get()+Parameters__Offset, typeof(FMovieSceneSectionParameters));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+Parameters__Offset, false);}
			
		}
		
		static readonly int StartOffset__Offset;
		public float StartOffset
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+StartOffset__Offset, typeof(float));}
			
		}
		
		static readonly int TimeScale__Offset;
		public float TimeScale
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+TimeScale__Offset, typeof(float));}
			
		}
		
		static readonly int PrerollTime__Offset;
		public float PrerollTime
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+PrerollTime__Offset, typeof(float));}
			
		}
		
		static readonly int SubSequence__Offset;
		public UMovieSceneSequence SubSequence
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + SubSequence__Offset); if (v == IntPtr.Zero)return null; UMovieSceneSequence retValue = new UMovieSceneSequence(); retValue._this = v; return retValue; }
			set{ CheckIsValid(); if (value == null)Marshal.WriteIntPtr(_this.Get() + SubSequence__Offset, IntPtr.Zero);else Marshal.WriteIntPtr(_this.Get() + SubSequence__Offset, value._this.Get()); }
			
		}
		
		static readonly int TargetSequenceName__Offset;
		public FString TargetSequenceName
		{
			get{ CheckIsValid();return (FString)Marshal.PtrToStructure(_this.Get()+TargetSequenceName__Offset, typeof(FString));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+TargetSequenceName__Offset, false);}
			
		}
		
		static readonly int TargetPathToRecordTo__Offset;
		public FDirectoryPath TargetPathToRecordTo
		{
			get{ CheckIsValid();return (FDirectoryPath)Marshal.PtrToStructure(_this.Get()+TargetPathToRecordTo__Offset, typeof(FDirectoryPath));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+TargetPathToRecordTo__Offset, false);}
			
		}
		
		static UMovieSceneSubSection()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("MovieSceneSubSection");
			Parameters__Offset=GetPropertyOffset(NativeClassPtr,"Parameters");
			StartOffset__Offset=GetPropertyOffset(NativeClassPtr,"StartOffset");
			TimeScale__Offset=GetPropertyOffset(NativeClassPtr,"TimeScale");
			PrerollTime__Offset=GetPropertyOffset(NativeClassPtr,"PrerollTime");
			SubSequence__Offset=GetPropertyOffset(NativeClassPtr,"SubSequence");
			TargetSequenceName__Offset=GetPropertyOffset(NativeClassPtr,"TargetSequenceName");
			TargetPathToRecordTo__Offset=GetPropertyOffset(NativeClassPtr,"TargetPathToRecordTo");
			
		}
		
	}
	
}
#endif
#endif
