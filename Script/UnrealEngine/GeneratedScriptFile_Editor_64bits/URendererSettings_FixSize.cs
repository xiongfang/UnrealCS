#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>Rendering settings.</summary>
	public partial class URendererSettings
	{
		static readonly int bMobileHDR__Offset;
		/// <summary>If true, mobile renders in full HDR. Disable this setting for games that do not require lighting features for better performance on slow devices. Changing this setting requires restarting the editor.</summary>
		public bool bMobileHDR
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bMobileHDR__Offset, 1, 0, 1, 1);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bMobileHDR__Offset, 1,0,1,1);}
			
		}
		
		static readonly int bMobileDisableVertexFog__Offset;
		/// <summary>If true, vertex fog will be omitted from all mobile shaders. If your game does not use fog, you should choose this setting to increase shading performance.</summary>
		public bool bMobileDisableVertexFog
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bMobileDisableVertexFog__Offset, 1, 0, 2, 2);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bMobileDisableVertexFog__Offset, 1,0,2,2);}
			
		}
		
		static readonly int MaxMobileCascades__Offset;
		/// <summary>The maximum number of cascades with which to render dynamic directional light shadows when using the mobile renderer.</summary>
		public int MaxMobileCascades
		{
			get{ CheckIsValid();return (int)Marshal.PtrToStructure(_this.Get()+MaxMobileCascades__Offset, typeof(int));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+MaxMobileCascades__Offset, false);}
			
		}
		
		static readonly int MobileMSAASampleCount__Offset;
		/// <summary>
		/// Multi-sample anti-aliasing setting to use on mobile. MSAA is currently supported using Metal on iOS, and on Android devices with the required support using ES 2 or ES 3.1.
		/// If MSAA is not available, the current default AA method will be used.
		/// </summary>
		public EMobileMSAASampleCount MobileMSAASampleCount
		{
			get{ CheckIsValid();return (EMobileMSAASampleCount)Marshal.PtrToStructure(_this.Get()+MobileMSAASampleCount__Offset, typeof(EMobileMSAASampleCount));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+MobileMSAASampleCount__Offset, false);}
			
		}
		
		static readonly int bDiscardUnusedQualityLevels__Offset;
		/// <summary>
		/// When running in game mode, whether to keep shaders for all quality levels in memory or only those needed for the current quality level.
		/// Unchecked: Keep all quality levels in memory allowing a runtime quality level change. (default)
		/// Checked: Discard unused quality levels when loading content for the game, saving some memory.
		/// </summary>
		public bool bDiscardUnusedQualityLevels
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bDiscardUnusedQualityLevels__Offset, 1, 0, 1, 1);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bDiscardUnusedQualityLevels__Offset, 1,0,1,1);}
			
		}
		
		static readonly int bOcclusionCulling__Offset;
		/// <summary>Allows occluded meshes to be culled and no rendered.</summary>
		public bool bOcclusionCulling
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bOcclusionCulling__Offset, 1, 0, 2, 2);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bOcclusionCulling__Offset, 1,0,2,2);}
			
		}
		
		static readonly int MinScreenRadiusForLights__Offset;
		/// <summary>Screen radius at which lights are culled. Larger values can improve performance but causes lights to pop off when they affect a small area of the screen.</summary>
		public float MinScreenRadiusForLights
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+MinScreenRadiusForLights__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+MinScreenRadiusForLights__Offset, false);}
			
		}
		
		static readonly int MinScreenRadiusForEarlyZPass__Offset;
		/// <summary>Screen radius at which objects are culled for the early Z pass. Larger values can improve performance but very large values can degrade performance if large occluders are not rendered.</summary>
		public float MinScreenRadiusForEarlyZPass
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+MinScreenRadiusForEarlyZPass__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+MinScreenRadiusForEarlyZPass__Offset, false);}
			
		}
		
		static readonly int MinScreenRadiusForCSMdepth__Offset;
		/// <summary>Screen radius at which objects are culled for cascaded shadow map depth passes. Larger values can improve performance but can cause artifacts as objects stop casting shadows.</summary>
		public float MinScreenRadiusForCSMdepth
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+MinScreenRadiusForCSMdepth__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+MinScreenRadiusForCSMdepth__Offset, false);}
			
		}
		
		static readonly int bPrecomputedVisibilityWarning__Offset;
		/// <summary>Displays a warning when no precomputed visibility data is available for the current camera location. This can be helpful if you are making a game that relies on precomputed visibility, e.g. a first person mobile game.</summary>
		public bool bPrecomputedVisibilityWarning
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bPrecomputedVisibilityWarning__Offset, 1, 0, 1, 1);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bPrecomputedVisibilityWarning__Offset, 1,0,1,1);}
			
		}
		
		static readonly int bTextureStreaming__Offset;
		/// <summary>When enabled textures will stream in based on what is visible on screen.</summary>
		public bool bTextureStreaming
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bTextureStreaming__Offset, 1, 0, 2, 2);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bTextureStreaming__Offset, 1,0,2,2);}
			
		}
		
		static readonly int bUseDXT5NormalMaps__Offset;
		/// <summary>Whether to use DXT5 for normal maps, otherwise BC5 will be used, which is not supported on all hardware. Changing this setting requires restarting the editor.</summary>
		public bool bUseDXT5NormalMaps
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bUseDXT5NormalMaps__Offset, 1, 0, 4, 4);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bUseDXT5NormalMaps__Offset, 1,0,4,4);}
			
		}
		
		static readonly int bClearCoatEnableSecondNormal__Offset;
		/// <summary>Use a separate normal map for the bottom layer of a clear coat material. This is a higher quality feature that is expensive.</summary>
		public bool bClearCoatEnableSecondNormal
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bClearCoatEnableSecondNormal__Offset, 1, 0, 8, 8);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bClearCoatEnableSecondNormal__Offset, 1,0,8,8);}
			
		}
		
		static readonly int ReflectionCaptureResolution__Offset;
		/// <summary>The cubemap resolution for all reflection capture probes. Must be power of 2. Note that for very high values the memory and performance impact may be severe.</summary>
		public int ReflectionCaptureResolution
		{
			get{ CheckIsValid();return (int)Marshal.PtrToStructure(_this.Get()+ReflectionCaptureResolution__Offset, typeof(int));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+ReflectionCaptureResolution__Offset, false);}
			
		}
		
		static readonly int ReflectionEnvironmentLightmapMixBasedOnRoughness__Offset;
		/// <summary>Whether to reduce lightmap mixing with reflection captures for very smooth surfaces.  This is useful to make sure reflection captures match SSR / planar reflections in brightness.</summary>
		public bool ReflectionEnvironmentLightmapMixBasedOnRoughness
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), ReflectionEnvironmentLightmapMixBasedOnRoughness__Offset, 1, 0, 1, 1);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), ReflectionEnvironmentLightmapMixBasedOnRoughness__Offset, 1,0,1,1);}
			
		}
		
		static readonly int bForwardShading__Offset;
		/// <summary>Whether to use forward shading on desktop platforms, requires Shader Model 5 hardware.  Forward shading supports MSAA and has lower default cost, but fewer features supported overall.  Materials have to opt-in to more expensive features like high quality reflections.  Changing this setting requires restarting the editor.</summary>
		public bool bForwardShading
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bForwardShading__Offset, 1, 0, 2, 2);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bForwardShading__Offset, 1,0,2,2);}
			
		}
		
		static readonly int bVertexFoggingForOpaque__Offset;
		/// <summary>Causes opaque materials to use per-vertex fogging, which costs less and integrates properly with MSAA.  Only supported with forward shading. Changing this setting requires restarting the editor.</summary>
		public bool bVertexFoggingForOpaque
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bVertexFoggingForOpaque__Offset, 1, 0, 4, 4);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bVertexFoggingForOpaque__Offset, 1,0,4,4);}
			
		}
		
		static readonly int bAllowStaticLighting__Offset;
		/// <summary>Whether to allow any static lighting to be generated and used, like lightmaps and shadowmaps. Games that only use dynamic lighting should set this to 0 to save some static lighting overhead. Changing this setting requires restarting the editor.</summary>
		public bool bAllowStaticLighting
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bAllowStaticLighting__Offset, 1, 0, 8, 8);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bAllowStaticLighting__Offset, 1,0,8,8);}
			
		}
		
		static readonly int bUseNormalMapsForStaticLighting__Offset;
		/// <summary>Whether to allow any static lighting to use normal maps for lighting computations.</summary>
		public bool bUseNormalMapsForStaticLighting
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bUseNormalMapsForStaticLighting__Offset, 1, 0, 16, 16);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bUseNormalMapsForStaticLighting__Offset, 1,0,16,16);}
			
		}
		
		static readonly int bGenerateMeshDistanceFields__Offset;
		/// <summary>Whether to build distance fields of static meshes, needed for distance field AO, which is used to implement Movable SkyLight shadows, and ray traced distance field shadows on directional lights.  Enabling will increase mesh build times and memory usage.  Changing this setting requires restarting the editor.</summary>
		public bool bGenerateMeshDistanceFields
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bGenerateMeshDistanceFields__Offset, 1, 0, 32, 32);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bGenerateMeshDistanceFields__Offset, 1,0,32,32);}
			
		}
		
		static readonly int bGenerateLandscapeGIData__Offset;
		/// <summary>Whether to generate a low-resolution base color texture for landscapes for rendering real-time global illumination.  This feature requires GenerateMeshDistanceFields is also enabled, and will increase mesh build times and memory usage.</summary>
		public bool bGenerateLandscapeGIData
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bGenerateLandscapeGIData__Offset, 1, 0, 64, 64);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bGenerateLandscapeGIData__Offset, 1,0,64,64);}
			
		}
		
		static readonly int TessellationAdaptivePixelsPerTriangle__Offset;
		/// <summary>When adaptive tessellation is enabled it will try to tessellate a mesh so that each triangle contains the specified number of pixels. The tessellation multiplier specified in the material can increase or decrease the amount of tessellation.</summary>
		public float TessellationAdaptivePixelsPerTriangle
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+TessellationAdaptivePixelsPerTriangle__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+TessellationAdaptivePixelsPerTriangle__Offset, false);}
			
		}
		
		static readonly int bSeparateTranslucency__Offset;
		/// <summary>Allow translucency to be rendered to a separate render targeted and composited after depth of field. Prevents translucency from appearing out of focus.</summary>
		public bool bSeparateTranslucency
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bSeparateTranslucency__Offset, 1, 0, 1, 1);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bSeparateTranslucency__Offset, 1,0,1,1);}
			
		}
		
		static readonly int TranslucentSortPolicy__Offset;
		/// <summary>The sort mode for translucent primitives, affecting how they are ordered and how they change order as the camera moves.</summary>
		public ETranslucentSortPolicy TranslucentSortPolicy
		{
			get{ CheckIsValid();return (ETranslucentSortPolicy)Marshal.PtrToStructure(_this.Get()+TranslucentSortPolicy__Offset, typeof(ETranslucentSortPolicy));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+TranslucentSortPolicy__Offset, false);}
			
		}
		
		static readonly int TranslucentSortAxis__Offset;
		/// <summary>The axis that sorting will occur along when Translucent Sort Policy is set to SortAlongAxis.</summary>
		public FVector TranslucentSortAxis
		{
			get{ CheckIsValid();return (FVector)Marshal.PtrToStructure(_this.Get()+TranslucentSortAxis__Offset, typeof(FVector));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+TranslucentSortAxis__Offset, false);}
			
		}
		
		static readonly int CustomDepthStencil__Offset;
		/// <summary>Whether the custom depth pass for tagging primitives for postprocessing passes is enabled. Enabling it on demand can save memory but may cause a hitch the first time the feature is used.</summary>
		public ECustomDepthStencil CustomDepthStencil
		{
			get{ CheckIsValid();return (ECustomDepthStencil)Marshal.PtrToStructure(_this.Get()+CustomDepthStencil__Offset, typeof(ECustomDepthStencil));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+CustomDepthStencil__Offset, false);}
			
		}
		
		static readonly int bCustomDepthTaaJitter__Offset;
		/// <summary>Whether the custom depth pass has the TemporalAA jitter enabled. Disabling this can be useful when the result of the CustomDepth Pass is used after TAA (e.g. after Tonemapping)</summary>
		public bool bCustomDepthTaaJitter
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bCustomDepthTaaJitter__Offset, 1, 0, 1, 1);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bCustomDepthTaaJitter__Offset, 1,0,1,1);}
			
		}
		
		static readonly int bDefaultFeatureBloom__Offset;
		/// <summary>Whether the default for Bloom is enabled or not (postprocess volume/camera/game setting can still override and enable or disable it independently)</summary>
		public bool bDefaultFeatureBloom
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bDefaultFeatureBloom__Offset, 1, 0, 2, 2);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bDefaultFeatureBloom__Offset, 1,0,2,2);}
			
		}
		
		static readonly int bDefaultFeatureAmbientOcclusion__Offset;
		/// <summary>Whether the default for AmbientOcclusion is enabled or not (postprocess volume/camera/game setting can still override and enable or disable it independently)</summary>
		public bool bDefaultFeatureAmbientOcclusion
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bDefaultFeatureAmbientOcclusion__Offset, 1, 0, 4, 4);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bDefaultFeatureAmbientOcclusion__Offset, 1,0,4,4);}
			
		}
		
		static readonly int bDefaultFeatureAmbientOcclusionStaticFraction__Offset;
		/// <summary>Whether the default for AmbientOcclusionStaticFraction is enabled or not (only useful for baked lighting and if AO is on, allows to have SSAO affect baked lighting as well, costs performance, postprocess volume/camera/game setting can still override and enable or disable it independently)</summary>
		public bool bDefaultFeatureAmbientOcclusionStaticFraction
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bDefaultFeatureAmbientOcclusionStaticFraction__Offset, 1, 0, 8, 8);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bDefaultFeatureAmbientOcclusionStaticFraction__Offset, 1,0,8,8);}
			
		}
		
		static readonly int bDefaultFeatureAutoExposure__Offset;
		/// <summary>Whether the default for AutoExposure is enabled or not (postprocess volume/camera/game setting can still override and enable or disable it independently)</summary>
		public bool bDefaultFeatureAutoExposure
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bDefaultFeatureAutoExposure__Offset, 1, 0, 16, 16);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bDefaultFeatureAutoExposure__Offset, 1,0,16,16);}
			
		}
		
		static readonly int DefaultFeatureAutoExposure__Offset;
		/// <summary>The default method for AutoExposure(postprocess volume/camera/game setting can still override and enable or disable it independently)</summary>
		public EAutoExposureMethodUI DefaultFeatureAutoExposure
		{
			get{ CheckIsValid();return (EAutoExposureMethodUI)Marshal.PtrToStructure(_this.Get()+DefaultFeatureAutoExposure__Offset, typeof(EAutoExposureMethodUI));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+DefaultFeatureAutoExposure__Offset, false);}
			
		}
		
		static readonly int bDefaultFeatureMotionBlur__Offset;
		/// <summary>Whether the default for MotionBlur is enabled or not (postprocess volume/camera/game setting can still override and enable or disable it independently)</summary>
		public bool bDefaultFeatureMotionBlur
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bDefaultFeatureMotionBlur__Offset, 1, 0, 1, 1);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bDefaultFeatureMotionBlur__Offset, 1,0,1,1);}
			
		}
		
		static readonly int bDefaultFeatureLensFlare__Offset;
		/// <summary>Whether the default for LensFlare is enabled or not (postprocess volume/camera/game setting can still override and enable or disable it independently)</summary>
		public bool bDefaultFeatureLensFlare
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bDefaultFeatureLensFlare__Offset, 1, 0, 2, 2);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bDefaultFeatureLensFlare__Offset, 1,0,2,2);}
			
		}
		
		static readonly int DefaultFeatureAntiAliasing__Offset;
		/// <summary>What anti-aliasing mode is used by default</summary>
		public EAntiAliasingMethod DefaultFeatureAntiAliasing
		{
			get{ CheckIsValid();return (EAntiAliasingMethod)Marshal.PtrToStructure(_this.Get()+DefaultFeatureAntiAliasing__Offset, typeof(EAntiAliasingMethod));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+DefaultFeatureAntiAliasing__Offset, false);}
			
		}
		
		static readonly int bStencilForLODDither__Offset;
		/// <summary>Whether to use stencil for LOD dither fading.  This saves GPU time in the base pass for materials with dither fading enabled, but forces a full prepass. Changing this setting requires restarting the editor.</summary>
		public bool bStencilForLODDither
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bStencilForLODDither__Offset, 1, 0, 1, 1);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bStencilForLODDither__Offset, 1,0,1,1);}
			
		}
		
		static readonly int EarlyZPass__Offset;
		/// <summary>Whether to use a depth only pass to initialize Z culling for the base pass.</summary>
		public EEarlyZPass EarlyZPass
		{
			get{ CheckIsValid();return (EEarlyZPass)Marshal.PtrToStructure(_this.Get()+EarlyZPass__Offset, typeof(EEarlyZPass));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+EarlyZPass__Offset, false);}
			
		}
		
		static readonly int bEarlyZPassMovable__Offset;
		/// <summary>Whether to render movable objects in the early Z pass. Need to reload the level!</summary>
		public bool bEarlyZPassMovable
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bEarlyZPassMovable__Offset, 1, 0, 1, 1);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bEarlyZPassMovable__Offset, 1,0,1,1);}
			
		}
		
		static readonly int bEarlyZPassOnlyMaterialMasking__Offset;
		/// <summary>Whether to compute materials' mask opacity only in early Z pass. Changing this setting requires restarting the editor.</summary>
		public bool bEarlyZPassOnlyMaterialMasking
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bEarlyZPassOnlyMaterialMasking__Offset, 1, 0, 2, 2);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bEarlyZPassOnlyMaterialMasking__Offset, 1,0,2,2);}
			
		}
		
		static readonly int bDBuffer__Offset;
		/// <summary>Whether to accumulate decal properties to a buffer before the base pass.  DBuffer decals correctly affect lightmap and sky lighting, unlike regular deferred decals.  DBuffer enabled forces a full prepass.  Changing this setting requires restarting the editor.</summary>
		public bool bDBuffer
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bDBuffer__Offset, 1, 0, 4, 4);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bDBuffer__Offset, 1,0,4,4);}
			
		}
		
		static readonly int ClearSceneMethod__Offset;
		/// <summary>Select how the g-buffer is cleared in game mode (only affects deferred shading).</summary>
		public EClearSceneOptions ClearSceneMethod
		{
			get{ CheckIsValid();return (EClearSceneOptions)Marshal.PtrToStructure(_this.Get()+ClearSceneMethod__Offset, typeof(EClearSceneOptions));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+ClearSceneMethod__Offset, false);}
			
		}
		
		static readonly int bBasePassOutputsVelocity__Offset;
		/// <summary>Enables materials with time-based World Position Offset and/or World Displacement to output accurate velocities. This incurs a performance cost. If this is disabled, those materials will not output velocities. Changing this setting requires restarting the editor.</summary>
		public bool bBasePassOutputsVelocity
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bBasePassOutputsVelocity__Offset, 1, 0, 1, 1);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bBasePassOutputsVelocity__Offset, 1,0,1,1);}
			
		}
		
		static readonly int bSelectiveBasePassOutputs__Offset;
		/// <summary>Enables not exporting to the GBuffer rendertargets that are not relevant. Changing this setting requires restarting the editor.</summary>
		public bool bSelectiveBasePassOutputs
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bSelectiveBasePassOutputs__Offset, 1, 0, 2, 2);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bSelectiveBasePassOutputs__Offset, 1,0,2,2);}
			
		}
		
		static readonly int bDefaultParticleCutouts__Offset;
		/// <summary>When enabled, after changing the material on a Required particle module a Particle Cutout texture will be chosen automatically from the Opacity Mask texture if it exists, if not the Opacity Texture will be used if it exists.</summary>
		public bool bDefaultParticleCutouts
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bDefaultParticleCutouts__Offset, 1, 0, 4, 4);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bDefaultParticleCutouts__Offset, 1,0,4,4);}
			
		}
		
		static readonly int bGlobalClipPlane__Offset;
		/// <summary>Whether to support the global clip plane needed for planar reflections.  Enabling this increases BasePass triangle cost by ~15% regardless of whether planar reflections are active. Changing this setting requires restarting the editor.</summary>
		public bool bGlobalClipPlane
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bGlobalClipPlane__Offset, 1, 0, 8, 8);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bGlobalClipPlane__Offset, 1,0,8,8);}
			
		}
		
		static readonly int GBufferFormat__Offset;
		/// <summary>Selects which GBuffer format should be used. Affects performance primarily via how much GPU memory bandwidth used.</summary>
		public EGBufferFormat GBufferFormat
		{
			get{ CheckIsValid();return (EGBufferFormat)Marshal.PtrToStructure(_this.Get()+GBufferFormat__Offset, typeof(EGBufferFormat));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+GBufferFormat__Offset, false);}
			
		}
		
		static readonly int bUseGPUMorphTargets__Offset;
		/// <summary>Whether to use original CPU method (loop per morph then by vertex) or use a GPU-based method on Shader Model 5 hardware.</summary>
		public bool bUseGPUMorphTargets
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bUseGPUMorphTargets__Offset, 1, 0, 1, 1);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bUseGPUMorphTargets__Offset, 1,0,1,1);}
			
		}
		
		static readonly int bInstancedStereo__Offset;
		/// <summary>Enable instanced stereo rendering (only available for D3D SM5 or PS4).</summary>
		public bool bInstancedStereo
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bInstancedStereo__Offset, 1, 0, 2, 2);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bInstancedStereo__Offset, 1,0,2,2);}
			
		}
		
		static readonly int bMultiView__Offset;
		/// <summary>Enable multi-view for instanced stereo rendering (only available on the PS4).</summary>
		public bool bMultiView
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bMultiView__Offset, 1, 0, 4, 4);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bMultiView__Offset, 1,0,4,4);}
			
		}
		
		static readonly int bMobileMultiView__Offset;
		/// <summary>Enable mobile multi-view rendering (only available on some GearVR Android devices using OpenGL ES 3.1).</summary>
		public bool bMobileMultiView
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bMobileMultiView__Offset, 1, 0, 8, 8);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bMobileMultiView__Offset, 1,0,8,8);}
			
		}
		
		static readonly int bMonoscopicFarField__Offset;
		/// <summary>Enable monoscopic far field rendering (only available for mobile).</summary>
		public bool bMonoscopicFarField
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bMonoscopicFarField__Offset, 1, 0, 16, 16);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bMonoscopicFarField__Offset, 1,0,16,16);}
			
		}
		
		static readonly int WireframeCullThreshold__Offset;
		/// <summary>Screen radius at which wireframe objects are culled. Larger values can improve performance when viewing a scene in wireframe.</summary>
		public float WireframeCullThreshold
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+WireframeCullThreshold__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+WireframeCullThreshold__Offset, false);}
			
		}
		
		static readonly int bSupportStationarySkylight__Offset;
		/// <summary>"Stationary skylight requires permutations of the basepass shaders.  Disabling will reduce the number of shader permutations required per material. Changing this setting requires restarting the editor."</summary>
		public bool bSupportStationarySkylight
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bSupportStationarySkylight__Offset, 1, 0, 1, 1);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bSupportStationarySkylight__Offset, 1,0,1,1);}
			
		}
		
		static readonly int bSupportLowQualityLightmaps__Offset;
		/// <summary>"Low quality lightmap requires permutations of the lightmap rendering shaders.  Disabling will reduce the number of shader permutations required per material. Changing this setting requires restarting the editor."</summary>
		public bool bSupportLowQualityLightmaps
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bSupportLowQualityLightmaps__Offset, 1, 0, 2, 2);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bSupportLowQualityLightmaps__Offset, 1,0,2,2);}
			
		}
		
		static readonly int bSupportPointLightWholeSceneShadows__Offset;
		/// <summary>PointLight WholeSceneShadows requires many vertex and geometry shader permutations for cubemap rendering. Disabling will reduce the number of shader permutations required per material. Changing this setting requires restarting the editor."</summary>
		public bool bSupportPointLightWholeSceneShadows
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bSupportPointLightWholeSceneShadows__Offset, 1, 0, 4, 4);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bSupportPointLightWholeSceneShadows__Offset, 1,0,4,4);}
			
		}
		
		static readonly int bSupportAtmosphericFog__Offset;
		/// <summary>"Atmospheric fog requires permutations of the basepass shaders.  Disabling will reduce the number of shader permutations required per material. Changing this setting requires restarting the editor."</summary>
		public bool bSupportAtmosphericFog
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bSupportAtmosphericFog__Offset, 1, 0, 8, 8);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bSupportAtmosphericFog__Offset, 1,0,8,8);}
			
		}
		
		static readonly int bSupportSkinCacheShaders__Offset;
		/// <summary>"Skincache allows a compute shader to skin once each vertex, save those results into a new buffer and reuse those calculations when later running the depth, base and velocity passes. This also allows opting into the 'recompute tangents' for skinned mesh instance feature. Disabling will reduce the number of shader permutations required per material. Changing this setting requires restarting the editor."</summary>
		public bool bSupportSkinCacheShaders
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bSupportSkinCacheShaders__Offset, 1, 0, 16, 16);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bSupportSkinCacheShaders__Offset, 1,0,16,16);}
			
		}
		
		static readonly int bMobileEnableStaticAndCSMShadowReceivers__Offset;
		/// <summary>Allow primitives to receive both static and CSM shadows from a stationary light. Disabling will free a mobile texture sampler and reduce shader permutations. Changing this setting requires restarting the editor.</summary>
		public bool bMobileEnableStaticAndCSMShadowReceivers
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bMobileEnableStaticAndCSMShadowReceivers__Offset, 1, 0, 32, 32);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bMobileEnableStaticAndCSMShadowReceivers__Offset, 1,0,32,32);}
			
		}
		
		static readonly int bMobileAllowDistanceFieldShadows__Offset;
		/// <summary>Generate shaders for primitives to receive distance field shadows from stationary directional lights. Changing this setting requires restarting the editor.</summary>
		public bool bMobileAllowDistanceFieldShadows
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bMobileAllowDistanceFieldShadows__Offset, 1, 0, 64, 64);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bMobileAllowDistanceFieldShadows__Offset, 1,0,64,64);}
			
		}
		
		static readonly int bMobileAllowMovableDirectionalLights__Offset;
		/// <summary>Generate shaders for primitives to receive movable directional lights. Changing this setting requires restarting the editor.</summary>
		public bool bMobileAllowMovableDirectionalLights
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bMobileAllowMovableDirectionalLights__Offset, 1, 0, 128, 128);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bMobileAllowMovableDirectionalLights__Offset, 1,0,128,128);}
			
		}
		
		static readonly int MobileNumDynamicPointLights__Offset;
		/// <summary>The number of dynamic point lights to support on mobile devices. Setting this to 0 for games which do not require dynamic point lights will reduce the number of shaders generated. Changing this setting requires restarting the editor.</summary>
		public uint MobileNumDynamicPointLights
		{
			get{ CheckIsValid();return (uint)Marshal.PtrToStructure(_this.Get()+MobileNumDynamicPointLights__Offset, typeof(uint));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+MobileNumDynamicPointLights__Offset, false);}
			
		}
		
		static readonly int bMobileDynamicPointLightsUseStaticBranch__Offset;
		/// <summary>If this setting is enabled, the same shader will be used for any number of dynamic point lights (up to the maximum specified above) hitting a surface. This is slightly slower but reduces the number of shaders generated. Changing this setting requires restarting the editor.</summary>
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
