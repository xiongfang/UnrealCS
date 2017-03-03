#if WITH_GAME
#if PLATFORM_32BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class ULightComponent
	{
		static readonly int Temperature__Offset;
		public float Temperature
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+Temperature__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+Temperature__Offset, false);}
			
		}
		
		static readonly int MaxDrawDistance__Offset;
		public float MaxDrawDistance
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+MaxDrawDistance__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+MaxDrawDistance__Offset, false);}
			
		}
		
		static readonly int MaxDistanceFadeRange__Offset;
		public float MaxDistanceFadeRange
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+MaxDistanceFadeRange__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+MaxDistanceFadeRange__Offset, false);}
			
		}
		
		static readonly int bUseTemperature__Offset;
		public bool bUseTemperature
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bUseTemperature__Offset, 1, 0, 1, 1);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bUseTemperature__Offset, 1,0,1,1);}
			
		}
		
		static readonly int ShadowMapChannel__Offset;
		public int ShadowMapChannel
		{
			get{ CheckIsValid();return (int)Marshal.PtrToStructure(_this.Get()+ShadowMapChannel__Offset, typeof(int));}
			
		}
		
		static readonly int MinRoughness__Offset;
		public float MinRoughness
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+MinRoughness__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+MinRoughness__Offset, false);}
			
		}
		
		static readonly int ShadowResolutionScale__Offset;
		public float ShadowResolutionScale
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+ShadowResolutionScale__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+ShadowResolutionScale__Offset, false);}
			
		}
		
		static readonly int ShadowBias__Offset;
		public float ShadowBias
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+ShadowBias__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+ShadowBias__Offset, false);}
			
		}
		
		static readonly int ShadowSharpen__Offset;
		public float ShadowSharpen
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+ShadowSharpen__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+ShadowSharpen__Offset, false);}
			
		}
		
		static readonly int ContactShadowLength__Offset;
		public float ContactShadowLength
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+ContactShadowLength__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+ContactShadowLength__Offset, false);}
			
		}
		
		static readonly int InverseSquaredFalloff__Offset;
		public bool InverseSquaredFalloff
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), InverseSquaredFalloff__Offset, 1, 0, 1, 1);}
			
		}
		
		static readonly int CastTranslucentShadows__Offset;
		public bool CastTranslucentShadows
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), CastTranslucentShadows__Offset, 1, 0, 2, 2);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), CastTranslucentShadows__Offset, 1,0,2,2);}
			
		}
		
		static readonly int bCastShadowsFromCinematicObjectsOnly__Offset;
		public bool bCastShadowsFromCinematicObjectsOnly
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bCastShadowsFromCinematicObjectsOnly__Offset, 1, 0, 4, 4);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bCastShadowsFromCinematicObjectsOnly__Offset, 1,0,4,4);}
			
		}
		
		static readonly int bAffectDynamicIndirectLighting__Offset;
		public bool bAffectDynamicIndirectLighting
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bAffectDynamicIndirectLighting__Offset, 1, 0, 8, 8);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bAffectDynamicIndirectLighting__Offset, 1,0,8,8);}
			
		}
		
		static readonly int LightingChannels__Offset;
		public FLightingChannels LightingChannels
		{
			get{ CheckIsValid();return (FLightingChannels)Marshal.PtrToStructure(_this.Get()+LightingChannels__Offset, typeof(FLightingChannels));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+LightingChannels__Offset, false);}
			
		}
		
		static readonly int LightFunctionMaterial__Offset;
		public UMaterialInterface LightFunctionMaterial
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + LightFunctionMaterial__Offset); if (v == IntPtr.Zero)return null; UMaterialInterface retValue = new UMaterialInterface(); retValue._this = v; return retValue; }
			set{ CheckIsValid(); if (value == null)Marshal.WriteIntPtr(_this.Get() + LightFunctionMaterial__Offset, IntPtr.Zero);else Marshal.WriteIntPtr(_this.Get() + LightFunctionMaterial__Offset, value._this.Get()); }
			
		}
		
		static readonly int LightFunctionScale__Offset;
		public FVector LightFunctionScale
		{
			get{ CheckIsValid();return (FVector)Marshal.PtrToStructure(_this.Get()+LightFunctionScale__Offset, typeof(FVector));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+LightFunctionScale__Offset, false);}
			
		}
		
		static readonly int IESTexture__Offset;
		public UTextureLightProfile IESTexture
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + IESTexture__Offset); if (v == IntPtr.Zero)return null; UTextureLightProfile retValue = new UTextureLightProfile(); retValue._this = v; return retValue; }
			set{ CheckIsValid(); if (value == null)Marshal.WriteIntPtr(_this.Get() + IESTexture__Offset, IntPtr.Zero);else Marshal.WriteIntPtr(_this.Get() + IESTexture__Offset, value._this.Get()); }
			
		}
		
		static readonly int bUseIESBrightness__Offset;
		public bool bUseIESBrightness
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bUseIESBrightness__Offset, 1, 0, 1, 1);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bUseIESBrightness__Offset, 1,0,1,1);}
			
		}
		
		static readonly int IESBrightnessScale__Offset;
		public float IESBrightnessScale
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+IESBrightnessScale__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+IESBrightnessScale__Offset, false);}
			
		}
		
		static readonly int LightFunctionFadeDistance__Offset;
		public float LightFunctionFadeDistance
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+LightFunctionFadeDistance__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+LightFunctionFadeDistance__Offset, false);}
			
		}
		
		static readonly int DisabledBrightness__Offset;
		public float DisabledBrightness
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+DisabledBrightness__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+DisabledBrightness__Offset, false);}
			
		}
		
		static readonly int bEnableLightShaftBloom__Offset;
		public bool bEnableLightShaftBloom
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bEnableLightShaftBloom__Offset, 1, 0, 1, 1);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bEnableLightShaftBloom__Offset, 1,0,1,1);}
			
		}
		
		static readonly int BloomScale__Offset;
		public float BloomScale
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+BloomScale__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+BloomScale__Offset, false);}
			
		}
		
		static readonly int BloomThreshold__Offset;
		public float BloomThreshold
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+BloomThreshold__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+BloomThreshold__Offset, false);}
			
		}
		
		static readonly int BloomTint__Offset;
		public FColor BloomTint
		{
			get{ CheckIsValid();return (FColor)Marshal.PtrToStructure(_this.Get()+BloomTint__Offset, typeof(FColor));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+BloomTint__Offset, false);}
			
		}
		
		static readonly int bUseRayTracedDistanceFieldShadows__Offset;
		public bool bUseRayTracedDistanceFieldShadows
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bUseRayTracedDistanceFieldShadows__Offset, 1, 0, 1, 255);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bUseRayTracedDistanceFieldShadows__Offset, 1,0,1,255);}
			
		}
		
		static readonly int RayStartOffsetDepthScale__Offset;
		public float RayStartOffsetDepthScale
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+RayStartOffsetDepthScale__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+RayStartOffsetDepthScale__Offset, false);}
			
		}
		
		static ULightComponent()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("LightComponent");
			Temperature__Offset=GetPropertyOffset(NativeClassPtr,"Temperature");
			MaxDrawDistance__Offset=GetPropertyOffset(NativeClassPtr,"MaxDrawDistance");
			MaxDistanceFadeRange__Offset=GetPropertyOffset(NativeClassPtr,"MaxDistanceFadeRange");
			bUseTemperature__Offset=GetPropertyOffset(NativeClassPtr,"bUseTemperature");
			ShadowMapChannel__Offset=GetPropertyOffset(NativeClassPtr,"ShadowMapChannel");
			MinRoughness__Offset=GetPropertyOffset(NativeClassPtr,"MinRoughness");
			ShadowResolutionScale__Offset=GetPropertyOffset(NativeClassPtr,"ShadowResolutionScale");
			ShadowBias__Offset=GetPropertyOffset(NativeClassPtr,"ShadowBias");
			ShadowSharpen__Offset=GetPropertyOffset(NativeClassPtr,"ShadowSharpen");
			ContactShadowLength__Offset=GetPropertyOffset(NativeClassPtr,"ContactShadowLength");
			InverseSquaredFalloff__Offset=GetPropertyOffset(NativeClassPtr,"InverseSquaredFalloff");
			CastTranslucentShadows__Offset=GetPropertyOffset(NativeClassPtr,"CastTranslucentShadows");
			bCastShadowsFromCinematicObjectsOnly__Offset=GetPropertyOffset(NativeClassPtr,"bCastShadowsFromCinematicObjectsOnly");
			bAffectDynamicIndirectLighting__Offset=GetPropertyOffset(NativeClassPtr,"bAffectDynamicIndirectLighting");
			LightingChannels__Offset=GetPropertyOffset(NativeClassPtr,"LightingChannels");
			LightFunctionMaterial__Offset=GetPropertyOffset(NativeClassPtr,"LightFunctionMaterial");
			LightFunctionScale__Offset=GetPropertyOffset(NativeClassPtr,"LightFunctionScale");
			IESTexture__Offset=GetPropertyOffset(NativeClassPtr,"IESTexture");
			bUseIESBrightness__Offset=GetPropertyOffset(NativeClassPtr,"bUseIESBrightness");
			IESBrightnessScale__Offset=GetPropertyOffset(NativeClassPtr,"IESBrightnessScale");
			LightFunctionFadeDistance__Offset=GetPropertyOffset(NativeClassPtr,"LightFunctionFadeDistance");
			DisabledBrightness__Offset=GetPropertyOffset(NativeClassPtr,"DisabledBrightness");
			bEnableLightShaftBloom__Offset=GetPropertyOffset(NativeClassPtr,"bEnableLightShaftBloom");
			BloomScale__Offset=GetPropertyOffset(NativeClassPtr,"BloomScale");
			BloomThreshold__Offset=GetPropertyOffset(NativeClassPtr,"BloomThreshold");
			BloomTint__Offset=GetPropertyOffset(NativeClassPtr,"BloomTint");
			bUseRayTracedDistanceFieldShadows__Offset=GetPropertyOffset(NativeClassPtr,"bUseRayTracedDistanceFieldShadows");
			RayStartOffsetDepthScale__Offset=GetPropertyOffset(NativeClassPtr,"RayStartOffsetDepthScale");
			
		}
		
	}
	
}
#endif
#endif
