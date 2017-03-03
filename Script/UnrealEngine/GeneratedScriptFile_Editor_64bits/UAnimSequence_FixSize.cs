#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class UAnimSequence
	{
		static readonly int NumFrames__Offset;
		/// <summary>Number of raw frames in this sequence (not used by engine - just for informational purposes).</summary>
		public int NumFrames
		{
			get{ CheckIsValid();return (int)Marshal.PtrToStructure(_this.Get()+NumFrames__Offset, typeof(int));}
			
		}
		
		static readonly int TrackToSkeletonMapTable__Offset;
		/// <summary>
		/// In the future, maybe keeping RawAnimSequenceTrack + TrackMap as one would be good idea to avoid inconsistent array size
		/// TrackToSkeletonMapTable(i) should contains  track mapping data for RawAnimationData(i).
		/// </summary>
		public TStructArray<FTrackToSkeletonMap> TrackToSkeletonMapTable
		{
			get{ CheckIsValid();return new TStructArray<FTrackToSkeletonMap>((FScriptArray)Marshal.PtrToStructure(_this.Get()+TrackToSkeletonMapTable__Offset, typeof(FScriptArray)));}
					set{ CheckIsValid();Marshal.StructureToPtr(value.InterArray, _this.Get()+TrackToSkeletonMapTable__Offset, false);}
			
		}
		
		static readonly int RawDataGuid__Offset;
		/// <summary>Update this if the contents of RawAnimationData changes;</summary>
		public FGuid RawDataGuid
		{
			get{ CheckIsValid();return (FGuid)Marshal.PtrToStructure(_this.Get()+RawDataGuid__Offset, typeof(FGuid));}
			
		}
		
		static readonly int AnimationTrackNames__Offset;
		/// <summary>This is name of RawAnimationData tracks for editoronly - if we lose skeleton, we'll need relink them</summary>
		public TStructArray<FName> AnimationTrackNames
		{
			get{ CheckIsValid();return new TStructArray<FName>((FScriptArray)Marshal.PtrToStructure(_this.Get()+AnimationTrackNames__Offset, typeof(FScriptArray)));}
					set{ CheckIsValid();Marshal.StructureToPtr(value.InterArray, _this.Get()+AnimationTrackNames__Offset, false);}
			
		}
		
		static readonly int CompressionScheme__Offset;
		/// <summary>
		/// The compression scheme that was most recently used to compress this animation.
		/// May be NULL.
		/// </summary>
		public UAnimCompress CompressionScheme
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + CompressionScheme__Offset); if (v == IntPtr.Zero)return null; UAnimCompress retValue = new UAnimCompress(); retValue._this = v; return retValue; }
			set{ CheckIsValid(); if (value == null)Marshal.WriteIntPtr(_this.Get() + CompressionScheme__Offset, IntPtr.Zero);else Marshal.WriteIntPtr(_this.Get() + CompressionScheme__Offset, value._this.Get()); }
			
		}
		
		static readonly int AdditiveAnimType__Offset;
		/// <summary>Additive animation type. *</summary>
		public EAdditiveAnimationType AdditiveAnimType
		{
			get{ CheckIsValid();return (EAdditiveAnimationType)Marshal.PtrToStructure(_this.Get()+AdditiveAnimType__Offset, typeof(EAdditiveAnimationType));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+AdditiveAnimType__Offset, false);}
			
		}
		
		static readonly int RefPoseType__Offset;
		/// <summary>Additive refrerence pose type. Refer above enum type</summary>
		public EAdditiveBasePoseType RefPoseType
		{
			get{ CheckIsValid();return (EAdditiveBasePoseType)Marshal.PtrToStructure(_this.Get()+RefPoseType__Offset, typeof(EAdditiveBasePoseType));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+RefPoseType__Offset, false);}
			
		}
		
		static readonly int RefPoseSeq__Offset;
		/// <summary>Additive reference animation if it's relevant - i.e. AnimScaled or AnimFrame *</summary>
		public UAnimSequence RefPoseSeq
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + RefPoseSeq__Offset); if (v == IntPtr.Zero)return null; UAnimSequence retValue = new UAnimSequence(); retValue._this = v; return retValue; }
			set{ CheckIsValid(); if (value == null)Marshal.WriteIntPtr(_this.Get() + RefPoseSeq__Offset, IntPtr.Zero);else Marshal.WriteIntPtr(_this.Get() + RefPoseSeq__Offset, value._this.Get()); }
			
		}
		
		static readonly int RefFrameIndex__Offset;
		/// <summary>Additve reference frame if RefPoseType == AnimFrame *</summary>
		public int RefFrameIndex
		{
			get{ CheckIsValid();return (int)Marshal.PtrToStructure(_this.Get()+RefFrameIndex__Offset, typeof(int));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+RefFrameIndex__Offset, false);}
			
		}
		
		static readonly int EncodingPkgVersion__Offset;
		/// <summary>The version of the global encoding package used at the time of import</summary>
		public int EncodingPkgVersion
		{
			get{ CheckIsValid();return (int)Marshal.PtrToStructure(_this.Get()+EncodingPkgVersion__Offset, typeof(int));}
			
		}
		
		static readonly int RetargetSource__Offset;
		/// <summary>Base pose to use when retargeting</summary>
		public FName RetargetSource
		{
			get{ CheckIsValid();return (FName)Marshal.PtrToStructure(_this.Get()+RetargetSource__Offset, typeof(FName));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+RetargetSource__Offset, false);}
			
		}
		
		static readonly int bEnableRootMotion__Offset;
		/// <summary>If this is on, it will allow extracting of root motion *</summary>
		public bool bEnableRootMotion
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bEnableRootMotion__Offset, 1, 0, 1, 255);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bEnableRootMotion__Offset, 1,0,1,255);}
			
		}
		
		static readonly int RootMotionRootLock__Offset;
		/// <summary>Root Bone will be locked to that position when extracting root motion.*</summary>
		public ERootMotionRootLock RootMotionRootLock
		{
			get{ CheckIsValid();return (ERootMotionRootLock)Marshal.PtrToStructure(_this.Get()+RootMotionRootLock__Offset, typeof(ERootMotionRootLock));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+RootMotionRootLock__Offset, false);}
			
		}
		
		static readonly int bForceRootLock__Offset;
		/// <summary>Force Root Bone Lock even if Root Motion is not enabled</summary>
		public bool bForceRootLock
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bForceRootLock__Offset, 1, 0, 1, 255);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bForceRootLock__Offset, 1,0,1,255);}
			
		}
		
		static readonly int bRootMotionSettingsCopiedFromMontage__Offset;
		/// <summary>Have we copied root motion settings from an owning montage</summary>
		public bool bRootMotionSettingsCopiedFromMontage
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bRootMotionSettingsCopiedFromMontage__Offset, 1, 0, 1, 255);}
			
		}
		
		static readonly int CompressCommandletVersion__Offset;
		/// <summary>Saved version number with CompressAnimations commandlet. To help with doing it in multiple passes.</summary>
		public int CompressCommandletVersion
		{
			get{ CheckIsValid();return (int)Marshal.PtrToStructure(_this.Get()+CompressCommandletVersion__Offset, typeof(int));}
			
		}
		
		static readonly int bDoNotOverrideCompression__Offset;
		/// <summary>
		/// Do not attempt to override compression scheme when running CompressAnimations commandlet.
		/// Some high frequency animations are too sensitive and shouldn't be changed.
		/// </summary>
		public bool bDoNotOverrideCompression
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bDoNotOverrideCompression__Offset, 1, 0, 1, 1);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bDoNotOverrideCompression__Offset, 1,0,1,1);}
			
		}
		
		static readonly int bWasCompressedWithoutTranslations__Offset;
		/// <summary>Used to track whether, or not, this sequence was compressed with it's full translation tracks</summary>
		public bool bWasCompressedWithoutTranslations
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bWasCompressedWithoutTranslations__Offset, 1, 0, 2, 2);}
			
		}
		
		static readonly int AssetImportData__Offset;
		/// <summary>Importing data and options used for this mesh</summary>
		public UAssetImportData AssetImportData
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + AssetImportData__Offset); if (v == IntPtr.Zero)return null; UAssetImportData retValue = new UAssetImportData(); retValue._this = v; return retValue; }
			set{ CheckIsValid(); if (value == null)Marshal.WriteIntPtr(_this.Get() + AssetImportData__Offset, IntPtr.Zero);else Marshal.WriteIntPtr(_this.Get() + AssetImportData__Offset, value._this.Get()); }
			
		}
		
		static readonly int SourceFilePath__Offset;
		/// <summary>Path to the resource used to construct this skeletal mesh</summary>
		public FString SourceFilePath
		{
			get{ CheckIsValid();return (FString)Marshal.PtrToStructure(_this.Get()+SourceFilePath__Offset, typeof(FString));}
			
		}
		
		static readonly int SourceFileTimestamp__Offset;
		/// <summary>Date/Time-stamp of the file from the last import</summary>
		public FString SourceFileTimestamp
		{
			get{ CheckIsValid();return (FString)Marshal.PtrToStructure(_this.Get()+SourceFileTimestamp__Offset, typeof(FString));}
			
		}
		
		static readonly int bNeedsRebake__Offset;
		public bool bNeedsRebake
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bNeedsRebake__Offset, 1, 0, 1, 255);}
			
		}
		
		static readonly int AuthoredSyncMarkers__Offset;
		/// <summary>Authored Sync markers</summary>
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
			RawDataGuid__Offset=GetPropertyOffset(NativeClassPtr,"RawDataGuid");
			AnimationTrackNames__Offset=GetPropertyOffset(NativeClassPtr,"AnimationTrackNames");
			CompressionScheme__Offset=GetPropertyOffset(NativeClassPtr,"CompressionScheme");
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
			CompressCommandletVersion__Offset=GetPropertyOffset(NativeClassPtr,"CompressCommandletVersion");
			bDoNotOverrideCompression__Offset=GetPropertyOffset(NativeClassPtr,"bDoNotOverrideCompression");
			bWasCompressedWithoutTranslations__Offset=GetPropertyOffset(NativeClassPtr,"bWasCompressedWithoutTranslations");
			AssetImportData__Offset=GetPropertyOffset(NativeClassPtr,"AssetImportData");
			SourceFilePath__Offset=GetPropertyOffset(NativeClassPtr,"SourceFilePath");
			SourceFileTimestamp__Offset=GetPropertyOffset(NativeClassPtr,"SourceFileTimestamp");
			bNeedsRebake__Offset=GetPropertyOffset(NativeClassPtr,"bNeedsRebake");
			AuthoredSyncMarkers__Offset=GetPropertyOffset(NativeClassPtr,"AuthoredSyncMarkers");
			
		}
		
	}
	
}
#endif
#endif
