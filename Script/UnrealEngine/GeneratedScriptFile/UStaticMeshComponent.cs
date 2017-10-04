using System;
namespace UnrealEngine
{
	public partial class UStaticMeshComponent:UMeshComponent
	{
		/// <summary>Get Local bounds</summary>
		public extern void GetLocalBounds(out FVector Min,out FVector Max);
		public extern void SetForcedLodModel(int NewForcedLodModel);
		/// <summary>Change the StaticMesh used by this instance.</summary>
		public extern virtual bool SetStaticMesh(UStaticMesh NewMesh);
		public extern void OnRep_StaticMesh(UStaticMesh OldStaticMesh);
		/// <summary>If 0, auto-select LOD level. if >0, force to (ForcedLodModel-1).</summary>
		public int ForcedLodModel;
		
		/// <summary>LOD that was desired for rendering this StaticMeshComponent last frame.</summary>
		public int PreviousLODLevel;
		
		/// <summary>Whether to override the MinLOD setting of the static mesh asset with the MinLOD of this component.</summary>
		public bool bOverrideMinLOD;
		
		/// <summary>
		/// Specifies the smallest LOD that will be used for this component.
		/// This is ignored if ForcedLodModel is enabled.
		/// </summary>
		public int MinLOD;
		
		public UStaticMesh StaticMesh;
		
		/// <summary>If true, WireframeColorOverride will be used. If false, color is determined based on mobility and physics simulation settings</summary>
		public bool bOverrideWireframeColor;
		
		/// <summary>Wireframe color to use if bOverrideWireframeColor is true</summary>
		public FColor WireframeColorOverride;
		
		/// <summary>The section currently selected in the Editor. Used for highlighting</summary>
		public int SelectedEditorSection;
		
		/// <summary>Index of the section to preview. If set to INDEX_NONE, all section will be rendered. Used for isolating in Static Mesh Tool *</summary>
		public int SectionIndexPreview;
		
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
		public int StaticMeshImportVersion;
		
		/// <summary>If true, bForceNavigationObstacle flag will take priority over navigation data stored in StaticMesh</summary>
		public bool bOverrideNavigationExport;
		
		/// <summary>Allows overriding navigation export behavior per component: full collisions or dynamic obstacle</summary>
		public bool bForceNavigationObstacle;
		
		/// <summary>If true, mesh painting is disallowed on this instance. Set if vertex colors are overridden in a construction script.</summary>
		public bool bDisallowMeshPaintPerInstance;
		
		/// <summary>
		/// Ignore this instance of this static mesh when calculating streaming information.
		/// This can be useful when doing things like applying character textures to static geometry,
		/// to avoid them using distance-based streaming.
		/// </summary>
		public bool bIgnoreInstanceForTextureStreaming;
		
		/// <summary>Whether to override the lightmap resolution defined in the static mesh.</summary>
		public bool bOverrideLightMapRes;
		
		/// <summary>Light map resolution to use on this component, used if bOverrideLightMapRes is true and there is a valid StaticMesh.</summary>
		public int OverriddenLightMapRes;
		
		/// <summary>
		/// Whether to use the mesh distance field representation (when present) for shadowing indirect lighting (from lightmaps or skylight) on Movable components.
		/// This works like capsule shadows on skeletal meshes, except using the mesh distance field so no physics asset is required.
		/// The StaticMesh must have 'Generate Mesh Distance Field' enabled, or the project must have 'Generate Mesh Distance Fields' enabled for this feature to work.
		/// </summary>
		public bool bCastDistanceFieldIndirectShadow;
		
		/// <summary>Controls how dark the dynamic indirect shadow can be.</summary>
		public float DistanceFieldIndirectShadowMinVisibility;
		
		/// <summary>Allows adjusting the desired resolution of streaming textures that uses UV 0.  1.0 is the default, whereas a higher value increases the streamed-in resolution.</summary>
		public float StreamingDistanceMultiplier;
		
		/// <summary>Subdivision step size for static vertex lighting.</summary>
		public int SubDivisionStepSize;
		
		/// <summary>Whether to use subdivisions or just the triangle's vertices.</summary>
		public bool bUseSubDivisions;
		
		/// <summary>Use the collision profile specified in the StaticMesh asset.</summary>
		public bool bUseDefaultCollision;
		
		/// <summary>Derived data key of the static mesh, used to determine if an update from the source static mesh is required.</summary>
		public FString StaticMeshDerivedDataKey;
		
		/// <summary>The component has some custom painting on LODs or not.</summary>
		public bool bCustomOverrideVertexColorPerLOD;
		
		/// <summary>The Lightmass settings for this object.</summary>
		public FLightmassPrimitiveSettings LightmassSettings;
		
		
	}
	
}
