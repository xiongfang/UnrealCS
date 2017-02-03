#if WITH_GAME
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class UMovieScene
	{
		static readonly int Spawnables__Offset;
		public TStructArray<FMovieSceneSpawnable> Spawnables
		{
			get{ CheckIsValid();return new TStructArray<FMovieSceneSpawnable>((FScriptArray)Marshal.PtrToStructure(_this.Get()+Spawnables__Offset, typeof(FScriptArray)));}
					set{ CheckIsValid();Marshal.StructureToPtr(value.InterArray, _this.Get()+Spawnables__Offset, false);}
			
		}
		
		static readonly int Possessables__Offset;
		public TStructArray<FMovieScenePossessable> Possessables
		{
			get{ CheckIsValid();return new TStructArray<FMovieScenePossessable>((FScriptArray)Marshal.PtrToStructure(_this.Get()+Possessables__Offset, typeof(FScriptArray)));}
					set{ CheckIsValid();Marshal.StructureToPtr(value.InterArray, _this.Get()+Possessables__Offset, false);}
			
		}
		
		static readonly int ObjectBindings__Offset;
		public TStructArray<FMovieSceneBinding> ObjectBindings
		{
			get{ CheckIsValid();return new TStructArray<FMovieSceneBinding>((FScriptArray)Marshal.PtrToStructure(_this.Get()+ObjectBindings__Offset, typeof(FScriptArray)));}
					set{ CheckIsValid();Marshal.StructureToPtr(value.InterArray, _this.Get()+ObjectBindings__Offset, false);}
			
		}
		
		static readonly int MasterTracks__Offset;
		public TObjectArray<UMovieSceneTrack>  MasterTracks
		{
					get{ CheckIsValid();return new TObjectArray<UMovieSceneTrack>((FScriptArray)Marshal.PtrToStructure(_this.Get()+MasterTracks__Offset, typeof(FScriptArray)));}
					set{ CheckIsValid();Marshal.StructureToPtr(value.InterArray, _this.Get()+MasterTracks__Offset, false);}
			
		}
		
		static readonly int CameraCutTrack__Offset;
		public UMovieSceneTrack CameraCutTrack
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + CameraCutTrack__Offset); if (v == IntPtr.Zero)return null; UMovieSceneTrack retValue = new UMovieSceneTrack(); retValue._this = v; return retValue; }
			
		}
		
		static readonly int SelectionRange__Offset;
		public FFloatRange SelectionRange
		{
			get{ CheckIsValid();return (FFloatRange)Marshal.PtrToStructure(_this.Get()+SelectionRange__Offset, typeof(FFloatRange));}
			
		}
		
		static readonly int PlaybackRange__Offset;
		public FFloatRange PlaybackRange
		{
			get{ CheckIsValid();return (FFloatRange)Marshal.PtrToStructure(_this.Get()+PlaybackRange__Offset, typeof(FFloatRange));}
			
		}
		
		static readonly int bForceFixedFrameIntervalPlayback__Offset;
		public bool bForceFixedFrameIntervalPlayback
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bForceFixedFrameIntervalPlayback__Offset, 1, 0, 1, 255);}
			
		}
		
		static readonly int FixedFrameInterval__Offset;
		public float FixedFrameInterval
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+FixedFrameInterval__Offset, typeof(float));}
			
		}
		
		static readonly int InTime__Offset;
		public float InTime
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+InTime__Offset, typeof(float));}
			
		}
		
		static readonly int OutTime__Offset;
		public float OutTime
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+OutTime__Offset, typeof(float));}
			
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
		
		static UMovieScene()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("MovieScene");
			Spawnables__Offset=GetPropertyOffset(NativeClassPtr,"Spawnables");
			Possessables__Offset=GetPropertyOffset(NativeClassPtr,"Possessables");
			ObjectBindings__Offset=GetPropertyOffset(NativeClassPtr,"ObjectBindings");
			MasterTracks__Offset=GetPropertyOffset(NativeClassPtr,"MasterTracks");
			CameraCutTrack__Offset=GetPropertyOffset(NativeClassPtr,"CameraCutTrack");
			SelectionRange__Offset=GetPropertyOffset(NativeClassPtr,"SelectionRange");
			PlaybackRange__Offset=GetPropertyOffset(NativeClassPtr,"PlaybackRange");
			bForceFixedFrameIntervalPlayback__Offset=GetPropertyOffset(NativeClassPtr,"bForceFixedFrameIntervalPlayback");
			FixedFrameInterval__Offset=GetPropertyOffset(NativeClassPtr,"FixedFrameInterval");
			InTime__Offset=GetPropertyOffset(NativeClassPtr,"InTime");
			OutTime__Offset=GetPropertyOffset(NativeClassPtr,"OutTime");
			StartTime__Offset=GetPropertyOffset(NativeClassPtr,"StartTime");
			EndTime__Offset=GetPropertyOffset(NativeClassPtr,"EndTime");
			
		}
		
	}
	
}
#endif
#endif
