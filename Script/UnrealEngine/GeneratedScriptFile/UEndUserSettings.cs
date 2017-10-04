using System;
namespace UnrealEngine
{
	public partial class UEndUserSettings:UObject
	{
		/// <summary>Determines whether the engine sends anonymous usage information about game sessions to Epic Games in order to improve Unreal Engine. Information will never be shared with 3rd parties.</summary>
		public bool bSendAnonymousUsageDataToEpic;
		
		/// <summary>Determines whether the engine sends anonymous crash/abnormal-shutdown data about game sessions to Epic Games in order to improve Unreal Engine. Information will never be shared with 3rd parties.</summary>
		public bool bSendMeanTimeBetweenFailureDataToEpic;
		
		/// <summary>If enabled, adds user identifying data to the otherwise anonymous reports sent to Epic Games.</summary>
		public bool bAllowUserIdInUsageData;
		
		
	}
	
}
