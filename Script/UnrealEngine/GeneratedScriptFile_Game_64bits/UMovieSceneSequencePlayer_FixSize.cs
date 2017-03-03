#if WITH_GAME
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class UMovieSceneSequencePlayer
	{
		static readonly int OnPlay__Offset;
		public FMulticastScriptDelegate OnPlay
		{
			get{ CheckIsValid(); return ((FMulticastScriptDelegate)Marshal.PtrToStructure(_this.Get()+OnPlay__Offset, typeof(FMulticastScriptDelegate)));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+OnPlay__Offset, false);}
			
		}
		
		static readonly int OnStop__Offset;
		public FMulticastScriptDelegate OnStop
		{
			get{ CheckIsValid(); return ((FMulticastScriptDelegate)Marshal.PtrToStructure(_this.Get()+OnStop__Offset, typeof(FMulticastScriptDelegate)));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+OnStop__Offset, false);}
			
		}
		
		static readonly int OnPause__Offset;
		public FMulticastScriptDelegate OnPause
		{
			get{ CheckIsValid(); return ((FMulticastScriptDelegate)Marshal.PtrToStructure(_this.Get()+OnPause__Offset, typeof(FMulticastScriptDelegate)));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+OnPause__Offset, false);}
			
		}
		
		static readonly int bIsPlaying__Offset;
		public bool bIsPlaying
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bIsPlaying__Offset, 1, 0, 1, 1);}
			
		}
		
		static readonly int bReversePlayback__Offset;
		public bool bReversePlayback
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bReversePlayback__Offset, 1, 0, 2, 2);}
			
		}
		
		static readonly int bPendingFirstUpdate__Offset;
		public bool bPendingFirstUpdate
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bPendingFirstUpdate__Offset, 1, 0, 4, 4);}
			
		}
		
		static readonly int Sequence__Offset;
		public UMovieSceneSequence Sequence
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + Sequence__Offset); if (v == IntPtr.Zero)return null; UMovieSceneSequence retValue = new UMovieSceneSequence(); retValue._this = v; return retValue; }
			
		}
		
		static readonly int TimeCursorPosition__Offset;
		public float TimeCursorPosition
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+TimeCursorPosition__Offset, typeof(float));}
			
		}
		
		static readonly int StartTime__Offset;
		public float StartTime
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+StartTime__Offset, typeof(float));}
			
		}
		
		static readonly int EndTime__Offset;
		public float EndTime
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+EndTime__Offset, typeof(float));}
			
		}
		
		static readonly int CurrentNumLoops__Offset;
		public int CurrentNumLoops
		{
			get{ CheckIsValid();return (int)Marshal.PtrToStructure(_this.Get()+CurrentNumLoops__Offset, typeof(int));}
			
		}
		
		static readonly int PlaybackSettings__Offset;
		public FMovieSceneSequencePlaybackSettings PlaybackSettings
		{
			get{ CheckIsValid();return (FMovieSceneSequencePlaybackSettings)Marshal.PtrToStructure(_this.Get()+PlaybackSettings__Offset, typeof(FMovieSceneSequencePlaybackSettings));}
			
		}
		
		static UMovieSceneSequencePlayer()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("MovieSceneSequencePlayer");
			OnPlay__Offset=GetPropertyOffset(NativeClassPtr,"OnPlay");
			OnStop__Offset=GetPropertyOffset(NativeClassPtr,"OnStop");
			OnPause__Offset=GetPropertyOffset(NativeClassPtr,"OnPause");
			bIsPlaying__Offset=GetPropertyOffset(NativeClassPtr,"bIsPlaying");
			bReversePlayback__Offset=GetPropertyOffset(NativeClassPtr,"bReversePlayback");
			bPendingFirstUpdate__Offset=GetPropertyOffset(NativeClassPtr,"bPendingFirstUpdate");
			Sequence__Offset=GetPropertyOffset(NativeClassPtr,"Sequence");
			TimeCursorPosition__Offset=GetPropertyOffset(NativeClassPtr,"TimeCursorPosition");
			StartTime__Offset=GetPropertyOffset(NativeClassPtr,"StartTime");
			EndTime__Offset=GetPropertyOffset(NativeClassPtr,"EndTime");
			CurrentNumLoops__Offset=GetPropertyOffset(NativeClassPtr,"CurrentNumLoops");
			PlaybackSettings__Offset=GetPropertyOffset(NativeClassPtr,"PlaybackSettings");
			
		}
		
	}
	
}
#endif
#endif
