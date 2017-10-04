using System;
namespace UnrealEngine
{
	public partial class UGarbageCollectionSettings:UDeveloperSettings
	{
		/// <summary>Time in seconds (game time) we should wait between purging object references to objects that are pending kill.</summary>
		public float TimeBetweenPurgingPendingKillObjects;
		
		/// <summary>If enabled, streaming will be flushed each time garbage collection is triggered.</summary>
		public bool FlushStreamingOnGC;
		
		/// <summary>If enabled, garbage collection will use multiple threads.</summary>
		public bool AllowParallelGC;
		
		/// <summary>If true, the engine will attempt to create clusters of objects for better garbage collection performance.</summary>
		public bool CreateGCClusters;
		
		/// <summary>If true, when creating clusters, the clusters referenced from another cluster will get merged into one big cluster.</summary>
		public bool MergeGCClusters;
		
		/// <summary>Maximum number of times GC can be skipped if worker threads are currently modifying UObject state. 0 = never force GC</summary>
		public int NumRetriesBeforeForcingGC;
		
		/// <summary>Maximum Object Count Not Considered By GC. Works only in cooked builds.</summary>
		public int MaxObjectsNotConsideredByGC;
		
		/// <summary>Size Of Permanent Object Pool (bytes). Works only in cooked builds.</summary>
		public int SizeOfPermanentObjectPool;
		
		/// <summary>Maximum number of UObjects that can exist in cooked game. Keep this as small as possible.</summary>
		public int MaxObjectsInGame;
		
		/// <summary>Maximum number of UObjects that can exist in the editor game. Make sure this can hold enough objects for the editor and commadlets within reasonable limit.</summary>
		public int MaxObjectsInEditor;
		
		
	}
	
}
