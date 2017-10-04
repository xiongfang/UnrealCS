using System;
namespace UnrealEngine
{
	public partial class UBlueprintPlatformLibrary:UBlueprintFunctionLibrary
	{
		/// <summary>
		/// Get the local notification that was used to launch the app
		/// @param NotificationLaunchedApp Return true if a notification was used to launch the app
		/// @param ActivationEvent Returns the name of the ActivationEvent if a notification was used to launch the app
		/// @param FireDate Returns the time the notification was activated
		/// </summary>
		public extern static void GetLaunchNotification(out bool NotificationLaunchedApp,out FString ActivationEvent,out int FireDate);
		/// <summary>
		/// Cancel a local notification given the ActivationEvent
		/// @param ActivationEvent The string passed into the Schedule call for the notification to be cancelled
		/// </summary>
		public extern static void CancelLocalNotification(FString ActivationEvent);
		/// <summary>
		/// Schedule a local notification to fire inSecondsFromNow from now
		/// @param inSecondsFromNow The seconds until the notification should fire
		/// @param LocalTime If true the provided time is in the local timezone, if false it is in UTC
		/// @param Title The title of the notification
		/// @param Body The more detailed description of the notification
		/// @param Action The text to be displayed on the slider controller
		/// @param ActivationEvent A string that is passed in the delegate callback when the app is brought into the foreground from the user activating the notification
		/// </summary>
		public extern static void ScheduleLocalNotificationFromNow(int inSecondsFromNow,FText Title,FText Body,FText Action,FString ActivationEvent);
		/// <summary>
		/// Schedule a local notification at a specific time, inLocalTime specifies the current local time or if UTC time should be used
		/// @param FireDateTime The time at which to fire the local notification
		/// @param LocalTime If true the provided time is in the local timezone, if false it is in UTC
		/// @param Title The title of the notification
		/// @param Body The more detailed description of the notification
		/// @param Action The text to be displayed on the slider controller
		/// @param ActivationEvent A string that is passed in the delegate callback when the app is brought into the foreground from the user activating the notification
		/// </summary>
		public extern static void ScheduleLocalNotificationAtTime(FDateTime FireDateTime,bool LocalTime,FText Title,FText Body,FText Action,FString ActivationEvent);
		/// <summary>Clear all pending local notifications. Typically this will be done before scheduling new notifications when going into the background</summary>
		public extern static void ClearAllLocalNotifications();
		
	}
	
}
