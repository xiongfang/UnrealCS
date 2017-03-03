#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>Implements a movie scene asset.</summary>
	public partial class UMovieScene
	{
		static readonly int Spawnables__Offset;
		/// <summary>
		/// Data-only blueprints for all of the objects that we we're able to spawn.
		/// These describe objects and actors that we may instantiate at runtime,
		/// or create proxy objects for previewing in the editor.
		/// </summary>
		public TStructArray<FMovieSceneSpawnable> Spawnables
		{
			get{ CheckIsValid();return new TStructArray<FMovieSceneSpawnable>((FScriptArray)Marshal.PtrToStructure(_this.Get()+Spawnables__Offset, typeof(FScriptArray)));}
					set{ CheckIsValid();Marshal.StructureToPtr(value.InterArray, _this.Get()+Spawnables__Offset, false);}
			
		}
		
		static readonly int Possessables__Offset;
		/// <summary>Typed slots for already-spawned objects that we are able to control with this MovieScene</summary>
		public TStructArray<FMovieScenePossessable> Possessables
		{
			get{ CheckIsValid();return new TStructArray<FMovieScenePossessable>((FScriptArray)Marshal.PtrToStructure(_this.Get()+Possessables__Offset, typeof(FScriptArray)));}
					set{ CheckIsValid();Marshal.StructureToPtr(value.InterArray, _this.Get()+Possessables__Offset, false);}
			
		}
		
		static readonly int ObjectBindings__Offset;
		/// <summary>Tracks bound to possessed or spawned objects</summary>
		public TStructArray<FMovieSceneBinding> ObjectBindings
		{
			get{ CheckIsValid();return new TStructArray<FMovieSceneBinding>((FScriptArray)Marshal.PtrToStructure(_this.Get()+ObjectBindings__Offset, typeof(FScriptArray)));}
					set{ CheckIsValid();Marshal.StructureToPtr(value.InterArray, _this.Get()+ObjectBindings__Offset, false);}
			
		}
		
		static readonly int MasterTracks__Offset;
		/// <summary>Master tracks which are not bound to spawned or possessed objects</summary>
		public TObjectArray<UMovieSceneTrack>  MasterTracks
		{
					get{ CheckIsValid();return new TObjectArray<UMovieSceneTrack>((FScriptArray)Marshal.PtrToStructure(_this.Get()+MasterTracks__Offset, typeof(FScriptArray)));}
					set{ CheckIsValid();Marshal.StructureToPtr(value.InterArray, _this.Get()+MasterTracks__Offset, false);}
			
		}
		
		static readonly int CameraCutTrack__Offset;
		/// <summary>The camera cut track is a specialized track for switching between cameras on a cinematic</summary>
		public UMovieSceneTrack CameraCutTrack
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + CameraCutTrack__Offset); if (v == IntPtr.Zero)return null; UMovieSceneTrack retValue = new UMovieSceneTrack(); retValue._this = v; return retValue; }
			
		}
		
		static readonly int SelectionRange__Offset;
		/// <summary>User-defined selection range.</summary>
		public FFloatRange SelectionRange
		{
			get{ CheckIsValid();return (FFloatRange)Marshal.PtrToStructure(_this.Get()+SelectionRange__Offset, typeof(FFloatRange));}
			
		}
		
		static readonly int PlaybackRange__Offset;
		/// <summary>User-defined playback range for this movie scene. Must be a finite range. Relative to this movie-scene's 0-time origin.</summary>
		public FFloatRange PlaybackRange
		{
			get{ CheckIsValid();return (FFloatRange)Marshal.PtrToStructure(_this.Get()+PlaybackRange__Offset, typeof(FFloatRange));}
			
		}
		
		static readonly int bPlaybackRangeLocked__Offset;
		public bool bPlaybackRangeLocked
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bPlaybackRangeLocked__Offset, 1, 0, 1, 255);}
			
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
		
		static readonly int EditorData__Offset;
		/// <summary>Editor only data that needs to be saved between sessions for editing but has no runtime purpose</summary>
		public FMovieSceneEditorData EditorData
		{
			get{ CheckIsValid();return (FMovieSceneEditorData)Marshal.PtrToStructure(_this.Get()+EditorData__Offset, typeof(FMovieSceneEditorData));}
			
		}
		
		static readonly int RootFolders__Offset;
		/// <summary>The root folders for this movie scene.</summary>
		public TObjectArray<UMovieSceneFolder>  RootFolders
		{
					get{ CheckIsValid();return new TObjectArray<UMovieSceneFolder>((FScriptArray)Marshal.PtrToStructure(_this.Get()+RootFolders__Offset, typeof(FScriptArray)));}
					set{ CheckIsValid();Marshal.StructureToPtr(value.InterArray, _this.Get()+RootFolders__Offset, false);}
			
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
			bPlaybackRangeLocked__Offset=GetPropertyOffset(NativeClassPtr,"bPlaybackRangeLocked");
			bForceFixedFrameIntervalPlayback__Offset=GetPropertyOffset(NativeClassPtr,"bForceFixedFrameIntervalPlayback");
			FixedFrameInterval__Offset=GetPropertyOffset(NativeClassPtr,"FixedFrameInterval");
			EditorData__Offset=GetPropertyOffset(NativeClassPtr,"EditorData");
			RootFolders__Offset=GetPropertyOffset(NativeClassPtr,"RootFolders");
			InTime__Offset=GetPropertyOffset(NativeClassPtr,"InTime");
			OutTime__Offset=GetPropertyOffset(NativeClassPtr,"OutTime");
			StartTime__Offset=GetPropertyOffset(NativeClassPtr,"StartTime");
			EndTime__Offset=GetPropertyOffset(NativeClassPtr,"EndTime");
			
		}
		
	}
	
}
#endif
#endif
