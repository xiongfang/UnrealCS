using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine{
public partial class UBlueprintPlatformLibrary:UBlueprintFunctionLibrary 
{
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void GetLaunchNotification(IntPtr _this,out int NotificationLaunchedApp,out string ActivationEvent,out int FireDate);
/// <summary>
/// Get the local notification that was used to launch the app
/// @param NotificationLaunchedApp Return true if a notification was used to launch the app
/// @param ActivationEvent Returns the name of the ActivationEvent if a notification was used to launch the app
/// @param FireDate Returns the time the notification was activated
/// </summary>
public static void GetLaunchNotification(out bool NotificationLaunchedApp,out string ActivationEvent,out int FireDate)
{
	int NotificationLaunchedApp_temp;
	GetLaunchNotification(IntPtr.Zero,out NotificationLaunchedApp_temp,out ActivationEvent,out FireDate);
	NotificationLaunchedApp=NotificationLaunchedApp_temp!=0;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void ScheduleLocalNotificationFromNow(IntPtr _this,int inSecondsFromNow,string Title,string Body,string Action,string ActivationEvent);
/// <summary>
/// Schedule a local notification to fire inSecondsFromNow from now
/// @param inSecondsFromNow The seconds until the notification should fire
/// @param LocalTime If true the provided time is in the local timezone, if false it is in UTC
/// @param Title The title of the notification
/// @param Body The more detailed description of the notification
/// @param Action The text to be displayed on the slider controller
/// @param ActivationEvent A string that is passed in the delegate callback when the app is brought into the foreground from the user activating the notification
/// </summary>
public static void ScheduleLocalNotificationFromNow(int inSecondsFromNow,string Title,string Body,string Action,string ActivationEvent)
{
	ScheduleLocalNotificationFromNow(IntPtr.Zero,inSecondsFromNow,Title,Body,Action,ActivationEvent);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void ScheduleLocalNotificationAtTime(IntPtr _this,ref FDateTime FireDateTime,int LocalTime,string Title,string Body,string Action,string ActivationEvent);
/// <summary>
/// Schedule a local notification at a specific time, inLocalTime specifies the current local time or if UTC time should be used
/// @param FireDateTime The time at which to fire the local notification
/// @param LocalTime If true the provided time is in the local timezone, if false it is in UTC
/// @param Title The title of the notification
/// @param Body The more detailed description of the notification
/// @param Action The text to be displayed on the slider controller
/// @param ActivationEvent A string that is passed in the delegate callback when the app is brought into the foreground from the user activating the notification
/// </summary>
public static void ScheduleLocalNotificationAtTime(FDateTime FireDateTime,bool LocalTime,string Title,string Body,string Action,string ActivationEvent)
{
	ScheduleLocalNotificationAtTime(IntPtr.Zero,ref FireDateTime,LocalTime?1:0,Title,Body,Action,ActivationEvent);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void ClearAllLocalNotifications(IntPtr _this);
/// <summary>Clear all pending local notifications. Typically this will be done before scheduling new notifications when going into the background</summary>
public static void ClearAllLocalNotifications()
{
	ClearAllLocalNotifications(IntPtr.Zero);
	
}
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	public extern static new IntPtr StaticClass();
}
}
