#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class UMaterialInterface
	{
		static readonly int SubsurfaceProfile__Offset;
		/// <summary>SubsurfaceProfile, for Screen Space Subsurface Scattering</summary>
		public USubsurfaceProfile SubsurfaceProfile
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + SubsurfaceProfile__Offset); if (v == IntPtr.Zero)return null; USubsurfaceProfile retValue = new USubsurfaceProfile(); retValue._this = v; return retValue; }
			set{ CheckIsValid(); if (value == null)Marshal.WriteIntPtr(_this.Get() + SubsurfaceProfile__Offset, IntPtr.Zero);else Marshal.WriteIntPtr(_this.Get() + SubsurfaceProfile__Offset, value._this.Get()); }
			
		}
		
		static readonly int LightmassSettings__Offset;
		/// <summary>The Lightmass settings for this object.</summary>
		public FLightmassMaterialInterfaceSettings LightmassSettings
		{
			get{ CheckIsValid();return (FLightmassMaterialInterfaceSettings)Marshal.PtrToStructure(_this.Get()+LightmassSettings__Offset, typeof(FLightmassMaterialInterfaceSettings));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+LightmassSettings__Offset, false);}
			
		}
		
		static readonly int bTextureStreamingDataSorted__Offset;
		/// <summary>Because of redirector, the texture names need to be resorted at each load in case they changed.</summary>
		public bool bTextureStreamingDataSorted
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bTextureStreamingDataSorted__Offset, 1, 0, 1, 255);}
			
		}
		
		static readonly int TextureStreamingData__Offset;
		/// <summary>Data used by the texture streaming to know how each texture is sampled by the material. Sorted by names for quick access.</summary>
		public TStructArray<FMaterialTextureInfo> TextureStreamingData
		{
			get{ CheckIsValid();return new TStructArray<FMaterialTextureInfo>((FScriptArray)Marshal.PtrToStructure(_this.Get()+TextureStreamingData__Offset, typeof(FScriptArray)));}
					set{ CheckIsValid();Marshal.StructureToPtr(value.InterArray, _this.Get()+TextureStreamingData__Offset, false);}
			
		}
		
		static readonly int PreviewMesh__Offset;
		/// <summary>The mesh used by the material editor to preview the material.</summary>
		public FStringAssetReference PreviewMesh
		{
			get{ CheckIsValid();return (FStringAssetReference)Marshal.PtrToStructure(_this.Get()+PreviewMesh__Offset, typeof(FStringAssetReference));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+PreviewMesh__Offset, false);}
			
		}
		
		static readonly int ThumbnailInfo__Offset;
		/// <summary>Information for thumbnail rendering</summary>
		public UThumbnailInfo ThumbnailInfo
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + ThumbnailInfo__Offset); if (v == IntPtr.Zero)return null; UThumbnailInfo retValue = new UThumbnailInfo(); retValue._this = v; return retValue; }
			set{ CheckIsValid(); if (value == null)Marshal.WriteIntPtr(_this.Get() + ThumbnailInfo__Offset, IntPtr.Zero);else Marshal.WriteIntPtr(_this.Get() + ThumbnailInfo__Offset, value._this.Get()); }
			
		}
		
		static readonly int LightingGuid__Offset;
		/// <summary>Unique ID for this material, used for caching during distributed lighting</summary>
		public FGuid LightingGuid
		{
			get{ CheckIsValid();return (FGuid)Marshal.PtrToStructure(_this.Get()+LightingGuid__Offset, typeof(FGuid));}
			
		}
		
		static UMaterialInterface()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("MaterialInterface");
			SubsurfaceProfile__Offset=GetPropertyOffset(NativeClassPtr,"SubsurfaceProfile");
			LightmassSettings__Offset=GetPropertyOffset(NativeClassPtr,"LightmassSettings");
			bTextureStreamingDataSorted__Offset=GetPropertyOffset(NativeClassPtr,"bTextureStreamingDataSorted");
			TextureStreamingData__Offset=GetPropertyOffset(NativeClassPtr,"TextureStreamingData");
			PreviewMesh__Offset=GetPropertyOffset(NativeClassPtr,"PreviewMesh");
			ThumbnailInfo__Offset=GetPropertyOffset(NativeClassPtr,"ThumbnailInfo");
			LightingGuid__Offset=GetPropertyOffset(NativeClassPtr,"LightingGuid");
			
		}
		
	}
	
}
#endif
#endif
