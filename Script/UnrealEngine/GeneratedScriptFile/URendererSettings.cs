using System;
namespace UnrealEngine
{
	public partial class URendererSettings:UDeveloperSettings
	{
		/// <summary>If true, mobile renders in full HDR. Disable this setting for games that do not require lighting features for better performance on slow devices. Changing this setting requires restarting the editor.</summary>
		public bool bMobileHDR;
		
		/// <summary>If true, vertex fog will be omitted from all mobile shaders. If your game does not use fog, you should choose this setting to increase shading performance.</summary>
		public bool bMobileDisableVertexFog;
		
		/// <summary>The maximum number of cascades with which to render dynamic directional light shadows when using the mobile renderer.</summary>
		public int MaxMobileCascades;
		
		/// <summary>
		/// Multi-sample anti-aliasing setting to use on mobile. MSAA is currently supported using Metal on iOS, and on Android devices with the required support using ES 2 or ES 3.1.
		/// If MSAA is not available, the current default AA method will be used.
		/// </summary>
		public EMobileMSAASampleCount MobileMSAASampleCount;
		
		/// <summary>
		/// When running in game mode, whether to keep shaders for all quality levels in memory or only those needed for the current quality level.
		/// Unchecked: Keep all quality levels in memory allowing a runtime quality level change. (default)
		/// Checked: Discard unused quality levels when loading content for the game, saving some memory.
		/// </summary>
		public bool bDiscardUnusedQualityLevels;
		
		/// <summary>Allows occluded meshes to be culled and no rendered.</summary>
		public bool bOcclusionCulling;
		
		/// <summary>Screen radius at which lights are culled. Larger values can improve performance but causes lights to pop off when they affect a small area of the screen.</summary>
		public float MinScreenRadiusForLights;
		
		/// <summary>Screen radius at which objects are culled for the early Z pass. Larger values can improve performance but very large values can degrade performance if large occluders are not rendered.</summary>
		public float MinScreenRadiusForEarlyZPass;
		
		/// <summary>Screen radius at which objects are culled for cascaded shadow map depth passes. Larger values can improve performance but can cause artifacts as objects stop casting shadows.</summary>
		public float MinScreenRadiusForCSMdepth;
		
		/// <summary>Displays a warning when no precomputed visibility data is available for the current camera location. This can be helpful if you are making a game that relies on precomputed visibility, e.g. a first person mobile game.</summary>
		public bool bPrecomputedVisibilityWarning;
		
		/// <summary>When enabled textures will stream in based on what is visible on screen.</summary>
		public bool bTextureStreaming;
		
		/// <summary>Whether to use DXT5 for normal maps, otherwise BC5 will be used, which is not supported on all hardware. Changing this setting requires restarting the editor.</summary>
		public bool bUseDXT5NormalMaps;
		
		/// <summary>Use a separate normal map for the bottom layer of a clear coat material. This is a higher quality feature that is expensive.</summary>
		public bool bClearCoatEnableSecondNormal;
		
		/// <summary>The cubemap resolution for all reflection capture probes. Must be power of 2. Note that for very high values the memory and performance impact may be severe.</summary>
		public int ReflectionCaptureResolution;
		
		/// <summary>Whether to reduce lightmap mixing with reflection captures for very smooth surfaces.  This is useful to make sure reflection captures match SSR / planar reflections in brightness.</summary>
		public bool ReflectionEnvironmentLightmapMixBasedOnRoughness;
		
		/// <summary>Whether to use forward shading on desktop platforms, requires Shader Model 5 hardware.  Forward shading supports MSAA and has lower default cost, but fewer features supported overall.  Materials have to opt-in to more expensive features like high quality reflections.  Changing this setting requires restarting the editor.</summary>
		public bool bForwardShading;
		
		/// <summary>Causes opaque materials to use per-vertex fogging, which costs less and integrates properly with MSAA.  Only supported with forward shading. Changing this setting requires restarting the editor.</summary>
		public bool bVertexFoggingForOpaque;
		
		/// <summary>Whether to allow any static lighting to be generated and used, like lightmaps and shadowmaps. Games that only use dynamic lighting should set this to 0 to save some static lighting overhead. Changing this setting requires restarting the editor.</summary>
		public bool bAllowStaticLighting;
		
		/// <summary>Whether to allow any static lighting to use normal maps for lighting computations.</summary>
		public bool bUseNormalMapsForStaticLighting;
		
		/// <summary>Whether to build distance fields of static meshes, needed for distance field AO, which is used to implement Movable SkyLight shadows, and ray traced distance field shadows on directional lights.  Enabling will increase mesh build times and memory usage.  Changing this setting requires restarting the editor.</summary>
		public bool bGenerateMeshDistanceFields;
		
