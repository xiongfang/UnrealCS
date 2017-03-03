#if WITH_GAME
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class UStreamingSettings
	{
		static readonly int AsyncLoadingThreadEnabled__Offset;
		public bool AsyncLoadingThreadEnabled
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), AsyncLoadingThreadEnabled__Offset, 1, 0, 1, 1);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), AsyncLoadingThreadEnabled__Offset, 1,0,1,1);}
			
		}
		
		static readonly int WarnIfTimeLimitExceeded__Offset;
		public bool WarnIfTimeLimitExceeded
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), WarnIfTimeLimitExceeded__Offset, 1, 0, 2, 2);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), WarnIfTimeLimitExceeded__Offset, 1,0,2,2);}
			
		}
		
		static readonly int TimeLimitExceededMultiplier__Offset;
		public float TimeLimitExceededMultiplier
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+TimeLimitExceededMultiplier__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+TimeLimitExceededMultiplier__Offset, false);}
			
		}
		
		static readonly int TimeLimitExceededMinTime__Offset;
		public float TimeLimitExceededMinTime
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+TimeLimitExceededMinTime__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+TimeLimitExceededMinTime__Offset, false);}
			
		}
		
		static readonly int MinBulkDataSizeForAsyncLoading__Offset;
		public int MinBulkDataSizeForAsyncLoading
		{
			get{ CheckIsValid();return (int)Marshal.PtrToStructure(_this.Get()+MinBulkDataSizeForAsyncLoading__Offset, typeof(int));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+MinBulkDataSizeForAsyncLoading__Offset, false);}
			
		}
		
		static readonly int AsyncIOBandwidthLimit__Offset;
		public float AsyncIOBandwidthLimit
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+AsyncIOBandwidthLimit__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+AsyncIOBandwidthLimit__Offset, false);}
			
		}
		
		static readonly int UseBackgroundLevelStreaming__Offset;
		public bool UseBackgroundLevelStreaming
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), UseBackgroundLevelStreaming__Offset, 1, 0, 1, 1);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), UseBackgroundLevelStreaming__Offset, 1,0,1,1);}
			
		}
		
		static readonly int AsyncLoadingUseFullTimeLimit__Offset;
		public bool AsyncLoadingUseFullTimeLimit
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), AsyncLoadingUseFullTimeLimit__Offset, 1, 0, 2, 2);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), AsyncLoadingUseFullTimeLimit__Offset, 1,0,2,2);}
			
		}
		
		static readonly int AsyncLoadingTimeLimit__Offset;
		public float AsyncLoadingTimeLimit
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+AsyncLoadingTimeLimit__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+AsyncLoadingTimeLimit__Offset, false);}
			
		}
		
		static readonly int PriorityAsyncLoadingExtraTime__Offset;
		public float PriorityAsyncLoadingExtraTime
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+PriorityAsyncLoadingExtraTime__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+PriorityAsyncLoadingExtraTime__Offset, false);}
			
		}
		
		static readonly int LevelStreamingActorsUpdateTimeLimit__Offset;
		public float LevelStreamingActorsUpdateTimeLimit
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+LevelStreamingActorsUpdateTimeLimit__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+LevelStreamingActorsUpdateTimeLimit__Offset, false);}
			
		}
		
		static readonly int LevelStreamingComponentsRegistrationGranularity__Offset;
		public int LevelStreamingComponentsRegistrationGranularity
		{
			get{ CheckIsValid();return (int)Marshal.PtrToStructure(_this.Get()+LevelStreamingComponentsRegistrationGranularity__Offset, typeof(int));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+LevelStreamingComponentsRegistrationGranularity__Offset, false);}
			
		}
		
		static readonly int LevelStreamingUnregisterComponentsTimeLimit__Offset;
		public float LevelStreamingUnregisterComponentsTimeLimit
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+LevelStreamingUnregisterComponentsTimeLimit__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+LevelStreamingUnregisterComponentsTimeLimit__Offset, false);}
			
		}
		
		static readonly int LevelStreamingComponentsUnregistrationGranularity__Offset;
		public int LevelStreamingComponentsUnregistrationGranularity
		{
			get{ CheckIsValid();return (int)Marshal.PtrToStructure(_this.Get()+LevelStreamingComponentsUnregistrationGranularity__Offset, typeof(int));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+LevelStreamingComponentsUnregistrationGranularity__Offset, false);}
			
		}
		
		static readonly int EventDrivenLoaderEnabled__Offset;
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
