using System;
namespace UnrealEngine
{
	public partial class ARecastNavMesh:ANavigationData
	{
		/// <summary>should we draw edges of every navmesh's triangle</summary>
		public bool bDrawTriangleEdges;
		
		/// <summary>should we draw edges of every poly (i.e. not only border-edges)</summary>
		public bool bDrawPolyEdges;
		
		/// <summary>if disabled skips filling drawn navmesh polygons</summary>
		public bool bDrawFilledPolys;
		
		/// <summary>should we draw border-edges</summary>
		public bool bDrawNavMeshEdges;
		
		/// <summary>should we draw the tile boundaries</summary>
		public bool bDrawTileBounds;
		
		/// <summary>Draw input geometry passed to the navmesh generator.  Recommend disabling other geometry rendering via viewport showflags in editor.</summary>
		public bool bDrawPathCollidingGeometry;
		
		public bool bDrawTileLabels;
		
		public bool bDrawPolygonLabels;
		
		public bool bDrawDefaultPolygonCost;
		
		public bool bDrawLabelsOnPathNodes;
		
		public bool bDrawNavLinks;
		
		public bool bDrawFailedNavLinks;
		
		public bool bDrawClusters;
		
		/// <summary>should we draw edges of every navmesh's triangle</summary>
		public bool bDrawOctree;
		
		public bool bDistinctlyDrawTilesBeingBuilt;
		
		public bool bDrawNavMesh;
		
		/// <summary>vertical offset added to navmesh's debug representation for better readability</summary>
		public float DrawOffset;
		
		/// <summary>if true, the NavMesh will allocate fixed size pool for tiles, should be enabled to support streaming</summary>
		public bool bFixedTilePoolSize;
		
		/// <summary>maximum number of tiles NavMesh can hold</summary>
		public int TilePoolSize;
		
		/// <summary>size of single tile, expressed in uu</summary>
		public float TileSizeUU;
		
		/// <summary>horizontal size of voxelization cell</summary>
		public float CellSize;
		
		/// <summary>vertical size of voxelization cell</summary>
		public float CellHeight;
		
		/// <summary>Radius of smallest agent to traverse this navmesh</summary>
		public float AgentRadius;
		
		public float AgentHeight;
		
		/// <summary>Size of the tallest agent that will path with this navmesh.</summary>
		public float AgentMaxHeight;
		
		/// <summary>The maximum slope (angle) that the agent can move on.</summary>
		public float AgentMaxSlope;
		
		public float AgentMaxStepHeight;
		
		/// <summary>The minimum dimension of area. Areas smaller than this will be discarded</summary>
		public float MinRegionArea;
		
		/// <summary>The size limit of regions to be merged with bigger regions (watershed partitioning only)</summary>
		public float MergeRegionSize;
		
		/// <summary>How much navigable shapes can get simplified - the higher the value the more freedom</summary>
		public float MaxSimplificationError;
		
		public int MaxSimultaneousTileGenerationJobsCount;
		
		/// <summary>
		/// Absolute hard limit to number of navmesh tiles. Be very, very careful while modifying it while
		///     having big maps with navmesh. A single, empty tile takes 176 bytes and empty tiles are
		///     allocated up front (subject to change, but that's where it's at now)
		///     @note TileNumberHardLimit is always rounded up to the closest power of 2
		/// </summary>
		public int TileNumberHardLimit;
		
		public int PolyRefTileBits;
		
		public int PolyRefNavPolyBits;
		
		public int PolyRefSaltBits;
		
		/// <summary>navmesh draw distance in game (always visible in editor)</summary>
		public float DefaultDrawDistance;
		
		/// <summary>
		/// specifes default limit to A* nodes used when performing navigation queries.
		///     Can be overridden by passing custom FNavigationQueryFilter
		/// </summary>
		public float DefaultMaxSearchNodes;
		
		/// <summary>specifes default limit to A* nodes used when performing hierarchical navigation queries.</summary>
		public float DefaultMaxHierarchicalSearchNodes;
		
		/// <summary>partitioning method for creating navmesh polys</summary>
		public ERecastPartitioning RegionPartitioning;
		
		/// <summary>partitioning method for creating tile layers</summary>
		public ERecastPartitioning LayerPartitioning;
		
		/// <summary>number of chunk splits (along single axis) used for region's partitioning: ChunkyMonotone</summary>
		public int RegionChunkSplits;
		
		/// <summary>number of chunk splits (along single axis) used for layer's partitioning: ChunkyMonotone</summary>
		public int LayerChunkSplits;
		
		/// <summary>
		/// Controls whether Navigation Areas will be sorted by cost before application
		///     to navmesh during navmesh generation. This is relevant then there are
		///     areas overlapping and we want to have area cost express area relevancy
		///     as well. Setting it to true will result in having area sorted by cost,
		///     but it will also increase navmesh generation cost a bit
		/// </summary>
		public bool bSortNavigationAreasByCost;
		
		/// <summary>
		/// controls whether voxel filterring will be applied (via FRecastTileGenerator::ApplyVoxelFilter).
		///     Results in generated navemesh better fitting navigation bounds, but hits (a bit) generation performance
		/// </summary>
		public bool bPerformVoxelFiltering;
		
		/// <summary>mark areas with insufficient free height above instead of cutting them out</summary>
		public bool bMarkLowHeightAreas;
		
		public bool bDoFullyAsyncNavDataGathering;
		
		/// <summary>TODO: switch to disable new code from OffsetFromCorners if necessary - remove it later</summary>
		public bool bUseBetterOffsetsFromCorners;
		
		/// <summary>If set, tiles generated without any navmesh data will be marked to distinguish them from not generated / streamed out ones. Defaults to false.</summary>
		public bool bStoreEmptyTileLayers;
		
		/// <summary>Indicates whether default navigation filters will use virtual functions. Defaults to true.</summary>
		public bool bUseVirtualFilters;
		
		/// <summary>Cache rasterized voxels instead of just collision vertices/indices in navigation octree</summary>
		public bool bUseVoxelCache;
		
		/// <summary>indicates how often we will sort navigation tiles to mach players position</summary>
		public float TileSetUpdateInterval;
		
		/// <summary>Euclidean distance heuristic scale used while pathfinding</summary>
		public float HeuristicScale;
		
		/// <summary>Value added to each search height to compensate for error between navmesh polys and walkable geometry</summary>
		public float VerticalDeviationFromGroundCompensation;
		
		
	}
	
}
