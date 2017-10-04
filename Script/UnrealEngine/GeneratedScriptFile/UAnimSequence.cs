using System;
namespace UnrealEngine
{
	public partial class UAnimSequence:UAnimSequenceBase
	{
		/// <summary>Number of raw frames in this sequence (not used by engine - just for informational purposes).</summary>
		public int NumFrames;
		
		/// <summary>Update this if the contents of RawAnimationData changes;</summary>
		public FGuid RawDataGuid;
		
		/// <summary>
		/// The compression scheme that was most recently used to compress this animation.
		/// May be NULL.
		/// </summary>
		public UAnimCompress CompressionScheme;
		
		/// <summary>Additive animation type. *</summary>
		public EAdditiveAnimationType AdditiveAnimType;
		
		/// <summary>Additive refrerence pose type. Refer above enum type</summary>
		public EAdditiveBasePoseType RefPoseType;
		
		/// <summary>Additive reference animation if it's relevant - i.e. AnimScaled or AnimFrame *</summary>
		public UAnimSequence RefPoseSeq;
		
		/// <summary>Additve reference frame if RefPoseType == AnimFrame *</summary>
		public int RefFrameIndex;
		
		/// <summary>The version of the global encoding package used at the time of import</summary>
		public int EncodingPkgVersion;
		
		/// <summary>Base pose to use when retargeting</summary>
		public FName RetargetSource;
		
		/// <summary>If this is on, it will allow extracting of root motion *</summary>
		public bool bEnableRootMotion;
		
		/// <summary>Root Bone will be locked to that position when extracting root motion.*</summary>
		public ERootMotionRootLock RootMotionRootLock;
		
		/// <summary>Force Root Bone Lock even if Root Motion is not enabled</summary>
		public bool bForceRootLock;
		
		/// <summary>Have we copied root motion settings from an owning montage</summary>
		public bool bRootMotionSettingsCopiedFromMontage;
		
		/// <summary>Saved version number with CompressAnimations commandlet. To help with doing it in multiple passes.</summary>
		public int CompressCommandletVersion;
		
		/// <summary>
		/// Do not attempt to override compression scheme when running CompressAnimations commandlet.
		/// Some high frequency animations are too sensitive and shouldn't be changed.
		/// </summary>
		public bool bDoNotOverrideCompression;
		
		/// <summary>Used to track whether, or not, this sequence was compressed with it's full translation tracks</summary>
		public bool bWasCompressedWithoutTranslations;
		
		/// <summary>Importing data and options used for this mesh</summary>
		public UAssetImportData AssetImportData;
		
		/// <summary>Path to the resource used to construct this skeletal mesh</summary>
		public FString SourceFilePath;
		
		/// <summary>Date/Time-stamp of the file from the last import</summary>
		public FString SourceFileTimestamp;
		
		public bool bNeedsRebake;
		
		
	}
	
}
