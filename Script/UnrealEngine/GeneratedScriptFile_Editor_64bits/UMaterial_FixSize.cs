#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>
	/// A Material is an asset which can be applied to a mesh to control the visual look of the scene.
	/// When light from the scene hits the surface, the shading model of the material is used to calculate how that light interacts with the surface.
	/// Warning: Creating new materials directly increases shader compile times!  Consider creating a Material Instance off of an existing material instead.
	/// </summary>
	public partial class UMaterial
	{
		static readonly int PhysMaterial__Offset;
		/// <summary>Physical material to use for this graphics material. Used for sounds, effects etc.</summary>
		public UPhysicalMaterial PhysMaterial
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + PhysMaterial__Offset); if (v == IntPtr.Zero)return null; UPhysicalMaterial retValue = new UPhysicalMaterial(); retValue._this = v; return retValue; }
			set{ CheckIsValid(); if (value == null)Marshal.WriteIntPtr(_this.Get() + PhysMaterial__Offset, IntPtr.Zero);else Marshal.WriteIntPtr(_this.Get() + PhysMaterial__Offset, value._this.Get()); }
			
		}
		
		static readonly int DiffuseColor__Offset;
		/// <summary>Reflection.</summary>
		public FColorMaterialInput DiffuseColor
		{
			get{ CheckIsValid();return (FColorMaterialInput)Marshal.PtrToStructure(_this.Get()+DiffuseColor__Offset, typeof(FColorMaterialInput));}
			
		}
		
		static readonly int SpecularColor__Offset;
		public FColorMaterialInput SpecularColor
		{
			get{ CheckIsValid();return (FColorMaterialInput)Marshal.PtrToStructure(_this.Get()+SpecularColor__Offset, typeof(FColorMaterialInput));}
			
		}
		
		static readonly int BaseColor__Offset;
		public FColorMaterialInput BaseColor
		{
			get{ CheckIsValid();return (FColorMaterialInput)Marshal.PtrToStructure(_this.Get()+BaseColor__Offset, typeof(FColorMaterialInput));}
			
		}
		
		static readonly int Metallic__Offset;
		public FScalarMaterialInput Metallic
		{
			get{ CheckIsValid();return (FScalarMaterialInput)Marshal.PtrToStructure(_this.Get()+Metallic__Offset, typeof(FScalarMaterialInput));}
			
		}
		
		static readonly int Specular__Offset;
		public FScalarMaterialInput Specular
		{
			get{ CheckIsValid();return (FScalarMaterialInput)Marshal.PtrToStructure(_this.Get()+Specular__Offset, typeof(FScalarMaterialInput));}
			
		}
		
		static readonly int Roughness__Offset;
		public FScalarMaterialInput Roughness
		{
			get{ CheckIsValid();return (FScalarMaterialInput)Marshal.PtrToStructure(_this.Get()+Roughness__Offset, typeof(FScalarMaterialInput));}
			
		}
		
		static readonly int Normal__Offset;
		public FVectorMaterialInput Normal
		{
			get{ CheckIsValid();return (FVectorMaterialInput)Marshal.PtrToStructure(_this.Get()+Normal__Offset, typeof(FVectorMaterialInput));}
			
		}
		
		static readonly int EmissiveColor__Offset;
		/// <summary>Emission.</summary>
		public FColorMaterialInput EmissiveColor
		{
			get{ CheckIsValid();return (FColorMaterialInput)Marshal.PtrToStructure(_this.Get()+EmissiveColor__Offset, typeof(FColorMaterialInput));}
			
		}
		
		static readonly int Opacity__Offset;
		/// <summary>Transmission.</summary>
		public FScalarMaterialInput Opacity
		{
			get{ CheckIsValid();return (FScalarMaterialInput)Marshal.PtrToStructure(_this.Get()+Opacity__Offset, typeof(FScalarMaterialInput));}
			
		}
		
		static readonly int OpacityMask__Offset;
		public FScalarMaterialInput OpacityMask
		{
			get{ CheckIsValid();return (FScalarMaterialInput)Marshal.PtrToStructure(_this.Get()+OpacityMask__Offset, typeof(FScalarMaterialInput));}
			
		}
		
		static readonly int MaterialDomain__Offset;
		/// <summary>
		/// The domain that the material's attributes will be evaluated in.
		/// Certain pieces of material functionality are only valid in certain domains, for example vertex normal is only valid on a surface.
		/// </summary>
		public EMaterialDomain MaterialDomain
		{
			get{ CheckIsValid();return (EMaterialDomain)Marshal.PtrToStructure(_this.Get()+MaterialDomain__Offset, typeof(EMaterialDomain));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+MaterialDomain__Offset, false);}
			
		}
		
		static readonly int BlendMode__Offset;
		/// <summary>Determines how the material's color is blended with background colors.</summary>
		public EBlendMode BlendMode
		{
			get{ CheckIsValid();return (EBlendMode)Marshal.PtrToStructure(_this.Get()+BlendMode__Offset, typeof(EBlendMode));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+BlendMode__Offset, false);}
			
		}
		
		static readonly int DecalBlendMode__Offset;
		/// <summary>Defines how the GBuffer chanels are getting manipulated by a decal material pass. (only with MaterialDomain == MD_DeferredDecal)</summary>
		public EDecalBlendMode DecalBlendMode
		{
			get{ CheckIsValid();return (EDecalBlendMode)Marshal.PtrToStructure(_this.Get()+DecalBlendMode__Offset, typeof(EDecalBlendMode));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+DecalBlendMode__Offset, false);}
			
		}
		
		static readonly int MaterialDecalResponse__Offset;
		/// <summary>
		/// Defines how the material reacts on DBuffer decals (Affects look, performance and texture/sample usage).
		/// Non DBuffer Decals can be disabled on the primitive (e.g. static mesh)
		/// </summary>
		public EMaterialDecalResponse MaterialDecalResponse
		{
			get{ CheckIsValid();return (EMaterialDecalResponse)Marshal.PtrToStructure(_this.Get()+MaterialDecalResponse__Offset, typeof(EMaterialDecalResponse));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+MaterialDecalResponse__Offset, false);}
			
		}
		
		static readonly int ShadingModel__Offset;
		/// <summary>Determines how inputs are combined to create the material's final color.</summary>
		public EMaterialShadingModel ShadingModel
		{
			get{ CheckIsValid();return (EMaterialShadingModel)Marshal.PtrToStructure(_this.Get()+ShadingModel__Offset, typeof(EMaterialShadingModel));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+ShadingModel__Offset, false);}
			
		}
		
		static readonly int OpacityMaskClipValue__Offset;
		/// <summary>If BlendMode is BLEND_Masked, the surface is not rendered where OpacityMask < OpacityMaskClipValue.</summary>
		public float OpacityMaskClipValue
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+OpacityMaskClipValue__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+OpacityMaskClipValue__Offset, false);}
			
		}
		
		static readonly int WorldPositionOffset__Offset;
		/// <summary>Adds to world position in the vertex shader.</summary>
		public FVectorMaterialInput WorldPositionOffset
		{
			get{ CheckIsValid();return (FVectorMaterialInput)Marshal.PtrToStructure(_this.Get()+WorldPositionOffset__Offset, typeof(FVectorMaterialInput));}
			
		}
		
		static readonly int WorldDisplacement__Offset;
		/// <summary>Offset in world space applied to tessellated vertices.</summary>
		public FVectorMaterialInput WorldDisplacement
		{
			get{ CheckIsValid();return (FVectorMaterialInput)Marshal.PtrToStructure(_this.Get()+WorldDisplacement__Offset, typeof(FVectorMaterialInput));}
			
		}
		
		static readonly int TessellationMultiplier__Offset;
		/// <summary>Multiplies the tessellation factors applied when a tessellation mode is set.</summary>
		public FScalarMaterialInput TessellationMultiplier
		{
			get{ CheckIsValid();return (FScalarMaterialInput)Marshal.PtrToStructure(_this.Get()+TessellationMultiplier__Offset, typeof(FScalarMaterialInput));}
			
		}
		
		static readonly int SubsurfaceColor__Offset;
		/// <summary>Inner material color, only used for ShadingModel=Subsurface</summary>
		public FColorMaterialInput SubsurfaceColor
		{
			get{ CheckIsValid();return (FColorMaterialInput)Marshal.PtrToStructure(_this.Get()+SubsurfaceColor__Offset, typeof(FColorMaterialInput));}
			
		}
		
		static readonly int ClearCoat__Offset;
		public FScalarMaterialInput ClearCoat
		{
			get{ CheckIsValid();return (FScalarMaterialInput)Marshal.PtrToStructure(_this.Get()+ClearCoat__Offset, typeof(FScalarMaterialInput));}
			
		}
		
		static readonly int ClearCoatRoughness__Offset;
		public FScalarMaterialInput ClearCoatRoughness
		{
			get{ CheckIsValid();return (FScalarMaterialInput)Marshal.PtrToStructure(_this.Get()+ClearCoatRoughness__Offset, typeof(FScalarMaterialInput));}
			
		}
		
		static readonly int AmbientOcclusion__Offset;
		/// <summary>output ambient occlusion to the GBuffer</summary>
		public FScalarMaterialInput AmbientOcclusion
		{
			get{ CheckIsValid();return (FScalarMaterialInput)Marshal.PtrToStructure(_this.Get()+AmbientOcclusion__Offset, typeof(FScalarMaterialInput));}
			
		}
		
		static readonly int Refraction__Offset;
		/// <summary>
		/// output refraction index for translucent rendering
		/// Air:1.0 Water:1.333 Ice:1.3 Glass:~1.6 Diamond:2.42
		/// </summary>
		public FScalarMaterialInput Refraction
		{
			get{ CheckIsValid();return (FScalarMaterialInput)Marshal.PtrToStructure(_this.Get()+Refraction__Offset, typeof(FScalarMaterialInput));}
			
		}
		
		static readonly int CustomizedUVs__Offset;
		/// <summary>
		/// These inputs are evaluated in the vertex shader and allow artists to do arbitrary vertex shader operations and access them in the pixel shader.
		/// When unconnected or hidden they default to passing through the vertex UVs.
		/// </summary>
		public FVector2MaterialInput CustomizedUVs
		{
			get{ CheckIsValid();return (FVector2MaterialInput)Marshal.PtrToStructure(_this.Get()+CustomizedUVs__Offset, typeof(FVector2MaterialInput));}
			
		}
		
		static readonly int MaterialAttributes__Offset;
		public FMaterialAttributesInput MaterialAttributes
		{
			get{ CheckIsValid();return (FMaterialAttributesInput)Marshal.PtrToStructure(_this.Get()+MaterialAttributes__Offset, typeof(FMaterialAttributesInput));}
			
		}
		
		static readonly int PixelDepthOffset__Offset;
		public FScalarMaterialInput PixelDepthOffset
		{
			get{ CheckIsValid();return (FScalarMaterialInput)Marshal.PtrToStructure(_this.Get()+PixelDepthOffset__Offset, typeof(FScalarMaterialInput));}
			
		}
		
		static readonly int bEnableSeparateTranslucency__Offset;
		/// <summary>Indicates that the material should be rendered in the SeparateTranslucency Pass (not affected by DOF, requires bAllowSeparateTranslucency to be set in .ini).</summary>
		public bool bEnableSeparateTranslucency
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bEnableSeparateTranslucency__Offset, 1, 0, 1, 1);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bEnableSeparateTranslucency__Offset, 1,0,1,1);}
			
		}
		
		static readonly int bEnableMobileSeparateTranslucency__Offset;
		/// <summary>Indicates that the translucent material should not be affected by bloom or DOF. (Note: Depth testing is not available)</summary>
		public bool bEnableMobileSeparateTranslucency
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bEnableMobileSeparateTranslucency__Offset, 1, 0, 2, 2);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bEnableMobileSeparateTranslucency__Offset, 1,0,2,2);}
			
		}
		
		static readonly int bEnableResponsiveAA__Offset;
		/// <summary>
		/// Indicates that the material should be rendered using responsive anti-aliasing. Improves sharpness of small moving particles such as sparks.
		/// Only use for small moving features because it will cause aliasing of the background.
		/// </summary>
		public bool bEnableResponsiveAA
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bEnableResponsiveAA__Offset, 1, 0, 4, 4);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bEnableResponsiveAA__Offset, 1,0,4,4);}
			
		}
		
		static readonly int bScreenSpaceReflections__Offset;
		/// <summary>SSR on translucency</summary>
		public bool bScreenSpaceReflections
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bScreenSpaceReflections__Offset, 1, 0, 8, 8);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bScreenSpaceReflections__Offset, 1,0,8,8);}
			
		}
		
		static readonly int TwoSided__Offset;
		/// <summary>Indicates that the material should be rendered without backface culling and the normal should be flipped for backfaces.</summary>
		public bool TwoSided
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), TwoSided__Offset, 1, 0, 16, 16);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), TwoSided__Offset, 1,0,16,16);}
			
		}
		
		static readonly int DitheredLODTransition__Offset;
		/// <summary>Whether meshes rendered with the material should support dithered LOD transitions.</summary>
		public bool DitheredLODTransition
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), DitheredLODTransition__Offset, 1, 0, 32, 32);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), DitheredLODTransition__Offset, 1,0,32,32);}
			
		}
		
		static readonly int DitherOpacityMask__Offset;
		/// <summary>Dither opacity mask. When combined with Temporal AA this can be used as a form of limited translucency which supports all lighting features.</summary>
		public bool DitherOpacityMask
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), DitherOpacityMask__Offset, 1, 0, 64, 64);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), DitherOpacityMask__Offset, 1,0,64,64);}
			
		}
		
		static readonly int bAllowNegativeEmissiveColor__Offset;
		/// <summary>Whether the material should allow outputting negative emissive color values.  Only allowed on unlit materials.</summary>
		public bool bAllowNegativeEmissiveColor
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bAllowNegativeEmissiveColor__Offset, 1, 0, 128, 128);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bAllowNegativeEmissiveColor__Offset, 1,0,128,128);}
			
		}
		
		static readonly int NumCustomizedUVs__Offset;
		/// <summary>Number of customized UV inputs to display.  Unconnected customized UV inputs will just pass through the vertex UVs.</summary>
		public int NumCustomizedUVs
		{
			get{ CheckIsValid();return (int)Marshal.PtrToStructure(_this.Get()+NumCustomizedUVs__Offset, typeof(int));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+NumCustomizedUVs__Offset, false);}
			
		}
		
		static readonly int TranslucencyLightingMode__Offset;
		/// <summary>Sets the lighting mode that will be used on this material if it is translucent.</summary>
		public ETranslucencyLightingMode TranslucencyLightingMode
		{
			get{ CheckIsValid();return (ETranslucencyLightingMode)Marshal.PtrToStructure(_this.Get()+TranslucencyLightingMode__Offset, typeof(ETranslucencyLightingMode));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+TranslucencyLightingMode__Offset, false);}
			
		}
		
		static readonly int TranslucencyDirectionalLightingIntensity__Offset;
		/// <summary>
		/// Useful for artificially increasing the influence of the normal on the lighting result for translucency.
		/// A value larger than 1 increases the influence of the normal, a value smaller than 1 makes the lighting more ambient.
		/// </summary>
		public float TranslucencyDirectionalLightingIntensity
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+TranslucencyDirectionalLightingIntensity__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+TranslucencyDirectionalLightingIntensity__Offset, false);}
			
		}
		
		static readonly int AllowTranslucentCustomDepthWrites__Offset;
		/// <summary>Allows a translucenct material to be used with custom depth writing by compiling additional shaders.</summary>
		public bool AllowTranslucentCustomDepthWrites
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), AllowTranslucentCustomDepthWrites__Offset, 1, 0, 1, 1);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), AllowTranslucentCustomDepthWrites__Offset, 1,0,1,1);}
			
		}
		
		static readonly int TranslucentShadowDensityScale__Offset;
		/// <summary>Scale used to make translucent shadows more or less opaque than the material's actual opacity.</summary>
		public float TranslucentShadowDensityScale
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+TranslucentShadowDensityScale__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+TranslucentShadowDensityScale__Offset, false);}
			
		}
		
		static readonly int TranslucentSelfShadowDensityScale__Offset;
		/// <summary>
		/// Scale used to make translucent self-shadowing more or less opaque than the material's shadow on other objects.
		/// This is only used when the object is casting a volumetric translucent shadow.
		/// </summary>
		public float TranslucentSelfShadowDensityScale
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+TranslucentSelfShadowDensityScale__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+TranslucentSelfShadowDensityScale__Offset, false);}
			
		}
		
		static readonly int TranslucentSelfShadowSecondDensityScale__Offset;
		/// <summary>Used to make a second self shadow gradient, to add interesting shading in the shadow of the first.</summary>
		public float TranslucentSelfShadowSecondDensityScale
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+TranslucentSelfShadowSecondDensityScale__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+TranslucentSelfShadowSecondDensityScale__Offset, false);}
			
		}
		
		static readonly int TranslucentSelfShadowSecondOpacity__Offset;
		/// <summary>Controls the strength of the second self shadow gradient.</summary>
		public float TranslucentSelfShadowSecondOpacity
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+TranslucentSelfShadowSecondOpacity__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+TranslucentSelfShadowSecondOpacity__Offset, false);}
			
		}
		
		static readonly int TranslucentBackscatteringExponent__Offset;
		/// <summary>
		/// Controls how diffuse the material's backscattering is when using the MSM_Subsurface shading model.
		/// Larger exponents give a less diffuse look (smaller, brighter backscattering highlight).
		/// This is only used when the object is casting a volumetric translucent shadow from a directional light.
		/// </summary>
		public float TranslucentBackscatteringExponent
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+TranslucentBackscatteringExponent__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+TranslucentBackscatteringExponent__Offset, false);}
			
		}
		
		static readonly int TranslucentMultipleScatteringExtinction__Offset;
		/// <summary>
		/// Colored extinction factor used to approximate multiple scattering in dense volumes.
		/// This is only used when the object is casting a volumetric translucent shadow.
		/// </summary>
		public FLinearColor TranslucentMultipleScatteringExtinction
		{
			get{ CheckIsValid();return (FLinearColor)Marshal.PtrToStructure(_this.Get()+TranslucentMultipleScatteringExtinction__Offset, typeof(FLinearColor));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+TranslucentMultipleScatteringExtinction__Offset, false);}
			
		}
		
		static readonly int TranslucentShadowStartOffset__Offset;
		/// <summary>Local space distance to bias the translucent shadow.  Positive values move the shadow away from the light.</summary>
		public float TranslucentShadowStartOffset
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+TranslucentShadowStartOffset__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+TranslucentShadowStartOffset__Offset, false);}
			
		}
		
		static readonly int bDisableDepthTest__Offset;
		/// <summary>Whether to draw on top of opaque pixels even if behind them. This only has meaning for translucency.</summary>
		public bool bDisableDepthTest
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bDisableDepthTest__Offset, 1, 0, 1, 1);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bDisableDepthTest__Offset, 1,0,1,1);}
			
		}
		
		static readonly int bGenerateSphericalParticleNormals__Offset;
		/// <summary>Whether to generate spherical normals for particles that use this material.</summary>
		public bool bGenerateSphericalParticleNormals
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bGenerateSphericalParticleNormals__Offset, 1, 0, 2, 2);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bGenerateSphericalParticleNormals__Offset, 1,0,2,2);}
			
		}
		
		static readonly int bTangentSpaceNormal__Offset;
		/// <summary>
		/// Whether the material takes a tangent space normal or a world space normal as input.
		/// (TangentSpace requires extra instructions but is often more convenient).
		/// </summary>
		public bool bTangentSpaceNormal
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bTangentSpaceNormal__Offset, 1, 0, 4, 4);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bTangentSpaceNormal__Offset, 1,0,4,4);}
			
		}
		
		static readonly int bUseEmissiveForDynamicAreaLighting__Offset;
		/// <summary>If enabled, the material's emissive colour is injected into the LightPropagationVolume</summary>
		public bool bUseEmissiveForDynamicAreaLighting
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bUseEmissiveForDynamicAreaLighting__Offset, 1, 0, 8, 8);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bUseEmissiveForDynamicAreaLighting__Offset, 1,0,8,8);}
			
		}
		
		static readonly int bBlockGI__Offset;
		/// <summary>If enabled, the material's opacity defines how much GI is blocked when using the LightPropagationVolume feature</summary>
		public bool bBlockGI
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bBlockGI__Offset, 1, 0, 16, 16);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bBlockGI__Offset, 1,0,16,16);}
			
		}
		
		static readonly int bUsedAsSpecialEngineMaterial__Offset;
		/// <summary>
		/// This is a special usage flag that allows a material to be assignable to any primitive type.
		/// This is useful for materials used by code to implement certain viewmodes, for example the default material or lighting only material.
		/// The cost is that nearly 20x more shaders will be compiled for the material than the average material, which will greatly increase shader compile time and memory usage.
		/// This flag should only be enabled when absolutely necessary, and is purposefully not exposed to the UI to prevent abuse.
		/// </summary>
		public bool bUsedAsSpecialEngineMaterial
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bUsedAsSpecialEngineMaterial__Offset, 1, 0, 32, 32);}
			
		}
		
		static readonly int bUsedWithSkeletalMesh__Offset;
		/// <summary>
		/// Indicates that the material and its instances can be use with skeletal meshes.
		/// This will result in the shaders required to support skeletal meshes being compiled which will increase shader compile time and memory usage.
		/// </summary>
		public bool bUsedWithSkeletalMesh
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bUsedWithSkeletalMesh__Offset, 1, 0, 64, 64);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bUsedWithSkeletalMesh__Offset, 1,0,64,64);}
			
		}
		
		static readonly int bUsedWithEditorCompositing__Offset;
		/// <summary>
		/// Indicates that the material and its instances can be use with editor compositing
		/// This will result in the shaders required to support editor compositing being compiled which will increase shader compile time and memory usage.
		/// </summary>
		public bool bUsedWithEditorCompositing
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bUsedWithEditorCompositing__Offset, 1, 0, 128, 128);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bUsedWithEditorCompositing__Offset, 1,0,128,128);}
			
		}
		
		static readonly int bUsedWithParticleSprites__Offset;
		/// <summary>
		/// Indicates that the material and its instances can be use with particle sprites
		/// This will result in the shaders required to support particle sprites being compiled which will increase shader compile time and memory usage.
		/// </summary>
		public bool bUsedWithParticleSprites
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bUsedWithParticleSprites__Offset, 1, 0, 1, 1);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bUsedWithParticleSprites__Offset, 1,0,1,1);}
			
		}
		
		static readonly int bUsedWithBeamTrails__Offset;
		/// <summary>
		/// Indicates that the material and its instances can be use with beam trails
		/// This will result in the shaders required to support beam trails being compiled which will increase shader compile time and memory usage.
		/// </summary>
		public bool bUsedWithBeamTrails
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bUsedWithBeamTrails__Offset, 1, 0, 2, 2);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bUsedWithBeamTrails__Offset, 1,0,2,2);}
			
		}
		
		static readonly int bUsedWithMeshParticles__Offset;
		/// <summary>
		/// Indicates that the material and its instances can be use with mesh particles
		/// This will result in the shaders required to support mesh particles being compiled which will increase shader compile time and memory usage.
		/// </summary>
		public bool bUsedWithMeshParticles
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bUsedWithMeshParticles__Offset, 1, 0, 4, 4);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bUsedWithMeshParticles__Offset, 1,0,4,4);}
			
		}
		
		static readonly int bUsedWithStaticLighting__Offset;
		/// <summary>
		/// Indicates that the material and its instances can be use with static lighting
		/// This will result in the shaders required to support static lighting being compiled which will increase shader compile time and memory usage.
		/// </summary>
		public bool bUsedWithStaticLighting
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bUsedWithStaticLighting__Offset, 1, 0, 8, 8);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bUsedWithStaticLighting__Offset, 1,0,8,8);}
			
		}
		
		static readonly int bUsedWithMorphTargets__Offset;
		/// <summary>
		/// Indicates that the material and its instances can be use with morph targets
		/// This will result in the shaders required to support morph targets being compiled which will increase shader compile time and memory usage.
		/// </summary>
		public bool bUsedWithMorphTargets
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bUsedWithMorphTargets__Offset, 1, 0, 16, 16);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bUsedWithMorphTargets__Offset, 1,0,16,16);}
			
		}
		
		static readonly int bUsedWithSplineMeshes__Offset;
		/// <summary>
		/// Indicates that the material and its instances can be use with spline meshes
		/// This will result in the shaders required to support spline meshes being compiled which will increase shader compile time and memory usage.
		/// </summary>
		public bool bUsedWithSplineMeshes
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bUsedWithSplineMeshes__Offset, 1, 0, 32, 32);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bUsedWithSplineMeshes__Offset, 1,0,32,32);}
			
		}
		
		static readonly int bUsedWithInstancedStaticMeshes__Offset;
		/// <summary>
		/// Indicates that the material and its instances can be use with instanced static meshes
		/// This will result in the shaders required to support instanced static meshes being compiled which will increase shader compile time and memory usage.
		/// </summary>
		public bool bUsedWithInstancedStaticMeshes
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bUsedWithInstancedStaticMeshes__Offset, 1, 0, 64, 64);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bUsedWithInstancedStaticMeshes__Offset, 1,0,64,64);}
			
		}
		
		static readonly int bUsesDistortion__Offset;
		/// <summary>
		/// Indicates that the material and its instances can be use with distortion
		/// This will result in the shaders required to support distortion being compiled which will increase shader compile time and memory usage.
		/// </summary>
		public bool bUsesDistortion
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bUsesDistortion__Offset, 1, 0, 128, 128);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bUsesDistortion__Offset, 1,0,128,128);}
			
		}
		
		static readonly int bUsedWithClothing__Offset;
		/// <summary>
		/// Indicates that the material and its instances can be use with clothing
		/// This will result in the shaders required to support clothing being compiled which will increase shader compile time and memory usage.
		/// </summary>
		public bool bUsedWithClothing
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bUsedWithClothing__Offset, 1, 0, 1, 1);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bUsedWithClothing__Offset, 1,0,1,1);}
			
		}
		
		static readonly int bUsedWithUI__Offset;
		/// <summary>
		/// Indicates that the material and its instances can be use with Slate UI and UMG
		/// This will result in the shaders required to support UI materials being compiled which will increase shader compile time and memory usage.
		/// </summary>
		public bool bUsedWithUI
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bUsedWithUI__Offset, 1, 0, 2, 2);}
			
		}
		
		static readonly int bAutomaticallySetUsageInEditor__Offset;
		/// <summary>
		/// Whether to automatically set usage flags based on what the material is applied to in the editor.
		/// It can be useful to disable this on a base material with many instances, where adding another usage flag accidentally (eg bUsedWithSkeletalMeshes) can add a lot of shader permutations.
		/// </summary>
		public bool bAutomaticallySetUsageInEditor
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bAutomaticallySetUsageInEditor__Offset, 1, 0, 4, 4);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bAutomaticallySetUsageInEditor__Offset, 1,0,4,4);}
			
		}
		
		static readonly int bFullyRough__Offset;
		/// <summary>Forces the material to be completely rough. Saves a number of instructions and one sampler.</summary>
		public bool bFullyRough
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bFullyRough__Offset, 1, 0, 8, 8);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bFullyRough__Offset, 1,0,8,8);}
			
		}
		
		static readonly int bUseFullPrecision__Offset;
		/// <summary>
		/// Forces this material to use full (highp) precision in the pixel shader.
		/// This is slower than the default (mediump) but can be used to work around precision-related rendering errors.
		/// This setting has no effect on older mobile devices that do not support high precision.
		/// </summary>
		public bool bUseFullPrecision
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bUseFullPrecision__Offset, 1, 0, 16, 16);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bUseFullPrecision__Offset, 1,0,16,16);}
			
		}
		
		static readonly int bUseLightmapDirectionality__Offset;
		/// <summary>Use lightmap directionality and per pixel normals. If disabled, lighting from lightmaps will be flat but cheaper.</summary>
		public bool bUseLightmapDirectionality
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bUseLightmapDirectionality__Offset, 1, 0, 32, 32);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bUseLightmapDirectionality__Offset, 1,0,32,32);}
			
		}
		
		static readonly int bUseHQForwardReflections__Offset;
		/// <summary>
		/// * Forward renderer: enables multiple parallax-corrected reflection captures that blend together.
		/// * Mobile renderer: blend between nearest 3 reflection captures, but reduces the number of samplers available to the material as two more samplers will be used for reflection cubemaps.
		/// </summary>
		public bool bUseHQForwardReflections
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bUseHQForwardReflections__Offset, 1, 0, 64, 64);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bUseHQForwardReflections__Offset, 1,0,64,64);}
			
		}
		
		static readonly int bUsePlanarForwardReflections__Offset;
		/// <summary>Enables planar reflection when using the forward renderer or mobile. Enabling this setting reduces the number of samplers available to the material as one more sampler will be used for the planar reflection.</summary>
		public bool bUsePlanarForwardReflections
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bUsePlanarForwardReflections__Offset, 1, 0, 128, 128);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bUsePlanarForwardReflections__Offset, 1,0,128,128);}
			
		}
		
		static readonly int bNormalCurvatureToRoughness__Offset;
		/// <summary>Reduce roughness based on screen space normal changes.</summary>
		public bool bNormalCurvatureToRoughness
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bNormalCurvatureToRoughness__Offset, 1, 0, 1, 1);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bNormalCurvatureToRoughness__Offset, 1,0,1,1);}
			
		}
		
		static readonly int D3D11TessellationMode__Offset;
		/// <summary>The type of tessellation to apply to this object.  Note D3D11 required for anything except MTM_NoTessellation.</summary>
		public EMaterialTessellationMode D3D11TessellationMode
		{
			get{ CheckIsValid();return (EMaterialTessellationMode)Marshal.PtrToStructure(_this.Get()+D3D11TessellationMode__Offset, typeof(EMaterialTessellationMode));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+D3D11TessellationMode__Offset, false);}
			
		}
		
		static readonly int bEnableCrackFreeDisplacement__Offset;
		/// <summary>Prevents cracks in the surface of the mesh when using tessellation.</summary>
		public bool bEnableCrackFreeDisplacement
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bEnableCrackFreeDisplacement__Offset, 1, 0, 1, 1);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bEnableCrackFreeDisplacement__Offset, 1,0,1,1);}
			
		}
		
		static readonly int bEnableAdaptiveTessellation__Offset;
		/// <summary>Enables adaptive tessellation, which tries to maintain a uniform number of pixels per triangle.</summary>
		public bool bEnableAdaptiveTessellation
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bEnableAdaptiveTessellation__Offset, 1, 0, 2, 2);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bEnableAdaptiveTessellation__Offset, 1,0,2,2);}
			
		}
		
		static readonly int MaxDisplacement__Offset;
		public float MaxDisplacement
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+MaxDisplacement__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+MaxDisplacement__Offset, false);}
			
		}
		
		static readonly int Wireframe__Offset;
		/// <summary>Enables a wireframe view of the mesh the material is applied to.</summary>
		public bool Wireframe
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), Wireframe__Offset, 1, 0, 1, 1);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), Wireframe__Offset, 1,0,1,1);}
			
		}
		
		static readonly int bOutputVelocityOnBasePass__Offset;
		/// <summary>Skips outputting velocity during the base pass.</summary>
		public bool bOutputVelocityOnBasePass
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bOutputVelocityOnBasePass__Offset, 1, 0, 2, 2);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bOutputVelocityOnBasePass__Offset, 1,0,2,2);}
			
		}
		
		static readonly int EditorX__Offset;
		public int EditorX
		{
			get{ CheckIsValid();return (int)Marshal.PtrToStructure(_this.Get()+EditorX__Offset, typeof(int));}
			
		}
		
		static readonly int EditorY__Offset;
		public int EditorY
		{
			get{ CheckIsValid();return (int)Marshal.PtrToStructure(_this.Get()+EditorY__Offset, typeof(int));}
			
		}
		
		static readonly int EditorPitch__Offset;
		public int EditorPitch
		{
			get{ CheckIsValid();return (int)Marshal.PtrToStructure(_this.Get()+EditorPitch__Offset, typeof(int));}
			
		}
		
		static readonly int EditorYaw__Offset;
		public int EditorYaw
		{
			get{ CheckIsValid();return (int)Marshal.PtrToStructure(_this.Get()+EditorYaw__Offset, typeof(int));}
			
		}
		
		static readonly int Expressions__Offset;
		/// <summary>Array of material expressions, excluding Comments.  Used by the material editor.</summary>
		public TObjectArray<UMaterialExpression>  Expressions
		{
					get{ CheckIsValid();return new TObjectArray<UMaterialExpression>((FScriptArray)Marshal.PtrToStructure(_this.Get()+Expressions__Offset, typeof(FScriptArray)));}
					set{ CheckIsValid();Marshal.StructureToPtr(value.InterArray, _this.Get()+Expressions__Offset, false);}
			
		}
		
		static readonly int EditorComments__Offset;
		/// <summary>Array of comments associated with this material; viewed in the material editor.</summary>
		public TObjectArray<UMaterialExpressionComment>  EditorComments
		{
					get{ CheckIsValid();return new TObjectArray<UMaterialExpressionComment>((FScriptArray)Marshal.PtrToStructure(_this.Get()+EditorComments__Offset, typeof(FScriptArray)));}
					set{ CheckIsValid();Marshal.StructureToPtr(value.InterArray, _this.Get()+EditorComments__Offset, false);}
			
		}
		
		static readonly int MaterialFunctionInfos__Offset;
		/// <summary>Array of all functions this material depends on.</summary>
		public TStructArray<FMaterialFunctionInfo> MaterialFunctionInfos
		{
			get{ CheckIsValid();return new TStructArray<FMaterialFunctionInfo>((FScriptArray)Marshal.PtrToStructure(_this.Get()+MaterialFunctionInfos__Offset, typeof(FScriptArray)));}
					set{ CheckIsValid();Marshal.StructureToPtr(value.InterArray, _this.Get()+MaterialFunctionInfos__Offset, false);}
			
		}
		
		static readonly int MaterialParameterCollectionInfos__Offset;
		/// <summary>Array of all parameter collections this material depends on.</summary>
		public TStructArray<FMaterialParameterCollectionInfo> MaterialParameterCollectionInfos
		{
			get{ CheckIsValid();return new TStructArray<FMaterialParameterCollectionInfo>((FScriptArray)Marshal.PtrToStructure(_this.Get()+MaterialParameterCollectionInfos__Offset, typeof(FScriptArray)));}
					set{ CheckIsValid();Marshal.StructureToPtr(value.InterArray, _this.Get()+MaterialParameterCollectionInfos__Offset, false);}
			
		}
		
		static readonly int bCanMaskedBeAssumedOpaque__Offset;
		/// <summary>true if this Material can be assumed Opaque when set to masked.</summary>
		public bool bCanMaskedBeAssumedOpaque
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bCanMaskedBeAssumedOpaque__Offset, 1, 0, 1, 1);}
			
		}
		
		static readonly int bIsMasked__Offset;
		/// <summary>true if Material is masked and uses custom opacity</summary>
		public bool bIsMasked
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bIsMasked__Offset, 1, 0, 2, 2);}
			
		}
		
		static readonly int bIsPreviewMaterial__Offset;
		/// <summary>true if Material is the preview material used in the material editor.</summary>
		public bool bIsPreviewMaterial
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bIsPreviewMaterial__Offset, 1, 0, 4, 4);}
			
		}
		
		static readonly int bUseMaterialAttributes__Offset;
		/// <summary>when true, the material attributes pin is used instead of the regular pins.</summary>
		public bool bUseMaterialAttributes
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bUseMaterialAttributes__Offset, 1, 0, 8, 8);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bUseMaterialAttributes__Offset, 1,0,8,8);}
			
		}
		
		static readonly int bUseTranslucencyVertexFog__Offset;
		/// <summary>When true, translucent materials are fogged. Defaults to true.</summary>
		public bool bUseTranslucencyVertexFog
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bUseTranslucencyVertexFog__Offset, 1, 0, 16, 16);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bUseTranslucencyVertexFog__Offset, 1,0,16,16);}
			
		}
		
		static readonly int bAllowDevelopmentShaderCompile__Offset;
		/// <summary>If true the compilation environment will be changed to remove the global COMPILE_SHADERS_FOR_DEVELOPMENT flag.</summary>
		public bool bAllowDevelopmentShaderCompile
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bAllowDevelopmentShaderCompile__Offset, 1, 0, 32, 32);}
			
		}
		
		static readonly int bIsMaterialEditorStatsMaterial__Offset;
		/// <summary>true if this is a special material used for stats by the material editor.</summary>
		public bool bIsMaterialEditorStatsMaterial
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bIsMaterialEditorStatsMaterial__Offset, 1, 0, 64, 64);}
			
		}
		
		static readonly int UsageFlagWarnings__Offset;
		/// <summary>true if we have printed a warning about material usage for a given usage flag.</summary>
		public uint UsageFlagWarnings
		{
			get{ CheckIsValid();return (uint)Marshal.PtrToStructure(_this.Get()+UsageFlagWarnings__Offset, typeof(uint));}
			
		}
		
		static readonly int BlendableLocation__Offset;
		/// <summary>Where the node is inserted in the (post processing) graph, only used if domain is PostProcess</summary>
		public EBlendableLocation BlendableLocation
		{
			get{ CheckIsValid();return (EBlendableLocation)Marshal.PtrToStructure(_this.Get()+BlendableLocation__Offset, typeof(EBlendableLocation));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+BlendableLocation__Offset, false);}
			
		}
		
		static readonly int BlendablePriority__Offset;
		/// <summary>If multiple nodes with the same  type are inserted at the same point, this defined order and if they get combined, only used if domain is PostProcess</summary>
		public int BlendablePriority
		{
			get{ CheckIsValid();return (int)Marshal.PtrToStructure(_this.Get()+BlendablePriority__Offset, typeof(int));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+BlendablePriority__Offset, false);}
			
		}
		
		static readonly int BlendableOutputAlpha__Offset;
		/// <summary>If this is enabled, the blendable will output alpha</summary>
		public bool BlendableOutputAlpha
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), BlendableOutputAlpha__Offset, 1, 0, 1, 255);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), BlendableOutputAlpha__Offset, 1,0,1,255);}
			
		}
		
		static readonly int RefractionMode__Offset;
		/// <summary>Controls how the Refraction input is interpreted and how the refraction offset into scene color is computed for this material.</summary>
		public ERefractionMode RefractionMode
		{
			get{ CheckIsValid();return (ERefractionMode)Marshal.PtrToStructure(_this.Get()+RefractionMode__Offset, typeof(ERefractionMode));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+RefractionMode__Offset, false);}
			
		}
		
		static readonly int RefractionDepthBias__Offset;
		/// <summary>This is the refraction depth bias, larger values offset distortion to prevent closer objects from rendering into the distorted surface at acute viewing angles but increases the disconnect between surface and where the refraction starts.</summary>
		public float RefractionDepthBias
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+RefractionDepthBias__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+RefractionDepthBias__Offset, false);}
			
		}
		
		static readonly int StateId__Offset;
		/// <summary>
		/// Guid that uniquely identifies this material.
		/// Any changes to the state of the material that do not appear separately in the shadermap DDC keys must cause this guid to be regenerated!
		/// For example, a modification to the Expressions array.
		/// Code changes that cause the guid to be regenerated on load should be avoided, as that requires a resave of the content to stop recompiling every load.
		/// </summary>
		public FGuid StateId
		{
			get{ CheckIsValid();return (FGuid)Marshal.PtrToStructure(_this.Get()+StateId__Offset, typeof(FGuid));}
			
		}
		
		static readonly int ExpressionTextureReferences__Offset;
		/// <summary>
		/// Cached texture references from all expressions in the material (including nested functions).
		/// This is used to link uniform texture expressions which were stored in the DDC with the UTextures that they reference.
		/// </summary>
		public TObjectArray<UTexture>  ExpressionTextureReferences
		{
					get{ CheckIsValid();return new TObjectArray<UTexture>((FScriptArray)Marshal.PtrToStructure(_this.Get()+ExpressionTextureReferences__Offset, typeof(FScriptArray)));}
					set{ CheckIsValid();Marshal.StructureToPtr(value.InterArray, _this.Get()+ExpressionTextureReferences__Offset, false);}
			
		}
		
		static readonly int ReferencedTextureGuids__Offset;
		public TStructArray<FGuid> ReferencedTextureGuids
		{
			get{ CheckIsValid();return new TStructArray<FGuid>((FScriptArray)Marshal.PtrToStructure(_this.Get()+ReferencedTextureGuids__Offset, typeof(FScriptArray)));}
					set{ CheckIsValid();Marshal.StructureToPtr(value.InterArray, _this.Get()+ReferencedTextureGuids__Offset, false);}
			
		}
		
		static UMaterial()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("Material");
			PhysMaterial__Offset=GetPropertyOffset(NativeClassPtr,"PhysMaterial");
			DiffuseColor__Offset=GetPropertyOffset(NativeClassPtr,"DiffuseColor");
			SpecularColor__Offset=GetPropertyOffset(NativeClassPtr,"SpecularColor");
			BaseColor__Offset=GetPropertyOffset(NativeClassPtr,"BaseColor");
			Metallic__Offset=GetPropertyOffset(NativeClassPtr,"Metallic");
			Specular__Offset=GetPropertyOffset(NativeClassPtr,"Specular");
			Roughness__Offset=GetPropertyOffset(NativeClassPtr,"Roughness");
			Normal__Offset=GetPropertyOffset(NativeClassPtr,"Normal");
			EmissiveColor__Offset=GetPropertyOffset(NativeClassPtr,"EmissiveColor");
			Opacity__Offset=GetPropertyOffset(NativeClassPtr,"Opacity");
			OpacityMask__Offset=GetPropertyOffset(NativeClassPtr,"OpacityMask");
			MaterialDomain__Offset=GetPropertyOffset(NativeClassPtr,"MaterialDomain");
			BlendMode__Offset=GetPropertyOffset(NativeClassPtr,"BlendMode");
			DecalBlendMode__Offset=GetPropertyOffset(NativeClassPtr,"DecalBlendMode");
			MaterialDecalResponse__Offset=GetPropertyOffset(NativeClassPtr,"MaterialDecalResponse");
			ShadingModel__Offset=GetPropertyOffset(NativeClassPtr,"ShadingModel");
			OpacityMaskClipValue__Offset=GetPropertyOffset(NativeClassPtr,"OpacityMaskClipValue");
			WorldPositionOffset__Offset=GetPropertyOffset(NativeClassPtr,"WorldPositionOffset");
			WorldDisplacement__Offset=GetPropertyOffset(NativeClassPtr,"WorldDisplacement");
			TessellationMultiplier__Offset=GetPropertyOffset(NativeClassPtr,"TessellationMultiplier");
			SubsurfaceColor__Offset=GetPropertyOffset(NativeClassPtr,"SubsurfaceColor");
			ClearCoat__Offset=GetPropertyOffset(NativeClassPtr,"ClearCoat");
			ClearCoatRoughness__Offset=GetPropertyOffset(NativeClassPtr,"ClearCoatRoughness");
			AmbientOcclusion__Offset=GetPropertyOffset(NativeClassPtr,"AmbientOcclusion");
			Refraction__Offset=GetPropertyOffset(NativeClassPtr,"Refraction");
			CustomizedUVs__Offset=GetPropertyOffset(NativeClassPtr,"CustomizedUVs");
			MaterialAttributes__Offset=GetPropertyOffset(NativeClassPtr,"MaterialAttributes");
			PixelDepthOffset__Offset=GetPropertyOffset(NativeClassPtr,"PixelDepthOffset");
			bEnableSeparateTranslucency__Offset=GetPropertyOffset(NativeClassPtr,"bEnableSeparateTranslucency");
			bEnableMobileSeparateTranslucency__Offset=GetPropertyOffset(NativeClassPtr,"bEnableMobileSeparateTranslucency");
			bEnableResponsiveAA__Offset=GetPropertyOffset(NativeClassPtr,"bEnableResponsiveAA");
			bScreenSpaceReflections__Offset=GetPropertyOffset(NativeClassPtr,"bScreenSpaceReflections");
			TwoSided__Offset=GetPropertyOffset(NativeClassPtr,"TwoSided");
			DitheredLODTransition__Offset=GetPropertyOffset(NativeClassPtr,"DitheredLODTransition");
			DitherOpacityMask__Offset=GetPropertyOffset(NativeClassPtr,"DitherOpacityMask");
			bAllowNegativeEmissiveColor__Offset=GetPropertyOffset(NativeClassPtr,"bAllowNegativeEmissiveColor");
			NumCustomizedUVs__Offset=GetPropertyOffset(NativeClassPtr,"NumCustomizedUVs");
			TranslucencyLightingMode__Offset=GetPropertyOffset(NativeClassPtr,"TranslucencyLightingMode");
			TranslucencyDirectionalLightingIntensity__Offset=GetPropertyOffset(NativeClassPtr,"TranslucencyDirectionalLightingIntensity");
			AllowTranslucentCustomDepthWrites__Offset=GetPropertyOffset(NativeClassPtr,"AllowTranslucentCustomDepthWrites");
			TranslucentShadowDensityScale__Offset=GetPropertyOffset(NativeClassPtr,"TranslucentShadowDensityScale");
			TranslucentSelfShadowDensityScale__Offset=GetPropertyOffset(NativeClassPtr,"TranslucentSelfShadowDensityScale");
			TranslucentSelfShadowSecondDensityScale__Offset=GetPropertyOffset(NativeClassPtr,"TranslucentSelfShadowSecondDensityScale");
			TranslucentSelfShadowSecondOpacity__Offset=GetPropertyOffset(NativeClassPtr,"TranslucentSelfShadowSecondOpacity");
			TranslucentBackscatteringExponent__Offset=GetPropertyOffset(NativeClassPtr,"TranslucentBackscatteringExponent");
			TranslucentMultipleScatteringExtinction__Offset=GetPropertyOffset(NativeClassPtr,"TranslucentMultipleScatteringExtinction");
			TranslucentShadowStartOffset__Offset=GetPropertyOffset(NativeClassPtr,"TranslucentShadowStartOffset");
			bDisableDepthTest__Offset=GetPropertyOffset(NativeClassPtr,"bDisableDepthTest");
			bGenerateSphericalParticleNormals__Offset=GetPropertyOffset(NativeClassPtr,"bGenerateSphericalParticleNormals");
			bTangentSpaceNormal__Offset=GetPropertyOffset(NativeClassPtr,"bTangentSpaceNormal");
			bUseEmissiveForDynamicAreaLighting__Offset=GetPropertyOffset(NativeClassPtr,"bUseEmissiveForDynamicAreaLighting");
			bBlockGI__Offset=GetPropertyOffset(NativeClassPtr,"bBlockGI");
			bUsedAsSpecialEngineMaterial__Offset=GetPropertyOffset(NativeClassPtr,"bUsedAsSpecialEngineMaterial");
			bUsedWithSkeletalMesh__Offset=GetPropertyOffset(NativeClassPtr,"bUsedWithSkeletalMesh");
			bUsedWithEditorCompositing__Offset=GetPropertyOffset(NativeClassPtr,"bUsedWithEditorCompositing");
			bUsedWithParticleSprites__Offset=GetPropertyOffset(NativeClassPtr,"bUsedWithParticleSprites");
			bUsedWithBeamTrails__Offset=GetPropertyOffset(NativeClassPtr,"bUsedWithBeamTrails");
			bUsedWithMeshParticles__Offset=GetPropertyOffset(NativeClassPtr,"bUsedWithMeshParticles");
			bUsedWithStaticLighting__Offset=GetPropertyOffset(NativeClassPtr,"bUsedWithStaticLighting");
			bUsedWithMorphTargets__Offset=GetPropertyOffset(NativeClassPtr,"bUsedWithMorphTargets");
			bUsedWithSplineMeshes__Offset=GetPropertyOffset(NativeClassPtr,"bUsedWithSplineMeshes");
			bUsedWithInstancedStaticMeshes__Offset=GetPropertyOffset(NativeClassPtr,"bUsedWithInstancedStaticMeshes");
			bUsesDistortion__Offset=GetPropertyOffset(NativeClassPtr,"bUsesDistortion");
			bUsedWithClothing__Offset=GetPropertyOffset(NativeClassPtr,"bUsedWithClothing");
			bUsedWithUI__Offset=GetPropertyOffset(NativeClassPtr,"bUsedWithUI");
			bAutomaticallySetUsageInEditor__Offset=GetPropertyOffset(NativeClassPtr,"bAutomaticallySetUsageInEditor");
			bFullyRough__Offset=GetPropertyOffset(NativeClassPtr,"bFullyRough");
			bUseFullPrecision__Offset=GetPropertyOffset(NativeClassPtr,"bUseFullPrecision");
			bUseLightmapDirectionality__Offset=GetPropertyOffset(NativeClassPtr,"bUseLightmapDirectionality");
			bUseHQForwardReflections__Offset=GetPropertyOffset(NativeClassPtr,"bUseHQForwardReflections");
			bUsePlanarForwardReflections__Offset=GetPropertyOffset(NativeClassPtr,"bUsePlanarForwardReflections");
			bNormalCurvatureToRoughness__Offset=GetPropertyOffset(NativeClassPtr,"bNormalCurvatureToRoughness");
			D3D11TessellationMode__Offset=GetPropertyOffset(NativeClassPtr,"D3D11TessellationMode");
			bEnableCrackFreeDisplacement__Offset=GetPropertyOffset(NativeClassPtr,"bEnableCrackFreeDisplacement");
			bEnableAdaptiveTessellation__Offset=GetPropertyOffset(NativeClassPtr,"bEnableAdaptiveTessellation");
			MaxDisplacement__Offset=GetPropertyOffset(NativeClassPtr,"MaxDisplacement");
			Wireframe__Offset=GetPropertyOffset(NativeClassPtr,"Wireframe");
			bOutputVelocityOnBasePass__Offset=GetPropertyOffset(NativeClassPtr,"bOutputVelocityOnBasePass");
			EditorX__Offset=GetPropertyOffset(NativeClassPtr,"EditorX");
			EditorY__Offset=GetPropertyOffset(NativeClassPtr,"EditorY");
			EditorPitch__Offset=GetPropertyOffset(NativeClassPtr,"EditorPitch");
			EditorYaw__Offset=GetPropertyOffset(NativeClassPtr,"EditorYaw");
			Expressions__Offset=GetPropertyOffset(NativeClassPtr,"Expressions");
			EditorComments__Offset=GetPropertyOffset(NativeClassPtr,"EditorComments");
			MaterialFunctionInfos__Offset=GetPropertyOffset(NativeClassPtr,"MaterialFunctionInfos");
			MaterialParameterCollectionInfos__Offset=GetPropertyOffset(NativeClassPtr,"MaterialParameterCollectionInfos");
			bCanMaskedBeAssumedOpaque__Offset=GetPropertyOffset(NativeClassPtr,"bCanMaskedBeAssumedOpaque");
			bIsMasked__Offset=GetPropertyOffset(NativeClassPtr,"bIsMasked");
			bIsPreviewMaterial__Offset=GetPropertyOffset(NativeClassPtr,"bIsPreviewMaterial");
			bUseMaterialAttributes__Offset=GetPropertyOffset(NativeClassPtr,"bUseMaterialAttributes");
			bUseTranslucencyVertexFog__Offset=GetPropertyOffset(NativeClassPtr,"bUseTranslucencyVertexFog");
			bAllowDevelopmentShaderCompile__Offset=GetPropertyOffset(NativeClassPtr,"bAllowDevelopmentShaderCompile");
			bIsMaterialEditorStatsMaterial__Offset=GetPropertyOffset(NativeClassPtr,"bIsMaterialEditorStatsMaterial");
			UsageFlagWarnings__Offset=GetPropertyOffset(NativeClassPtr,"UsageFlagWarnings");
			BlendableLocation__Offset=GetPropertyOffset(NativeClassPtr,"BlendableLocation");
			BlendablePriority__Offset=GetPropertyOffset(NativeClassPtr,"BlendablePriority");
			BlendableOutputAlpha__Offset=GetPropertyOffset(NativeClassPtr,"BlendableOutputAlpha");
			RefractionMode__Offset=GetPropertyOffset(NativeClassPtr,"RefractionMode");
			RefractionDepthBias__Offset=GetPropertyOffset(NativeClassPtr,"RefractionDepthBias");
			StateId__Offset=GetPropertyOffset(NativeClassPtr,"StateId");
			ExpressionTextureReferences__Offset=GetPropertyOffset(NativeClassPtr,"ExpressionTextureReferences");
			ReferencedTextureGuids__Offset=GetPropertyOffset(NativeClassPtr,"ReferencedTextureGuids");
			
		}
		
	}
	
}
#endif
#endif
