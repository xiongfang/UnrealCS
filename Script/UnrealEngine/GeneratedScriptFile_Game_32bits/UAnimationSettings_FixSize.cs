#if WITH_GAME
#if PLATFORM_32BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class UAnimationSettings
	{
		static readonly int CompressCommandletVersion__Offset;
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
		public bool bForceBelowThreshold
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bForceBelowThreshold__Offset, 1, 0, 1, 255);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bForceBelowThreshold__Offset, 1,0,1,255);}
			
		}
		
		static readonly int bFirstRecompressUsingCurrentOrDefault__Offset;
		public bool bFirstRecompressUsingCurrentOrDefault
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bFirstRecompressUsingCurrentOrDefault__Offset, 1, 0, 1, 255);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bFirstRecompressUsingCurrentOrDefault__Offset, 1,0,1,255);}
			
		}
		
		static readonly int bRaiseMaxErrorToExisting__Offset;
		public bool bRaiseMaxErrorToExisting
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bRaiseMaxErrorToExisting__Offset, 1, 0, 1, 255);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bRaiseMaxErrorToExisting__Offset, 1,0,1,255);}
			
		}
		
		static readonly int bTryFixedBitwiseCompression__Offset;
		public bool bTryFixedBitwiseCompression
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bTryFixedBitwiseCompression__Offset, 1, 0, 1, 255);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bTryFixedBitwiseCompression__Offset, 1,0,1,255);}
			
		}
		
		static readonly int bTryPerTrackBitwiseCompression__Offset;
		public bool bTryPerTrackBitwiseCompression
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bTryPerTrackBitwiseCompression__Offset, 1, 0, 1, 255);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bTryPerTrackBitwiseCompression__Offset, 1,0,1,255);}
			
		}
		
		static readonly int bTryLinearKeyRemovalCompression__Offset;
		public bool bTryLinearKeyRemovalCompression
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bTryLinearKeyRemovalCompression__Offset, 1, 0, 1, 255);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bTryLinearKeyRemovalCompression__Offset, 1,0,1,255);}
			
		}
		
		static readonly int bTryIntervalKeyRemoval__Offset;
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
