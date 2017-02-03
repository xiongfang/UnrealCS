#if WITH_GAME
#if PLATFORM_32BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class UTexture
	{
		static readonly int LightingGuid__Offset;
		public FGuid LightingGuid
		{
			get{ CheckIsValid();return (FGuid)Marshal.PtrToStructure(_this.Get()+LightingGuid__Offset, typeof(FGuid));}
			
		}
		
		static readonly int LODBias__Offset;
		public int LODBias
		{
			get{ CheckIsValid();return (int)Marshal.PtrToStructure(_this.Get()+LODBias__Offset, typeof(int));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+LODBias__Offset, false);}
			
		}
		
		static readonly int NumCinematicMipLevels__Offset;
		public int NumCinematicMipLevels
		{
			get{ CheckIsValid();return (int)Marshal.PtrToStructure(_this.Get()+NumCinematicMipLevels__Offset, typeof(int));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+NumCinematicMipLevels__Offset, false);}
			
		}
		
		static readonly int SRGB__Offset;
		public bool SRGB
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), SRGB__Offset, 1, 0, 1, 1);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), SRGB__Offset, 1,0,1,1);}
			
		}
		
		static readonly int NeverStream__Offset;
		public bool NeverStream
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), NeverStream__Offset, 1, 0, 2, 2);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), NeverStream__Offset, 1,0,2,2);}
			
		}
		
		static readonly int bNoTiling__Offset;
		public bool bNoTiling
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bNoTiling__Offset, 1, 0, 4, 4);}
			
		}
		
		static readonly int bUseCinematicMipLevels__Offset;
		public bool bUseCinematicMipLevels
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bUseCinematicMipLevels__Offset, 1, 0, 8, 8);}
			
		}
		
		static readonly int AssetUserData__Offset;
		public TObjectArray<UAssetUserData>  AssetUserData
		{
					get{ CheckIsValid();return new TObjectArray<UAssetUserData>((FScriptArray)Marshal.PtrToStructure(_this.Get()+AssetUserData__Offset, typeof(FScriptArray)));}
					set{ CheckIsValid();Marshal.StructureToPtr(value.InterArray, _this.Get()+AssetUserData__Offset, false);}
			
		}
		
		static readonly int CachedCombinedLODBias__Offset;
		public int CachedCombinedLODBias
		{
			get{ CheckIsValid();return (int)Marshal.PtrToStructure(_this.Get()+CachedCombinedLODBias__Offset, typeof(int));}
			
		}
		
		static readonly int bAsyncResourceReleaseHasBeenStarted__Offset;
		public bool bAsyncResourceReleaseHasBeenStarted
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bAsyncResourceReleaseHasBeenStarted__Offset, 1, 0, 1, 1);}
			
		}
		
		static readonly int CompressionSettings__Offset;
		public TextureCompressionSettings CompressionSettings
		{
			get{ CheckIsValid();return (TextureCompressionSettings)Marshal.PtrToStructure(_this.Get()+CompressionSettings__Offset, typeof(TextureCompressionSettings));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+CompressionSettings__Offset, false);}
			
		}
		
		static readonly int Filter__Offset;
		public TextureFilter Filter
		{
			get{ CheckIsValid();return (TextureFilter)Marshal.PtrToStructure(_this.Get()+Filter__Offset, typeof(TextureFilter));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+Filter__Offset, false);}
			
		}
		
		static readonly int LODGroup__Offset;
		public TextureGroup LODGroup
		{
			get{ CheckIsValid();return (TextureGroup)Marshal.PtrToStructure(_this.Get()+LODGroup__Offset, typeof(TextureGroup));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+LODGroup__Offset, false);}
			
		}
		
		static UTexture()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("Texture");
			LightingGuid__Offset=GetPropertyOffset(NativeClassPtr,"LightingGuid");
			LODBias__Offset=GetPropertyOffset(NativeClassPtr,"LODBias");
			NumCinematicMipLevels__Offset=GetPropertyOffset(NativeClassPtr,"NumCinematicMipLevels");
			SRGB__Offset=GetPropertyOffset(NativeClassPtr,"SRGB");
			NeverStream__Offset=GetPropertyOffset(NativeClassPtr,"NeverStream");
			bNoTiling__Offset=GetPropertyOffset(NativeClassPtr,"bNoTiling");
			bUseCinematicMipLevels__Offset=GetPropertyOffset(NativeClassPtr,"bUseCinematicMipLevels");
			AssetUserData__Offset=GetPropertyOffset(NativeClassPtr,"AssetUserData");
			CachedCombinedLODBias__Offset=GetPropertyOffset(NativeClassPtr,"CachedCombinedLODBias");
			bAsyncResourceReleaseHasBeenStarted__Offset=GetPropertyOffset(NativeClassPtr,"bAsyncResourceReleaseHasBeenStarted");
			CompressionSettings__Offset=GetPropertyOffset(NativeClassPtr,"CompressionSettings");
			Filter__Offset=GetPropertyOffset(NativeClassPtr,"Filter");
			LODGroup__Offset=GetPropertyOffset(NativeClassPtr,"LODGroup");
			
		}
		
	}
	
}
#endif
#endif
