#if WITH_GAME
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class UAnimSequence
	{
		static readonly int NumFrames__Offset;
		public int NumFrames
		{
			get{ CheckIsValid();return (int)Marshal.PtrToStructure(_this.Get()+NumFrames__Offset, typeof(int));}
			
		}
		
		static readonly int TrackToSkeletonMapTable__Offset;
		public TStructArray<FTrackToSkeletonMap> TrackToSkeletonMapTable
		{
			get{ CheckIsValid();return new TStructArray<FTrackToSkeletonMap>((FScriptArray)Marshal.PtrToStructure(_this.Get()+TrackToSkeletonMapTable__Offset, typeof(FScriptArray)));}
					set{ CheckIsValid();Marshal.StructureToPtr(value.InterArray, _this.Get()+TrackToSkeletonMapTable__Offset, false);}
			
		}
		
		static readonly int AdditiveAnimType__Offset;
		public EAdditiveAnimationType AdditiveAnimType
		{
			get{ CheckIsValid();return (EAdditiveAnimationType)Marshal.PtrToStructure(_this.Get()+AdditiveAnimType__Offset, typeof(EAdditiveAnimationType));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+AdditiveAnimType__Offset, false);}
			
		}
		
		static readonly int RefPoseType__Offset;
		public EAdditiveBasePoseType RefPoseType
		{
			get{ CheckIsValid();return (EAdditiveBasePoseType)Marshal.PtrToStructure(_this.Get()+RefPoseType__Offset, typeof(EAdditiveBasePoseType));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+RefPoseType__Offset, false);}
			
		}
		
		static readonly int RefPoseSeq__Offset;
		public UAnimSequence RefPoseSeq
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + RefPoseSeq__Offset); if (v == IntPtr.Zero)return null; UAnimSequence retValue = new UAnimSequence(); retValue._this = v; return retValue; }
			set{ CheckIsValid(); if (value == null)Marshal.WriteIntPtr(_this.Get() + RefPoseSeq__Offset, IntPtr.Zero);else Marshal.WriteIntPtr(_this.Get() + RefPoseSeq__Offset, value._this.Get()); }
			
		}
		
		static readonly int RefFrameIndex__Offset;
		public int RefFrameIndex
		{
			get{ CheckIsValid();return (int)Marshal.PtrToStructure(_this.Get()+RefFrameIndex__Offset, typeof(int));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+RefFrameIndex__Offset, false);}
			
		}
		
		static readonly int EncodingPkgVersion__Offset;
		public int EncodingPkgVersion
		{
			get{ CheckIsValid();return (int)Marshal.PtrToStructure(_this.Get()+EncodingPkgVersion__Offset, typeof(int));}
			
		}
		
		static readonly int RetargetSource__Offset;
		public FName RetargetSource
		{
			get{ CheckIsValid();return (FName)Marshal.PtrToStructure(_this.Get()+RetargetSource__Offset, typeof(FName));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+RetargetSource__Offset, false);}
			
		}
		
		static readonly int bEnableRootMotion__Offset;
		public bool bEnableRootMotion
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bEnableRootMotion__Offset, 1, 0, 1, 255);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bEnableRootMotion__Offset, 1,0,1,255);}
			
		}
		
		static readonly int RootMotionRootLock__Offset;
		public ERootMotionRootLock RootMotionRootLock
		{
			get{ CheckIsValid();return (ERootMotionRootLock)Marshal.PtrToStructure(_this.Get()+RootMotionRootLock__Offset, typeof(ERootMotionRootLock));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+RootMotionRootLock__Offset, false);}
			
		}
		
		static readonly int bForceRootLock__Offset;
		public bool bForceRootLock
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bForceRootLock__Offset, 1, 0, 1, 255);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bForceRootLock__Offset, 1,0,1,255);}
			
		}
		
		static readonly int bRootMotionSettingsCopiedFromMontage__Offset;
		public bool bRootMotionSettingsCopiedFromMontage
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bRootMotionSettingsCopiedFromMontage__Offset, 1, 0, 1, 255);}
			
		}
		
		static readonly int AuthoredSyncMarkers__Offset;
		public TStructArray<FAnimSyncMarker> AuthoredSyncMarkers
		{
			get{ CheckIsValid();return new TStructArray<FAnimSyncMarker>((FScriptArray)Marshal.PtrToStructure(_this.Get()+AuthoredSyncMarkers__Offset, typeof(FScriptArray)));}
					set{ CheckIsValid();Marshal.StructureToPtr(value.InterArray, _this.Get()+AuthoredSyncMarkers__Offset, false);}
			
		}
		
		static UAnimSequence()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("AnimSequence");
			NumFrames__Offset=GetPropertyOffset(NativeClassPtr,"NumFrames");
			TrackToSkeletonMapTable__Offset=GetPropertyOffset(NativeClassPtr,"TrackToSkeletonMapTable");
			AdditiveAnimType__Offset=GetPropertyOffset(NativeClassPtr,"AdditiveAnimType");
			RefPoseType__Offset=GetPropertyOffset(NativeClassPtr,"RefPoseType");
			RefPoseSeq__Offset=GetPropertyOffset(NativeClassPtr,"RefPoseSeq");
			RefFrameIndex__Offset=GetPropertyOffset(NativeClassPtr,"RefFrameIndex");
			EncodingPkgVersion__Offset=GetPropertyOffset(NativeClassPtr,"EncodingPkgVersion");
			RetargetSource__Offset=GetPropertyOffset(NativeClassPtr,"RetargetSource");
			bEnableRootMotion__Offset=GetPropertyOffset(NativeClassPtr,"bEnableRootMotion");
			RootMotionRootLock__Offset=GetPropertyOffset(NativeClassPtr,"RootMotionRootLock");
			bForceRootLock__Offset=GetPropertyOffset(NativeClassPtr,"bForceRootLock");
			bRootMotionSettingsCopiedFromMontage__Offset=GetPropertyOffset(NativeClassPtr,"bRootMotionSettingsCopiedFromMontage");
			AuthoredSyncMarkers__Offset=GetPropertyOffset(NativeClassPtr,"AuthoredSyncMarkers");
			
		}
		
	}
	
}
#endif
#endif
