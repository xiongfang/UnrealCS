#if WITH_GAME
#if PLATFORM_32BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class UAnimCompress_Automatic
	{
		static readonly int MaxEndEffectorError__Offset;
		public float MaxEndEffectorError
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+MaxEndEffectorError__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+MaxEndEffectorError__Offset, false);}
			
		}
		
		static readonly int bTryFixedBitwiseCompression__Offset;
		public bool bTryFixedBitwiseCompression
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bTryFixedBitwiseCompression__Offset, 1, 0, 1, 1);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bTryFixedBitwiseCompression__Offset, 1,0,1,1);}
			
		}
		
		static readonly int bTryPerTrackBitwiseCompression__Offset;
		public bool bTryPerTrackBitwiseCompression
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bTryPerTrackBitwiseCompression__Offset, 1, 0, 2, 2);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bTryPerTrackBitwiseCompression__Offset, 1,0,2,2);}
			
		}
		
		static readonly int bTryLinearKeyRemovalCompression__Offset;
		public bool bTryLinearKeyRemovalCompression
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bTryLinearKeyRemovalCompression__Offset, 1, 0, 4, 4);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bTryLinearKeyRemovalCompression__Offset, 1,0,4,4);}
			
		}
		
		static readonly int bTryIntervalKeyRemoval__Offset;
		public bool bTryIntervalKeyRemoval
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bTryIntervalKeyRemoval__Offset, 1, 0, 8, 8);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bTryIntervalKeyRemoval__Offset, 1,0,8,8);}
			
		}
		
		static readonly int bRunCurrentDefaultCompressor__Offset;
		public bool bRunCurrentDefaultCompressor
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bRunCurrentDefaultCompressor__Offset, 1, 0, 16, 16);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bRunCurrentDefaultCompressor__Offset, 1,0,16,16);}
			
		}
		
		static readonly int bAutoReplaceIfExistingErrorTooGreat__Offset;
		public bool bAutoReplaceIfExistingErrorTooGreat
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bAutoReplaceIfExistingErrorTooGreat__Offset, 1, 0, 32, 32);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bAutoReplaceIfExistingErrorTooGreat__Offset, 1,0,32,32);}
			
		}
		
		static readonly int bRaiseMaxErrorToExisting__Offset;
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
