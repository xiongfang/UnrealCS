#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>
	/// StaticMeshComponent is used to create an instance of a UStaticMesh.
	/// A static mesh is a piece of geometry that consists of a static set of polygons.
	/// @see https://docs.unrealengine.com/latest/INT/Engine/Content/Types/StaticMeshes/
	/// @see UStaticMesh
	/// </summary>
	public partial class UStaticMeshComponent
	{
		static readonly int ForcedLodModel__Offset;
		/// <summary>If 0, auto-select LOD level. if >0, force to (ForcedLodModel-1).</summary>
		public int ForcedLodModel
		{
			get{ CheckIsValid();return (int)Marshal.PtrToStructure(_this.Get()+ForcedLodModel__Offset, typeof(int));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+ForcedLodModel__Offset, false);}
			
		}
		
		static readonly int PreviousLODLevel__Offset;
		/// <summary>LOD that was desired for rendering this StaticMeshComponent last frame.</summary>
		public int PreviousLODLevel
		{
			get{ CheckIsValid();return (int)Marshal.PtrToStructure(_this.Get()+PreviousLODLevel__Offset, typeof(int));}
			
		}
		
		static readonly int bOverrideMinLOD__Offset;
		/// <summary>Whether to override the MinLOD setting of the static mesh asset with the MinLOD of this component.</summary>
		public bool bOverrideMinLOD
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bOverrideMinLOD__Offset, 1, 0, 1, 255);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bOverrideMinLOD__Offset, 1,0,1,255);}
			
		}
		
		static readonly int MinLOD__Offset;
		/// <summary>
		/// Specifies the smallest LOD that will be used for this component.
		/// This is ignored if ForcedLodModel is enabled.
		/// </summary>
		public int MinLOD
		{
			get{ CheckIsValid();return (int)Marshal.PtrToStructure(_this.Get()+MinLOD__Offset, typeof(int));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+MinLOD__Offset, false);}
			
		}
		
		static readonly int StaticMesh__Offset;
		public UStaticMesh StaticMesh
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + StaticMesh__Offset); if (v == IntPtr.Zero)return null; UStaticMesh retValue = new UStaticMesh(); retValue._this = v; return retValue; }
			set{ CheckIsValid(); if (value == null)Marshal.WriteIntPtr(_this.Get() + StaticMesh__Offset, IntPtr.Zero);else Marshal.WriteIntPtr(_this.Get() + StaticMesh__Offset, value._this.Get()); }
			
		}
		
		static readonly int bOverrideWireframeColor__Offset;
		/// <summary>If true, WireframeColorOverride will be used. If false, color is determined based on mobility and physics simulation settings</summary>
		public bool bOverrideWireframeColor
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bOverrideWireframeColor__Offset, 1, 0, 1, 255);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bOverrideWireframeColor__Offset, 1,0,1,255);}
			
		}
		
		static readonly int WireframeColorOverride__Offset;
		/// <summary>Wireframe color to use if bOverrideWireframeColor is true</summary>
		public FColor WireframeColorOverride
		{
			get{ CheckIsValid();return (FColor)Marshal.PtrToStructure(_this.Get()+WireframeColorOverride__Offset, typeof(FColor));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+WireframeColorOverride__Offset, false);}
			
		}
		
		static readonly int SelectedEditorSection__Offset;
		/// <summary>The section currently selected in the Editor. Used for highlighting</summary>
		public int SelectedEditorSection
		{
			get{ CheckIsValid();return (int)Marshal.PtrToStructure(_this.Get()+SelectedEditorSection__Offset, typeof(int));}
			
		}
		
		static readonly int SectionIndexPreview__Offset;
		/// <summary>Index of the section to preview. If set to INDEX_NONE, all section will be rendered. Used for isolating in Static Mesh Tool *</summary>
		public int SectionIndexPreview
		{
			get{ CheckIsValid();return (int)Marshal.PtrToStructure(_this.Get()+SectionIndexPreview__Offset, typeof(int));}
			
		}
		
		static readonly int StaticMeshImportVersion__Offset;
		/// <summary>
		/// * The import version of the static mesh when it was assign this is update when:
		/// * - The user assign a new staticmesh to the component
		/// * - The component is serialize (IsSaving)
		/// * - Default value is BeforeImportStaticMeshVersionWasAdded
		/// *
		/// * If when the component get load (PostLoad) the version of the attach staticmesh is newer
		/// * then this value, we will remap the material override because the order of the materials list
		/// * in the staticmesh can be changed. Hopefully there is a remap table save in the staticmesh.
		/// </summary>
		public int StaticMeshImportVersion
		{
			get{ CheckIsValid();return (int)Marshal.PtrToStructure(_this.Get()+StaticMeshImportVersion__Offset, typeof(int));}
			
		}
		
		static readonly int bOverrideNavigationExport__Offset;
		/// <summary>If true, bForceNavigationObstacle flag will take priority over navigation data stored in StaticMesh</summary>
		public bool bOverrideNavigationExport
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bOverrideNavigationExport__Offset, 1, 0, 1, 1);}
			
		}
		
		static readonly int bForceNavigationObstacle__Offset;
		/// <summary>Allows overriding navigation export behavior per component: full collisions or dynamic obstacle</summary>
		public bool bForceNavigationObstacle
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bForceNavigationObstacle__Offset, 1, 0, 2, 2);}
			
		}
		
		static readonly int bDisallowMeshPaintPerInstance__Offset;
		/// <summary>If true, mesh painting is disallowed on this instance. Set if vertex colors are overridden in a construction script.</summary>
		public bool bDisallowMeshPaintPerInstance
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bDisallowMeshPaintPerInstance__Offset, 1, 0, 4, 4);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bDisallowMeshPaintPerInstance__Offset, 1,0,4,4);}
			
		}
		
		static readonly int bIgnoreInstanceForTextureStreaming__Offset;
		/// <summary>
		/// Ignore this instance of this static mesh when calculating streaming information.
		/// This can be useful when doing things like applying character textures to static geometry,
		/// to avoid them using distance-based streaming.
		/// </summary>
		public bool bIgnoreInstanceForTextureStreaming
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bIgnoreInstanceForTextureStreaming__Offset, 1, 0, 16, 16);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bIgnoreInstanceForTextureStreaming__Offset, 1,0,16,16);}
			
		}
		
		static readonly int bOverrideLightMapRes__Offset;
		/// <summary>Whether to override the lightmap resolution defined in the static mesh.</summary>
		public bool bOverrideLightMapRes
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bOverrideLightMapRes__Offset, 1, 0, 32, 32);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bOverrideLightMapRes__Offset, 1,0,32,32);}
			
		}
		
		static readonly int OverriddenLightMapRes__Offset;
		/// <summary>Light map resolution to use on this component, used if bOverrideLightMapRes is true and there is a valid StaticMesh.</summary>
		public int OverriddenLightMapRes
		{
			get{ CheckIsValid();return (int)Marshal.PtrToStructure(_this.Get()+OverriddenLightMapRes__Offset, typeof(int));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+OverriddenLightMapRes__Offset, false);}
			
		}
		
		static readonly int bCastDistanceFieldIndirectShadow__Offset;
		/// <summary>
		/// Whether to use the mesh distance field representation (when present) for shadowing indirect lighting (from lightmaps or skylight) on Movable components.
		/// This works like capsule shadows on skeletal meshes, except using the mesh distance field so no physics asset is required.
		/// The StaticMesh must have 'Generate Mesh Distance Field' enabled, or the project must have 'Generate Mesh Distance Fields' enabled for this feature to work.
		/// </summary>
		public bool bCastDistanceFieldIndirectShadow
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bCastDistanceFieldIndirectShadow__Offset, 1, 0, 1, 1);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bCastDistanceFieldIndirectShadow__Offset, 1,0,1,1);}
			
		}
		
		static readonly int DistanceFieldIndirectShadowMinVisibility__Offset;
		/// <summary>Controls how dark the dynamic indirect shadow can be.</summary>
		public float DistanceFieldIndirectShadowMinVisibility
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+DistanceFieldIndirectShadowMinVisibility__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+DistanceFieldIndirectShadowMinVisibility__Offset, false);}
			
		}
		
		static readonly int StreamingDistanceMultiplier__Offset;
		/// <summary>Allows adjusting the desired resolution of streaming textures that uses UV 0.  1.0 is the default, whereas a higher value increases the streamed-in resolution.</summary>
		public float StreamingDistanceMultiplier
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+StreamingDistanceMultiplier__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+StreamingDistanceMultiplier__Offset, false);}
			
		}
		
		static readonly int SubDivisionStepSize__Offset;
		/// <summary>Subdivision step size for static vertex lighting.</summary>
		public int SubDivisionStepSize
		{
			get{ CheckIsValid();return (int)Marshal.PtrToStructure(_this.Get()+SubDivisionStepSize__Offset, typeof(int));}
			
		}
		
		static readonly int bUseSubDivisions__Offset;
		/// <summary>Whether to use subdivisions or just the triangle's vertices.</summary>
		public bool bUseSubDivisions
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bUseSubDivisions__Offset, 1, 0, 1, 1);}
			
		}
		
		static readonly int IrrelevantLights__Offset;
		public TStructArray<FGuid> IrrelevantLights
		{
			get{ CheckIsValid();return new TStructArray<FGuid>((FScriptArray)Marshal.PtrToStructure(_this.Get()+IrrelevantLights__Offset, typeof(FScriptArray)));}
					set{ CheckIsValid();Marshal.StructureToPtr(value.InterArray, _this.Get()+IrrelevantLights__Offset, false);}
			
		}
		
		static readonly int LODData__Offset;
		/// <summary>Static mesh LOD data.  Contains static lighting data along with instanced mesh vertex colors.</summary>
		public TStructArray<FStaticMeshComponentLODInfo> LODData
		{
			get{ CheckIsValid();return new TStructArray<FStaticMeshComponentLODInfo>((FScriptArray)Marshal.PtrToStructure(_this.Get()+LODData__Offset, typeof(FScriptArray)));}
					set{ CheckIsValid();Marshal.StructureToPtr(value.InterArray, _this.Get()+LODData__Offset, false);}
			
		}
		
		static readonly int StreamingTextureData__Offset;
		/// <summary>The list of texture, bounds and scales. As computed in the texture streaming build process.</summary>
		public TStructArray<FStreamingTextureBuildInfo> StreamingTextureData
		{
			get{ CheckIsValid();return new TStructArray<FStreamingTextureBuildInfo>((FScriptArray)Marshal.PtrToStructure(_this.Get()+StreamingTextureData__Offset, typeof(FScriptArray)));}
					set{ CheckIsValid();Marshal.StructureToPtr(value.InterArray, _this.Get()+StreamingTextureData__Offset, false);}
			
		}
		
		static readonly int bUseDefaultCollision__Offset;
		/// <summary>Use the collision profile specified in the StaticMesh asset.</summary>
		public bool bUseDefaultCollision
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bUseDefaultCollision__Offset, 1, 0, 1, 255);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bUseDefaultCollision__Offset, 1,0,1,255);}
			
		}
		
		static readonly int StaticMeshDerivedDataKey__Offset;
		/// <summary>Derived data key of the static mesh, used to determine if an update from the source static mesh is required.</summary>
		public FString StaticMeshDerivedDataKey
		{
			get{ CheckIsValid();return (FString)Marshal.PtrToStructure(_this.Get()+StaticMeshDerivedDataKey__Offset, typeof(FString));}
			
		}
		
		static readonly int MaterialStreamingRelativeBoxes__Offset;
		/// <summary>Material Bounds used for texture streaming.</summary>
		public TStructArray<uint> MaterialStreamingRelativeBoxes
		{
			get{ CheckIsValid();return new TStructArray<uint>((FScriptArray)Marshal.PtrToStructure(_this.Get()+MaterialStreamingRelativeBoxes__Offset, typeof(FScriptArray)));}
					set{ CheckIsValid();Marshal.StructureToPtr(value.InterArray, _this.Get()+MaterialStreamingRelativeBoxes__Offset, false);}
			
		}
		
		static readonly int bCustomOverrideVertexColorPerLOD__Offset;
		/// <summary>The component has some custom painting on LODs or not.</summary>
		public bool bCustomOverrideVertexColorPerLOD
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bCustomOverrideVertexColorPerLOD__Offset, 1, 0, 1, 255);}
			
		}
		
		static readonly int LightmassSettings__Offset;
		/// <summary>The Lightmass settings for this object.</summary>
		public FLightmassPrimitiveSettings LightmassSettings
		{
			get{ CheckIsValid();return (FLightmassPrimitiveSettings)Marshal.PtrToStructure(_this.Get()+LightmassSettings__Offset, typeof(FLightmassPrimitiveSettings));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+LightmassSettings__Offset, false);}
			
		}
		
		static UStaticMeshComponent()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("StaticMeshComponent");
			ForcedLodModel__Offset=GetPropertyOffset(NativeClassPtr,"ForcedLodModel");
			PreviousLODLevel__Offset=GetPropertyOffset(NativeClassPtr,"PreviousLODLevel");
			bOverrideMinLOD__Offset=GetPropertyOffset(NativeClassPtr,"bOverrideMinLOD");
			MinLOD__Offset=GetPropertyOffset(NativeClassPtr,"MinLOD");
			StaticMesh__Offset=GetPropertyOffset(NativeClassPtr,"StaticMesh");
			bOverrideWireframeColor__Offset=GetPropertyOffset(NativeClassPtr,"bOverrideWireframeColor");
			WireframeColorOverride__Offset=GetPropertyOffset(NativeClassPtr,"WireframeColorOverride");
			SelectedEditorSection__Offset=GetPropertyOffset(NativeClassPtr,"SelectedEditorSection");
			SectionIndexPreview__Offset=GetPropertyOffset(NativeClassPtr,"SectionIndexPreview");
			StaticMeshImportVersion__Offset=GetPropertyOffset(NativeClassPtr,"StaticMeshImportVersion");
			bOverrideNavigationExport__Offset=GetPropertyOffset(NativeClassPtr,"bOverrideNavigationExport");
			bForceNavigationObstacle__Offset=GetPropertyOffset(NativeClassPtr,"bForceNavigationObstacle");
			bDisallowMeshPaintPerInstance__Offset=GetPropertyOffset(NativeClassPtr,"bDisallowMeshPaintPerInstance");
			bIgnoreInstanceForTextureStreaming__Offset=GetPropertyOffset(NativeClassPtr,"bIgnoreInstanceForTextureStreaming");
			bOverrideLightMapRes__Offset=GetPropertyOffset(NativeClassPtr,"bOverrideLightMapRes");
			OverriddenLightMapRes__Offset=GetPropertyOffset(NativeClassPtr,"OverriddenLightMapRes");
			bCastDistanceFieldIndirectShadow__Offset=GetPropertyOffset(NativeClassPtr,"bCastDistanceFieldIndirectShadow");
			DistanceFieldIndirectShadowMinVisibility__Offset=GetPropertyOffset(NativeClassPtr,"DistanceFieldIndirectShadowMinVisibility");
			StreamingDistanceMultiplier__Offset=GetPropertyOffset(NativeClassPtr,"StreamingDistanceMultiplier");
			SubDivisionStepSize__Offset=GetPropertyOffset(NativeClassPtr,"SubDivisionStepSize");
			bUseSubDivisions__Offset=GetPropertyOffset(NativeClassPtr,"bUseSubDivisions");
			IrrelevantLights__Offset=GetPropertyOffset(NativeClassPtr,"IrrelevantLights");
			LODData__Offset=GetPropertyOffset(NativeClassPtr,"LODData");
			StreamingTextureData__Offset=GetPropertyOffset(NativeClassPtr,"StreamingTextureData");
			bUseDefaultCollision__Offset=GetPropertyOffset(NativeClassPtr,"bUseDefaultCollision");
			StaticMeshDerivedDataKey__Offset=GetPropertyOffset(NativeClassPtr,"StaticMeshDerivedDataKey");
			MaterialStreamingRelativeBoxes__Offset=GetPropertyOffset(NativeClassPtr,"MaterialStreamingRelativeBoxes");
			bCustomOverrideVertexColorPerLOD__Offset=GetPropertyOffset(NativeClassPtr,"bCustomOverrideVertexColorPerLOD");
			LightmassSettings__Offset=GetPropertyOffset(NativeClassPtr,"LightmassSettings");
			
		}
		
	}
	
}
#endif
#endif
