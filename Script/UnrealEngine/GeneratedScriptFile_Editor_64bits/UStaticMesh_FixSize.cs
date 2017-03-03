#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>
	/// A StaticMesh is a piece of geometry that consists of a static set of polygons.
	/// Static Meshes can be translated, rotated, and scaled, but they cannot have their vertices animated in any way. As such, they are more efficient
	/// to render than other types of geometry such as USkeletalMesh, and they are often the basic building block of levels created in the engine.
	/// @see https://docs.unrealengine.com/latest/INT/Engine/Content/Types/StaticMeshes/
	/// @see AStaticMeshActor, UStaticMeshComponent
	/// </summary>
	public partial class UStaticMesh
	{
		static readonly int SourceModels__Offset;
		/// <summary>Imported raw mesh bulk data.</summary>
		public TStructArray<FStaticMeshSourceModel> SourceModels
		{
			get{ CheckIsValid();return new TStructArray<FStaticMeshSourceModel>((FScriptArray)Marshal.PtrToStructure(_this.Get()+SourceModels__Offset, typeof(FScriptArray)));}
					set{ CheckIsValid();Marshal.StructureToPtr(value.InterArray, _this.Get()+SourceModels__Offset, false);}
			
		}
		
		static readonly int SectionInfoMap__Offset;
		/// <summary>Map of LOD+Section index to per-section info.</summary>
		public FMeshSectionInfoMap SectionInfoMap
		{
			get{ CheckIsValid();return (FMeshSectionInfoMap)Marshal.PtrToStructure(_this.Get()+SectionInfoMap__Offset, typeof(FMeshSectionInfoMap));}
			
		}
		
		static readonly int LODGroup__Offset;
		/// <summary>The LOD group to which this mesh belongs.</summary>
		public FName LODGroup
		{
			get{ CheckIsValid();return (FName)Marshal.PtrToStructure(_this.Get()+LODGroup__Offset, typeof(FName));}
			
		}
		
		static readonly int bAutoComputeLODScreenSize__Offset;
		/// <summary>If true, the screen sizees at which LODs swap are computed automatically.</summary>
		public bool bAutoComputeLODScreenSize
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bAutoComputeLODScreenSize__Offset, 1, 0, 1, 1);}
			
		}
		
		static readonly int ImportVersion__Offset;
		/// <summary>The last import version</summary>
		public int ImportVersion
		{
			get{ CheckIsValid();return (int)Marshal.PtrToStructure(_this.Get()+ImportVersion__Offset, typeof(int));}
			
		}
		
		static readonly int MaterialRemapIndexPerImportVersion__Offset;
		public TStructArray<FMaterialRemapIndex> MaterialRemapIndexPerImportVersion
		{
			get{ CheckIsValid();return new TStructArray<FMaterialRemapIndex>((FScriptArray)Marshal.PtrToStructure(_this.Get()+MaterialRemapIndexPerImportVersion__Offset, typeof(FScriptArray)));}
					set{ CheckIsValid();Marshal.StructureToPtr(value.InterArray, _this.Get()+MaterialRemapIndexPerImportVersion__Offset, false);}
			
		}
		
		static readonly int MinLOD__Offset;
		/// <summary>Minimum LOD to use for rendering.  This is the default setting for the mesh and can be overridden by component settings.</summary>
		public int MinLOD
		{
			get{ CheckIsValid();return (int)Marshal.PtrToStructure(_this.Get()+MinLOD__Offset, typeof(int));}
			
		}
		
		static readonly int Materials__Offset;
		/// <summary>Materials used by this static mesh. Individual sections index in to this array.</summary>
		public TObjectArray<UMaterialInterface>  Materials
		{
					get{ CheckIsValid();return new TObjectArray<UMaterialInterface>((FScriptArray)Marshal.PtrToStructure(_this.Get()+Materials__Offset, typeof(FScriptArray)));}
					set{ CheckIsValid();Marshal.StructureToPtr(value.InterArray, _this.Get()+Materials__Offset, false);}
			
		}
		
		static readonly int StaticMaterials__Offset;
		public TStructArray<FStaticMaterial> StaticMaterials
		{
			get{ CheckIsValid();return new TStructArray<FStaticMaterial>((FScriptArray)Marshal.PtrToStructure(_this.Get()+StaticMaterials__Offset, typeof(FScriptArray)));}
					set{ CheckIsValid();Marshal.StructureToPtr(value.InterArray, _this.Get()+StaticMaterials__Offset, false);}
			
		}
		
		static readonly int LightmapUVDensity__Offset;
		public float LightmapUVDensity
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+LightmapUVDensity__Offset, typeof(float));}
			
		}
		
		static readonly int LightMapResolution__Offset;
		/// <summary>The light map resolution</summary>
		public int LightMapResolution
		{
			get{ CheckIsValid();return (int)Marshal.PtrToStructure(_this.Get()+LightMapResolution__Offset, typeof(int));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+LightMapResolution__Offset, false);}
			
		}
		
		static readonly int LightMapCoordinateIndex__Offset;
		/// <summary>The light map coordinate index</summary>
		public int LightMapCoordinateIndex
		{
			get{ CheckIsValid();return (int)Marshal.PtrToStructure(_this.Get()+LightMapCoordinateIndex__Offset, typeof(int));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+LightMapCoordinateIndex__Offset, false);}
			
		}
		
		static readonly int bGenerateMeshDistanceField__Offset;
		/// <summary>
		/// Whether to generate a distance field for this mesh, which can be used by DistanceField Indirect Shadows.
		/// This is ignored if the project's 'Generate Mesh Distance Fields' setting is enabled.
		/// </summary>
		public bool bGenerateMeshDistanceField
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bGenerateMeshDistanceField__Offset, 1, 0, 1, 1);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bGenerateMeshDistanceField__Offset, 1,0,1,1);}
			
		}
		
		static readonly int BodySetup__Offset;
		/// <summary>Physics data.</summary>
		public UBodySetup BodySetup
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + BodySetup__Offset); if (v == IntPtr.Zero)return null; UBodySetup retValue = new UBodySetup(); retValue._this = v; return retValue; }
			set{ CheckIsValid(); if (value == null)Marshal.WriteIntPtr(_this.Get() + BodySetup__Offset, IntPtr.Zero);else Marshal.WriteIntPtr(_this.Get() + BodySetup__Offset, value._this.Get()); }
			
		}
		
		static readonly int LODForCollision__Offset;
		/// <summary>
		/// Specifies which mesh LOD to use for complex (per-poly) collision.
		/// Sometimes it can be desirable to use a lower poly representation for collision to reduce memory usage, improve performance and behaviour.
		/// Collision representation does not change based on distance to camera.
		/// </summary>
		public int LODForCollision
		{
			get{ CheckIsValid();return (int)Marshal.PtrToStructure(_this.Get()+LODForCollision__Offset, typeof(int));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+LODForCollision__Offset, false);}
			
		}
		
		static readonly int bStripComplexCollisionForConsole__Offset;
		/// <summary>
		/// If true, strips unwanted complex collision data aka kDOP tree when cooking for consoles.
		///               On the Playstation 3 data of this mesh will be stored in video memory.
		/// </summary>
		public bool bStripComplexCollisionForConsole
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bStripComplexCollisionForConsole__Offset, 1, 0, 1, 1);}
			
		}
		
		static readonly int bHasNavigationData__Offset;
		/// <summary>
		/// If true, mesh will have NavCollision property with additional data for navmesh generation and usage.
		///           Set to false for distant meshes (always outside navigation bounds) to save memory on collision data.
		/// </summary>
		public bool bHasNavigationData
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bHasNavigationData__Offset, 1, 0, 2, 2);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bHasNavigationData__Offset, 1,0,2,2);}
			
		}
		
		static readonly int LpvBiasMultiplier__Offset;
		/// <summary>Bias multiplier for Light Propagation Volume lighting</summary>
		public float LpvBiasMultiplier
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+LpvBiasMultiplier__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+LpvBiasMultiplier__Offset, false);}
			
		}
		
		static readonly int bAllowCPUAccess__Offset;
		/// <summary>
		/// If true, will keep geometry data CPU-accessible in cooked builds, rather than uploading to GPU memory and releasing it from CPU memory.
		/// This is required if you wish to access StaticMesh geometry data on the CPU at runtime in cooked builds (e.g. to convert StaticMesh to ProceduralMeshComponent)
		/// </summary>
		public bool bAllowCPUAccess
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bAllowCPUAccess__Offset, 1, 0, 1, 255);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bAllowCPUAccess__Offset, 1,0,1,255);}
			
		}
		
		static readonly int AssetImportData__Offset;
		/// <summary>Importing data and options used for this mesh</summary>
		public UAssetImportData AssetImportData
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + AssetImportData__Offset); if (v == IntPtr.Zero)return null; UAssetImportData retValue = new UAssetImportData(); retValue._this = v; return retValue; }
			set{ CheckIsValid(); if (value == null)Marshal.WriteIntPtr(_this.Get() + AssetImportData__Offset, IntPtr.Zero);else Marshal.WriteIntPtr(_this.Get() + AssetImportData__Offset, value._this.Get()); }
			
		}
		
		static readonly int SourceFilePath__Offset;
		/// <summary>Path to the resource used to construct this static mesh</summary>
		public FString SourceFilePath
		{
			get{ CheckIsValid();return (FString)Marshal.PtrToStructure(_this.Get()+SourceFilePath__Offset, typeof(FString));}
			
		}
		
		static readonly int SourceFileTimestamp__Offset;
		/// <summary>Date/Time-stamp of the file from the last import</summary>
		public FString SourceFileTimestamp
		{
			get{ CheckIsValid();return (FString)Marshal.PtrToStructure(_this.Get()+SourceFileTimestamp__Offset, typeof(FString));}
			
		}
		
		static readonly int ThumbnailInfo__Offset;
		/// <summary>Information for thumbnail rendering</summary>
		public UThumbnailInfo ThumbnailInfo
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + ThumbnailInfo__Offset); if (v == IntPtr.Zero)return null; UThumbnailInfo retValue = new UThumbnailInfo(); retValue._this = v; return retValue; }
			set{ CheckIsValid(); if (value == null)Marshal.WriteIntPtr(_this.Get() + ThumbnailInfo__Offset, IntPtr.Zero);else Marshal.WriteIntPtr(_this.Get() + ThumbnailInfo__Offset, value._this.Get()); }
			
		}
		
		static readonly int EditorCameraPosition__Offset;
		/// <summary>The stored camera position to use as a default for the static mesh editor</summary>
		public FAssetEditorOrbitCameraPosition EditorCameraPosition
		{
			get{ CheckIsValid();return (FAssetEditorOrbitCameraPosition)Marshal.PtrToStructure(_this.Get()+EditorCameraPosition__Offset, typeof(FAssetEditorOrbitCameraPosition));}
			
		}
		
		static readonly int bCustomizedCollision__Offset;
		/// <summary>If the user has modified collision in any way or has custom collision imported. Used for determining if to auto generate collision on import</summary>
		public bool bCustomizedCollision
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bCustomizedCollision__Offset, 1, 0, 1, 255);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bCustomizedCollision__Offset, 1,0,1,255);}
			
		}
		
		static readonly int Sockets__Offset;
		/// <summary>
		/// Array of named socket locations, set up in editor and used as a shortcut instead of specifying
		/// everything explicitly to AttachComponent in the StaticMeshComponent.
		/// </summary>
		public TObjectArray<UStaticMeshSocket>  Sockets
		{
					get{ CheckIsValid();return new TObjectArray<UStaticMeshSocket>((FScriptArray)Marshal.PtrToStructure(_this.Get()+Sockets__Offset, typeof(FScriptArray)));}
					set{ CheckIsValid();Marshal.StructureToPtr(value.InterArray, _this.Get()+Sockets__Offset, false);}
			
		}
		
		static readonly int PositiveBoundsExtension__Offset;
		/// <summary>Bound extension values in the positive direction of XYZ, positive value increases bound size</summary>
		public FVector PositiveBoundsExtension
		{
			get{ CheckIsValid();return (FVector)Marshal.PtrToStructure(_this.Get()+PositiveBoundsExtension__Offset, typeof(FVector));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+PositiveBoundsExtension__Offset, false);}
			
		}
		
		static readonly int NegativeBoundsExtension__Offset;
		/// <summary>Bound extension values in the negative direction of XYZ, positive value increases bound size</summary>
		public FVector NegativeBoundsExtension
		{
			get{ CheckIsValid();return (FVector)Marshal.PtrToStructure(_this.Get()+NegativeBoundsExtension__Offset, typeof(FVector));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+NegativeBoundsExtension__Offset, false);}
			
		}
		
		static readonly int ExtendedBounds__Offset;
		/// <summary>Original mesh bounds extended with Positive/NegativeBoundsExtension</summary>
		public FBoxSphereBounds ExtendedBounds
		{
			get{ CheckIsValid();return (FBoxSphereBounds)Marshal.PtrToStructure(_this.Get()+ExtendedBounds__Offset, typeof(FBoxSphereBounds));}
			
		}
		
		static readonly int ElementToIgnoreForTexFactor__Offset;
		/// <summary>
		/// Index of an element to ignore while gathering streaming texture factors.
		/// This is useful to disregard automatically generated vertex data which breaks texture factor heuristics.
		/// </summary>
		public int ElementToIgnoreForTexFactor
		{
			get{ CheckIsValid();return (int)Marshal.PtrToStructure(_this.Get()+ElementToIgnoreForTexFactor__Offset, typeof(int));}
			
		}
		
		static readonly int AssetUserData__Offset;
		/// <summary>Array of user data stored with the asset</summary>
		public TObjectArray<UAssetUserData>  AssetUserData
		{
					get{ CheckIsValid();return new TObjectArray<UAssetUserData>((FScriptArray)Marshal.PtrToStructure(_this.Get()+AssetUserData__Offset, typeof(FScriptArray)));}
					set{ CheckIsValid();Marshal.StructureToPtr(value.InterArray, _this.Get()+AssetUserData__Offset, false);}
			
		}
		
		static readonly int NavCollision__Offset;
		/// <summary>Pre-build navigation collision</summary>
		public UNavCollision NavCollision
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + NavCollision__Offset); if (v == IntPtr.Zero)return null; UNavCollision retValue = new UNavCollision(); retValue._this = v; return retValue; }
			set{ CheckIsValid(); if (value == null)Marshal.WriteIntPtr(_this.Get() + NavCollision__Offset, IntPtr.Zero);else Marshal.WriteIntPtr(_this.Get() + NavCollision__Offset, value._this.Get()); }
			
		}
		
		static UStaticMesh()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("StaticMesh");
			SourceModels__Offset=GetPropertyOffset(NativeClassPtr,"SourceModels");
			SectionInfoMap__Offset=GetPropertyOffset(NativeClassPtr,"SectionInfoMap");
			LODGroup__Offset=GetPropertyOffset(NativeClassPtr,"LODGroup");
			bAutoComputeLODScreenSize__Offset=GetPropertyOffset(NativeClassPtr,"bAutoComputeLODScreenSize");
			ImportVersion__Offset=GetPropertyOffset(NativeClassPtr,"ImportVersion");
			MaterialRemapIndexPerImportVersion__Offset=GetPropertyOffset(NativeClassPtr,"MaterialRemapIndexPerImportVersion");
			MinLOD__Offset=GetPropertyOffset(NativeClassPtr,"MinLOD");
			Materials__Offset=GetPropertyOffset(NativeClassPtr,"Materials");
			StaticMaterials__Offset=GetPropertyOffset(NativeClassPtr,"StaticMaterials");
			LightmapUVDensity__Offset=GetPropertyOffset(NativeClassPtr,"LightmapUVDensity");
			LightMapResolution__Offset=GetPropertyOffset(NativeClassPtr,"LightMapResolution");
			LightMapCoordinateIndex__Offset=GetPropertyOffset(NativeClassPtr,"LightMapCoordinateIndex");
			bGenerateMeshDistanceField__Offset=GetPropertyOffset(NativeClassPtr,"bGenerateMeshDistanceField");
			BodySetup__Offset=GetPropertyOffset(NativeClassPtr,"BodySetup");
			LODForCollision__Offset=GetPropertyOffset(NativeClassPtr,"LODForCollision");
			bStripComplexCollisionForConsole__Offset=GetPropertyOffset(NativeClassPtr,"bStripComplexCollisionForConsole");
			bHasNavigationData__Offset=GetPropertyOffset(NativeClassPtr,"bHasNavigationData");
			LpvBiasMultiplier__Offset=GetPropertyOffset(NativeClassPtr,"LpvBiasMultiplier");
			bAllowCPUAccess__Offset=GetPropertyOffset(NativeClassPtr,"bAllowCPUAccess");
			AssetImportData__Offset=GetPropertyOffset(NativeClassPtr,"AssetImportData");
			SourceFilePath__Offset=GetPropertyOffset(NativeClassPtr,"SourceFilePath");
			SourceFileTimestamp__Offset=GetPropertyOffset(NativeClassPtr,"SourceFileTimestamp");
			ThumbnailInfo__Offset=GetPropertyOffset(NativeClassPtr,"ThumbnailInfo");
			EditorCameraPosition__Offset=GetPropertyOffset(NativeClassPtr,"EditorCameraPosition");
			bCustomizedCollision__Offset=GetPropertyOffset(NativeClassPtr,"bCustomizedCollision");
			Sockets__Offset=GetPropertyOffset(NativeClassPtr,"Sockets");
			PositiveBoundsExtension__Offset=GetPropertyOffset(NativeClassPtr,"PositiveBoundsExtension");
			NegativeBoundsExtension__Offset=GetPropertyOffset(NativeClassPtr,"NegativeBoundsExtension");
			ExtendedBounds__Offset=GetPropertyOffset(NativeClassPtr,"ExtendedBounds");
			ElementToIgnoreForTexFactor__Offset=GetPropertyOffset(NativeClassPtr,"ElementToIgnoreForTexFactor");
			AssetUserData__Offset=GetPropertyOffset(NativeClassPtr,"AssetUserData");
			NavCollision__Offset=GetPropertyOffset(NativeClassPtr,"NavCollision");
			
		}
		
	}
	
}
#endif
#endif