		/// <summary>Whether to generate a low-resolution base color texture for landscapes for rendering real-time global illumination.  This feature requires GenerateMeshDistanceFields is also enabled, and will increase mesh build times and memory usage.</summary>
		public bool bGenerateLandscapeGIData;
		
		/// <summary>When adaptive tessellation is enabled it will try to tessellate a mesh so that each triangle contains the specified number of pixels. The tessellation multiplier specified in the material can increase or decrease the amount of tessellation.</summary>
		public float TessellationAdaptivePixelsPerTriangle;
		
		/// <summary>Allow translucency to be rendered to a separate render targeted and composited after depth of field. Prevents translucency from appearing out of focus.</summary>
		public bool bSeparateTranslucency;
		
		/// <summary>The sort mode for translucent primitives, affecting how they are ordered and how they change order as the camera moves.</summary>
		public ETranslucentSortPolicy TranslucentSortPolicy;
		
		/// <summary>The axis that sorting will occur along when Translucent Sort Policy is set to SortAlongAxis.</summary>
		public FVector TranslucentSortAxis;
		
		/// <summary>Whether the custom depth pass for tagging primitives for postprocessing passes is enabled. Enabling it on demand can save memory but may cause a hitch the first time the feature is used.</summary>
		public ECustomDepthStencil CustomDepthStencil;
		
		/// <summary>Whether the custom depth pass has the TemporalAA jitter enabled. Disabling this can be useful when the result of the CustomDepth Pass is used after TAA (e.g. after Tonemapping)</summary>
		public bool bCustomDepthTaaJitter;
		
		/// <summary>Whether the default for Bloom is enabled or not (postprocess volume/camera/game setting can still override and enable or disable it independently)</summary>
		public bool bDefaultFeatureBloom;
		
		/// <summary>Whether the default for AmbientOcclusion is enabled or not (postprocess volume/camera/game setting can still override and enable or disable it independently)</summary>
		public bool bDefaultFeatureAmbientOcclusion;
		
		/// <summary>Whether the default for AmbientOcclusionStaticFraction is enabled or not (only useful for baked lighting and if AO is on, allows to have SSAO affect baked lighting as well, costs performance, postprocess volume/camera/game setting can still override and enable or disable it independently)</summary>
		public bool bDefaultFeatureAmbientOcclusionStaticFraction;
		
		/// <summary>Whether the default for AutoExposure is enabled or not (postprocess volume/camera/game setting can still override and enable or disable it independently)</summary>
		public bool bDefaultFeatureAutoExposure;
		
		/// <summary>The default method for AutoExposure(postprocess volume/camera/game setting can still override and enable or disable it independently)</summary>
		public EAutoExposureMethodUI DefaultFeatureAutoExposure;
		
		/// <summary>Whether the default for MotionBlur is enabled or not (postprocess volume/camera/game setting can still override and enable or disable it independently)</summary>
		public bool bDefaultFeatureMotionBlur;
		
		/// <summary>Whether the default for LensFlare is enabled or not (postprocess volume/camera/game setting can still override and enable or disable it independently)</summary>
		public bool bDefaultFeatureLensFlare;
		
		/// <summary>What anti-aliasing mode is used by default</summary>
		public EAntiAliasingMethod DefaultFeatureAntiAliasing;
		
		/// <summary>Whether to use stencil for LOD dither fading.  This saves GPU time in the base pass for materials with dither fading enabled, but forces a full prepass. Changing this setting requires restarting the editor.</summary>
		public bool bStencilForLODDither;
		
		/// <summary>Whether to use a depth only pass to initialize Z culling for the base pass.</summary>
		public EEarlyZPass EarlyZPass;
		
		/// <summary>Whether to render movable objects in the early Z pass. Need to reload the level!</summary>
		public bool bEarlyZPassMovable;
		
		/// <summary>Whether to compute materials' mask opacity only in early Z pass. Changing this setting requires restarting the editor.</summary>
		public bool bEarlyZPassOnlyMaterialMasking;
		
		/// <summary>Whether to accumulate decal properties to a buffer before the base pass.  DBuffer decals correctly affect lightmap and sky lighting, unlike regular deferred decals.  DBuffer enabled forces a full prepass.  Changing this setting requires restarting the editor.</summary>
		public bool bDBuffer;
		
		/// <summary>Select how the g-buffer is cleared in game mode (only affects deferred shading).</summary>
		public EClearSceneOptions ClearSceneMethod;
		
