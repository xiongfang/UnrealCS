using System;
namespace UnrealEngine
{
	public partial class UTexture2D:UTexture
	{
		/// <summary>Number of miplevels the texture should have resident.</summary>
		public int RequestedMips;
		
		/// <summary>Number of miplevels currently resident.</summary>
		public int ResidentMips;
		
		/// <summary>FStreamingTexture index used by the texture streaming system.</summary>
		public int StreamingIndex;
		
		/// <summary>
		/// * Level scope index of this texture. It is used to reduce the amount of lookup to map a texture to its level index.
		/// * Useful when building texture streaming data, as well as when filling the texture streamer with precomputed data.
		/// * It relates to FStreamingTextureBuildInfo::TextureLevelIndex and also the index in ULevel::StreamingTextureGuids.
		/// * Default value of -1, indicates that the texture has an unknown index (not yet processed). At level load time,
		/// * -2 is also used to indicate that the texture has been processed but no entry were found in the level table.
		/// * After any of these processes, the LevelIndex is reset to INDEX_NONE. Making it ready for the next level task.
		/// </summary>
		public int LevelIndex;
		
		/// <summary>keep track of first mip level used for ResourceMem creation</summary>
		public int FirstResourceMemMip;
		
		/// <summary>
		/// The imported size of the texture. Only valid on cooked builds when texture source is not
		/// available. Access ONLY via the GetImportedSize() accessor!
		/// </summary>
		public FIntPoint ImportedSize;
		
		/// <summary>WorldSettings timestamp that tells the streamer to force all miplevels to be resident up until that time.</summary>
		public double ForceMipLevelsToBeResidentTimestamp;
		
		/// <summary>
		/// True if streaming is temporarily disabled so we can update subregions of this texture's resource
		///       without streaming clobbering it. Automatically cleared before saving.
		/// </summary>
		public bool bTemporarilyDisableStreaming;
		
		/// <summary>Whether the texture is currently streamable or not.</summary>
		public bool bIsStreamable;
		
		/// <summary>Whether some mips might be streamed soon. If false, the texture is not planned resolution will be stable.</summary>
		public bool bHasStreamingUpdatePending;
		
		/// <summary>Whether the current texture mip change request is pending cancellation.</summary>
		public bool bHasCancelationPending;
		
		/// <summary>Override whether to fully stream even if texture hasn't been rendered.</summary>
		public bool bForceMiplevelsToBeResident;
		
		/// <summary>Ignores the streaming mip bias used to accommodate memory constraints.</summary>
		public bool bIgnoreStreamingMipBias;
		
		/// <summary>Global and serialized version of ForceMiplevelsToBeResident.</summary>
		public bool bGlobalForceMipLevelsToBeResident;
		
		/// <summary>Whether the texture has been painted in the editor.</summary>
		public bool bHasBeenPaintedInEditor;
		
		/// <summary>The addressing mode to use for the X axis.</summary>
		public TextureAddress AddressX;
		
		/// <summary>The addressing mode to use for the Y axis.</summary>
		public TextureAddress AddressY;
		
		
	}
	
}
