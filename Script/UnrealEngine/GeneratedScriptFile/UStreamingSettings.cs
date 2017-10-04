using System;
namespace UnrealEngine
{
	public partial class UStreamingSettings:UDeveloperSettings
	{
		/// <summary>Enables separate thread for package streaming. Requires restart to take effect.</summary>
		public bool AsyncLoadingThreadEnabled;
		
		/// <summary>Enables log warning if time limit for time-sliced package streaming has been exceeded.</summary>
		public bool WarnIfTimeLimitExceeded;
		
		/// <summary>Multiplier for time limit exceeded warning time threshold.</summary>
		public float TimeLimitExceededMultiplier;
		
		/// <summary>Minimum time the time limit exceeded warning will be triggered by.</summary>
		public float TimeLimitExceededMinTime;
		
		/// <summary>Minimum time the time limit exceeded warning will be triggered by.</summary>
		public int MinBulkDataSizeForAsyncLoading;
		
		/// <summary>Constrain bandwidth if wanted. Value is in MByte/ sec.</summary>
		public float AsyncIOBandwidthLimit;
		
		/// <summary>Whether to allow background level streaming.</summary>
		public bool UseBackgroundLevelStreaming;
		
		/// <summary>Whether to use the entire time limit even if blocked on I/O.</summary>
		public bool AsyncLoadingUseFullTimeLimit;
		
		/// <summary>Maximum amount of time to spend doing asynchronous loading (ms per frame).</summary>
		public float AsyncLoadingTimeLimit;
		
		/// <summary>Additional time to spend asynchronous loading during a high priority load.</summary>
		public float PriorityAsyncLoadingExtraTime;
		
		/// <summary>Maximum allowed time to spend for actor registration steps during level streaming (ms per frame).</summary>
		public float LevelStreamingActorsUpdateTimeLimit;
		
		/// <summary>Batching granularity used to register actor components during level streaming.</summary>
		public int LevelStreamingComponentsRegistrationGranularity;
		
		/// <summary>Maximum allowed time to spend while unregistering components during level streaming (ms per frame).</summary>
		public float LevelStreamingUnregisterComponentsTimeLimit;
		
		/// <summary>Batching granularity used to unregister actor components during level streaming.</summary>
		public int LevelStreamingComponentsUnregistrationGranularity;
		
		/// <summary>Enables the event driven loader in cooked builds.</summary>
		public bool EventDrivenLoaderEnabled;
		
		
	}
	
}
