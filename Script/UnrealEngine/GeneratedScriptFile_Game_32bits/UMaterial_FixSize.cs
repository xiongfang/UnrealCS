#if WITH_GAME
#if PLATFORM_32BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class UMaterial
	{
		static readonly int PhysMaterial__Offset;
		public UPhysicalMaterial PhysMaterial
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + PhysMaterial__Offset); if (v == IntPtr.Zero)return null; UPhysicalMaterial retValue = new UPhysicalMaterial(); retValue._this = v; return retValue; }
			set{ CheckIsValid(); if (value == null)Marshal.WriteIntPtr(_this.Get() + PhysMaterial__Offset, IntPtr.Zero);else Marshal.WriteIntPtr(_this.Get() + PhysMaterial__Offset, value._this.Get()); }
			
		}
		
		static readonly int DiffuseColor__Offset;
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
		public FColorMaterialInput EmissiveColor
		{
			get{ CheckIsValid();return (FColorMaterialInput)Marshal.PtrToStructure(_this.Get()+EmissiveColor__Offset, typeof(FColorMaterialInput));}
			
		}
		
		static readonly int Opacity__Offset;
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
		public EMaterialDomain MaterialDomain
		{
			get{ CheckIsValid();return (EMaterialDomain)Marshal.PtrToStructure(_this.Get()+MaterialDomain__Offset, typeof(EMaterialDomain));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+MaterialDomain__Offset, false);}
			
		}
		
		static readonly int BlendMode__Offset;
		public EBlendMode BlendMode
		{
			get{ CheckIsValid();return (EBlendMode)Marshal.PtrToStructure(_this.Get()+BlendMode__Offset, typeof(EBlendMode));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+BlendMode__Offset, false);}
			
		}
		
		static readonly int DecalBlendMode__Offset;
		public EDecalBlendMode DecalBlendMode
		{
			get{ CheckIsValid();return (EDecalBlendMode)Marshal.PtrToStructure(_this.Get()+DecalBlendMode__Offset, typeof(EDecalBlendMode));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+DecalBlendMode__Offset, false);}
			
		}
		
		static readonly int MaterialDecalResponse__Offset;
		public EMaterialDecalResponse MaterialDecalResponse
		{
			get{ CheckIsValid();return (EMaterialDecalResponse)Marshal.PtrToStructure(_this.Get()+MaterialDecalResponse__Offset, typeof(EMaterialDecalResponse));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+MaterialDecalResponse__Offset, false);}
			
		}
		
		static readonly int ShadingModel__Offset;
		public EMaterialShadingModel ShadingModel
		{
			get{ CheckIsValid();return (EMaterialShadingModel)Marshal.PtrToStructure(_this.Get()+ShadingModel__Offset, typeof(EMaterialShadingModel));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+ShadingModel__Offset, false);}
			
		}
		
		static readonly int OpacityMaskClipValue__Offset;
		public float OpacityMaskClipValue
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+OpacityMaskClipValue__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+OpacityMaskClipValue__Offset, false);}
			
		}
		
		static readonly int WorldPositionOffset__Offset;
		public FVectorMaterialInput WorldPositionOffset
		{
			get{ CheckIsValid();return (FVectorMaterialInput)Marshal.PtrToStructure(_this.Get()+WorldPositionOffset__Offset, typeof(FVectorMaterialInput));}
			
		}
		
		static readonly int WorldDisplacement__Offset;
		public FVectorMaterialInput WorldDisplacement
		{
			get{ CheckIsValid();return (FVectorMaterialInput)Marshal.PtrToStructure(_this.Get()+WorldDisplacement__Offset, typeof(FVectorMaterialInput));}
			
		}
		
		static readonly int TessellationMultiplier__Offset;
		public FScalarMaterialInput TessellationMultiplier
		{
			get{ CheckIsValid();return (FScalarMaterialInput)Marshal.PtrToStructure(_this.Get()+TessellationMultiplier__Offset, typeof(FScalarMaterialInput));}
			
		}
		
		static readonly int SubsurfaceColor__Offset;
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
		public FScalarMaterialInput AmbientOcclusion
		{
			get{ CheckIsValid();return (FScalarMaterialInput)Marshal.PtrToStructure(_this.Get()+AmbientOcclusion__Offset, typeof(FScalarMaterialInput));}
			
		}
		
		static readonly int Refraction__Offset;
		public FScalarMaterialInput Refraction
		{
			get{ CheckIsValid();return (FScalarMaterialInput)Marshal.PtrToStructure(_this.Get()+Refraction__Offset, typeof(FScalarMaterialInput));}
			
		}
		
		static readonly int CustomizedUVs__Offset;
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
		public bool bEnableSeparateTranslucency
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bEnableSeparateTranslucency__Offset, 1, 0, 1, 1);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bEnableSeparateTranslucency__Offset, 1,0,1,1);}
			
		}
		
		static readonly int bEnableMobileSeparateTranslucency__Offset;
		public bool bEnableMobileSeparateTranslucency
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bEnableMobileSeparateTranslucency__Offset, 1, 0, 2, 2);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bEnableMobileSeparateTranslucency__Offset, 1,0,2,2);}
			
		}
		
		static readonly int bEnableResponsiveAA__Offset;
		public bool bEnableResponsiveAA
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bEnableResponsiveAA__Offset, 1, 0, 4, 4);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bEnableResponsiveAA__Offset, 1,0,4,4);}
			
		}
		
		static readonly int bScreenSpaceReflections__Offset;
		public bool bScreenSpaceReflections
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bScreenSpaceReflections__Offset, 1, 0, 8, 8);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bScreenSpaceReflections__Offset, 1,0,8,8);}
			
		}
		
		static readonly int TwoSided__Offset;
		public bool TwoSided
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), TwoSided__Offset, 1, 0, 16, 16);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), TwoSided__Offset, 1,0,16,16);}
			
		}
		
		static readonly int DitheredLODTransition__Offset;
		public bool DitheredLODTransition
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), DitheredLODTransition__Offset, 1, 0, 32, 32);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), DitheredLODTransition__Offset, 1,0,32,32);}
			
		}
		
		static readonly int DitherOpacityMask__Offset;
		public bool DitherOpacityMask
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), DitherOpacityMask__Offset, 1, 0, 64, 64);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), DitherOpacityMask__Offset, 1,0,64,64);}
			
		}
		
		static readonly int bAllowNegativeEmissiveColor__Offset;
		public bool bAllowNegativeEmissiveColor
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bAllowNegativeEmissiveColor__Offset, 1, 0, 128, 128);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bAllowNegativeEmissiveColor__Offset, 1,0,128,128);}
			
		}
		
		static readonly int NumCustomizedUVs__Offset;
		public int NumCustomizedUVs
		{
			get{ CheckIsValid();return (int)Marshal.PtrToStructure(_this.Get()+NumCustomizedUVs__Offset, typeof(int));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+NumCustomizedUVs__Offset, false);}
			
		}
		
		static readonly int TranslucencyLightingMode__Offset;
		public ETranslucencyLightingMode TranslucencyLightingMode
		{
			get{ CheckIsValid();return (ETranslucencyLightingMode)Marshal.PtrToStructure(_this.Get()+TranslucencyLightingMode__Offset, typeof(ETranslucencyLightingMode));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+TranslucencyLightingMode__Offset, false);}
			
		}
		
		static readonly int TranslucencyDirectionalLightingIntensity__Offset;
		public float TranslucencyDirectionalLightingIntensity
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+TranslucencyDirectionalLightingIntensity__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+TranslucencyDirectionalLightingIntensity__Offset, false);}
			
		}
		
		static readonly int AllowTranslucentCustomDepthWrites__Offset;
		public bool AllowTranslucentCustomDepthWrites
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), AllowTranslucentCustomDepthWrites__Offset, 1, 0, 1, 1);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), AllowTranslucentCustomDepthWrites__Offset, 1,0,1,1);}
			
		}
		
		static readonly int TranslucentShadowDensityScale__Offset;
		public float TranslucentShadowDensityScale
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+TranslucentShadowDensityScale__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+TranslucentShadowDensityScale__Offset, false);}
			
		}
		
		static readonly int TranslucentSelfShadowDensityScale__Offset;
		public float TranslucentSelfShadowDensityScale
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+TranslucentSelfShadowDensityScale__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+TranslucentSelfShadowDensityScale__Offset, false);}
			
		}
		
		static readonly int TranslucentSelfShadowSecondDensityScale__Offset;
		public float TranslucentSelfShadowSecondDensityScale
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+TranslucentSelfShadowSecondDensityScale__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+TranslucentSelfShadowSecondDensityScale__Offset, false);}
			
		}
		
		static readonly int TranslucentSelfShadowSecondOpacity__Offset;
		public float TranslucentSelfShadowSecondOpacity
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+TranslucentSelfShadowSecondOpacity__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+TranslucentSelfShadowSecondOpacity__Offset, false);}
			
		}
		
		static readonly int TranslucentBackscatteringExponent__Offset;
		public float TranslucentBackscatteringExponent
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+TranslucentBackscatteringExponent__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+TranslucentBackscatteringExponent__Offset, false);}
			
		}
		
		static readonly int TranslucentMultipleScatteringExtinction__Offset;
		public FLinearColor TranslucentMultipleScatteringExtinction
		{
			get{ CheckIsValid();return (FLinearColor)Marshal.PtrToStructure(_this.Get()+TranslucentMultipleScatteringExtinction__Offset, typeof(FLinearColor));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+TranslucentMultipleScatteringExtinction__Offset, false);}
			
		}
		
		static readonly int TranslucentShadowStartOffset__Offset;
		public float TranslucentShadowStartOffset
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+TranslucentShadowStartOffset__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+TranslucentShadowStartOffset__Offset, false);}
			
		}
		
		static readonly int bDisableDepthTest__Offset;
		public bool bDisableDepthTest
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bDisableDepthTest__Offset, 1, 0, 1, 1);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bDisableDepthTest__Offset, 1,0,1,1);}
			
		}
		
		static readonly int bGenerateSphericalParticleNormals__Offset;
		public bool bGenerateSphericalParticleNormals
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bGenerateSphericalParticleNormals__Offset, 1, 0, 2, 2);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bGenerateSphericalParticleNormals__Offset, 1,0,2,2);}
			
		}
		
		static readonly int bTangentSpaceNormal__Offset;
		public bool bTangentSpaceNormal
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bTangentSpaceNormal__Offset, 1, 0, 4, 4);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bTangentSpaceNormal__Offset, 1,0,4,4);}
			
		}
		
		static readonly int bUseEmissiveForDynamicAreaLighting__Offset;
		public bool bUseEmissiveForDynamicAreaLighting
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bUseEmissiveForDynamicAreaLighting__Offset, 1, 0, 8, 8);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bUseEmissiveForDynamicAreaLighting__Offset, 1,0,8,8);}
			
		}
		
		static readonly int bBlockGI__Offset;
		public bool bBlockGI
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bBlockGI__Offset, 1, 0, 16, 16);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bBlockGI__Offset, 1,0,16,16);}
			
		}
		
		static readonly int bUsedAsSpecialEngineMaterial__Offset;
		public bool bUsedAsSpecialEngineMaterial
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bUsedAsSpecialEngineMaterial__Offset, 1, 0, 32, 32);}
			
		}
		
		static readonly int bUsedWithSkeletalMesh__Offset;
		public bool bUsedWithSkeletalMesh
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bUsedWithSkeletalMesh__Offset, 1, 0, 64, 64);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bUsedWithSkeletalMesh__Offset, 1,0,64,64);}
			
		}
		
		static readonly int bUsedWithEditorCompositing__Offset;
		public bool bUsedWithEditorCompositing
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bUsedWithEditorCompositing__Offset, 1, 0, 128, 128);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bUsedWithEditorCompositing__Offset, 1,0,128,128);}
			
		}
		
		static readonly int bUsedWithParticleSprites__Offset;
		public bool bUsedWithParticleSprites
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bUsedWithParticleSprites__Offset, 1, 0, 1, 1);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bUsedWithParticleSprites__Offset, 1,0,1,1);}
			
		}
		
		static readonly int bUsedWithBeamTrails__Offset;
		public bool bUsedWithBeamTrails
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bUsedWithBeamTrails__Offset, 1, 0, 2, 2);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bUsedWithBeamTrails__Offset, 1,0,2,2);}
			
		}
		
		static readonly int bUsedWithMeshParticles__Offset;
		public bool bUsedWithMeshParticles
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bUsedWithMeshParticles__Offset, 1, 0, 4, 4);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bUsedWithMeshParticles__Offset, 1,0,4,4);}
			
		}
		
		static readonly int bUsedWithStaticLighting__Offset;
		public bool bUsedWithStaticLighting
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bUsedWithStaticLighting__Offset, 1, 0, 8, 8);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bUsedWithStaticLighting__Offset, 1,0,8,8);}
			
		}
		
		static readonly int bUsedWithMorphTargets__Offset;
		public bool bUsedWithMorphTargets
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bUsedWithMorphTargets__Offset, 1, 0, 16, 16);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bUsedWithMorphTargets__Offset, 1,0,16,16);}
			
		}
		
		static readonly int bUsedWithSplineMeshes__Offset;
		public bool bUsedWithSplineMeshes
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bUsedWithSplineMeshes__Offset, 1, 0, 32, 32);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bUsedWithSplineMeshes__Offset, 1,0,32,32);}
			
		}
		
		static readonly int bUsedWithInstancedStaticMeshes__Offset;
		public bool bUsedWithInstancedStaticMeshes
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bUsedWithInstancedStaticMeshes__Offset, 1, 0, 64, 64);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bUsedWithInstancedStaticMeshes__Offset, 1,0,64,64);}
			
		}
		
		static readonly int bUsesDistortion__Offset;
		public bool bUsesDistortion
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bUsesDistortion__Offset, 1, 0, 128, 128);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bUsesDistortion__Offset, 1,0,128,128);}
			
		}
		
		static readonly int bUsedWithClothing__Offset;
		public bool bUsedWithClothing
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bUsedWithClothing__Offset, 1, 0, 1, 1);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bUsedWithClothing__Offset, 1,0,1,1);}
			
		}
		
		static readonly int bUsedWithUI__Offset;
		public bool bUsedWithUI
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bUsedWithUI__Offset, 1, 0, 2, 2);}
			
		}
		
		static readonly int bAutomaticallySetUsageInEditor__Offset;
		public bool bAutomaticallySetUsageInEditor
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bAutomaticallySetUsageInEditor__Offset, 1, 0, 4, 4);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bAutomaticallySetUsageInEditor__Offset, 1,0,4,4);}
			
		}
		
		static readonly int bFullyRough__Offset;
		public bool bFullyRough
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bFullyRough__Offset, 1, 0, 8, 8);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bFullyRough__Offset, 1,0,8,8);}
			
		}
		
		static readonly int bUseFullPrecision__Offset;
		public bool bUseFullPrecision
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bUseFullPrecision__Offset, 1, 0, 16, 16);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bUseFullPrecision__Offset, 1,0,16,16);}
			
		}
		
		static readonly int bUseLightmapDirectionality__Offset;
		public bool bUseLightmapDirectionality
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bUseLightmapDirectionality__Offset, 1, 0, 32, 32);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bUseLightmapDirectionality__Offset, 1,0,32,32);}
			
		}
		
		static readonly int bUseHQForwardReflections__Offset;
		public bool bUseHQForwardReflections
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bUseHQForwardReflections__Offset, 1, 0, 64, 64);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bUseHQForwardReflections__Offset, 1,0,64,64);}
			
		}
		
		static readonly int bUsePlanarForwardReflections__Offset;
		public bool bUsePlanarForwardReflections
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bUsePlanarForwardReflections__Offset, 1, 0, 128, 128);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bUsePlanarForwardReflections__Offset, 1,0,128,128);}
			
		}
		
		static readonly int bNormalCurvatureToRoughness__Offset;
		public bool bNormalCurvatureToRoughness
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bNormalCurvatureToRoughness__Offset, 1, 0, 1, 1);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bNormalCurvatureToRoughness__Offset, 1,0,1,1);}
			
		}
		
		static readonly int D3D11TessellationMode__Offset;
		public EMaterialTessellationMode D3D11TessellationMode
		{
			get{ CheckIsValid();return (EMaterialTessellationMode)Marshal.PtrToStructure(_this.Get()+D3D11TessellationMode__Offset, typeof(EMaterialTessellationMode));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+D3D11TessellationMode__Offset, false);}
			
		}
		
		static readonly int bEnableCrackFreeDisplacement__Offset;
		public bool bEnableCrackFreeDisplacement
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bEnableCrackFreeDisplacement__Offset, 1, 0, 1, 1);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bEnableCrackFreeDisplacement__Offset, 1,0,1,1);}
			
		}
		
		static readonly int bEnableAdaptiveTessellation__Offset;
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
		public bool Wireframe
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), Wireframe__Offset, 1, 0, 1, 1);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), Wireframe__Offset, 1,0,1,1);}
			
		}
		
		static readonly int bOutputVelocityOnBasePass__Offset;
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
		public TObjectArray<UMaterialExpression>  Expressions
		{
					get{ CheckIsValid();return new TObjectArray<UMaterialExpression>((FScriptArray)Marshal.PtrToStructure(_this.Get()+Expressions__Offset, typeof(FScriptArray)));}
					set{ CheckIsValid();Marshal.StructureToPtr(value.InterArray, _this.Get()+Expressions__Offset, false);}
			
		}
		
		static readonly int MaterialFunctionInfos__Offset;
		public TStructArray<FMaterialFunctionInfo> MaterialFunctionInfos
		{
			get{ CheckIsValid();return new TStructArray<FMaterialFunctionInfo>((FScriptArray)Marshal.PtrToStructure(_this.Get()+MaterialFunctionInfos__Offset, typeof(FScriptArray)));}
					set{ CheckIsValid();Marshal.StructureToPtr(value.InterArray, _this.Get()+MaterialFunctionInfos__Offset, false);}
			
		}
		
		static readonly int MaterialParameterCollectionInfos__Offset;
		public TStructArray<FMaterialParameterCollectionInfo> MaterialParameterCollectionInfos
		{
			get{ CheckIsValid();return new TStructArray<FMaterialParameterCollectionInfo>((FScriptArray)Marshal.PtrToStructure(_this.Get()+MaterialParameterCollectionInfos__Offset, typeof(FScriptArray)));}
					set{ CheckIsValid();Marshal.StructureToPtr(value.InterArray, _this.Get()+MaterialParameterCollectionInfos__Offset, false);}
			
		}
		
		static readonly int bCanMaskedBeAssumedOpaque__Offset;
		public bool bCanMaskedBeAssumedOpaque
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bCanMaskedBeAssumedOpaque__Offset, 1, 0, 1, 1);}
			
		}
		
		static readonly int bIsMasked__Offset;
		public bool bIsMasked
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bIsMasked__Offset, 1, 0, 2, 2);}
			
		}
		
		static readonly int bIsPreviewMaterial__Offset;
		public bool bIsPreviewMaterial
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bIsPreviewMaterial__Offset, 1, 0, 4, 4);}
			
		}
		
		static readonly int bUseMaterialAttributes__Offset;
		public bool bUseMaterialAttributes
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bUseMaterialAttributes__Offset, 1, 0, 8, 8);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bUseMaterialAttributes__Offset, 1,0,8,8);}
			
		}
		
		static readonly int bUseTranslucencyVertexFog__Offset;
		public bool bUseTranslucencyVertexFog
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bUseTranslucencyVertexFog__Offset, 1, 0, 16, 16);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bUseTranslucencyVertexFog__Offset, 1,0,16,16);}
			
		}
		
		static readonly int bAllowDevelopmentShaderCompile__Offset;
		public bool bAllowDevelopmentShaderCompile
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bAllowDevelopmentShaderCompile__Offset, 1, 0, 32, 32);}
			
		}
		
		static readonly int bIsMaterialEditorStatsMaterial__Offset;
		public bool bIsMaterialEditorStatsMaterial
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bIsMaterialEditorStatsMaterial__Offset, 1, 0, 64, 64);}
			
		}
		
		static readonly int UsageFlagWarnings__Offset;
		public uint UsageFlagWarnings
		{
			get{ CheckIsValid();return (uint)Marshal.PtrToStructure(_this.Get()+UsageFlagWarnings__Offset, typeof(uint));}
			
		}
		
		static readonly int BlendableLocation__Offset;
		public EBlendableLocation BlendableLocation
		{
			get{ CheckIsValid();return (EBlendableLocation)Marshal.PtrToStructure(_this.Get()+BlendableLocation__Offset, typeof(EBlendableLocation));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+BlendableLocation__Offset, false);}
			
		}
		
		static readonly int BlendablePriority__Offset;
		public int BlendablePriority
		{
			get{ CheckIsValid();return (int)Marshal.PtrToStructure(_this.Get()+BlendablePriority__Offset, typeof(int));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+BlendablePriority__Offset, false);}
			
		}
		
		static readonly int BlendableOutputAlpha__Offset;
		public bool BlendableOutputAlpha
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), BlendableOutputAlpha__Offset, 1, 0, 1, 255);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), BlendableOutputAlpha__Offset, 1,0,1,255);}
			
		}
		
		static readonly int RefractionMode__Offset;
		public ERefractionMode RefractionMode
		{
			get{ CheckIsValid();return (ERefractionMode)Marshal.PtrToStructure(_this.Get()+RefractionMode__Offset, typeof(ERefractionMode));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+RefractionMode__Offset, false);}
			
		}
		
		static readonly int RefractionDepthBias__Offset;
		public float RefractionDepthBias
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+RefractionDepthBias__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+RefractionDepthBias__Offset, false);}
			
		}
		
		static readonly int StateId__Offset;
		public FGuid StateId
		{
			get{ CheckIsValid();return (FGuid)Marshal.PtrToStructure(_this.Get()+StateId__Offset, typeof(FGuid));}
			
		}
		
		static readonly int ExpressionTextureReferences__Offset;
		public TObjectArray<UTexture>  ExpressionTextureReferences
		{
					get{ CheckIsValid();return new TObjectArray<UTexture>((FScriptArray)Marshal.PtrToStructure(_this.Get()+ExpressionTextureReferences__Offset, typeof(FScriptArray)));}
					set{ CheckIsValid();Marshal.StructureToPtr(value.InterArray, _this.Get()+ExpressionTextureReferences__Offset, false);}
			
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
			
		}
		
	}
	
}
#endif
#endif
