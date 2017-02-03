#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class UAnimCompress_Automatic
	{
		static readonly int MaxEndEffectorError__Offset;
		/// <summary>
		/// Maximum amount of error that a compression technique can introduce in an end effector
		/// Determines the current setting for world - space error tolerance in the animation compressor.
		/// When requested, animation being compressed will also consider an alternative compression
		/// method if the end result of that method produces less error than the AlternativeCompressionThreshold.
		/// Also known as "Alternative Compression Threshold"
		/// </summary>
		public float MaxEndEffectorError
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+MaxEndEffectorError__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+MaxEndEffectorError__Offset, false);}
			
		}
		
		static readonly int bTryFixedBitwiseCompression__Offset;
		/// <summary>If true, the uniform bitwise techniques will be tried</summary>
		public bool bTryFixedBitwiseCompression
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bTryFixedBitwiseCompression__Offset, 1, 0, 1, 1);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bTryFixedBitwiseCompression__Offset, 1,0,1,1);}
			
		}
		
		static readonly int bTryPerTrackBitwiseCompression__Offset;
		/// <summary>If true, the per-track compressor techniques will be tried</summary>
		public bool bTryPerTrackBitwiseCompression
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bTryPerTrackBitwiseCompression__Offset, 1, 0, 2, 2);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bTryPerTrackBitwiseCompression__Offset, 1,0,2,2);}
			
		}
		
		static readonly int bTryLinearKeyRemovalCompression__Offset;
		/// <summary>If true, the linear key removal techniques will be tried</summary>
		public bool bTryLinearKeyRemovalCompression
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bTryLinearKeyRemovalCompression__Offset, 1, 0, 4, 4);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bTryLinearKeyRemovalCompression__Offset, 1,0,4,4);}
			
		}
		
		static readonly int bTryIntervalKeyRemoval__Offset;
		/// <summary>If true, the resampling techniques will be tried</summary>
		public bool bTryIntervalKeyRemoval
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bTryIntervalKeyRemoval__Offset, 1, 0, 8, 8);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bTryIntervalKeyRemoval__Offset, 1,0,8,8);}
			
		}
		
		static readonly int bRunCurrentDefaultCompressor__Offset;
		/// <summary>
		/// If true, then the animation will be first recompressed with it's current compressor if non-NULL, or with the global default compressor (specified in the engine ini)
		/// Also known as "First Recompress Using Current Or Default"
		/// </summary>
		public bool bRunCurrentDefaultCompressor
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bRunCurrentDefaultCompressor__Offset, 1, 0, 16, 16);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bRunCurrentDefaultCompressor__Offset, 1,0,16,16);}
			
		}
		
		static readonly int bAutoReplaceIfExistingErrorTooGreat__Offset;
		/// <summary>
		/// If true and the existing compression error is greater than Max End Effector Error, then any compression technique (even one that increases the size) with a lower error will be used until it falls below the threshold
		/// Also known as "force below threshold"
		/// </summary>
		public bool bAutoReplaceIfExistingErrorTooGreat
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bAutoReplaceIfExistingErrorTooGreat__Offset, 1, 0, 32, 32);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bAutoReplaceIfExistingErrorTooGreat__Offset, 1,0,32,32);}
			
		}
		
		static readonly int bRaiseMaxErrorToExisting__Offset;
		/// <summary>If true and the existing compression error is greater than Max End Effector Error, then Max End Effector Error will be effectively raised to the existing error level</summary>
		public bool bRaiseMaxErrorToExisting
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bRaiseMaxErrorToExisting__Offset, 1, 0, 64, 64);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bRaiseMaxErrorToExisting__Offset, 1,0,64,64);}
			
		}
		
		static UAnimCompress_Automatic()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("AnimCompress_Automatic");
			MaxEndEffectorError__Offset=GetPropertyOffset(NativeClassPtr,"MaxEndEffectorError");
			bTryFixedBitwiseCompression__Offset=GetPropertyOffset(NativeClassPtr,"bTryFixedBitwiseCompression");
			bTryPerTrackBitwiseCompression__Offset=GetPropertyOffset(NativeClassPtr,"bTryPerTrackBitwiseCompression");
			bTryLinearKeyRemovalCompression__Offset=GetPropertyOffset(NativeClassPtr,"bTryLinearKeyRemovalCompression");
			bTryIntervalKeyRemoval__Offset=GetPropertyOffset(NativeClassPtr,"bTryIntervalKeyRemoval");
			bRunCurrentDefaultCompressor__Offset=GetPropertyOffset(NativeClassPtr,"bRunCurrentDefaultCompressor");
			bAutoReplaceIfExistingErrorTooGreat__Offset=GetPropertyOffset(NativeClassPtr,"bAutoReplaceIfExistingErrorTooGreat");
			bRaiseMaxErrorToExisting__Offset=GetPropertyOffset(NativeClassPtr,"bRaiseMaxErrorToExisting");
			
		}
		
	}
	
}
#endif
#endif
