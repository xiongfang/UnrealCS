#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class UEndUserSettings
	{
		static readonly int bSendAnonymousUsageDataToEpic__Offset;
		/// <summary>Determines whether the engine sends anonymous usage information about game sessions to Epic Games in order to improve Unreal Engine. Information will never be shared with 3rd parties.</summary>
		public bool bSendAnonymousUsageDataToEpic
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bSendAnonymousUsageDataToEpic__Offset, 1, 0, 1, 255);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bSendAnonymousUsageDataToEpic__Offset, 1,0,1,255);}
			
		}
		
		static readonly int bSendMeanTimeBetweenFailureDataToEpic__Offset;
		/// <summary>Determines whether the engine sends anonymous crash/abnormal-shutdown data about game sessions to Epic Games in order to improve Unreal Engine. Information will never be shared with 3rd parties.</summary>
		public bool bSendMeanTimeBetweenFailureDataToEpic
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bSendMeanTimeBetweenFailureDataToEpic__Offset, 1, 0, 1, 255);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bSendMeanTimeBetweenFailureDataToEpic__Offset, 1,0,1,255);}
			
		}
		
		static readonly int bAllowUserIdInUsageData__Offset;
		/// <summary>If enabled, adds user identifying data to the otherwise anonymous reports sent to Epic Games.</summary>
		public bool bAllowUserIdInUsageData
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bAllowUserIdInUsageData__Offset, 1, 0, 1, 255);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bAllowUserIdInUsageData__Offset, 1,0,1,255);}
			
		}
		
		static UEndUserSettings()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("EndUserSettings");
			bSendAnonymousUsageDataToEpic__Offset=GetPropertyOffset(NativeClassPtr,"bSendAnonymousUsageDataToEpic");
			bSendMeanTimeBetweenFailureDataToEpic__Offset=GetPropertyOffset(NativeClassPtr,"bSendMeanTimeBetweenFailureDataToEpic");
			bAllowUserIdInUsageData__Offset=GetPropertyOffset(NativeClassPtr,"bAllowUserIdInUsageData");
			
		}
		
	}
	
}
#endif
#endif
