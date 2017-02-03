#if WITH_GAME
#if PLATFORM_32BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class UInterpTrackEvent
	{
		static readonly int EventTrack__Offset;
		public TStructArray<FEventTrackKey> EventTrack
		{
			get{ CheckIsValid();return new TStructArray<FEventTrackKey>((FScriptArray)Marshal.PtrToStructure(_this.Get()+EventTrack__Offset, typeof(FScriptArray)));}
					set{ CheckIsValid();Marshal.StructureToPtr(value.InterArray, _this.Get()+EventTrack__Offset, false);}
			
		}
		
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
		
		static readonly int bFireEventsWhenJumpingForwards__Offset;
		public bool bFireEventsWhenJumpingForwards
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bFireEventsWhenJumpingForwards__Offset, 1, 0, 4, 4);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bFireEventsWhenJumpingForwards__Offset, 1,0,4,4);}
			
		}
		
		static readonly int bUseCustomEventName__Offset;
		public bool bUseCustomEventName
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bUseCustomEventName__Offset, 1, 0, 8, 8);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bUseCustomEventName__Offset, 1,0,8,8);}
			
		}
		
		static UInterpTrackEvent()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("InterpTrackEvent");
			EventTrack__Offset=GetPropertyOffset(NativeClassPtr,"EventTrack");
			bFireEventsWhenForwards__Offset=GetPropertyOffset(NativeClassPtr,"bFireEventsWhenForwards");
			bFireEventsWhenBackwards__Offset=GetPropertyOffset(NativeClassPtr,"bFireEventsWhenBackwards");
			bFireEventsWhenJumpingForwards__Offset=GetPropertyOffset(NativeClassPtr,"bFireEventsWhenJumpingForwards");
			bUseCustomEventName__Offset=GetPropertyOffset(NativeClassPtr,"bUseCustomEventName");
			
		}
		
	}
	
}
#endif
#endif
