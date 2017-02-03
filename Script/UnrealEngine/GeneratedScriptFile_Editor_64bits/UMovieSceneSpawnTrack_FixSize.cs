#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>Handles when a spawnable should be spawned and destroyed</summary>
	public partial class UMovieSceneSpawnTrack
	{
		static readonly int Sections__Offset;
		/// <summary>All the sections in this track</summary>
		public TObjectArray<UMovieSceneSection>  Sections
		{
					get{ CheckIsValid();return new TObjectArray<UMovieSceneSection>((FScriptArray)Marshal.PtrToStructure(_this.Get()+Sections__Offset, typeof(FScriptArray)));}
					set{ CheckIsValid();Marshal.StructureToPtr(value.InterArray, _this.Get()+Sections__Offset, false);}
			
		}
		
		static readonly int ObjectGuid__Offset;
		/// <summary>The guid relating to the object we are to spawn and destroy</summary>
		public FGuid ObjectGuid
		{
			get{ CheckIsValid();return (FGuid)Marshal.PtrToStructure(_this.Get()+ObjectGuid__Offset, typeof(FGuid));}
			
		}
		
		static UMovieSceneSpawnTrack()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("MovieSceneSpawnTrack");
			Sections__Offset=GetPropertyOffset(NativeClassPtr,"Sections");
			ObjectGuid__Offset=GetPropertyOffset(NativeClassPtr,"ObjectGuid");
			
		}
		
	}
	
}
#endif
#endif
