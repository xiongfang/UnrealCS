using System;
namespace UnrealEngine
{
	public partial class UStaticMesh:UObject
	{
		/// <summary>Returns number of Sections that this StaticMesh has, in the supplied LOD (LOD 0 is the highest)</summary>
		public extern int GetNumSections(int InLOD);
		/// <summary>Returns the bounding box, in local space including bounds extension(s), of the StaticMesh asset</summary>
		public extern FBox GetBoundingBox();
		/// <summary>
		/// Returns the number of bounds of the mesh.
		/// @return      The bounding box represented as box origin with extents and also a sphere that encapsulates that box
		/// </summary>
		public extern FBoxSphereBounds GetBounds();
		/// <summary>Returns the number of LODs used by the mesh.</summary>
		public extern int GetNumLODs();
		/// <summary>Map of LOD+Section index to per-section info.</summary>
		public FMeshSectionInfoMap SectionInfoMap;
		
		/// <summary>The LOD group to which this mesh belongs.</summary>
		public FName LODGroup;
		
		/// <summary>If true, the screen sizees at which LODs swap are computed automatically.</summary>
		public bool bAutoComputeLODScreenSize;
		
		/// <summary>The last import version</summary>
		public int ImportVersion;
		
		/// <summary>Minimum LOD to use for rendering.  This is the default setting for the mesh and can be overridden by component settings.</summary>
		public int MinLOD;
		
		public float LightmapUVDensity;
		
		/// <summary>The light map resolution</summary>
		public int LightMapResolution;
		
		/// <summary>The light map coordinate index</summary>
		public int LightMapCoordinateIndex;
		
		/// <summary>
		/// Whether to generate a distance field for this mesh, which can be used by DistanceField Indirect Shadows.
		/// This is ignored if the project's 'Generate Mesh Distance Fields' setting is enabled.
		/// </summary>
		public bool bGenerateMeshDistanceField;
		
		/// <summary>Physics data.</summary>
		public UBodySetup BodySetup;
		
		/// <summary>
		/// Specifies which mesh LOD to use for complex (per-poly) collision.
		/// Sometimes it can be desirable to use a lower poly representation for collision to reduce memory usage, improve performance and behaviour.
		/// Collision representation does not change based on distance to camera.
		/// </summary>
		public int LODForCollision;
		
		/// <summary>
		/// If true, strips unwanted complex collision data aka kDOP tree when cooking for consoles.
		///               On the Playstation 3 data of this mesh will be stored in video memory.
		/// </summary>
		public bool bStripComplexCollisionForConsole;
		
		/// <summary>
		/// If true, mesh will have NavCollision property with additional data for navmesh generation and usage.
		///           Set to false for distant meshes (always outside navigation bounds) to save memory on collision data.
		/// </summary>
		public bool bHasNavigationData;
		
		/// <summary>Bias multiplier for Light Propagation Volume lighting</summary>
		public float LpvBiasMultiplier;
		
		/// <summary>
		/// If true, will keep geometry data CPU-accessible in cooked builds, rather than uploading to GPU memory and releasing it from CPU memory.
		/// This is required if you wish to access StaticMesh geometry data on the CPU at runtime in cooked builds (e.g. to convert StaticMesh to ProceduralMeshComponent)
		/// </summary>
		public bool bAllowCPUAccess;
		
		/// <summary>Importing data and options used for this mesh</summary>
		public UAssetImportData AssetImportData;
		
		/// <summary>Path to the resource used to construct this static mesh</summary>
		public FString SourceFilePath;
		
		/// <summary>Date/Time-stamp of the file from the last import</summary>
		public FString SourceFileTimestamp;
		
		/// <summary>Information for thumbnail rendering</summary>
		public UThumbnailInfo ThumbnailInfo;
		
		/// <summary>The stored camera position to use as a default for the static mesh editor</summary>
		public FAssetEditorOrbitCameraPosition EditorCameraPosition;
		
		/// <summary>If the user has modified collision in any way or has custom collision imported. Used for determining if to auto generate collision on import</summary>
		public bool bCustomizedCollision;
		
		/// <summary>Bound extension values in the positive direction of XYZ, positive value increases bound size</summary>
		public FVector PositiveBoundsExtension;
		
		/// <summary>Bound extension values in the negative direction of XYZ, positive value increases bound size</summary>
		public FVector NegativeBoundsExtension;
		
		/// <summary>Original mesh bounds extended with Positive/NegativeBoundsExtension</summary>
		public FBoxSphereBounds ExtendedBounds;
		
		/// <summary>
		/// Index of an element to ignore while gathering streaming texture factors.
		/// This is useful to disregard automatically generated vertex data which breaks texture factor heuristics.
		/// </summary>
		public int ElementToIgnoreForTexFactor;
		
		/// <summary>Pre-build navigation collision</summary>
		public UNavCollision NavCollision;
		
		
	}
	
}
