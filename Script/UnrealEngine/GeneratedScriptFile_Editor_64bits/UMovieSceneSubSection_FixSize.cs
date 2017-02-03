#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>Implements a section in sub-sequence tracks.</summary>
	public partial class UMovieSceneSubSection
	{
		static readonly int StartOffset__Offset;
		/// <summary>Number of seconds to skip at the beginning of the sub-sequence.</summary>
		public float StartOffset
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+StartOffset__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+StartOffset__Offset, false);}
			
		}
		
		static readonly int TimeScale__Offset;
		/// <summary>Playback time scaling factor.</summary>
		public float TimeScale
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+TimeScale__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+TimeScale__Offset, false);}
			
		}
		
		static readonly int PrerollTime__Offset;
		/// <summary>Preroll time.</summary>
		public float PrerollTime
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+PrerollTime__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+PrerollTime__Offset, false);}
			
		}
		
		static readonly int SubSequence__Offset;
		/// <summary>
		/// Movie scene being played by this section.
		/// @todo Sequencer: Should this be lazy loaded?
		/// </summary>
		public UMovieSceneSequence SubSequence
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + SubSequence__Offset); if (v == IntPtr.Zero)return null; UMovieSceneSequence retValue = new UMovieSceneSequence(); retValue._this = v; return retValue; }
			set{ CheckIsValid(); if (value == null)Marshal.WriteIntPtr(_this.Get() + SubSequence__Offset, IntPtr.Zero);else Marshal.WriteIntPtr(_this.Get() + SubSequence__Offset, value._this.Get()); }
			
		}
		
		static readonly int TargetSequenceName__Offset;
		/// <summary>Target name of sequence to try to record to (will record automatically to another if this already exists)</summary>
		public FString TargetSequenceName
		{
			get{ CheckIsValid();return (FString)Marshal.PtrToStructure(_this.Get()+TargetSequenceName__Offset, typeof(FString));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+TargetSequenceName__Offset, false);}
			
		}
		
		static readonly int TargetPathToRecordTo__Offset;
		/// <summary>Target path of sequence to record to</summary>
		public FDirectoryPath TargetPathToRecordTo
		{
			get{ CheckIsValid();return (FDirectoryPath)Marshal.PtrToStructure(_this.Get()+TargetPathToRecordTo__Offset, typeof(FDirectoryPath));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+TargetPathToRecordTo__Offset, false);}
			
		}
		
		static UMovieSceneSubSection()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("MovieSceneSubSection");
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