		/// <summary>Enables materials with time-based World Position Offset and/or World Displacement to output accurate velocities. This incurs a performance cost. If this is disabled, those materials will not output velocities. Changing this setting requires restarting the editor.</summary>
		public bool bBasePassOutputsVelocity;
		
		/// <summary>Enables not exporting to the GBuffer rendertargets that are not relevant. Changing this setting requires restarting the editor.</summary>
		public bool bSelectiveBasePassOutputs;
		
		/// <summary>When enabled, after changing the material on a Required particle module a Particle Cutout texture will be chosen automatically from the Opacity Mask texture if it exists, if not the Opacity Texture will be used if it exists.</summary>
		public bool bDefaultParticleCutouts;
		
		/// <summary>Whether to support the global clip plane needed for planar reflections.  Enabling this increases BasePass triangle cost by ~15% regardless of whether planar reflections are active. Changing this setting requires restarting the editor.</summary>
		public bool bGlobalClipPlane;
		
		/// <summary>Selects which GBuffer format should be used. Affects performance primarily via how much GPU memory bandwidth used.</summary>
		public EGBufferFormat GBufferFormat;
		
		/// <summary>Whether to use original CPU method (loop per morph then by vertex) or use a GPU-based method on Shader Model 5 hardware.</summary>
		public bool bUseGPUMorphTargets;
		
		/// <summary>Enable instanced stereo rendering (only available for D3D SM5 or PS4).</summary>
		public bool bInstancedStereo;
		
		/// <summary>Enable multi-view for instanced stereo rendering (only available on the PS4).</summary>
		public bool bMultiView;
		
		/// <summary>Enable mobile multi-view rendering (only available on some GearVR Android devices using OpenGL ES 3.1).</summary>
		public bool bMobileMultiView;
		
		/// <summary>Enable monoscopic far field rendering (only available for mobile).</summary>
		public bool bMonoscopicFarField;
		
		/// <summary>Screen radius at which wireframe objects are culled. Larger values can improve performance when viewing a scene in wireframe.</summary>
		public float WireframeCullThreshold;
		
		/// <summary>"Stationary skylight requires permutations of the basepass shaders.  Disabling will reduce the number of shader permutations required per material. Changing this setting requires restarting the editor."</summary>
		public bool bSupportStationarySkylight;
		
		/// <summary>"Low quality lightmap requires permutations of the lightmap rendering shaders.  Disabling will reduce the number of shader permutations required per material. Changing this setting requires restarting the editor."</summary>
		public bool bSupportLowQualityLightmaps;
		
		/// <summary>PointLight WholeSceneShadows requires many vertex and geometry shader permutations for cubemap rendering. Disabling will reduce the number of shader permutations required per material. Changing this setting requires restarting the editor."</summary>
		public bool bSupportPointLightWholeSceneShadows;
		
		/// <summary>"Atmospheric fog requires permutations of the basepass shaders.  Disabling will reduce the number of shader permutations required per material. Changing this setting requires restarting the editor."</summary>
		public bool bSupportAtmosphericFog;
		
		/// <summary>"Skincache allows a compute shader to skin once each vertex, save those results into a new buffer and reuse those calculations when later running the depth, base and velocity passes. This also allows opting into the 'recompute tangents' for skinned mesh instance feature. Disabling will reduce the number of shader permutations required per material. Changing this setting requires restarting the editor."</summary>
		public bool bSupportSkinCacheShaders;
		
		/// <summary>Allow primitives to receive both static and CSM shadows from a stationary light. Disabling will free a mobile texture sampler and reduce shader permutations. Changing this setting requires restarting the editor.</summary>
		public bool bMobileEnableStaticAndCSMShadowReceivers;
		
		/// <summary>Generate shaders for primitives to receive distance field shadows from stationary directional lights. Changing this setting requires restarting the editor.</summary>
		public bool bMobileAllowDistanceFieldShadows;
		
		/// <summary>Generate shaders for primitives to receive movable directional lights. Changing this setting requires restarting the editor.</summary>
		public bool bMobileAllowMovableDirectionalLights;
		
		/// <summary>The number of dynamic point lights to support on mobile devices. Setting this to 0 for games which do not require dynamic point lights will reduce the number of shaders generated. Changing this setting requires restarting the editor.</summary>
		public uint MobileNumDynamicPointLights;
		
		/// <summary>If this setting is enabled, the same shader will be used for any number of dynamic point lights (up to the maximum specified above) hitting a surface. This is slightly slower but reduces the number of shaders generated. Changing this setting requires restarting the editor.</summary>
		public bool bMobileDynamicPointLightsUseStaticBranch;
		
		
	}
	
}
