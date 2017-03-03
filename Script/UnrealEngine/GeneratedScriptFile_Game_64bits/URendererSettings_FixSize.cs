#if WITH_GAME
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class URendererSettings
	{
		static readonly int bMobileHDR__Offset;
		public bool bMobileHDR
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bMobileHDR__Offset, 1, 0, 1, 1);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bMobileHDR__Offset, 1,0,1,1);}
			
		}
		
		static readonly int bMobileDisableVertexFog__Offset;
		public bool bMobileDisableVertexFog
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bMobileDisableVertexFog__Offset, 1, 0, 2, 2);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bMobileDisableVertexFog__Offset, 1,0,2,2);}
			
		}
		
		static readonly int MaxMobileCascades__Offset;
		public int MaxMobileCascades
		{
			get{ CheckIsValid();return (int)Marshal.PtrToStructure(_this.Get()+MaxMobileCascades__Offset, typeof(int));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+MaxMobileCascades__Offset, false);}
			
		}
		
		static readonly int MobileMSAASampleCount__Offset;
		public EMobileMSAASampleCount MobileMSAASampleCount
		{
			get{ CheckIsValid();return (EMobileMSAASampleCount)Marshal.PtrToStructure(_this.Get()+MobileMSAASampleCount__Offset, typeof(EMobileMSAASampleCount));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+MobileMSAASampleCount__Offset, false);}
			
		}
		
		static readonly int bDiscardUnusedQualityLevels__Offset;
		public bool bDiscardUnusedQualityLevels
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bDiscardUnusedQualityLevels__Offset, 1, 0, 1, 1);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bDiscardUnusedQualityLevels__Offset, 1,0,1,1);}
			
		}
		
		static readonly int bOcclusionCulling__Offset;
		public bool bOcclusionCulling
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bOcclusionCulling__Offset, 1, 0, 2, 2);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bOcclusionCulling__Offset, 1,0,2,2);}
			
		}
		
		static readonly int MinScreenRadiusForLights__Offset;
		public float MinScreenRadiusForLights
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+MinScreenRadiusForLights__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+MinScreenRadiusForLights__Offset, false);}
			
		}
		
		static readonly int MinScreenRadiusForEarlyZPass__Offset;
		public float MinScreenRadiusForEarlyZPass
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+MinScreenRadiusForEarlyZPass__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+MinScreenRadiusForEarlyZPass__Offset, false);}
			
		}
		
		static readonly int MinScreenRadiusForCSMdepth__Offset;
		public float MinScreenRadiusForCSMdepth
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+MinScreenRadiusForCSMdepth__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+MinScreenRadiusForCSMdepth__Offset, false);}
			
		}
		
		static readonly int bPrecomputedVisibilityWarning__Offset;
		public bool bPrecomputedVisibilityWarning
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bPrecomputedVisibilityWarning__Offset, 1, 0, 1, 1);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bPrecomputedVisibilityWarning__Offset, 1,0,1,1);}
			
		}
		
		static readonly int bTextureStreaming__Offset;
		public bool bTextureStreaming
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bTextureStreaming__Offset, 1, 0, 2, 2);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bTextureStreaming__Offset, 1,0,2,2);}
			
		}
		
		static readonly int bUseDXT5NormalMaps__Offset;
		public bool bUseDXT5NormalMaps
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bUseDXT5NormalMaps__Offset, 1, 0, 4, 4);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bUseDXT5NormalMaps__Offset, 1,0,4,4);}
			
		}
		
		static readonly int bClearCoatEnableSecondNormal__Offset;
		public bool bClearCoatEnableSecondNormal
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bClearCoatEnableSecondNormal__Offset, 1, 0, 8, 8);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bClearCoatEnableSecondNormal__Offset, 1,0,8,8);}
			
		}
		
		static readonly int ReflectionCaptureResolution__Offset;
		public int ReflectionCaptureResolution
		{
			get{ CheckIsValid();return (int)Marshal.PtrToStructure(_this.Get()+ReflectionCaptureResolution__Offset, typeof(int));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+ReflectionCaptureResolution__Offset, false);}
			
		}
		
		static readonly int ReflectionEnvironmentLightmapMixBasedOnRoughness__Offset;
		public bool ReflectionEnvironmentLightmapMixBasedOnRoughness
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), ReflectionEnvironmentLightmapMixBasedOnRoughness__Offset, 1, 0, 1, 1);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), ReflectionEnvironmentLightmapMixBasedOnRoughness__Offset, 1,0,1,1);}
			
		}
		
		static readonly int bForwardShading__Offset;
		public bool bForwardShading
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bForwardShading__Offset, 1, 0, 2, 2);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bForwardShading__Offset, 1,0,2,2);}
			
		}
		
		static readonly int bVertexFoggingForOpaque__Offset;
		public bool bVertexFoggingForOpaque
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bVertexFoggingForOpaque__Offset, 1, 0, 4, 4);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bVertexFoggingForOpaque__Offset, 1,0,4,4);}
			
		}
		
		static readonly int bAllowStaticLighting__Offset;
		public bool bAllowStaticLighting
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bAllowStaticLighting__Offset, 1, 0, 8, 8);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bAllowStaticLighting__Offset, 1,0,8,8);}
			
		}
		
		static readonly int bUseNormalMapsForStaticLighting__Offset;
		public bool bUseNormalMapsForStaticLighting
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bUseNormalMapsForStaticLighting__Offset, 1, 0, 16, 16);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bUseNormalMapsForStaticLighting__Offset, 1,0,16,16);}
			
		}
		
		static readonly int bGenerateMeshDistanceFields__Offset;
		public bool bGenerateMeshDistanceFields
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bGenerateMeshDistanceFields__Offset, 1, 0, 32, 32);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bGenerateMeshDistanceFields__Offset, 1,0,32,32);}
			
		}
		
		static readonly int bGenerateLandscapeGIData__Offset;
		public bool bGenerateLandscapeGIData
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bGenerateLandscapeGIData__Offset, 1, 0, 64, 64);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bGenerateLandscapeGIData__Offset, 1,0,64,64);}
			
		}
		
		static readonly int TessellationAdaptivePixelsPerTriangle__Offset;
		public float TessellationAdaptivePixelsPerTriangle
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+TessellationAdaptivePixelsPerTriangle__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+TessellationAdaptivePixelsPerTriangle__Offset, false);}
			
		}
		
		static readonly int bSeparateTranslucency__Offset;
		public bool bSeparateTranslucency
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bSeparateTranslucency__Offset, 1, 0, 1, 1);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bSeparateTranslucency__Offset, 1,0,1,1);}
			
		}
		
		static readonly int TranslucentSortPolicy__Offset;
		public ETranslucentSortPolicy TranslucentSortPolicy
		{
			get{ CheckIsValid();return (ETranslucentSortPolicy)Marshal.PtrToStructure(_this.Get()+TranslucentSortPolicy__Offset, typeof(ETranslucentSortPolicy));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+TranslucentSortPolicy__Offset, false);}
			
		}
		
		static readonly int TranslucentSortAxis__Offset;
		public FVector TranslucentSortAxis
		{
			get{ CheckIsValid();return (FVector)Marshal.PtrToStructure(_this.Get()+TranslucentSortAxis__Offset, typeof(FVector));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+TranslucentSortAxis__Offset, false);}
			
		}
		
		static readonly int CustomDepthStencil__Offset;
		public ECustomDepthStencil CustomDepthStencil
		{
			get{ CheckIsValid();return (ECustomDepthStencil)Marshal.PtrToStructure(_this.Get()+CustomDepthStencil__Offset, typeof(ECustomDepthStencil));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+CustomDepthStencil__Offset, false);}
			
		}
		
		static readonly int bCustomDepthTaaJitter__Offset;
		public bool bCustomDepthTaaJitter
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bCustomDepthTaaJitter__Offset, 1, 0, 1, 1);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bCustomDepthTaaJitter__Offset, 1,0,1,1);}
			
		}
		
		static readonly int bDefaultFeatureBloom__Offset;
		public bool bDefaultFeatureBloom
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bDefaultFeatureBloom__Offset, 1, 0, 2, 2);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bDefaultFeatureBloom__Offset, 1,0,2,2);}
			
		}
		
		static readonly int bDefaultFeatureAmbientOcclusion__Offset;
		public bool bDefaultFeatureAmbientOcclusion
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bDefaultFeatureAmbientOcclusion__Offset, 1, 0, 4, 4);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bDefaultFeatureAmbientOcclusion__Offset, 1,0,4,4);}
			
		}
		
		static readonly int bDefaultFeatureAmbientOcclusionStaticFraction__Offset;
		public bool bDefaultFeatureAmbientOcclusionStaticFraction
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bDefaultFeatureAmbientOcclusionStaticFraction__Offset, 1, 0, 8, 8);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bDefaultFeatureAmbientOcclusionStaticFraction__Offset, 1,0,8,8);}
			
		}
		
		static readonly int bDefaultFeatureAutoExposure__Offset;
		public bool bDefaultFeatureAutoExposure
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bDefaultFeatureAutoExposure__Offset, 1, 0, 16, 16);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bDefaultFeatureAutoExposure__Offset, 1,0,16,16);}
			
		}
		
		static readonly int DefaultFeatureAutoExposure__Offset;
		public EAutoExposureMethodUI DefaultFeatureAutoExposure
		{
			get{ CheckIsValid();return (EAutoExposureMethodUI)Marshal.PtrToStructure(_this.Get()+DefaultFeatureAutoExposure__Offset, typeof(EAutoExposureMethodUI));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+DefaultFeatureAutoExposure__Offset, false);}
			
		}
		
		static readonly int bDefaultFeatureMotionBlur__Offset;
		public bool bDefaultFeatureMotionBlur
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bDefaultFeatureMotionBlur__Offset, 1, 0, 1, 1);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bDefaultFeatureMotionBlur__Offset, 1,0,1,1);}
			
		}
		
		static readonly int bDefaultFeatureLensFlare__Offset;
		public bool bDefaultFeatureLensFlare
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bDefaultFeatureLensFlare__Offset, 1, 0, 2, 2);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bDefaultFeatureLensFlare__Offset, 1,0,2,2);}
			
		}
		
		static readonly int DefaultFeatureAntiAliasing__Offset;
		public EAntiAliasingMethod DefaultFeatureAntiAliasing
		{
			get{ CheckIsValid();return (EAntiAliasingMethod)Marshal.PtrToStructure(_this.Get()+DefaultFeatureAntiAliasing__Offset, typeof(EAntiAliasingMethod));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+DefaultFeatureAntiAliasing__Offset, false);}
			
		}
		
		static readonly int bStencilForLODDither__Offset;
		public bool bStencilForLODDither
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bStencilForLODDither__Offset, 1, 0, 1, 1);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bStencilForLODDither__Offset, 1,0,1,1);}
			
		}
		
		static readonly int EarlyZPass__Offset;
		public EEarlyZPass EarlyZPass
		{
			get{ CheckIsValid();return (EEarlyZPass)Marshal.PtrToStructure(_this.Get()+EarlyZPass__Offset, typeof(EEarlyZPass));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+EarlyZPass__Offset, false);}
			
		}
		
		static readonly int bEarlyZPassMovable__Offset;
		public bool bEarlyZPassMovable
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bEarlyZPassMovable__Offset, 1, 0, 1, 1);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bEarlyZPassMovable__Offset, 1,0,1,1);}
			
		}
		
		static readonly int bEarlyZPassOnlyMaterialMasking__Offset;
		public bool bEarlyZPassOnlyMaterialMasking
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bEarlyZPassOnlyMaterialMasking__Offset, 1, 0, 2, 2);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bEarlyZPassOnlyMaterialMasking__Offset, 1,0,2,2);}
			
		}
		
		static readonly int bDBuffer__Offset;
		public bool bDBuffer
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bDBuffer__Offset, 1, 0, 4, 4);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bDBuffer__Offset, 1,0,4,4);}
			
		}
		
		static readonly int ClearSceneMethod__Offset;
		public EClearSceneOptions ClearSceneMethod
		{
			get{ CheckIsValid();return (EClearSceneOptions)Marshal.PtrToStructure(_this.Get()+ClearSceneMethod__Offset, typeof(EClearSceneOptions));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+ClearSceneMethod__Offset, false);}
			
		}
		
		static readonly int bBasePassOutputsVelocity__Offset;
		public bool bBasePassOutputsVelocity
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bBasePassOutputsVelocity__Offset, 1, 0, 1, 1);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bBasePassOutputsVelocity__Offset, 1,0,1,1);}
			
		}
		
		static readonly int bSelectiveBasePassOutputs__Offset;
		public bool bSelectiveBasePassOutputs
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bSelectiveBasePassOutputs__Offset, 1, 0, 2, 2);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bSelectiveBasePassOutputs__Offset, 1,0,2,2);}
			
		}
		
		static readonly int bDefaultParticleCutouts__Offset;
		public bool bDefaultParticleCutouts
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bDefaultParticleCutouts__Offset, 1, 0, 4, 4);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bDefaultParticleCutouts__Offset, 1,0,4,4);}
			
		}
		
		static readonly int bGlobalClipPlane__Offset;
		public bool bGlobalClipPlane
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bGlobalClipPlane__Offset, 1, 0, 8, 8);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bGlobalClipPlane__Offset, 1,0,8,8);}
			
		}
		
		static readonly int GBufferFormat__Offset;
		public EGBufferFormat GBufferFormat
		{
			get{ CheckIsValid();return (EGBufferFormat)Marshal.PtrToStructure(_this.Get()+GBufferFormat__Offset, typeof(EGBufferFormat));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+GBufferFormat__Offset, false);}
			
		}
		
		static readonly int bUseGPUMorphTargets__Offset;
		public bool bUseGPUMorphTargets
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bUseGPUMorphTargets__Offset, 1, 0, 1, 1);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bUseGPUMorphTargets__Offset, 1,0,1,1);}
			
		}
		
		static readonly int bInstancedStereo__Offset;
		public bool bInstancedStereo
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bInstancedStereo__Offset, 1, 0, 2, 2);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bInstancedStereo__Offset, 1,0,2,2);}
			
		}
		
		static readonly int bMultiView__Offset;
		public bool bMultiView
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bMultiView__Offset, 1, 0, 4, 4);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bMultiView__Offset, 1,0,4,4);}
			
		}
		
		static readonly int bMobileMultiView__Offset;
		public bool bMobileMultiView
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bMobileMultiView__Offset, 1, 0, 8, 8);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bMobileMultiView__Offset, 1,0,8,8);}
			
		}
		
		static readonly int bMonoscopicFarField__Offset;
		public bool bMonoscopicFarField
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bMonoscopicFarField__Offset, 1, 0, 16, 16);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bMonoscopicFarField__Offset, 1,0,16,16);}
			
		}
		
		static readonly int WireframeCullThreshold__Offset;
		public float WireframeCullThreshold
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+WireframeCullThreshold__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+WireframeCullThreshold__Offset, false);}
			
		}
		
		static readonly int bSupportStationarySkylight__Offset;
		public bool bSupportStationarySkylight
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bSupportStationarySkylight__Offset, 1, 0, 1, 1);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bSupportStationarySkylight__Offset, 1,0,1,1);}
			
		}
		
		static readonly int bSupportLowQualityLightmaps__Offset;
		public bool bSupportLowQualityLightmaps
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bSupportLowQualityLightmaps__Offset, 1, 0, 2, 2);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bSupportLowQualityLightmaps__Offset, 1,0,2,2);}
			
		}
		
		static readonly int bSupportPointLightWholeSceneShadows__Offset;
		public bool bSupportPointLightWholeSceneShadows
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bSupportPointLightWholeSceneShadows__Offset, 1, 0, 4, 4);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bSupportPointLightWholeSceneShadows__Offset, 1,0,4,4);}
			
		}
		
		static readonly int bSupportAtmosphericFog__Offset;
		public bool bSupportAtmosphericFog
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bSupportAtmosphericFog__Offset, 1, 0, 8, 8);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bSupportAtmosphericFog__Offset, 1,0,8,8);}
			
		}
		
		static readonly int bSupportSkinCacheShaders__Offset;
		public bool bSupportSkinCacheShaders
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bSupportSkinCacheShaders__Offset, 1, 0, 16, 16);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bSupportSkinCacheShaders__Offset, 1,0,16,16);}
			
		}
		
		static readonly int bMobileEnableStaticAndCSMShadowReceivers__Offset;
		public bool bMobileEnableStaticAndCSMShadowReceivers
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bMobileEnableStaticAndCSMShadowReceivers__Offset, 1, 0, 32, 32);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bMobileEnableStaticAndCSMShadowReceivers__Offset, 1,0,32,32);}
			
		}
		
		static readonly int bMobileAllowDistanceFieldShadows__Offset;
		public bool bMobileAllowDistanceFieldShadows
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bMobileAllowDistanceFieldShadows__Offset, 1, 0, 64, 64);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bMobileAllowDistanceFieldShadows__Offset, 1,0,64,64);}
			
		}
		
		static readonly int bMobileAllowMovableDirectionalLights__Offset;
		public bool bMobileAllowMovableDirectionalLights
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bMobileAllowMovableDirectionalLights__Offset, 1, 0, 128, 128);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bMobileAllowMovableDirectionalLights__Offset, 1,0,128,128);}
			
		}
		
		static readonly int MobileNumDynamicPointLights__Offset;
		public uint MobileNumDynamicPointLights
		{
			get{ CheckIsValid();return (uint)Marshal.PtrToStructure(_this.Get()+MobileNumDynamicPointLights__Offset, typeof(uint));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+MobileNumDynamicPointLights__Offset, false);}
			
		}
		
		static readonly int bMobileDynamicPointLightsUseStaticBranch__Offset;
		public bool bMobileDynamicPointLightsUseStaticBranch
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bMobileDynamicPointLightsUseStaticBranch__Offset, 1, 0, 1, 1);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bMobileDynamicPointLightsUseStaticBranch__Offset, 1,0,1,1);}
			
		}
		
		static URendererSettings()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("RendererSettings");
			bMobileHDR__Offset=GetPropertyOffset(NativeClassPtr,"bMobileHDR");
			bMobileDisableVertexFog__Offset=GetPropertyOffset(NativeClassPtr,"bMobileDisableVertexFog");
			MaxMobileCascades__Offset=GetPropertyOffset(NativeClassPtr,"MaxMobileCascades");
			MobileMSAASampleCount__Offset=GetPropertyOffset(NativeClassPtr,"MobileMSAASampleCount");
			bDiscardUnusedQualityLevels__Offset=GetPropertyOffset(NativeClassPtr,"bDiscardUnusedQualityLevels");
			bOcclusionCulling__Offset=GetPropertyOffset(NativeClassPtr,"bOcclusionCulling");
			MinScreenRadiusForLights__Offset=GetPropertyOffset(NativeClassPtr,"MinScreenRadiusForLights");
			MinScreenRadiusForEarlyZPass__Offset=GetPropertyOffset(NativeClassPtr,"MinScreenRadiusForEarlyZPass");
			MinScreenRadiusForCSMdepth__Offset=GetPropertyOffset(NativeClassPtr,"MinScreenRadiusForCSMdepth");
			bPrecomputedVisibilityWarning__Offset=GetPropertyOffset(NativeClassPtr,"bPrecomputedVisibilityWarning");
			bTextureStreaming__Offset=GetPropertyOffset(NativeClassPtr,"bTextureStreaming");
			bUseDXT5NormalMaps__Offset=GetPropertyOffset(NativeClassPtr,"bUseDXT5NormalMaps");
			bClearCoatEnableSecondNormal__Offset=GetPropertyOffset(NativeClassPtr,"bClearCoatEnableSecondNormal");
			ReflectionCaptureResolution__Offset=GetPropertyOffset(NativeClassPtr,"ReflectionCaptureResolution");
			ReflectionEnvironmentLightmapMixBasedOnRoughness__Offset=GetPropertyOffset(NativeClassPtr,"ReflectionEnvironmentLightmapMixBasedOnRoughness");
			bForwardShading__Offset=GetPropertyOffset(NativeClassPtr,"bForwardShading");
			bVertexFoggingForOpaque__Offset=GetPropertyOffset(NativeClassPtr,"bVertexFoggingForOpaque");
			bAllowStaticLighting__Offset=GetPropertyOffset(NativeClassPtr,"bAllowStaticLighting");
			bUseNormalMapsForStaticLighting__Offset=GetPropertyOffset(NativeClassPtr,"bUseNormalMapsForStaticLighting");
			bGenerateMeshDistanceFields__Offset=GetPropertyOffset(NativeClassPtr,"bGenerateMeshDistanceFields");
			bGenerateLandscapeGIData__Offset=GetPropertyOffset(NativeClassPtr,"bGenerateLandscapeGIData");
			TessellationAdaptivePixelsPerTriangle__Offset=GetPropertyOffset(NativeClassPtr,"TessellationAdaptivePixelsPerTriangle");
			bSeparateTranslucency__Offset=GetPropertyOffset(NativeClassPtr,"bSeparateTranslucency");
			TranslucentSortPolicy__Offset=GetPropertyOffset(NativeClassPtr,"TranslucentSortPolicy");
			TranslucentSortAxis__Offset=GetPropertyOffset(NativeClassPtr,"TranslucentSortAxis");
			CustomDepthStencil__Offset=GetPropertyOffset(NativeClassPtr,"CustomDepthStencil");
			bCustomDepthTaaJitter__Offset=GetPropertyOffset(NativeClassPtr,"bCustomDepthTaaJitter");
			bDefaultFeatureBloom__Offset=GetPropertyOffset(NativeClassPtr,"bDefaultFeatureBloom");
			bDefaultFeatureAmbientOcclusion__Offset=GetPropertyOffset(NativeClassPtr,"bDefaultFeatureAmbientOcclusion");
			bDefaultFeatureAmbientOcclusionStaticFraction__Offset=GetPropertyOffset(NativeClassPtr,"bDefaultFeatureAmbientOcclusionStaticFraction");
			bDefaultFeatureAutoExposure__Offset=GetPropertyOffset(NativeClassPtr,"bDefaultFeatureAutoExposure");
			DefaultFeatureAutoExposure__Offset=GetPropertyOffset(NativeClassPtr,"DefaultFeatureAutoExposure");
			bDefaultFeatureMotionBlur__Offset=GetPropertyOffset(NativeClassPtr,"bDefaultFeatureMotionBlur");
			bDefaultFeatureLensFlare__Offset=GetPropertyOffset(NativeClassPtr,"bDefaultFeatureLensFlare");
			DefaultFeatureAntiAliasing__Offset=GetPropertyOffset(NativeClassPtr,"DefaultFeatureAntiAliasing");
			bStencilForLODDither__Offset=GetPropertyOffset(NativeClassPtr,"bStencilForLODDither");
			EarlyZPass__Offset=GetPropertyOffset(NativeClassPtr,"EarlyZPass");
			bEarlyZPassMovable__Offset=GetPropertyOffset(NativeClassPtr,"bEarlyZPassMovable");
			bEarlyZPassOnlyMaterialMasking__Offset=GetPropertyOffset(NativeClassPtr,"bEarlyZPassOnlyMaterialMasking");
			bDBuffer__Offset=GetPropertyOffset(NativeClassPtr,"bDBuffer");
			ClearSceneMethod__Offset=GetPropertyOffset(NativeClassPtr,"ClearSceneMethod");
			bBasePassOutputsVelocity__Offset=GetPropertyOffset(NativeClassPtr,"bBasePassOutputsVelocity");
			bSelectiveBasePassOutputs__Offset=GetPropertyOffset(NativeClassPtr,"bSelectiveBasePassOutputs");
			bDefaultParticleCutouts__Offset=GetPropertyOffset(NativeClassPtr,"bDefaultParticleCutouts");
			bGlobalClipPlane__Offset=GetPropertyOffset(NativeClassPtr,"bGlobalClipPlane");
			GBufferFormat__Offset=GetPropertyOffset(NativeClassPtr,"GBufferFormat");
			bUseGPUMorphTargets__Offset=GetPropertyOffset(NativeClassPtr,"bUseGPUMorphTargets");
			bInstancedStereo__Offset=GetPropertyOffset(NativeClassPtr,"bInstancedStereo");
			bMultiView__Offset=GetPropertyOffset(NativeClassPtr,"bMultiView");
			bMobileMultiView__Offset=GetPropertyOffset(NativeClassPtr,"bMobileMultiView");
			bMonoscopicFarField__Offset=GetPropertyOffset(NativeClassPtr,"bMonoscopicFarField");
			WireframeCullThreshold__Offset=GetPropertyOffset(NativeClassPtr,"WireframeCullThreshold");
			bSupportStationarySkylight__Offset=GetPropertyOffset(NativeClassPtr,"bSupportStationarySkylight");
			bSupportLowQualityLightmaps__Offset=GetPropertyOffset(NativeClassPtr,"bSupportLowQualityLightmaps");
			bSupportPointLightWholeSceneShadows__Offset=GetPropertyOffset(NativeClassPtr,"bSupportPointLightWholeSceneShadows");
			bSupportAtmosphericFog__Offset=GetPropertyOffset(NativeClassPtr,"bSupportAtmosphericFog");
			bSupportSkinCacheShaders__Offset=GetPropertyOffset(NativeClassPtr,"bSupportSkinCacheShaders");
			bMobileEnableStaticAndCSMShadowReceivers__Offset=GetPropertyOffset(NativeClassPtr,"bMobileEnableStaticAndCSMShadowReceivers");
			bMobileAllowDistanceFieldShadows__Offset=GetPropertyOffset(NativeClassPtr,"bMobileAllowDistanceFieldShadows");
			bMobileAllowMovableDirectionalLights__Offset=GetPropertyOffset(NativeClassPtr,"bMobileAllowMovableDirectionalLights");
			MobileNumDynamicPointLights__Offset=GetPropertyOffset(NativeClassPtr,"MobileNumDynamicPointLights");
			bMobileDynamicPointLightsUseStaticBranch__Offset=GetPropertyOffset(NativeClassPtr,"bMobileDynamicPointLightsUseStaticBranch");
			
		}
		
	}
	
}
#endif
#endif
