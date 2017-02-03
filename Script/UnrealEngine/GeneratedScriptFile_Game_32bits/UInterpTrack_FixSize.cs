#if WITH_GAME
#if PLATFORM_32BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class UInterpTrack
	{
		static readonly int SubTracks__Offset;
		public TObjectArray<UInterpTrack>  SubTracks
		{
					get{ CheckIsValid();return new TObjectArray<UInterpTrack>((FScriptArray)Marshal.PtrToStructure(_this.Get()+SubTracks__Offset, typeof(FScriptArray)));}
					set{ CheckIsValid();Marshal.StructureToPtr(value.InterArray, _this.Get()+SubTracks__Offset, false);}
			
		}
		
		static readonly int TrackInstClass__Offset;
		public TSubclassOf<UInterpTrackInst>  TrackInstClass
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + TrackInstClass__Offset); return v; }
			
		}
		
		static readonly int ActiveCondition__Offset;
		public ETrackActiveCondition ActiveCondition
		{
			get{ CheckIsValid();return (ETrackActiveCondition)Marshal.PtrToStructure(_this.Get()+ActiveCondition__Offset, typeof(ETrackActiveCondition));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+ActiveCondition__Offset, false);}
			
		}
		
		static readonly int TrackTitle__Offset;
		public FString TrackTitle
		{
			get{ CheckIsValid();return (FString)Marshal.PtrToStructure(_this.Get()+TrackTitle__Offset, typeof(FString));}
			
		}
		
		static readonly int bOnePerGroup__Offset;
		public bool bOnePerGroup
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bOnePerGroup__Offset, 1, 0, 1, 1);}
			
		}
		
		static readonly int bDirGroupOnly__Offset;
		public bool bDirGroupOnly
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bDirGroupOnly__Offset, 1, 0, 2, 2);}
			
		}
		
		static readonly int bDisableTrack__Offset;
		public bool bDisableTrack
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bDisableTrack__Offset, 1, 0, 4, 4);}
			
		}
		
		static readonly int bIsSelected__Offset;
		public bool bIsSelected
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bIsSelected__Offset, 1, 0, 8, 8);}
			
		}
		
		static readonly int bIsAnimControlTrack__Offset;
		public bool bIsAnimControlTrack
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bIsAnimControlTrack__Offset, 1, 0, 16, 16);}
			
		}
		
		static readonly int bSubTrackOnly__Offset;
		public bool bSubTrackOnly
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bSubTrackOnly__Offset, 1, 0, 32, 32);}
			
		}
		
		static readonly int bVisible__Offset;
		public bool bVisible
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bVisible__Offset, 1, 0, 64, 64);}
			
		}
		
		static readonly int bIsRecording__Offset;
		public bool bIsRecording
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bIsRecording__Offset, 1, 0, 128, 128);}
			
		}
		
		static UInterpTrack()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("InterpTrack");
			SubTracks__Offset=GetPropertyOffset(NativeClassPtr,"SubTracks");
			TrackInstClass__Offset=GetPropertyOffset(NativeClassPtr,"TrackInstClass");
			ActiveCondition__Offset=GetPropertyOffset(NativeClassPtr,"ActiveCondition");
			TrackTitle__Offset=GetPropertyOffset(NativeClassPtr,"TrackTitle");
			bOnePerGroup__Offset=GetPropertyOffset(NativeClassPtr,"bOnePerGroup");
			bDirGroupOnly__Offset=GetPropertyOffset(NativeClassPtr,"bDirGroupOnly");
			bDisableTrack__Offset=GetPropertyOffset(NativeClassPtr,"bDisableTrack");
			bIsSelected__Offset=GetPropertyOffset(NativeClassPtr,"bIsSelected");
			bIsAnimControlTrack__Offset=GetPropertyOffset(NativeClassPtr,"bIsAnimControlTrack");
			bSubTrackOnly__Offset=GetPropertyOffset(NativeClassPtr,"bSubTrackOnly");
			bVisible__Offset=GetPropertyOffset(NativeClassPtr,"bVisible");
			bIsRecording__Offset=GetPropertyOffset(NativeClassPtr,"bIsRecording");
			
		}
		
	}
	
}
#endif
#endif
