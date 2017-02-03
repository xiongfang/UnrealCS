#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>Implements the settings for garbage collection.</summary>
	public partial class UGarbageCollectionSettings
	{
		static readonly int TimeBetweenPurgingPendingKillObjects__Offset;
		/// <summary>Time in seconds (game time) we should wait between purging object references to objects that are pending kill.</summary>
		public float TimeBetweenPurgingPendingKillObjects
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+TimeBetweenPurgingPendingKillObjects__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+TimeBetweenPurgingPendingKillObjects__Offset, false);}
			
		}
		
		static readonly int FlushStreamingOnGC__Offset;
		/// <summary>If enabled, streaming will be flushed each time garbage collection is triggered.</summary>
		public bool FlushStreamingOnGC
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), FlushStreamingOnGC__Offset, 1, 0, 1, 1);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), FlushStreamingOnGC__Offset, 1,0,1,1);}
			
		}
		
		static readonly int AllowParallelGC__Offset;
		/// <summary>If enabled, garbage collection will use multiple threads.</summary>
		public bool AllowParallelGC
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), AllowParallelGC__Offset, 1, 0, 2, 2);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), AllowParallelGC__Offset, 1,0,2,2);}
			
		}
		
		static readonly int CreateGCClusters__Offset;
		/// <summary>If true, the engine will attempt to create clusters of objects for better garbage collection performance.</summary>
		public bool CreateGCClusters
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), CreateGCClusters__Offset, 1, 0, 4, 4);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), CreateGCClusters__Offset, 1,0,4,4);}
			
		}
		
		static readonly int MergeGCClusters__Offset;
		/// <summary>If true, when creating clusters, the clusters referenced from another cluster will get merged into one big cluster.</summary>
		public bool MergeGCClusters
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), MergeGCClusters__Offset, 1, 0, 8, 8);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), MergeGCClusters__Offset, 1,0,8,8);}
			
		}
		
		static readonly int NumRetriesBeforeForcingGC__Offset;
		/// <summary>Maximum number of times GC can be skipped if worker threads are currently modifying UObject state. 0 = never force GC</summary>
		public int NumRetriesBeforeForcingGC
		{
			get{ CheckIsValid();return (int)Marshal.PtrToStructure(_this.Get()+NumRetriesBeforeForcingGC__Offset, typeof(int));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+NumRetriesBeforeForcingGC__Offset, false);}
			
		}
		
		static readonly int MaxObjectsNotConsideredByGC__Offset;
		/// <summary>Maximum Object Count Not Considered By GC. Works only in cooked builds.</summary>
		public int MaxObjectsNotConsideredByGC
		{
			get{ CheckIsValid();return (int)Marshal.PtrToStructure(_this.Get()+MaxObjectsNotConsideredByGC__Offset, typeof(int));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+MaxObjectsNotConsideredByGC__Offset, false);}
			
		}
		
		static readonly int SizeOfPermanentObjectPool__Offset;
		/// <summary>Size Of Permanent Object Pool (bytes). Works only in cooked builds.</summary>
		public int SizeOfPermanentObjectPool
		{
			get{ CheckIsValid();return (int)Marshal.PtrToStructure(_this.Get()+SizeOfPermanentObjectPool__Offset, typeof(int));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+SizeOfPermanentObjectPool__Offset, false);}
			
		}
		
		static readonly int MaxObjectsInGame__Offset;
		/// <summary>Maximum number of UObjects that can exist in cooked game. Keep this as small as possible.</summary>
		public int MaxObjectsInGame
		{
			get{ CheckIsValid();return (int)Marshal.PtrToStructure(_this.Get()+MaxObjectsInGame__Offset, typeof(int));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+MaxObjectsInGame__Offset, false);}
			
		}
		
		static readonly int MaxObjectsInEditor__Offset;
		/// <summary>Maximum number of UObjects that can exist in the editor game. Make sure this can hold enough objects for the editor and commadlets within reasonable limit.</summary>
		public int MaxObjectsInEditor
		{
			get{ CheckIsValid();return (int)Marshal.PtrToStructure(_this.Get()+MaxObjectsInEditor__Offset, typeof(int));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+MaxObjectsInEditor__Offset, false);}
			
		}
		
		static UGarbageCollectionSettings()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("GarbageCollectionSettings");
			TimeBetweenPurgingPendingKillObjects__Offset=GetPropertyOffset(NativeClassPtr,"TimeBetweenPurgingPendingKillObjects");
			FlushStreamingOnGC__Offset=GetPropertyOffset(NativeClassPtr,"FlushStreamingOnGC");
			AllowParallelGC__Offset=GetPropertyOffset(NativeClassPtr,"AllowParallelGC");
			CreateGCClusters__Offset=GetPropertyOffset(NativeClassPtr,"CreateGCClusters");
			MergeGCClusters__Offset=GetPropertyOffset(NativeClassPtr,"MergeGCClusters");
			NumRetriesBeforeForcingGC__Offset=GetPropertyOffset(NativeClassPtr,"NumRetriesBeforeForcingGC");
			MaxObjectsNotConsideredByGC__Offset=GetPropertyOffset(NativeClassPtr,"MaxObjectsNotConsideredByGC");
			SizeOfPermanentObjectPool__Offset=GetPropertyOffset(NativeClassPtr,"SizeOfPermanentObjectPool");
			MaxObjectsInGame__Offset=GetPropertyOffset(NativeClassPtr,"MaxObjectsInGame");
			MaxObjectsInEditor__Offset=GetPropertyOffset(NativeClassPtr,"MaxObjectsInEditor");
			
		}
		
	}
	
}
#endif
#endif
