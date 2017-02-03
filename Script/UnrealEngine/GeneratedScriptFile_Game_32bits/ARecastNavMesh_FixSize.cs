#if WITH_GAME
#if PLATFORM_32BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class ARecastNavMesh
	{
		static readonly int bDrawTriangleEdges__Offset;
		public bool bDrawTriangleEdges
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bDrawTriangleEdges__Offset, 1, 0, 1, 1);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bDrawTriangleEdges__Offset, 1,0,1,1);}
			
		}
		
		static readonly int bDrawPolyEdges__Offset;
		public bool bDrawPolyEdges
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bDrawPolyEdges__Offset, 1, 0, 2, 2);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bDrawPolyEdges__Offset, 1,0,2,2);}
			
		}
		
		static readonly int bDrawFilledPolys__Offset;
		public bool bDrawFilledPolys
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bDrawFilledPolys__Offset, 1, 0, 4, 4);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bDrawFilledPolys__Offset, 1,0,4,4);}
			
		}
		
		static readonly int bDrawNavMeshEdges__Offset;
		public bool bDrawNavMeshEdges
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bDrawNavMeshEdges__Offset, 1, 0, 8, 8);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bDrawNavMeshEdges__Offset, 1,0,8,8);}
			
		}
		
		static readonly int bDrawTileBounds__Offset;
		public bool bDrawTileBounds
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bDrawTileBounds__Offset, 1, 0, 16, 16);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bDrawTileBounds__Offset, 1,0,16,16);}
			
		}
		
		static readonly int bDrawPathCollidingGeometry__Offset;
		public bool bDrawPathCollidingGeometry
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bDrawPathCollidingGeometry__Offset, 1, 0, 32, 32);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bDrawPathCollidingGeometry__Offset, 1,0,32,32);}
			
		}
		
		static readonly int bDrawTileLabels__Offset;
		public bool bDrawTileLabels
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bDrawTileLabels__Offset, 1, 0, 64, 64);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bDrawTileLabels__Offset, 1,0,64,64);}
			
		}
		
		static readonly int bDrawPolygonLabels__Offset;
		public bool bDrawPolygonLabels
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bDrawPolygonLabels__Offset, 1, 0, 128, 128);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bDrawPolygonLabels__Offset, 1,0,128,128);}
			
		}
		
		static readonly int bDrawDefaultPolygonCost__Offset;
		public bool bDrawDefaultPolygonCost
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bDrawDefaultPolygonCost__Offset, 1, 0, 1, 1);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bDrawDefaultPolygonCost__Offset, 1,0,1,1);}
			
		}
		
		static readonly int bDrawLabelsOnPathNodes__Offset;
		public bool bDrawLabelsOnPathNodes
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bDrawLabelsOnPathNodes__Offset, 1, 0, 2, 2);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bDrawLabelsOnPathNodes__Offset, 1,0,2,2);}
			
		}
		
		static readonly int bDrawNavLinks__Offset;
		public bool bDrawNavLinks
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bDrawNavLinks__Offset, 1, 0, 4, 4);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bDrawNavLinks__Offset, 1,0,4,4);}
			
		}
		
		static readonly int bDrawFailedNavLinks__Offset;
		public bool bDrawFailedNavLinks
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bDrawFailedNavLinks__Offset, 1, 0, 8, 8);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bDrawFailedNavLinks__Offset, 1,0,8,8);}
			
		}
		
		static readonly int bDrawClusters__Offset;
		public bool bDrawClusters
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bDrawClusters__Offset, 1, 0, 16, 16);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bDrawClusters__Offset, 1,0,16,16);}
			
		}
		
		static readonly int bDrawOctree__Offset;
		public bool bDrawOctree
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bDrawOctree__Offset, 1, 0, 32, 32);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bDrawOctree__Offset, 1,0,32,32);}
			
		}
		
		static readonly int bDistinctlyDrawTilesBeingBuilt__Offset;
		public bool bDistinctlyDrawTilesBeingBuilt
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bDistinctlyDrawTilesBeingBuilt__Offset, 1, 0, 64, 64);}
			
		}
		
		static readonly int bDrawNavMesh__Offset;
		public bool bDrawNavMesh
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bDrawNavMesh__Offset, 1, 0, 128, 128);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bDrawNavMesh__Offset, 1,0,128,128);}
			
		}
		
		static readonly int DrawOffset__Offset;
		public float DrawOffset
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+DrawOffset__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+DrawOffset__Offset, false);}
			
		}
		
		static readonly int bFixedTilePoolSize__Offset;
		public bool bFixedTilePoolSize
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bFixedTilePoolSize__Offset, 1, 0, 1, 1);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bFixedTilePoolSize__Offset, 1,0,1,1);}
			
		}
		
		static readonly int TilePoolSize__Offset;
		public int TilePoolSize
		{
			get{ CheckIsValid();return (int)Marshal.PtrToStructure(_this.Get()+TilePoolSize__Offset, typeof(int));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+TilePoolSize__Offset, false);}
			
		}
		
		static readonly int TileSizeUU__Offset;
		public float TileSizeUU
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+TileSizeUU__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+TileSizeUU__Offset, false);}
			
		}
		
		static readonly int CellSize__Offset;
		public float CellSize
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+CellSize__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+CellSize__Offset, false);}
			
		}
		
		static readonly int CellHeight__Offset;
		public float CellHeight
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+CellHeight__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+CellHeight__Offset, false);}
			
		}
		
		static readonly int AgentRadius__Offset;
		public float AgentRadius
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+AgentRadius__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+AgentRadius__Offset, false);}
			
		}
		
		static readonly int AgentHeight__Offset;
		public float AgentHeight
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+AgentHeight__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+AgentHeight__Offset, false);}
			
		}
		
		static readonly int AgentMaxHeight__Offset;
		public float AgentMaxHeight
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+AgentMaxHeight__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+AgentMaxHeight__Offset, false);}
			
		}
		
		static readonly int AgentMaxSlope__Offset;
		public float AgentMaxSlope
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+AgentMaxSlope__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+AgentMaxSlope__Offset, false);}
			
		}
		
		static readonly int AgentMaxStepHeight__Offset;
		public float AgentMaxStepHeight
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+AgentMaxStepHeight__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+AgentMaxStepHeight__Offset, false);}
			
		}
		
		static readonly int MinRegionArea__Offset;
		public float MinRegionArea
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+MinRegionArea__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+MinRegionArea__Offset, false);}
			
		}
		
		static readonly int MergeRegionSize__Offset;
		public float MergeRegionSize
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+MergeRegionSize__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+MergeRegionSize__Offset, false);}
			
		}
		
		static readonly int MaxSimplificationError__Offset;
		public float MaxSimplificationError
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+MaxSimplificationError__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+MaxSimplificationError__Offset, false);}
			
		}
		
		static readonly int MaxSimultaneousTileGenerationJobsCount__Offset;
		public int MaxSimultaneousTileGenerationJobsCount
		{
			get{ CheckIsValid();return (int)Marshal.PtrToStructure(_this.Get()+MaxSimultaneousTileGenerationJobsCount__Offset, typeof(int));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+MaxSimultaneousTileGenerationJobsCount__Offset, false);}
			
		}
		
		static readonly int TileNumberHardLimit__Offset;
		public int TileNumberHardLimit
		{
			get{ CheckIsValid();return (int)Marshal.PtrToStructure(_this.Get()+TileNumberHardLimit__Offset, typeof(int));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+TileNumberHardLimit__Offset, false);}
			
		}
		
		static readonly int PolyRefTileBits__Offset;
		public int PolyRefTileBits
		{
			get{ CheckIsValid();return (int)Marshal.PtrToStructure(_this.Get()+PolyRefTileBits__Offset, typeof(int));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+PolyRefTileBits__Offset, false);}
			
		}
		
		static readonly int PolyRefNavPolyBits__Offset;
		public int PolyRefNavPolyBits
		{
			get{ CheckIsValid();return (int)Marshal.PtrToStructure(_this.Get()+PolyRefNavPolyBits__Offset, typeof(int));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+PolyRefNavPolyBits__Offset, false);}
			
		}
		
		static readonly int PolyRefSaltBits__Offset;
		public int PolyRefSaltBits
		{
			get{ CheckIsValid();return (int)Marshal.PtrToStructure(_this.Get()+PolyRefSaltBits__Offset, typeof(int));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+PolyRefSaltBits__Offset, false);}
			
		}
		
		static readonly int DefaultDrawDistance__Offset;
		public float DefaultDrawDistance
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+DefaultDrawDistance__Offset, typeof(float));}
			
		}
		
		static readonly int DefaultMaxSearchNodes__Offset;
		public float DefaultMaxSearchNodes
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+DefaultMaxSearchNodes__Offset, typeof(float));}
			
		}
		
		static readonly int DefaultMaxHierarchicalSearchNodes__Offset;
		public float DefaultMaxHierarchicalSearchNodes
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+DefaultMaxHierarchicalSearchNodes__Offset, typeof(float));}
			
		}
		
		static readonly int RegionPartitioning__Offset;
		public ERecastPartitioning RegionPartitioning
		{
			get{ CheckIsValid();return (ERecastPartitioning)Marshal.PtrToStructure(_this.Get()+RegionPartitioning__Offset, typeof(ERecastPartitioning));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+RegionPartitioning__Offset, false);}
			
		}
		
		static readonly int LayerPartitioning__Offset;
		public ERecastPartitioning LayerPartitioning
		{
			get{ CheckIsValid();return (ERecastPartitioning)Marshal.PtrToStructure(_this.Get()+LayerPartitioning__Offset, typeof(ERecastPartitioning));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+LayerPartitioning__Offset, false);}
			
		}
		
		static readonly int RegionChunkSplits__Offset;
		public int RegionChunkSplits
		{
			get{ CheckIsValid();return (int)Marshal.PtrToStructure(_this.Get()+RegionChunkSplits__Offset, typeof(int));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+RegionChunkSplits__Offset, false);}
			
		}
		
		static readonly int LayerChunkSplits__Offset;
		public int LayerChunkSplits
		{
			get{ CheckIsValid();return (int)Marshal.PtrToStructure(_this.Get()+LayerChunkSplits__Offset, typeof(int));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+LayerChunkSplits__Offset, false);}
			
		}
		
		static readonly int bSortNavigationAreasByCost__Offset;
		public bool bSortNavigationAreasByCost
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bSortNavigationAreasByCost__Offset, 1, 0, 1, 1);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bSortNavigationAreasByCost__Offset, 1,0,1,1);}
			
		}
		
		static readonly int bPerformVoxelFiltering__Offset;
		public bool bPerformVoxelFiltering
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bPerformVoxelFiltering__Offset, 1, 0, 2, 2);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bPerformVoxelFiltering__Offset, 1,0,2,2);}
			
		}
		
		static readonly int bMarkLowHeightAreas__Offset;
		public bool bMarkLowHeightAreas
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bMarkLowHeightAreas__Offset, 1, 0, 4, 4);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bMarkLowHeightAreas__Offset, 1,0,4,4);}
			
		}
		
		static readonly int bDoFullyAsyncNavDataGathering__Offset;
		public bool bDoFullyAsyncNavDataGathering
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bDoFullyAsyncNavDataGathering__Offset, 1, 0, 8, 8);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bDoFullyAsyncNavDataGathering__Offset, 1,0,8,8);}
			
		}
		
		static readonly int bUseBetterOffsetsFromCorners__Offset;
		public bool bUseBetterOffsetsFromCorners
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bUseBetterOffsetsFromCorners__Offset, 1, 0, 16, 16);}
			
		}
		
		static readonly int bStoreEmptyTileLayers__Offset;
		public bool bStoreEmptyTileLayers
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bStoreEmptyTileLayers__Offset, 1, 0, 32, 32);}
			
		}
		
		static readonly int bUseVirtualFilters__Offset;
		public bool bUseVirtualFilters
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bUseVirtualFilters__Offset, 1, 0, 64, 64);}
			
		}
		
		static readonly int bUseVoxelCache__Offset;
		public bool bUseVoxelCache
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bUseVoxelCache__Offset, 1, 0, 128, 128);}
			
		}
		
		static readonly int TileSetUpdateInterval__Offset;
		public float TileSetUpdateInterval
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+TileSetUpdateInterval__Offset, typeof(float));}
			
		}
		
		static readonly int HeuristicScale__Offset;
		public float HeuristicScale
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+HeuristicScale__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+HeuristicScale__Offset, false);}
			
		}
		
		static readonly int VerticalDeviationFromGroundCompensation__Offset;
		public float VerticalDeviationFromGroundCompensation
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+VerticalDeviationFromGroundCompensation__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+VerticalDeviationFromGroundCompensation__Offset, false);}
			
		}
		
		static ARecastNavMesh()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("RecastNavMesh");
			bDrawTriangleEdges__Offset=GetPropertyOffset(NativeClassPtr,"bDrawTriangleEdges");
			bDrawPolyEdges__Offset=GetPropertyOffset(NativeClassPtr,"bDrawPolyEdges");
			bDrawFilledPolys__Offset=GetPropertyOffset(NativeClassPtr,"bDrawFilledPolys");
			bDrawNavMeshEdges__Offset=GetPropertyOffset(NativeClassPtr,"bDrawNavMeshEdges");
			bDrawTileBounds__Offset=GetPropertyOffset(NativeClassPtr,"bDrawTileBounds");
			bDrawPathCollidingGeometry__Offset=GetPropertyOffset(NativeClassPtr,"bDrawPathCollidingGeometry");
			bDrawTileLabels__Offset=GetPropertyOffset(NativeClassPtr,"bDrawTileLabels");
			bDrawPolygonLabels__Offset=GetPropertyOffset(NativeClassPtr,"bDrawPolygonLabels");
			bDrawDefaultPolygonCost__Offset=GetPropertyOffset(NativeClassPtr,"bDrawDefaultPolygonCost");
			bDrawLabelsOnPathNodes__Offset=GetPropertyOffset(NativeClassPtr,"bDrawLabelsOnPathNodes");
			bDrawNavLinks__Offset=GetPropertyOffset(NativeClassPtr,"bDrawNavLinks");
			bDrawFailedNavLinks__Offset=GetPropertyOffset(NativeClassPtr,"bDrawFailedNavLinks");
			bDrawClusters__Offset=GetPropertyOffset(NativeClassPtr,"bDrawClusters");
			bDrawOctree__Offset=GetPropertyOffset(NativeClassPtr,"bDrawOctree");
			bDistinctlyDrawTilesBeingBuilt__Offset=GetPropertyOffset(NativeClassPtr,"bDistinctlyDrawTilesBeingBuilt");
			bDrawNavMesh__Offset=GetPropertyOffset(NativeClassPtr,"bDrawNavMesh");
			DrawOffset__Offset=GetPropertyOffset(NativeClassPtr,"DrawOffset");
			bFixedTilePoolSize__Offset=GetPropertyOffset(NativeClassPtr,"bFixedTilePoolSize");
			TilePoolSize__Offset=GetPropertyOffset(NativeClassPtr,"TilePoolSize");
			TileSizeUU__Offset=GetPropertyOffset(NativeClassPtr,"TileSizeUU");
			CellSize__Offset=GetPropertyOffset(NativeClassPtr,"CellSize");
			CellHeight__Offset=GetPropertyOffset(NativeClassPtr,"CellHeight");
			AgentRadius__Offset=GetPropertyOffset(NativeClassPtr,"AgentRadius");
			AgentHeight__Offset=GetPropertyOffset(NativeClassPtr,"AgentHeight");
			AgentMaxHeight__Offset=GetPropertyOffset(NativeClassPtr,"AgentMaxHeight");
			AgentMaxSlope__Offset=GetPropertyOffset(NativeClassPtr,"AgentMaxSlope");
			AgentMaxStepHeight__Offset=GetPropertyOffset(NativeClassPtr,"AgentMaxStepHeight");
			MinRegionArea__Offset=GetPropertyOffset(NativeClassPtr,"MinRegionArea");
			MergeRegionSize__Offset=GetPropertyOffset(NativeClassPtr,"MergeRegionSize");
			MaxSimplificationError__Offset=GetPropertyOffset(NativeClassPtr,"MaxSimplificationError");
			MaxSimultaneousTileGenerationJobsCount__Offset=GetPropertyOffset(NativeClassPtr,"MaxSimultaneousTileGenerationJobsCount");
			TileNumberHardLimit__Offset=GetPropertyOffset(NativeClassPtr,"TileNumberHardLimit");
			PolyRefTileBits__Offset=GetPropertyOffset(NativeClassPtr,"PolyRefTileBits");
			PolyRefNavPolyBits__Offset=GetPropertyOffset(NativeClassPtr,"PolyRefNavPolyBits");
			PolyRefSaltBits__Offset=GetPropertyOffset(NativeClassPtr,"PolyRefSaltBits");
			DefaultDrawDistance__Offset=GetPropertyOffset(NativeClassPtr,"DefaultDrawDistance");
			DefaultMaxSearchNodes__Offset=GetPropertyOffset(NativeClassPtr,"DefaultMaxSearchNodes");
			DefaultMaxHierarchicalSearchNodes__Offset=GetPropertyOffset(NativeClassPtr,"DefaultMaxHierarchicalSearchNodes");
			RegionPartitioning__Offset=GetPropertyOffset(NativeClassPtr,"RegionPartitioning");
			LayerPartitioning__Offset=GetPropertyOffset(NativeClassPtr,"LayerPartitioning");
			RegionChunkSplits__Offset=GetPropertyOffset(NativeClassPtr,"RegionChunkSplits");
			LayerChunkSplits__Offset=GetPropertyOffset(NativeClassPtr,"LayerChunkSplits");
			bSortNavigationAreasByCost__Offset=GetPropertyOffset(NativeClassPtr,"bSortNavigationAreasByCost");
			bPerformVoxelFiltering__Offset=GetPropertyOffset(NativeClassPtr,"bPerformVoxelFiltering");
			bMarkLowHeightAreas__Offset=GetPropertyOffset(NativeClassPtr,"bMarkLowHeightAreas");
			bDoFullyAsyncNavDataGathering__Offset=GetPropertyOffset(NativeClassPtr,"bDoFullyAsyncNavDataGathering");
			bUseBetterOffsetsFromCorners__Offset=GetPropertyOffset(NativeClassPtr,"bUseBetterOffsetsFromCorners");
			bStoreEmptyTileLayers__Offset=GetPropertyOffset(NativeClassPtr,"bStoreEmptyTileLayers");
			bUseVirtualFilters__Offset=GetPropertyOffset(NativeClassPtr,"bUseVirtualFilters");
			bUseVoxelCache__Offset=GetPropertyOffset(NativeClassPtr,"bUseVoxelCache");
			TileSetUpdateInterval__Offset=GetPropertyOffset(NativeClassPtr,"TileSetUpdateInterval");
			HeuristicScale__Offset=GetPropertyOffset(NativeClassPtr,"HeuristicScale");
			VerticalDeviationFromGroundCompensation__Offset=GetPropertyOffset(NativeClassPtr,"VerticalDeviationFromGroundCompensation");
			
		}
		
	}
	
}
#endif
#endif
