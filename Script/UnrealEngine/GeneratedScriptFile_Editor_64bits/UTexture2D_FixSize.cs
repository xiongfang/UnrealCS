#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class UTexture2D
	{
		static readonly int RequestedMips__Offset;
		/// <summary>Number of miplevels the texture should have resident.</summary>
		public int RequestedMips
		{
			get{ CheckIsValid();return (int)Marshal.PtrToStructure(_this.Get()+RequestedMips__Offset, typeof(int));}
			
		}
		
		static readonly int ResidentMips__Offset;
		/// <summary>Number of miplevels currently resident.</summary>
		public int ResidentMips
		{
			get{ CheckIsValid();return (int)Marshal.PtrToStructure(_this.Get()+ResidentMips__Offset, typeof(int));}
			
		}
		
		static readonly int StreamingIndex__Offset;
		/// <summary>FStreamingTexture index used by the texture streaming system.</summary>
		public int StreamingIndex
		{
			get{ CheckIsValid();return (int)Marshal.PtrToStructure(_this.Get()+StreamingIndex__Offset, typeof(int));}
			
		}
		
		static readonly int LevelIndex__Offset;
		/// <summary>
		/// * Level scope index of this texture. It is used to reduce the amount of lookup to map a texture to its level index.
		/// * Useful when building texture streaming data, as well as when filling the texture streamer with precomputed data.
		/// * It relates to FStreamingTextureBuildInfo::TextureLevelIndex and also the index in ULevel::StreamingTextureGuids.
		/// * Default value of -1, indicates that the texture has an unknown index (not yet processed). At level load time,
		/// * -2 is also used to indicate that the texture has been processed but no entry were found in the level table.
		/// * After any of these processes, the LevelIndex is reset to INDEX_NONE. Making it ready for the next level task.
		/// </summary>
		public int LevelIndex
		{
			get{ CheckIsValid();return (int)Marshal.PtrToStructure(_this.Get()+LevelIndex__Offset, typeof(int));}
			
		}
		
		static readonly int FirstResourceMemMip__Offset;
		/// <summary>keep track of first mip level used for ResourceMem creation</summary>
		public int FirstResourceMemMip
		{
			get{ CheckIsValid();return (int)Marshal.PtrToStructure(_this.Get()+FirstResourceMemMip__Offset, typeof(int));}
			
		}
		
		static readonly int ImportedSize__Offset;
		/// <summary>
		/// The imported size of the texture. Only valid on cooked builds when texture source is not
		/// available. Access ONLY via the GetImportedSize() accessor!
		/// </summary>
		public FIntPoint ImportedSize
		{
			get{ CheckIsValid();return (FIntPoint)Marshal.PtrToStructure(_this.Get()+ImportedSize__Offset, typeof(FIntPoint));}
			
		}
		
		static readonly int ForceMipLevelsToBeResidentTimestamp__Offset;
		/// <summary>WorldSettings timestamp that tells the streamer to force all miplevels to be resident up until that time.</summary>
		public double ForceMipLevelsToBeResidentTimestamp
		{
			get{ CheckIsValid();return (double)Marshal.PtrToStructure(_this.Get()+ForceMipLevelsToBeResidentTimestamp__Offset, typeof(double));}
			
		}
		
		static readonly int bTemporarilyDisableStreaming__Offset;
		/// <summary>
		/// True if streaming is temporarily disabled so we can update subregions of this texture's resource
		///       without streaming clobbering it. Automatically cleared before saving.
		/// </summary>
		public bool bTemporarilyDisableStreaming
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bTemporarilyDisableStreaming__Offset, 1, 0, 1, 1);}
			
		}
		
		static readonly int bIsStreamable__Offset;
		/// <summary>Whether the texture is currently streamable or not.</summary>
		public bool bIsStreamable
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bIsStreamable__Offset, 1, 0, 2, 2);}
			
		}
		
		static readonly int bHasStreamingUpdatePending__Offset;
		/// <summary>Whether some mips might be streamed soon. If false, the texture is not planned resolution will be stable.</summary>
		public bool bHasStreamingUpdatePending
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bHasStreamingUpdatePending__Offset, 1, 0, 4, 4);}
			
		}
		
		static readonly int bHasCancelationPending__Offset;
		/// <summary>Whether the current texture mip change request is pending cancellation.</summary>
		public bool bHasCancelationPending
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bHasCancelationPending__Offset, 1, 0, 8, 8);}
			
		}
		
		static readonly int bForceMiplevelsToBeResident__Offset;
		/// <summary>Override whether to fully stream even if texture hasn't been rendered.</summary>
		public bool bForceMiplevelsToBeResident
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bForceMiplevelsToBeResident__Offset, 1, 0, 16, 16);}
			
		}
		
		static readonly int bIgnoreStreamingMipBias__Offset;
		/// <summary>Ignores the streaming mip bias used to accommodate memory constraints.</summary>
		public bool bIgnoreStreamingMipBias
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bIgnoreStreamingMipBias__Offset, 1, 0, 32, 32);}
			
		}
		
		static readonly int bGlobalForceMipLevelsToBeResident__Offset;
		/// <summary>Global and serialized version of ForceMiplevelsToBeResident.</summary>
		public bool bGlobalForceMipLevelsToBeResident
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bGlobalForceMipLevelsToBeResident__Offset, 1, 0, 64, 64);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bGlobalForceMipLevelsToBeResident__Offset, 1,0,64,64);}
			
		}
		
		static readonly int bHasBeenPaintedInEditor__Offset;
		/// <summary>Whether the texture has been painted in the editor.</summary>
		public bool bHasBeenPaintedInEditor
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bHasBeenPaintedInEditor__Offset, 1, 0, 128, 128);}
			
		}
		
		static readonly int AddressX__Offset;
		/// <summary>The addressing mode to use for the X axis.</summary>
		public TextureAddress AddressX
		{
			get{ CheckIsValid();return (TextureAddress)Marshal.PtrToStructure(_this.Get()+AddressX__Offset, typeof(TextureAddress));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+AddressX__Offset, false);}
			
		}
		
		static readonly int AddressY__Offset;
		/// <summary>The addressing mode to use for the Y axis.</summary>
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
			bHasBeenPaintedInEditor__Offset=GetPropertyOffset(NativeClassPtr,"bHasBeenPaintedInEditor");
			AddressX__Offset=GetPropertyOffset(NativeClassPtr,"AddressX");
			AddressY__Offset=GetPropertyOffset(NativeClassPtr,"AddressY");
			
		}
		
	}
	
}
#endif
#endif
