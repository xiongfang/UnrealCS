#if WITH_GAME
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class UTexture2D
	{
		static readonly int RequestedMips__Offset;
		public int RequestedMips
		{
			get{ CheckIsValid();return (int)Marshal.PtrToStructure(_this.Get()+RequestedMips__Offset, typeof(int));}
			
		}
		
		static readonly int ResidentMips__Offset;
		public int ResidentMips
		{
			get{ CheckIsValid();return (int)Marshal.PtrToStructure(_this.Get()+ResidentMips__Offset, typeof(int));}
			
		}
		
		static readonly int StreamingIndex__Offset;
		public int StreamingIndex
		{
			get{ CheckIsValid();return (int)Marshal.PtrToStructure(_this.Get()+StreamingIndex__Offset, typeof(int));}
			
		}
		
		static readonly int LevelIndex__Offset;
		public int LevelIndex
		{
			get{ CheckIsValid();return (int)Marshal.PtrToStructure(_this.Get()+LevelIndex__Offset, typeof(int));}
			
		}
		
		static readonly int FirstResourceMemMip__Offset;
		public int FirstResourceMemMip
		{
			get{ CheckIsValid();return (int)Marshal.PtrToStructure(_this.Get()+FirstResourceMemMip__Offset, typeof(int));}
			
		}
		
		static readonly int ImportedSize__Offset;
		public FIntPoint ImportedSize
		{
			get{ CheckIsValid();return (FIntPoint)Marshal.PtrToStructure(_this.Get()+ImportedSize__Offset, typeof(FIntPoint));}
			
		}
		
		static readonly int ForceMipLevelsToBeResidentTimestamp__Offset;
		public double ForceMipLevelsToBeResidentTimestamp
		{
			get{ CheckIsValid();return (double)Marshal.PtrToStructure(_this.Get()+ForceMipLevelsToBeResidentTimestamp__Offset, typeof(double));}
			
		}
		
		static readonly int bTemporarilyDisableStreaming__Offset;
		public bool bTemporarilyDisableStreaming
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bTemporarilyDisableStreaming__Offset, 1, 0, 1, 1);}
			
		}
		
		static readonly int bIsStreamable__Offset;
		public bool bIsStreamable
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bIsStreamable__Offset, 1, 0, 2, 2);}
			
		}
		
		static readonly int bHasStreamingUpdatePending__Offset;
		public bool bHasStreamingUpdatePending
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bHasStreamingUpdatePending__Offset, 1, 0, 4, 4);}
			
		}
		
		static readonly int bHasCancelationPending__Offset;
		public bool bHasCancelationPending
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bHasCancelationPending__Offset, 1, 0, 8, 8);}
			
		}
		
		static readonly int bForceMiplevelsToBeResident__Offset;
		public bool bForceMiplevelsToBeResident
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bForceMiplevelsToBeResident__Offset, 1, 0, 16, 16);}
			
		}
		
		static readonly int bIgnoreStreamingMipBias__Offset;
		public bool bIgnoreStreamingMipBias
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bIgnoreStreamingMipBias__Offset, 1, 0, 32, 32);}
			
		}
		
		static readonly int bGlobalForceMipLevelsToBeResident__Offset;
		public bool bGlobalForceMipLevelsToBeResident
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bGlobalForceMipLevelsToBeResident__Offset, 1, 0, 64, 64);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bGlobalForceMipLevelsToBeResident__Offset, 1,0,64,64);}
			
		}
		
		static readonly int AddressX__Offset;
		public TextureAddress AddressX
		{
			get{ CheckIsValid();return (TextureAddress)Marshal.PtrToStructure(_this.Get()+AddressX__Offset, typeof(TextureAddress));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+AddressX__Offset, false);}
			
		}
		
		static readonly int AddressY__Offset;
		public TextureAddress AddressY
		{
			get{ CheckIsValid();return (TextureAddress)Marshal.PtrToStructure(_this.Get()+AddressY__Offset, typeof(TextureAddress));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+AddressY__Offset, false);}
			
		}
		
		static UTexture2D()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("Texture2D");
			RequestedMips__Offset=GetPropertyOffset(NativeClassPtr,"RequestedMips");
			ResidentMips__Offset=GetPropertyOffset(NativeClassPtr,"ResidentMips");
			StreamingIndex__Offset=GetPropertyOffset(NativeClassPtr,"StreamingIndex");
			LevelIndex__Offset=GetPropertyOffset(NativeClassPtr,"LevelIndex");
			FirstResourceMemMip__Offset=GetPropertyOffset(NativeClassPtr,"FirstResourceMemMip");
			ImportedSize__Offset=GetPropertyOffset(NativeClassPtr,"ImportedSize");
			ForceMipLevelsToBeResidentTimestamp__Offset=GetPropertyOffset(NativeClassPtr,"ForceMipLevelsToBeResidentTimestamp");
			bTemporarilyDisableStreaming__Offset=GetPropertyOffset(NativeClassPtr,"bTemporarilyDisableStreaming");
			bIsStreamable__Offset=GetPropertyOffset(NativeClassPtr,"bIsStreamable");
			bHasStreamingUpdatePending__Offset=GetPropertyOffset(NativeClassPtr,"bHasStreamingUpdatePending");
			bHasCancelationPending__Offset=GetPropertyOffset(NativeClassPtr,"bHasCancelationPending");
			bForceMiplevelsToBeResident__Offset=GetPropertyOffset(NativeClassPtr,"bForceMiplevelsToBeResident");
			bIgnoreStreamingMipBias__Offset=GetPropertyOffset(NativeClassPtr,"bIgnoreStreamingMipBias");
			bGlobalForceMipLevelsToBeResident__Offset=GetPropertyOffset(NativeClassPtr,"bGlobalForceMipLevelsToBeResident");
			AddressX__Offset=GetPropertyOffset(NativeClassPtr,"AddressX");
			AddressY__Offset=GetPropertyOffset(NativeClassPtr,"AddressY");
			
		}
		
	}
	
}
#endif
#endif
