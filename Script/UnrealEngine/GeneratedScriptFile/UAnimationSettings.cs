using System;
namespace UnrealEngine
{
	public partial class UAnimationSettings:UDeveloperSettings
	{
		/// <summary>compression upgrade version</summary>
		public int CompressCommandletVersion;
		
		public TSubclassOf<UAnimCompress>  DefaultCompressionAlgorithm;
		
		public AnimationCompressionFormat RotationCompressionFormat;
		
		public AnimationCompressionFormat TranslationCompressionFormat;
		
		/// <summary>
		/// The alternate error threshold (0.0 means don't try anything other than the current / default scheme)
		/// Determines the current setting for world-space error tolerance in the animation compressor.
		/// When requested, animation being compressed will also consider an alternative compression
		/// method if the end result of that method produces less error than the AlternativeCompressionThreshold.
		/// Also known as "Max End Effector Error"
		/// </summary>
		public float AlternativeCompressionThreshold;
		
		public bool ForceRecompression;
		
		public bool bOnlyCheckForMissingSkeletalMeshes;
		
		/// <summary>If true and the existing compression error is greater than Alternative Compression Threshold, then any compression technique (even one that increases the size) with a lower error will be used until it falls below the threshold</summary>
		public bool bForceBelowThreshold;
		
		/// <summary>
		/// If true, then the animation will be first recompressed with it's current compressor if non-NULL, or with the global default compressor (specified in the engine ini)
		/// Also known as "Run Current Default Compressor"
		/// </summary>
		public bool bFirstRecompressUsingCurrentOrDefault;
		
		/// <summary>If true and the existing compression error is greater than Alternative Compression Threshold, then Alternative Compression Threshold will be effectively raised to the existing error level</summary>
		public bool bRaiseMaxErrorToExisting;
		
		/// <summary>If true, the uniform bitwise techniques will be tried</summary>
		public bool bTryFixedBitwiseCompression;
		
		/// <summary>If true, the per-track compressor techniques will be tried</summary>
		public bool bTryPerTrackBitwiseCompression;
		
		/// <summary>If true, the linear key removal techniques will be tried</summary>
		public bool bTryLinearKeyRemovalCompression;
		
		/// <summary>If true, the resampling techniques will be tried</summary>
		public bool bTryIntervalKeyRemoval;
		
		public bool bEnablePerformanceLog;
		
		/// <summary>If true, animation track data will be stripped from dedicated server cooked data</summary>
		public bool bStripAnimationDataOnDedicatedServer;
		
		
	}
	
}
