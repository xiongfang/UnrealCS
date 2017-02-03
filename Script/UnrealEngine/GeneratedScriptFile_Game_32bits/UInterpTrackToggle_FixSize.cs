#if WITH_GAME
#if PLATFORM_32BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class UInterpTrackToggle
	{
		static readonly int ToggleTrack__Offset;
		public TStructArray<FToggleTrackKey> ToggleTrack
		{
			get{ CheckIsValid();return new TStructArray<FToggleTrackKey>((FScriptArray)Marshal.PtrToStructure(_this.Get()+ToggleTrack__Offset, typeof(FScriptArray)));}
					set{ CheckIsValid();Marshal.StructureToPtr(value.InterArray, _this.Get()+ToggleTrack__Offset, false);}
			
		}
		
		static readonly int bActivateSystemEachUpdate__Offset;
		public bool bActivateSystemEachUpdate
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bActivateSystemEachUpdate__Offset, 1, 0, 1, 1);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bActivateSystemEachUpdate__Offset, 1,0,1,1);}
			
		}
		
		static readonly int bActivateWithJustAttachedFlag__Offset;
		public bool bActivateWithJustAttachedFlag
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bActivateWithJustAttachedFlag__Offset, 1, 0, 2, 2);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bActivateWithJustAttachedFlag__Offset, 1,0,2,2);}
			
		}
		
		static readonly int bFireEventsWhenForwards__Offset;
		public bool bFireEventsWhenForwards
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bFireEventsWhenForwards__Offset, 1, 0, 4, 4);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bFireEventsWhenForwards__Offset, 1,0,4,4);}
			
		}
		
		static readonly int bFireEventsWhenBackwards__Offset;
		public bool bFireEventsWhenBackwards
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bFireEventsWhenBackwards__Offset, 1, 0, 8, 8);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bFireEventsWhenBackwards__Offset, 1,0,8,8);}
			
		}
		
		static readonly int bFireEventsWhenJumpingForwards__Offset;
		public bool bFireEventsWhenJumpingForwards
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bFireEventsWhenJumpingForwards__Offset, 1, 0, 16, 16);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bFireEventsWhenJumpingForwards__Offset, 1,0,16,16);}
			
		}
		
		static UInterpTrackToggle()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("InterpTrackToggle");
			ToggleTrack__Offset=GetPropertyOffset(NativeClassPtr,"ToggleTrack");
			bActivateSystemEachUpdate__Offset=GetPropertyOffset(NativeClassPtr,"bActivateSystemEachUpdate");
			bActivateWithJustAttachedFlag__Offset=GetPropertyOffset(NativeClassPtr,"bActivateWithJustAttachedFlag");
			bFireEventsWhenForwards__Offset=GetPropertyOffset(NativeClassPtr,"bFireEventsWhenForwards");
			bFireEventsWhenBackwards__Offset=GetPropertyOffset(NativeClassPtr,"bFireEventsWhenBackwards");
			bFireEventsWhenJumpingForwards__Offset=GetPropertyOffset(NativeClassPtr,"bFireEventsWhenJumpingForwards");
			
		}
		
	}
	
}
#endif
#endif
