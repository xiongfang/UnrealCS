#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>Rendering settings.</summary>
	public partial class UStreamingSettings
	{
		static readonly int AsyncLoadingThreadEnabled__Offset;
		/// <summary>Enables separate thread for package streaming. Requires restart to take effect.</summary>
		public bool AsyncLoadingThreadEnabled
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), AsyncLoadingThreadEnabled__Offset, 1, 0, 1, 1);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), AsyncLoadingThreadEnabled__Offset, 1,0,1,1);}
			
		}
		
		static readonly int WarnIfTimeLimitExceeded__Offset;
		/// <summary>Enables log warning if time limit for time-sliced package streaming has been exceeded.</summary>
		public bool WarnIfTimeLimitExceeded
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), WarnIfTimeLimitExceeded__Offset, 1, 0, 2, 2);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), WarnIfTimeLimitExceeded__Offset, 1,0,2,2);}
			
		}
		
		static readonly int TimeLimitExceededMultiplier__Offset;
		/// <summary>Multiplier for time limit exceeded warning time threshold.</summary>
		public float TimeLimitExceededMultiplier
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+TimeLimitExceededMultiplier__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+TimeLimitExceededMultiplier__Offset, false);}
			
		}
		
		static readonly int TimeLimitExceededMinTime__Offset;
		/// <summary>Minimum time the time limit exceeded warning will be triggered by.</summary>
		public float TimeLimitExceededMinTime
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+TimeLimitExceededMinTime__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+TimeLimitExceededMinTime__Offset, false);}
			
		}
		
		static readonly int MinBulkDataSizeForAsyncLoading__Offset;
		/// <summary>Minimum time the time limit exceeded warning will be triggered by.</summary>
		public int MinBulkDataSizeForAsyncLoading
		{
			get{ CheckIsValid();return (int)Marshal.PtrToStructure(_this.Get()+MinBulkDataSizeForAsyncLoading__Offset, typeof(int));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+MinBulkDataSizeForAsyncLoading__Offset, false);}
			
		}
		
		static readonly int AsyncIOBandwidthLimit__Offset;
		/// <summary>Constrain bandwidth if wanted. Value is in MByte/ sec.</summary>
		public float AsyncIOBandwidthLimit
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+AsyncIOBandwidthLimit__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+AsyncIOBandwidthLimit__Offset, false);}
			
		}
		
		static readonly int UseBackgroundLevelStreaming__Offset;
		/// <summary>Whether to allow background level streaming.</summary>
		public bool UseBackgroundLevelStreaming
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), UseBackgroundLevelStreaming__Offset, 1, 0, 1, 1);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), UseBackgroundLevelStreaming__Offset, 1,0,1,1);}
			
		}
		
		static readonly int AsyncLoadingUseFullTimeLimit__Offset;
		/// <summary>Whether to use the entire time limit even if blocked on I/O.</summary>
		public bool AsyncLoadingUseFullTimeLimit
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), AsyncLoadingUseFullTimeLimit__Offset, 1, 0, 2, 2);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), AsyncLoadingUseFullTimeLimit__Offset, 1,0,2,2);}
			
		}
		
		static readonly int AsyncLoadingTimeLimit__Offset;
		/// <summary>Maximum amount of time to spend doing asynchronous loading (ms per frame).</summary>
		public float AsyncLoadingTimeLimit
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+AsyncLoadingTimeLimit__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+AsyncLoadingTimeLimit__Offset, false);}
			
		}
		
		static readonly int PriorityAsyncLoadingExtraTime__Offset;
		/// <summary>Additional time to spend asynchronous loading during a high priority load.</summary>
		public float PriorityAsyncLoadingExtraTime
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+PriorityAsyncLoadingExtraTime__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+PriorityAsyncLoadingExtraTime__Offset, false);}
			
		}
		
		static readonly int LevelStreamingActorsUpdateTimeLimit__Offset;
		/// <summary>Maximum allowed time to spend for actor registration steps during level streaming (ms per frame).</summary>
		public float LevelStreamingActorsUpdateTimeLimit
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+LevelStreamingActorsUpdateTimeLimit__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+LevelStreamingActorsUpdateTimeLimit__Offset, false);}
			
		}
		
		static readonly int LevelStreamingComponentsRegistrationGranularity__Offset;
		/// <summary>Batching granularity used to register actor components during level streaming.</summary>
		public int LevelStreamingComponentsRegistrationGranularity
		{
			get{ CheckIsValid();return (int)Marshal.PtrToStructure(_this.Get()+LevelStreamingComponentsRegistrationGranularity__Offset, typeof(int));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+LevelStreamingComponentsRegistrationGranularity__Offset, false);}
			
		}
		
		static readonly int LevelStreamingUnregisterComponentsTimeLimit__Offset;
		/// <summary>Maximum allowed time to spend while unregistering components during level streaming (ms per frame).</summary>
		public float LevelStreamingUnregisterComponentsTimeLimit
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+LevelStreamingUnregisterComponentsTimeLimit__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+LevelStreamingUnregisterComponentsTimeLimit__Offset, false);}
			
		}
		
		static readonly int LevelStreamingComponentsUnregistrationGranularity__Offset;
		/// <summary>Batching granularity used to unregister actor components during level streaming.</summary>
		public int LevelStreamingComponentsUnregistrationGranularity
		{
			get{ CheckIsValid();return (int)Marshal.PtrToStructure(_this.Get()+LevelStreamingComponentsUnregistrationGranularity__Offset, typeof(int));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+LevelStreamingComponentsUnregistrationGranularity__Offset, false);}
			
		}
		
		static readonly int EventDrivenLoaderEnabled__Offset;
		/// <summary>Enables the event driven loader in cooked builds.</summary>
		public bool EventDrivenLoaderEnabled
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), EventDrivenLoaderEnabled__Offset, 1, 0, 1, 1);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), EventDrivenLoaderEnabled__Offset, 1,0,1,1);}
			
		}
		
		static UStreamingSettings()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("StreamingSettings");
			AsyncLoadingThreadEnabled__Offset=GetPropertyOffset(NativeClassPtr,"AsyncLoadingThreadEnabled");
			WarnIfTimeLimitExceeded__Offset=GetPropertyOffset(NativeClassPtr,"WarnIfTimeLimitExceeded");
			TimeLimitExceededMultiplier__Offset=GetPropertyOffset(NativeClassPtr,"TimeLimitExceededMultiplier");
			TimeLimitExceededMinTime__Offset=GetPropertyOffset(NativeClassPtr,"TimeLimitExceededMinTime");
			MinBulkDataSizeForAsyncLoading__Offset=GetPropertyOffset(NativeClassPtr,"MinBulkDataSizeForAsyncLoading");
			AsyncIOBandwidthLimit__Offset=GetPropertyOffset(NativeClassPtr,"AsyncIOBandwidthLimit");
			UseBackgroundLevelStreaming__Offset=GetPropertyOffset(NativeClassPtr,"UseBackgroundLevelStreaming");
			AsyncLoadingUseFullTimeLimit__Offset=GetPropertyOffset(NativeClassPtr,"AsyncLoadingUseFullTimeLimit");
			AsyncLoadingTimeLimit__Offset=GetPropertyOffset(NativeClassPtr,"AsyncLoadingTimeLimit");
			PriorityAsyncLoadingExtraTime__Offset=GetPropertyOffset(NativeClassPtr,"PriorityAsyncLoadingExtraTime");
			LevelStreamingActorsUpdateTimeLimit__Offset=GetPropertyOffset(NativeClassPtr,"LevelStreamingActorsUpdateTimeLimit");
			LevelStreamingComponentsRegistrationGranularity__Offset=GetPropertyOffset(NativeClassPtr,"LevelStreamingComponentsRegistrationGranularity");
			LevelStreamingUnregisterComponentsTimeLimit__Offset=GetPropertyOffset(NativeClassPtr,"LevelStreamingUnregisterComponentsTimeLimit");
			LevelStreamingComponentsUnregistrationGranularity__Offset=GetPropertyOffset(NativeClassPtr,"LevelStreamingComponentsUnregistrationGranularity");
			EventDrivenLoaderEnabled__Offset=GetPropertyOffset(NativeClassPtr,"EventDrivenLoaderEnabled");
			
		}
		
	}
	
}
#endif
#endif
