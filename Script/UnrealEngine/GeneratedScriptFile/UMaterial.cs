using System;
namespace UnrealEngine
{
	public partial class UMaterial:UMaterialInterface
	{
		/// <summary>Physical material to use for this graphics material. Used for sounds, effects etc.</summary>
		public UPhysicalMaterial PhysMaterial;
		
		/// <summary>Reflection.</summary>
		public FColorMaterialInput DiffuseColor;
		
		public FColorMaterialInput SpecularColor;
		
		public FColorMaterialInput BaseColor;
		
		public FScalarMaterialInput Metallic;
		
		public FScalarMaterialInput Specular;
		
		public FScalarMaterialInput Roughness;
		
		public FVectorMaterialInput Normal;
		
		/// <summary>Emission.</summary>
		public FColorMaterialInput EmissiveColor;
		
		/// <summary>Transmission.</summary>
		public FScalarMaterialInput Opacity;
		
		public FScalarMaterialInput OpacityMask;
		
		/// <summary>
		/// The domain that the material's attributes will be evaluated in.
		/// Certain pieces of material functionality are only valid in certain domains, for example vertex normal is only valid on a surface.
		/// </summary>
		public EMaterialDomain MaterialDomain;
		
		/// <summary>Determines how the material's color is blended with background colors.</summary>
		public EBlendMode BlendMode;
		
		/// <summary>Defines how the GBuffer chanels are getting manipulated by a decal material pass. (only with MaterialDomain == MD_DeferredDecal)</summary>
		public EDecalBlendMode DecalBlendMode;
		
		/// <summary>
		/// Defines how the material reacts on DBuffer decals (Affects look, performance and texture/sample usage).
		/// Non DBuffer Decals can be disabled on the primitive (e.g. static mesh)
		/// </summary>
		public EMaterialDecalResponse MaterialDecalResponse;
		
		/// <summary>Determines how inputs are combined to create the material's final color.</summary>
		public EMaterialShadingModel ShadingModel;
		
		/// <summary>If BlendMode is BLEND_Masked, the surface is not rendered where OpacityMask < OpacityMaskClipValue.</summary>
		public float OpacityMaskClipValue;
		
		/// <summary>Adds to world position in the vertex shader.</summary>
		public FVectorMaterialInput WorldPositionOffset;
		
		/// <summary>Offset in world space applied to tessellated vertices.</summary>
		public FVectorMaterialInput WorldDisplacement;
		
		/// <summary>Multiplies the tessellation factors applied when a tessellation mode is set.</summary>
		public FScalarMaterialInput TessellationMultiplier;
		
		/// <summary>Inner material color, only used for ShadingModel=Subsurface</summary>
		public FColorMaterialInput SubsurfaceColor;
		
		public FScalarMaterialInput ClearCoat;
		
		public FScalarMaterialInput ClearCoatRoughness;
		
		/// <summary>output ambient occlusion to the GBuffer</summary>
		public FScalarMaterialInput AmbientOcclusion;
		
		/// <summary>
		/// output refraction index for translucent rendering
		/// Air:1.0 Water:1.333 Ice:1.3 Glass:~1.6 Diamond:2.42
		/// </summary>
		public FScalarMaterialInput Refraction;
		
		/// <summary>
		/// These inputs are evaluated in the vertex shader and allow artists to do arbitrary vertex shader operations and access them in the pixel shader.
		/// When unconnected or hidden they default to passing through the vertex UVs.
		/// </summary>
		public FVector2MaterialInput CustomizedUVs;
		
		public FMaterialAttributesInput MaterialAttributes;
		
		public FScalarMaterialInput PixelDepthOffset;
		
		/// <summary>Indicates that the material should be rendered in the SeparateTranslucency Pass (not affected by DOF, requires bAllowSeparateTranslucency to be set in .ini).</summary>
		public bool bEnableSeparateTranslucency;
		
		/// <summary>Indicates that the translucent material should not be affected by bloom or DOF. (Note: Depth testing is not available)</summary>
		public bool bEnableMobileSeparateTranslucency;
		
