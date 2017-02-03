#pragma once

namespace UnrealEngine
{
	class _UBlueprintPlatformLibrary
	{
		static void GetLaunchNotification(UBlueprintPlatformLibrary* _this,int32* NotificationLaunchedApp,MonoString** ActivationEvent,int32* FireDate)
		{
			bool NotificationLaunchedApp_temp;
			FString ActivationEvent_temp;
			_this->GetLaunchNotification(NotificationLaunchedApp_temp,ActivationEvent_temp,*FireDate);
			*NotificationLaunchedApp=NotificationLaunchedApp_temp!=0;
			*ActivationEvent=FStringToMonoString(ActivationEvent_temp);
			
		}
		static void CancelLocalNotification(UBlueprintPlatformLibrary* _this,MonoString* ActivationEvent)
		{
			FString ActivationEvent_temp=MonoStringToFString(ActivationEvent);
			_this->CancelLocalNotification(ActivationEvent_temp);
			
		}
		static void ScheduleLocalNotificationFromNow(UBlueprintPlatformLibrary* _this,int32 inSecondsFromNow,MonoString* Title,MonoString* Body,MonoString* Action,MonoString* ActivationEvent)
		{
			FText Title_temp=FText::FromString(MonoStringToFString(Title));
			FText Body_temp=FText::FromString(MonoStringToFString(Body));
			FText Action_temp=FText::FromString(MonoStringToFString(Action));
			FString ActivationEvent_temp=MonoStringToFString(ActivationEvent);
			_this->ScheduleLocalNotificationFromNow(inSecondsFromNow,Title_temp,Body_temp,Action_temp,ActivationEvent_temp);
			
		}
		static void ScheduleLocalNotificationAtTime(UBlueprintPlatformLibrary* _this,FDateTime* FireDateTime,int32 LocalTime,MonoString* Title,MonoString* Body,MonoString* Action,MonoString* ActivationEvent)
		{
			FText Title_temp=FText::FromString(MonoStringToFString(Title));
			FText Body_temp=FText::FromString(MonoStringToFString(Body));
			FText Action_temp=FText::FromString(MonoStringToFString(Action));
			FString ActivationEvent_temp=MonoStringToFString(ActivationEvent);
			_this->ScheduleLocalNotificationAtTime(*FireDateTime,LocalTime>0?true:false,Title_temp,Body_temp,Action_temp,ActivationEvent_temp);
			
		}
		static void ClearAllLocalNotifications(UBlueprintPlatformLibrary* _this)
		{
			_this->ClearAllLocalNotifications();
			
		}
		static UClass* StaticClass(){return UBlueprintPlatformLibrary::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UBlueprintPlatformLibrary::GetLaunchNotification",(const void*)GetLaunchNotification);
			mono_add_internal_call("UnrealEngine.UBlueprintPlatformLibrary::CancelLocalNotification",(const void*)CancelLocalNotification);
			mono_add_internal_call("UnrealEngine.UBlueprintPlatformLibrary::ScheduleLocalNotificationFromNow",(const void*)ScheduleLocalNotificationFromNow);
			mono_add_internal_call("UnrealEngine.UBlueprintPlatformLibrary::ScheduleLocalNotificationAtTime",(const void*)ScheduleLocalNotificationAtTime);
			mono_add_internal_call("UnrealEngine.UBlueprintPlatformLibrary::ClearAllLocalNotifications",(const void*)ClearAllLocalNotifications);
			mono_add_internal_call("UnrealEngine.UBlueprintPlatformLibrary::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
