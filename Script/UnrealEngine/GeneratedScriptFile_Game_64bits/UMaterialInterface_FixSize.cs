#if WITH_GAME
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class UMaterialInterface
	{
		static readonly int SubsurfaceProfile__Offset;
		public USubsurfaceProfile SubsurfaceProfile
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + SubsurfaceProfile__Offset); if (v == IntPtr.Zero)return null; USubsurfaceProfile retValue = new USubsurfaceProfile(); retValue._this = v; return retValue; }
			set{ CheckIsValid(); if (value == null)Marshal.WriteIntPtr(_this.Get() + SubsurfaceProfile__Offset, IntPtr.Zero);else Marshal.WriteIntPtr(_this.Get() + SubsurfaceProfile__Offset, value._this.Get()); }
			
		}
		
		static readonly int LightmassSettings__Offset;
		public FLightmassMaterialInterfaceSettings LightmassSettings
		{
			get{ CheckIsValid();return (FLightmassMaterialInterfaceSettings)Marshal.PtrToStructure(_this.Get()+LightmassSettings__Offset, typeof(FLightmassMaterialInterfaceSettings));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+LightmassSettings__Offset, false);}
			
		}
		
		static readonly int TextureStreamingData__Offset;
		public TStructArray<FMaterialTextureInfo> TextureStreamingData
		{
			get{ CheckIsValid();return new TStructArray<FMaterialTextureInfo>((FScriptArray)Marshal.PtrToStructure(_this.Get()+TextureStreamingData__Offset, typeof(FScriptArray)));}
					set{ CheckIsValid();Marshal.StructureToPtr(value.InterArray, _this.Get()+TextureStreamingData__Offset, false);}
			
		}
		
		static UMaterialInterface()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("MaterialInterface");
			SubsurfaceProfile__Offset=GetPropertyOffset(NativeClassPtr,"SubsurfaceProfile");
			LightmassSettings__Offset=GetPropertyOffset(NativeClassPtr,"LightmassSettings");
			TextureStreamingData__Offset=GetPropertyOffset(NativeClassPtr,"TextureStreamingData");
			
		}
		
	}
	
}
#endif
#endif
