#if WITH_GAME
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class UMovieSceneEventTrack
	{
		static readonly int bFireEventsWhenForwards__Offset;
		public bool bFireEventsWhenForwards
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bFireEventsWhenForwards__Offset, 1, 0, 1, 1);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bFireEventsWhenForwards__Offset, 1,0,1,1);}
			
		}
		
		static readonly int bFireEventsWhenBackwards__Offset;
		public bool bFireEventsWhenBackwards
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bFireEventsWhenBackwards__Offset, 1, 0, 2, 2);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bFireEventsWhenBackwards__Offset, 1,0,2,2);}
			
		}
		
		static readonly int Sections__Offset;
		public TObjectArray<UMovieSceneSection>  Sections
		{
					get{ CheckIsValid();return new TObjectArray<UMovieSceneSection>((FScriptArray)Marshal.PtrToStructure(_this.Get()+Sections__Offset, typeof(FScriptArray)));}
					set{ CheckIsValid();Marshal.StructureToPtr(value.InterArray, _this.Get()+Sections__Offset, false);}
			
		}
		
		static UMovieSceneEventTrack()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("MovieSceneEventTrack");
			bFireEventsWhenForwards__Offset=GetPropertyOffset(NativeClassPtr,"bFireEventsWhenForwards");
			bFireEventsWhenBackwards__Offset=GetPropertyOffset(NativeClassPtr,"bFireEventsWhenBackwards");
			Sections__Offset=GetPropertyOffset(NativeClassPtr,"Sections");
			
		}
		
	}
	
}
#endif
#endif
