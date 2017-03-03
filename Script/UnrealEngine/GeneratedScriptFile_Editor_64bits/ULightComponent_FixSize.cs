#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class ULightComponent
	{
		static readonly int Temperature__Offset;
		/// <summary>
		/// Color temperature in Kelvin of the blackbody illuminant.
		/// White (D65) is 6500K.
		/// </summary>
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
		/// <summary>false: use white (D65) as illuminant.</summary>
		public bool bUseTemperature
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bUseTemperature__Offset, 1, 0, 1, 1);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bUseTemperature__Offset, 1,0,1,1);}
			
		}
		
		static readonly int ShadowMapChannel__Offset;
		/// <summary>Legacy shadowmap channel from the lighting build, now stored in FLightComponentMapBuildData.</summary>
		public int ShadowMapChannel
		{
			get{ CheckIsValid();return (int)Marshal.PtrToStructure(_this.Get()+ShadowMapChannel__Offset, typeof(int));}
			
		}
		
		static readonly int MinRoughness__Offset;
		/// <summary>Min roughness effective for this light. Used for softening specular highlights.</summary>
		public float MinRoughness
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+MinRoughness__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+MinRoughness__Offset, false);}
			
		}
		
		static readonly int ShadowResolutionScale__Offset;
		/// <summary>
		/// Scales the resolution of shadowmaps used to shadow this light.  By default shadowmap resolution is chosen based on screen size of the caster.
		/// Note: shadowmap resolution is still clamped by 'r.Shadow.MaxResolution'
		/// </summary>
		public float ShadowResolutionScale
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+ShadowResolutionScale__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+ShadowResolutionScale__Offset, false);}
			
		}
		
		static readonly int ShadowBias__Offset;
		/// <summary>
		/// Controls how accurate self shadowing of whole scene shadows from this light are.
		/// At 0, shadows will start at the their caster surface, but there will be many self shadowing artifacts.
		/// larger values, shadows will start further from their caster, and there won't be self shadowing artifacts but object might appear to fly.
		/// around 0.5 seems to be a good tradeoff. This also affects the soft transition of shadows
		/// </summary>
		public float ShadowBias
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+ShadowBias__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+ShadowBias__Offset, false);}
			
		}
		
		static readonly int ShadowSharpen__Offset;
		/// <summary>Amount to sharpen shadow filtering</summary>
		public float ShadowSharpen
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+ShadowSharpen__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+ShadowSharpen__Offset, false);}
			
		}
		
		static readonly int ContactShadowLength__Offset;
		/// <summary>Length of screen space ray trace for sharp contact shadows. Zero is disabled.</summary>
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
		/// <summary>Whether the light is allowed to cast dynamic shadows from translucency.</summary>
		public bool CastTranslucentShadows
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), CastTranslucentShadows__Offset, 1, 0, 2, 2);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), CastTranslucentShadows__Offset, 1,0,2,2);}
			
		}
		
		static readonly int bCastShadowsFromCinematicObjectsOnly__Offset;
		/// <summary>
		/// Whether the light should only cast shadows from components marked as bCastCinematicShadows.
		/// This is useful for setting up cinematic Movable spotlights aimed at characters and avoiding the shadow depth rendering costs of the background.
		/// Note: this only works with dynamic shadow maps, not with static shadowing or Ray Traced Distance Field shadows.
		/// </summary>
		public bool bCastShadowsFromCinematicObjectsOnly
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bCastShadowsFromCinematicObjectsOnly__Offset, 1, 0, 4, 4);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bCastShadowsFromCinematicObjectsOnly__Offset, 1,0,4,4);}
			
		}
		
		static readonly int bAffectDynamicIndirectLighting__Offset;
		/// <summary>Whether the light should be injected into the Light Propagation Volume</summary>
		public bool bAffectDynamicIndirectLighting
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bAffectDynamicIndirectLighting__Offset, 1, 0, 8, 8);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bAffectDynamicIndirectLighting__Offset, 1,0,8,8);}
			
		}
		
		static readonly int LightingChannels__Offset;
		/// <summary>
		/// Channels that this light should affect.
		/// These channels only apply to opaque materials, direct lighting, and dynamic lighting and shadowing.
		/// </summary>
		public FLightingChannels LightingChannels
		{
			get{ CheckIsValid();return (FLightingChannels)Marshal.PtrToStructure(_this.Get()+LightingChannels__Offset, typeof(FLightingChannels));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+LightingChannels__Offset, false);}
			
		}
		
		static readonly int LightFunctionMaterial__Offset;
		/// <summary>
		/// The light function material to be applied to this light.
		/// Note that only non-lightmapped lights (UseDirectLightMap=False) can have a light function.
		/// </summary>
		public UMaterialInterface LightFunctionMaterial
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + LightFunctionMaterial__Offset); if (v == IntPtr.Zero)return null; UMaterialInterface retValue = new UMaterialInterface(); retValue._this = v; return retValue; }
			set{ CheckIsValid(); if (value == null)Marshal.WriteIntPtr(_this.Get() + LightFunctionMaterial__Offset, IntPtr.Zero);else Marshal.WriteIntPtr(_this.Get() + LightFunctionMaterial__Offset, value._this.Get()); }
			
		}
		
		static readonly int LightFunctionScale__Offset;
		/// <summary>Scales the light function projection.  X and Y scale in the directions perpendicular to the light's direction, Z scales along the light direction.</summary>
		public FVector LightFunctionScale
		{
			get{ CheckIsValid();return (FVector)Marshal.PtrToStructure(_this.Get()+LightFunctionScale__Offset, typeof(FVector));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+LightFunctionScale__Offset, false);}
			
		}
		
		static readonly int IESTexture__Offset;
		/// <summary>IES texture (light profiles from real world measured data)</summary>
		public UTextureLightProfile IESTexture
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + IESTexture__Offset); if (v == IntPtr.Zero)return null; UTextureLightProfile retValue = new UTextureLightProfile(); retValue._this = v; return retValue; }
			set{ CheckIsValid(); if (value == null)Marshal.WriteIntPtr(_this.Get() + IESTexture__Offset, IntPtr.Zero);else Marshal.WriteIntPtr(_this.Get() + IESTexture__Offset, value._this.Get()); }
			
		}
		
		static readonly int bUseIESBrightness__Offset;
		/// <summary>true: take light brightness from IES profile, false: use the light brightness - the maximum light in one direction is used to define no masking. Use with InverseSquareFalloff. Will be disabled if a valid IES profile texture is not supplied.</summary>
		public bool bUseIESBrightness
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bUseIESBrightness__Offset, 1, 0, 1, 1);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bUseIESBrightness__Offset, 1,0,1,1);}
			
		}
		
		static readonly int IESBrightnessScale__Offset;
		/// <summary>Global scale for IES brightness contribution. Only available when "Use IES Brightness" is selected, and a valid IES profile texture is set</summary>
		public float IESBrightnessScale
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+IESBrightnessScale__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+IESBrightnessScale__Offset, false);}
			
		}
		
		static readonly int LightFunctionFadeDistance__Offset;
		/// <summary>
		/// Distance at which the light function should be completely faded to DisabledBrightness.
		/// This is useful for hiding aliasing from light functions applied in the distance.
		/// </summary>
		public float LightFunctionFadeDistance
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+LightFunctionFadeDistance__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+LightFunctionFadeDistance__Offset, false);}
			
		}
		
		static readonly int DisabledBrightness__Offset;
		/// <summary>
		/// Brightness factor applied to the light when the light function is specified but disabled, for example in scene captures that use SceneCapView_LitNoShadows.
		/// This should be set to the average brightness of the light function material's emissive input, which should be between 0 and 1.
		/// </summary>
		public float DisabledBrightness
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+DisabledBrightness__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+DisabledBrightness__Offset, false);}
			
		}
		
		static readonly int bEnableLightShaftBloom__Offset;
		/// <summary>
		/// Whether to render light shaft bloom from this light.
		/// For directional lights, the color around the light direction will be blurred radially and added back to the scene.
		/// for point lights, the color on pixels closer than the light's SourceRadius will be blurred radially and added back to the scene.
		/// </summary>
		public bool bEnableLightShaftBloom
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bEnableLightShaftBloom__Offset, 1, 0, 1, 1);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bEnableLightShaftBloom__Offset, 1,0,1,1);}
			
		}
		
		static readonly int BloomScale__Offset;
		/// <summary>Scales the additive color.</summary>
		public float BloomScale
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+BloomScale__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+BloomScale__Offset, false);}
			
		}
		
		static readonly int BloomThreshold__Offset;
		/// <summary>Scene color must be larger than this to create bloom in the light shafts.</summary>
		public float BloomThreshold
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+BloomThreshold__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+BloomThreshold__Offset, false);}
			
		}
		
		static readonly int BloomTint__Offset;
		/// <summary>Multiplies against scene color to create the bloom color.</summary>
		public FColor BloomTint
		{
			get{ CheckIsValid();return (FColor)Marshal.PtrToStructure(_this.Get()+BloomTint__Offset, typeof(FColor));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+BloomTint__Offset, false);}
			
		}
		
		static readonly int bUseRayTracedDistanceFieldShadows__Offset;
		/// <summary>
		/// Whether to use ray traced distance field area shadows.  The project setting bGenerateMeshDistanceFields must be enabled for this to have effect.
		/// Distance field shadows support area lights so they create soft shadows with sharp contacts.
		/// They have less aliasing artifacts than standard shadowmaps, but inherit all the limitations of distance field representations (only uniform scale, no deformation).
		/// These shadows have a low per-object cost (and don't depend on triangle count) so they are effective for distant shadows from a dynamic sun.
		/// </summary>
		public bool bUseRayTracedDistanceFieldShadows
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bUseRayTracedDistanceFieldShadows__Offset, 1, 0, 1, 255);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bUseRayTracedDistanceFieldShadows__Offset, 1,0,1,255);}
			
		}
		
		static readonly int RayStartOffsetDepthScale__Offset;
		/// <summary>
		/// Controls how large of an offset ray traced shadows have from the receiving surface as the camera gets further away.
		/// This can be useful to hide self-shadowing artifacts from low resolution distance fields on huge static meshes.
		/// </summary>
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
