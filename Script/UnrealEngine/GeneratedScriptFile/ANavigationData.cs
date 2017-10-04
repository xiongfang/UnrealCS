using System;
namespace UnrealEngine
{
	public partial class ANavigationData:AActor
	{
		public UPrimitiveComponent RenderingComp;
		
		public FNavDataConfig NavDataConfig;
		
		/// <summary>if set to true then this navigation data will be drawing itself when requested as part of "show navigation"</summary>
		public bool bEnableDrawing;
		
		/// <summary>
		/// By default navigation will skip the first update after being successfully loaded
		/// setting bForceRebuildOnLoad to false can override this behavior
		/// </summary>
		public bool bForceRebuildOnLoad;
		
		/// <summary>If set, navigation data can act as default one in navigation system's queries</summary>
		public bool bCanBeMainNavData;
		
		/// <summary>If set, navigation data will be spawned in persistent level during rebuild if actor doesn't exist</summary>
		public bool bCanSpawnOnRebuild;
		
		/// <summary>If true, the NavMesh can be dynamically rebuilt at runtime.</summary>
		public bool bRebuildAtRuntime;
		
		/// <summary>all observed paths will be processed every ObservedPathsTickInterval seconds</summary>
		public float ObservedPathsTickInterval;
		
		/// <summary>Navigation data versioning.</summary>
		public uint DataVersion;
		
		
	}
	
}
