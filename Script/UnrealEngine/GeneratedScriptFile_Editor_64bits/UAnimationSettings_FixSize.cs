#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>Default animation settings.</summary>
	public partial class UAnimationSettings
	{
		static readonly int CompressCommandletVersion__Offset;
		/// <summary>compression upgrade version</summary>
		public int CompressCommandletVersion
		{
			get{ CheckIsValid();return (int)Marshal.PtrToStructure(_this.Get()+CompressCommandletVersion__Offset, typeof(int));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+CompressCommandletVersion__Offset, false);}
			
		}
		
		static readonly int KeyEndEffectorsMatchNameArray__Offset;
		public TStructArray<FString> KeyEndEffectorsMatchNameArray
		{
			get{ CheckIsValid();return new TStructArray<FString>((FScriptArray)Marshal.PtrToStructure(_this.Get()+KeyEndEffectorsMatchNameArray__Offset, typeof(FScriptArray)));}
					set{ CheckIsValid();Marshal.StructureToPtr(value.InterArray, _this.Get()+KeyEndEffectorsMatchNameArray__Offset, false);}
			
		}
		
		static readonly int DefaultCompressionAlgorithm__Offset;
		public TSubclassOf<UAnimCompress>  DefaultCompressionAlgorithm
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + DefaultCompressionAlgorithm__Offset); return v; }
			set{ CheckIsValid(); Marshal.WriteIntPtr(_this.Get() + DefaultCompressionAlgorithm__Offset, value); }
			
		}
		
		static readonly int RotationCompressionFormat__Offset;
		public AnimationCompressionFormat RotationCompressionFormat
		{
			get{ CheckIsValid();return (AnimationCompressionFormat)Marshal.PtrToStructure(_this.Get()+RotationCompressionFormat__Offset, typeof(AnimationCompressionFormat));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+RotationCompressionFormat__Offset, false);}
			
		}
		
		static readonly int TranslationCompressionFormat__Offset;
		public AnimationCompressionFormat TranslationCompressionFormat
		{
			get{ CheckIsValid();return (AnimationCompressionFormat)Marshal.PtrToStructure(_this.Get()+TranslationCompressionFormat__Offset, typeof(AnimationCompressionFormat));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+TranslationCompressionFormat__Offset, false);}
			
		}
		
		static readonly int AlternativeCompressionThreshold__Offset;
		/// <summary>
		/// The alternate error threshold (0.0 means don't try anything other than the current / default scheme)
		/// Determines the current setting for world-space error tolerance in the animation compressor.
		/// When requested, animation being compressed will also consider an alternative compression
		/// method if the end result of that method produces less error than the AlternativeCompressionThreshold.
		/// Also known as "Max End Effector Error"
		/// </summary>
		public float AlternativeCompressionThreshold
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+AlternativeCompressionThreshold__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+AlternativeCompressionThreshold__Offset, false);}
			
		}
		
		static readonly int ForceRecompression__Offset;
		public bool ForceRecompression
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), ForceRecompression__Offset, 1, 0, 1, 255);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), ForceRecompression__Offset, 1,0,1,255);}
			
		}
		
		static readonly int bOnlyCheckForMissingSkeletalMeshes__Offset;
		public bool bOnlyCheckForMissingSkeletalMeshes
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bOnlyCheckForMissingSkeletalMeshes__Offset, 1, 0, 1, 255);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bOnlyCheckForMissingSkeletalMeshes__Offset, 1,0,1,255);}
			
		}
		
		static readonly int bForceBelowThreshold__Offset;
		/// <summary>If true and the existing compression error is greater than Alternative Compression Threshold, then any compression technique (even one that increases the size) with a lower error will be used until it falls below the threshold</summary>
		public bool bForceBelowThreshold
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bForceBelowThreshold__Offset, 1, 0, 1, 255);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bForceBelowThreshold__Offset, 1,0,1,255);}
			
		}
		
		static readonly int bFirstRecompressUsingCurrentOrDefault__Offset;
		/// <summary>
		/// If true, then the animation will be first recompressed with it's current compressor if non-NULL, or with the global default compressor (specified in the engine ini)
		/// Also known as "Run Current Default Compressor"
		/// </summary>
		public bool bFirstRecompressUsingCurrentOrDefault
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bFirstRecompressUsingCurrentOrDefault__Offset, 1, 0, 1, 255);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bFirstRecompressUsingCurrentOrDefault__Offset, 1,0,1,255);}
			
		}
		
		static readonly int bRaiseMaxErrorToExisting__Offset;
		/// <summary>If true and the existing compression error is greater than Alternative Compression Threshold, then Alternative Compression Threshold will be effectively raised to the existing error level</summary>
		public bool bRaiseMaxErrorToExisting
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bRaiseMaxErrorToExisting__Offset, 1, 0, 1, 255);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bRaiseMaxErrorToExisting__Offset, 1,0,1,255);}
			
		}
		
		static readonly int bTryFixedBitwiseCompression__Offset;
		/// <summary>If true, the uniform bitwise techniques will be tried</summary>
		public bool bTryFixedBitwiseCompression
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bTryFixedBitwiseCompression__Offset, 1, 0, 1, 255);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bTryFixedBitwiseCompression__Offset, 1,0,1,255);}
			
		}
		
		static readonly int bTryPerTrackBitwiseCompression__Offset;
		/// <summary>If true, the per-track compressor techniques will be tried</summary>
		public bool bTryPerTrackBitwiseCompression
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bTryPerTrackBitwiseCompression__Offset, 1, 0, 1, 255);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bTryPerTrackBitwiseCompression__Offset, 1,0,1,255);}
			
		}
		
		static readonly int bTryLinearKeyRemovalCompression__Offset;
		/// <summary>If true, the linear key removal techniques will be tried</summary>
		public bool bTryLinearKeyRemovalCompression
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bTryLinearKeyRemovalCompression__Offset, 1, 0, 1, 255);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bTryLinearKeyRemovalCompression__Offset, 1,0,1,255);}
			
		}
		
		static readonly int bTryIntervalKeyRemoval__Offset;
		/// <summary>If true, the resampling techniques will be tried</summary>
		public bool bTryIntervalKeyRemoval
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bTryIntervalKeyRemoval__Offset, 1, 0, 1, 255);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bTryIntervalKeyRemoval__Offset, 1,0,1,255);}
			
		}
		
		static readonly int bEnablePerformanceLog__Offset;
		public bool bEnablePerformanceLog
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bEnablePerformanceLog__Offset, 1, 0, 1, 255);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bEnablePerformanceLog__Offset, 1,0,1,255);}
			
		}
		
		static readonly int bStripAnimationDataOnDedicatedServer__Offset;
		/// <summary>If true, animation track data will be stripped from dedicated server cooked data</summary>
		public bool bStripAnimationDataOnDedicatedServer
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bStripAnimationDataOnDedicatedServer__Offset, 1, 0, 1, 255);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bStripAnimationDataOnDedicatedServer__Offset, 1,0,1,255);}
			
		}
		
		static UAnimationSettings()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("AnimationSettings");
			CompressCommandletVersion__Offset=GetPropertyOffset(NativeClassPtr,"CompressCommandletVersion");
			KeyEndEffectorsMatchNameArray__Offset=GetPropertyOffset(NativeClassPtr,"KeyEndEffectorsMatchNameArray");
			DefaultCompressionAlgorithm__Offset=GetPropertyOffset(NativeClassPtr,"DefaultCompressionAlgorithm");
			RotationCompressionFormat__Offset=GetPropertyOffset(NativeClassPtr,"RotationCompressionFormat");
			TranslationCompressionFormat__Offset=GetPropertyOffset(NativeClassPtr,"TranslationCompressionFormat");
			AlternativeCompressionThreshold__Offset=GetPropertyOffset(NativeClassPtr,"AlternativeCompressionThreshold");
			ForceRecompression__Offset=GetPropertyOffset(NativeClassPtr,"ForceRecompression");
			bOnlyCheckForMissingSkeletalMeshes__Offset=GetPropertyOffset(NativeClassPtr,"bOnlyCheckForMissingSkeletalMeshes");
			bForceBelowThreshold__Offset=GetPropertyOffset(NativeClassPtr,"bForceBelowThreshold");
			bFirstRecompressUsingCurrentOrDefault__Offset=GetPropertyOffset(NativeClassPtr,"bFirstRecompressUsingCurrentOrDefault");
			bRaiseMaxErrorToExisting__Offset=GetPropertyOffset(NativeClassPtr,"bRaiseMaxErrorToExisting");
			bTryFixedBitwiseCompression__Offset=GetPropertyOffset(NativeClassPtr,"bTryFixedBitwiseCompression");
			bTryPerTrackBitwiseCompression__Offset=GetPropertyOffset(NativeClassPtr,"bTryPerTrackBitwiseCompression");
			bTryLinearKeyRemovalCompression__Offset=GetPropertyOffset(NativeClassPtr,"bTryLinearKeyRemovalCompression");
			bTryIntervalKeyRemoval__Offset=GetPropertyOffset(NativeClassPtr,"bTryIntervalKeyRemoval");
			bEnablePerformanceLog__Offset=GetPropertyOffset(NativeClassPtr,"bEnablePerformanceLog");
			bStripAnimationDataOnDedicatedServer__Offset=GetPropertyOffset(NativeClassPtr,"bStripAnimationDataOnDedicatedServer");
			
		}
		
	}
	
}
#endif
#endif