		/// <summary>
		/// Indicates that the material should be rendered using responsive anti-aliasing. Improves sharpness of small moving particles such as sparks.
		/// Only use for small moving features because it will cause aliasing of the background.
		/// </summary>
		public bool bEnableResponsiveAA;
		
		/// <summary>SSR on translucency</summary>
		public bool bScreenSpaceReflections;
		
		/// <summary>Indicates that the material should be rendered without backface culling and the normal should be flipped for backfaces.</summary>
		public bool TwoSided;
		
		/// <summary>Whether meshes rendered with the material should support dithered LOD transitions.</summary>
		public bool DitheredLODTransition;
		
		/// <summary>Dither opacity mask. When combined with Temporal AA this can be used as a form of limited translucency which supports all lighting features.</summary>
		public bool DitherOpacityMask;
		
		/// <summary>Whether the material should allow outputting negative emissive color values.  Only allowed on unlit materials.</summary>
		public bool bAllowNegativeEmissiveColor;
		
		/// <summary>Number of customized UV inputs to display.  Unconnected customized UV inputs will just pass through the vertex UVs.</summary>
		public int NumCustomizedUVs;
		
		/// <summary>Sets the lighting mode that will be used on this material if it is translucent.</summary>
		public ETranslucencyLightingMode TranslucencyLightingMode;
		
		/// <summary>
		/// Useful for artificially increasing the influence of the normal on the lighting result for translucency.
		/// A value larger than 1 increases the influence of the normal, a value smaller than 1 makes the lighting more ambient.
		/// </summary>
		public float TranslucencyDirectionalLightingIntensity;
		
		/// <summary>Allows a translucenct material to be used with custom depth writing by compiling additional shaders.</summary>
		public bool AllowTranslucentCustomDepthWrites;
		
		/// <summary>Scale used to make translucent shadows more or less opaque than the material's actual opacity.</summary>
		public float TranslucentShadowDensityScale;
		
		/// <summary>
		/// Scale used to make translucent self-shadowing more or less opaque than the material's shadow on other objects.
		/// This is only used when the object is casting a volumetric translucent shadow.
		/// </summary>
		public float TranslucentSelfShadowDensityScale;
		
		/// <summary>Used to make a second self shadow gradient, to add interesting shading in the shadow of the first.</summary>
		public float TranslucentSelfShadowSecondDensityScale;
		
		/// <summary>Controls the strength of the second self shadow gradient.</summary>
		public float TranslucentSelfShadowSecondOpacity;
		
		/// <summary>
		/// Controls how diffuse the material's backscattering is when using the MSM_Subsurface shading model.
		/// Larger exponents give a less diffuse look (smaller, brighter backscattering highlight).
		/// This is only used when the object is casting a volumetric translucent shadow from a directional light.
		/// </summary>
		public float TranslucentBackscatteringExponent;
		
		/// <summary>
		/// Colored extinction factor used to approximate multiple scattering in dense volumes.
		/// This is only used when the object is casting a volumetric translucent shadow.
		/// </summary>
		public FLinearColor TranslucentMultipleScatteringExtinction;
		
		/// <summary>Local space distance to bias the translucent shadow.  Positive values move the shadow away from the light.</summary>
		public float TranslucentShadowStartOffset;
		
		/// <summary>Whether to draw on top of opaque pixels even if behind them. This only has meaning for translucency.</summary>
		public bool bDisableDepthTest;
		
		/// <summary>Whether to generate spherical normals for particles that use this material.</summary>
		public bool bGenerateSphericalParticleNormals;
		
		/// <summary>
		/// Whether the material takes a tangent space normal or a world space normal as input.
		/// (TangentSpace requires extra instructions but is often more convenient).
		/// </summary>
		public bool bTangentSpaceNormal;
		
		/// <summary>If enabled, the material's emissive colour is injected into the LightPropagationVolume</summary>
		public bool bUseEmissiveForDynamicAreaLighting;
		
		/// <summary>If enabled, the material's opacity defines how much GI is blocked when using the LightPropagationVolume feature</summary>
		public bool bBlockGI;
		
