#if WITH_GAME
#if PLATFORM_32BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class UMovieSceneSpawnTrack
	{
		static readonly int Sections__Offset;
		public TObjectArray<UMovieSceneSection>  Sections
		{
					get{ CheckIsValid();return new TObjectArray<UMovieSceneSection>((FScriptArray)Marshal.PtrToStructure(_this.Get()+Sections__Offset, typeof(FScriptArray)));}
					set{ CheckIsValid();Marshal.StructureToPtr(value.InterArray, _this.Get()+Sections__Offset, false);}
			
		}
		
		static readonly int ObjectGuid__Offset;
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
