#if WITH_GAME
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class AMatineeActor
	{
		static readonly int MatineeData__Offset;
		public UInterpData MatineeData
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + MatineeData__Offset); if (v == IntPtr.Zero)return null; UInterpData retValue = new UInterpData(); retValue._this = v; return retValue; }
			set{ CheckIsValid(); if (value == null)Marshal.WriteIntPtr(_this.Get() + MatineeData__Offset, IntPtr.Zero);else Marshal.WriteIntPtr(_this.Get() + MatineeData__Offset, value._this.Get()); }
			
		}
		
		static readonly int MatineeControllerName__Offset;
		public FName MatineeControllerName
		{
			get{ CheckIsValid();return (FName)Marshal.PtrToStructure(_this.Get()+MatineeControllerName__Offset, typeof(FName));}
			
		}
		
		static readonly int PlayRate__Offset;
		public float PlayRate
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+PlayRate__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+PlayRate__Offset, false);}
			
		}
		
		static readonly int bPlayOnLevelLoad__Offset;
		public bool bPlayOnLevelLoad
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bPlayOnLevelLoad__Offset, 1, 0, 1, 1);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bPlayOnLevelLoad__Offset, 1,0,1,1);}
			
		}
		
		static readonly int bForceStartPos__Offset;
		public bool bForceStartPos
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bForceStartPos__Offset, 1, 0, 2, 2);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bForceStartPos__Offset, 1,0,2,2);}
			
		}
		
		static readonly int ForceStartPosition__Offset;
		public float ForceStartPosition
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+ForceStartPosition__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+ForceStartPosition__Offset, false);}
			
		}
		
		static readonly int bLooping__Offset;
		public bool bLooping
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bLooping__Offset, 1, 0, 1, 1);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bLooping__Offset, 1,0,1,1);}
			
		}
		
		static readonly int bRewindOnPlay__Offset;
		public bool bRewindOnPlay
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bRewindOnPlay__Offset, 1, 0, 2, 2);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bRewindOnPlay__Offset, 1,0,2,2);}
			
		}
		
		static readonly int bNoResetOnRewind__Offset;
		public bool bNoResetOnRewind
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bNoResetOnRewind__Offset, 1, 0, 4, 4);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bNoResetOnRewind__Offset, 1,0,4,4);}
			
		}
		
		static readonly int bRewindIfAlreadyPlaying__Offset;
		public bool bRewindIfAlreadyPlaying
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bRewindIfAlreadyPlaying__Offset, 1, 0, 8, 8);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bRewindIfAlreadyPlaying__Offset, 1,0,8,8);}
			
		}
		
		static readonly int bDisableRadioFilter__Offset;
		public bool bDisableRadioFilter
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bDisableRadioFilter__Offset, 1, 0, 16, 16);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bDisableRadioFilter__Offset, 1,0,16,16);}
			
		}
		
		static readonly int bClientSideOnly__Offset;
		public bool bClientSideOnly
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bClientSideOnly__Offset, 1, 0, 32, 32);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bClientSideOnly__Offset, 1,0,32,32);}
			
		}
		
		static readonly int bSkipUpdateIfNotVisible__Offset;
		public bool bSkipUpdateIfNotVisible
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bSkipUpdateIfNotVisible__Offset, 1, 0, 64, 64);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bSkipUpdateIfNotVisible__Offset, 1,0,64,64);}
			
		}
		
		static readonly int bIsSkippable__Offset;
		public bool bIsSkippable
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bIsSkippable__Offset, 1, 0, 128, 128);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bIsSkippable__Offset, 1,0,128,128);}
			
		}
		
		static readonly int PreferredSplitScreenNum__Offset;
		public int PreferredSplitScreenNum
		{
			get{ CheckIsValid();return (int)Marshal.PtrToStructure(_this.Get()+PreferredSplitScreenNum__Offset, typeof(int));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+PreferredSplitScreenNum__Offset, false);}
			
		}
		
		static readonly int bDisableMovementInput__Offset;
		public bool bDisableMovementInput
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bDisableMovementInput__Offset, 1, 0, 1, 1);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bDisableMovementInput__Offset, 1,0,1,1);}
			
		}
		
		static readonly int bDisableLookAtInput__Offset;
		public bool bDisableLookAtInput
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bDisableLookAtInput__Offset, 1, 0, 2, 2);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bDisableLookAtInput__Offset, 1,0,2,2);}
			
		}
		
		static readonly int bHidePlayer__Offset;
		public bool bHidePlayer
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bHidePlayer__Offset, 1, 0, 4, 4);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bHidePlayer__Offset, 1,0,4,4);}
			
		}
		
		static readonly int bHideHud__Offset;
		public bool bHideHud
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bHideHud__Offset, 1, 0, 8, 8);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bHideHud__Offset, 1,0,8,8);}
			
		}
		
		static readonly int GroupActorInfos__Offset;
		public TStructArray<FInterpGroupActorInfo> GroupActorInfos
		{
			get{ CheckIsValid();return new TStructArray<FInterpGroupActorInfo>((FScriptArray)Marshal.PtrToStructure(_this.Get()+GroupActorInfos__Offset, typeof(FScriptArray)));}
					set{ CheckIsValid();Marshal.StructureToPtr(value.InterArray, _this.Get()+GroupActorInfos__Offset, false);}
			
		}
		
		static readonly int bShouldShowGore__Offset;
		public bool bShouldShowGore
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bShouldShowGore__Offset, 1, 0, 1, 1);}
			
		}
		
		static readonly int GroupInst__Offset;
		public TObjectArray<UInterpGroupInst>  GroupInst
		{
					get{ CheckIsValid();return new TObjectArray<UInterpGroupInst>((FScriptArray)Marshal.PtrToStructure(_this.Get()+GroupInst__Offset, typeof(FScriptArray)));}
					set{ CheckIsValid();Marshal.StructureToPtr(value.InterArray, _this.Get()+GroupInst__Offset, false);}
			
		}
		
		static readonly int CameraCuts__Offset;
		public TStructArray<FCameraCutInfo> CameraCuts
		{
			get{ CheckIsValid();return new TStructArray<FCameraCutInfo>((FScriptArray)Marshal.PtrToStructure(_this.Get()+CameraCuts__Offset, typeof(FScriptArray)));}
					set{ CheckIsValid();Marshal.StructureToPtr(value.InterArray, _this.Get()+CameraCuts__Offset, false);}
			
		}
		
		static readonly int bIsPlaying__Offset;
		public bool bIsPlaying
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bIsPlaying__Offset, 1, 0, 1, 1);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bIsPlaying__Offset, 1,0,1,1);}
			
		}
		
		static readonly int bReversePlayback__Offset;
		public bool bReversePlayback
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bReversePlayback__Offset, 1, 0, 2, 2);}
			
		}
		
		static readonly int bPaused__Offset;
		public bool bPaused
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bPaused__Offset, 1, 0, 4, 4);}
			
		}
		
		static readonly int bPendingStop__Offset;
		public bool bPendingStop
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bPendingStop__Offset, 1, 0, 8, 8);}
			
		}
		
		static readonly int InterpPosition__Offset;
		public float InterpPosition
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+InterpPosition__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+InterpPosition__Offset, false);}
			
		}
		
		static readonly int ReplicationForceIsPlaying__Offset;
		public byte ReplicationForceIsPlaying
		{
			get{ CheckIsValid();return (byte)Marshal.PtrToStructure(_this.Get()+ReplicationForceIsPlaying__Offset, typeof(byte));}
			
		}
		
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
		
		static AMatineeActor()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("MatineeActor");
			MatineeData__Offset=GetPropertyOffset(NativeClassPtr,"MatineeData");
			MatineeControllerName__Offset=GetPropertyOffset(NativeClassPtr,"MatineeControllerName");
			PlayRate__Offset=GetPropertyOffset(NativeClassPtr,"PlayRate");
			bPlayOnLevelLoad__Offset=GetPropertyOffset(NativeClassPtr,"bPlayOnLevelLoad");
			bForceStartPos__Offset=GetPropertyOffset(NativeClassPtr,"bForceStartPos");
			ForceStartPosition__Offset=GetPropertyOffset(NativeClassPtr,"ForceStartPosition");
			bLooping__Offset=GetPropertyOffset(NativeClassPtr,"bLooping");
			bRewindOnPlay__Offset=GetPropertyOffset(NativeClassPtr,"bRewindOnPlay");
			bNoResetOnRewind__Offset=GetPropertyOffset(NativeClassPtr,"bNoResetOnRewind");
			bRewindIfAlreadyPlaying__Offset=GetPropertyOffset(NativeClassPtr,"bRewindIfAlreadyPlaying");
			bDisableRadioFilter__Offset=GetPropertyOffset(NativeClassPtr,"bDisableRadioFilter");
			bClientSideOnly__Offset=GetPropertyOffset(NativeClassPtr,"bClientSideOnly");
			bSkipUpdateIfNotVisible__Offset=GetPropertyOffset(NativeClassPtr,"bSkipUpdateIfNotVisible");
			bIsSkippable__Offset=GetPropertyOffset(NativeClassPtr,"bIsSkippable");
			PreferredSplitScreenNum__Offset=GetPropertyOffset(NativeClassPtr,"PreferredSplitScreenNum");
			bDisableMovementInput__Offset=GetPropertyOffset(NativeClassPtr,"bDisableMovementInput");
			bDisableLookAtInput__Offset=GetPropertyOffset(NativeClassPtr,"bDisableLookAtInput");
			bHidePlayer__Offset=GetPropertyOffset(NativeClassPtr,"bHidePlayer");
			bHideHud__Offset=GetPropertyOffset(NativeClassPtr,"bHideHud");
			GroupActorInfos__Offset=GetPropertyOffset(NativeClassPtr,"GroupActorInfos");
			bShouldShowGore__Offset=GetPropertyOffset(NativeClassPtr,"bShouldShowGore");
			GroupInst__Offset=GetPropertyOffset(NativeClassPtr,"GroupInst");
			CameraCuts__Offset=GetPropertyOffset(NativeClassPtr,"CameraCuts");
			bIsPlaying__Offset=GetPropertyOffset(NativeClassPtr,"bIsPlaying");
			bReversePlayback__Offset=GetPropertyOffset(NativeClassPtr,"bReversePlayback");
			bPaused__Offset=GetPropertyOffset(NativeClassPtr,"bPaused");
			bPendingStop__Offset=GetPropertyOffset(NativeClassPtr,"bPendingStop");
			InterpPosition__Offset=GetPropertyOffset(NativeClassPtr,"InterpPosition");
			ReplicationForceIsPlaying__Offset=GetPropertyOffset(NativeClassPtr,"ReplicationForceIsPlaying");
			OnPlay__Offset=GetPropertyOffset(NativeClassPtr,"OnPlay");
			OnStop__Offset=GetPropertyOffset(NativeClassPtr,"OnStop");
			OnPause__Offset=GetPropertyOffset(NativeClassPtr,"OnPause");
			
		}
		
	}
	
}
#endif
#endif