		/// <summary>
		/// This is a special usage flag that allows a material to be assignable to any primitive type.
		/// This is useful for materials used by code to implement certain viewmodes, for example the default material or lighting only material.
		/// The cost is that nearly 20x more shaders will be compiled for the material than the average material, which will greatly increase shader compile time and memory usage.
		/// This flag should only be enabled when absolutely necessary, and is purposefully not exposed to the UI to prevent abuse.
		/// </summary>
		public bool bUsedAsSpecialEngineMaterial;
		
		/// <summary>
		/// Indicates that the material and its instances can be use with skeletal meshes.
		/// This will result in the shaders required to support skeletal meshes being compiled which will increase shader compile time and memory usage.
		/// </summary>
		public bool bUsedWithSkeletalMesh;
		
		/// <summary>
		/// Indicates that the material and its instances can be use with editor compositing
		/// This will result in the shaders required to support editor compositing being compiled which will increase shader compile time and memory usage.
		/// </summary>
		public bool bUsedWithEditorCompositing;
		
		/// <summary>
		/// Indicates that the material and its instances can be use with particle sprites
		/// This will result in the shaders required to support particle sprites being compiled which will increase shader compile time and memory usage.
		/// </summary>
		public bool bUsedWithParticleSprites;
		
		/// <summary>
		/// Indicates that the material and its instances can be use with beam trails
		/// This will result in the shaders required to support beam trails being compiled which will increase shader compile time and memory usage.
		/// </summary>
		public bool bUsedWithBeamTrails;
		
		/// <summary>
		/// Indicates that the material and its instances can be use with mesh particles
		/// This will result in the shaders required to support mesh particles being compiled which will increase shader compile time and memory usage.
		/// </summary>
		public bool bUsedWithMeshParticles;
		
		/// <summary>
		/// Indicates that the material and its instances can be use with static lighting
		/// This will result in the shaders required to support static lighting being compiled which will increase shader compile time and memory usage.
		/// </summary>
		public bool bUsedWithStaticLighting;
		
		/// <summary>
		/// Indicates that the material and its instances can be use with morph targets
		/// This will result in the shaders required to support morph targets being compiled which will increase shader compile time and memory usage.
		/// </summary>
		public bool bUsedWithMorphTargets;
		
		/// <summary>
		/// Indicates that the material and its instances can be use with spline meshes
		/// This will result in the shaders required to support spline meshes being compiled which will increase shader compile time and memory usage.
		/// </summary>
		public bool bUsedWithSplineMeshes;
		
		/// <summary>
		/// Indicates that the material and its instances can be use with instanced static meshes
		/// This will result in the shaders required to support instanced static meshes being compiled which will increase shader compile time and memory usage.
		/// </summary>
		public bool bUsedWithInstancedStaticMeshes;
		
		/// <summary>
		/// Indicates that the material and its instances can be use with distortion
		/// This will result in the shaders required to support distortion being compiled which will increase shader compile time and memory usage.
		/// </summary>
		public bool bUsesDistortion;
		
		/// <summary>
		/// Indicates that the material and its instances can be use with clothing
		/// This will result in the shaders required to support clothing being compiled which will increase shader compile time and memory usage.
		/// </summary>
		public bool bUsedWithClothing;
		
		/// <summary>
		/// Indicates that the material and its instances can be use with Slate UI and UMG
		/// This will result in the shaders required to support UI materials being compiled which will increase shader compile time and memory usage.
		/// </summary>
		public bool bUsedWithUI;
		
		/// <summary>
		/// Whether to automatically set usage flags based on what the material is applied to in the editor.
		/// It can be useful to disable this on a base material with many instances, where adding another usage flag accidentally (eg bUsedWithSkeletalMeshes) can add a lot of shader permutations.
		/// </summary>
		public bool bAutomaticallySetUsageInEditor;
		
		/// <summary>Forces the material to be completely rough. Saves a number of instructions and one sampler.</summary>
		public bool bFullyRough;
		
		/// <summary>
		/// Forces this material to use full (highp) precision in the pixel shader.
		/// This is slower than the default (mediump) but can be used to work around precision-related rendering errors.
		/// This setting has no effect on older mobile devices that do not support high precision.
		/// </summary>
		public bool bUseFullPrecision;
		
		/// <summary>Use lightmap directionality and per pixel normals. If disabled, lighting from lightmaps will be flat but cheaper.</summary>
		public bool bUseLightmapDirectionality;
		
		/// <summary>
		/// * Forward renderer: enables multiple parallax-corrected reflection captures that blend together.
		/// * Mobile renderer: blend between nearest 3 reflection captures, but reduces the number of samplers available to the material as two more samplers will be used for reflection cubemaps.
		/// </summary>
		public bool bUseHQForwardReflections;
		
		/// <summary>Enables planar reflection when using the forward renderer or mobile. Enabling this setting reduces the number of samplers available to the material as one more sampler will be used for the planar reflection.</summary>
		public bool bUsePlanarForwardReflections;
		
		/// <summary>Reduce roughness based on screen space normal changes.</summary>
		public bool bNormalCurvatureToRoughness;
		
		/// <summary>The type of tessellation to apply to this object.  Note D3D11 required for anything except MTM_NoTessellation.</summary>
		public EMaterialTessellationMode D3D11TessellationMode;
		
		/// <summary>Prevents cracks in the surface of the mesh when using tessellation.</summary>
		public bool bEnableCrackFreeDisplacement;
		
		/// <summary>Enables adaptive tessellation, which tries to maintain a uniform number of pixels per triangle.</summary>
		public bool bEnableAdaptiveTessellation;
		
		public float MaxDisplacement;
		
		/// <summary>Enables a wireframe view of the mesh the material is applied to.</summary>
		public bool Wireframe;
		
		/// <summary>Skips outputting velocity during the base pass.</summary>
		public bool bOutputVelocityOnBasePass;
		
		public int EditorX;
		
		public int EditorY;
		
		public int EditorPitch;
		
		public int EditorYaw;
		
		/// <summary>true if this Material can be assumed Opaque when set to masked.</summary>
		public bool bCanMaskedBeAssumedOpaque;
		
		/// <summary>true if Material is masked and uses custom opacity</summary>
		public bool bIsMasked;
		
		/// <summary>true if Material is the preview material used in the material editor.</summary>
		public bool bIsPreviewMaterial;
		
		/// <summary>when true, the material attributes pin is used instead of the regular pins.</summary>
		public bool bUseMaterialAttributes;
		
		/// <summary>When true, translucent materials are fogged. Defaults to true.</summary>
		public bool bUseTranslucencyVertexFog;
		
		/// <summary>If true the compilation environment will be changed to remove the global COMPILE_SHADERS_FOR_DEVELOPMENT flag.</summary>
		public bool bAllowDevelopmentShaderCompile;
		
		/// <summary>true if this is a special material used for stats by the material editor.</summary>
		public bool bIsMaterialEditorStatsMaterial;
		
		/// <summary>true if we have printed a warning about material usage for a given usage flag.</summary>
		public uint UsageFlagWarnings;
		
		/// <summary>Where the node is inserted in the (post processing) graph, only used if domain is PostProcess</summary>
		public EBlendableLocation BlendableLocation;
		
		/// <summary>If multiple nodes with the same  type are inserted at the same point, this defined order and if they get combined, only used if domain is PostProcess</summary>
		public int BlendablePriority;
		
		/// <summary>If this is enabled, the blendable will output alpha</summary>
		public bool BlendableOutputAlpha;
		
		/// <summary>Controls how the Refraction input is interpreted and how the refraction offset into scene color is computed for this material.</summary>
		public ERefractionMode RefractionMode;
		
		/// <summary>This is the refraction depth bias, larger values offset distortion to prevent closer objects from rendering into the distorted surface at acute viewing angles but increases the disconnect between surface and where the refraction starts.</summary>
		public float RefractionDepthBias;
		
		/// <summary>
		/// Guid that uniquely identifies this material.
		/// Any changes to the state of the material that do not appear separately in the shadermap DDC keys must cause this guid to be regenerated!
		/// For example, a modification to the Expressions array.
		/// Code changes that cause the guid to be regenerated on load should be avoided, as that requires a resave of the content to stop recompiling every load.
		/// </summary>
		public FGuid StateId;
		
		
	}
	
}
