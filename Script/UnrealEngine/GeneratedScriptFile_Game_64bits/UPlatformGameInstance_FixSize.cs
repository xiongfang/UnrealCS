#if WITH_GAME
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class UPlatformGameInstance
	{
		static readonly int ApplicationWillDeactivateDelegate__Offset;
		public FMulticastScriptDelegate ApplicationWillDeactivateDelegate
		{
			get{ CheckIsValid(); return ((FMulticastScriptDelegate)Marshal.PtrToStructure(_this.Get()+ApplicationWillDeactivateDelegate__Offset, typeof(FMulticastScriptDelegate)));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+ApplicationWillDeactivateDelegate__Offset, false);}
			
		}
		
		static readonly int ApplicationHasReactivatedDelegate__Offset;
		public FMulticastScriptDelegate ApplicationHasReactivatedDelegate
		{
			get{ CheckIsValid(); return ((FMulticastScriptDelegate)Marshal.PtrToStructure(_this.Get()+ApplicationHasReactivatedDelegate__Offset, typeof(FMulticastScriptDelegate)));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+ApplicationHasReactivatedDelegate__Offset, false);}
			
		}
		
		static readonly int ApplicationWillEnterBackgroundDelegate__Offset;
		public FMulticastScriptDelegate ApplicationWillEnterBackgroundDelegate
		{
			get{ CheckIsValid(); return ((FMulticastScriptDelegate)Marshal.PtrToStructure(_this.Get()+ApplicationWillEnterBackgroundDelegate__Offset, typeof(FMulticastScriptDelegate)));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+ApplicationWillEnterBackgroundDelegate__Offset, false);}
			
		}
		
		static readonly int ApplicationHasEnteredForegroundDelegate__Offset;
		public FMulticastScriptDelegate ApplicationHasEnteredForegroundDelegate
		{
			get{ CheckIsValid(); return ((FMulticastScriptDelegate)Marshal.PtrToStructure(_this.Get()+ApplicationHasEnteredForegroundDelegate__Offset, typeof(FMulticastScriptDelegate)));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+ApplicationHasEnteredForegroundDelegate__Offset, false);}
			
		}
		
		static readonly int ApplicationWillTerminateDelegate__Offset;
		public FMulticastScriptDelegate ApplicationWillTerminateDelegate
		{
			get{ CheckIsValid(); return ((FMulticastScriptDelegate)Marshal.PtrToStructure(_this.Get()+ApplicationWillTerminateDelegate__Offset, typeof(FMulticastScriptDelegate)));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+ApplicationWillTerminateDelegate__Offset, false);}
			
		}
		
		static readonly int ApplicationRegisteredForRemoteNotificationsDelegate__Offset;
		public FMulticastScriptDelegate ApplicationRegisteredForRemoteNotificationsDelegate
		{
			get{ CheckIsValid(); return ((FMulticastScriptDelegate)Marshal.PtrToStructure(_this.Get()+ApplicationRegisteredForRemoteNotificationsDelegate__Offset, typeof(FMulticastScriptDelegate)));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+ApplicationRegisteredForRemoteNotificationsDelegate__Offset, false);}
			
		}
		
		static readonly int ApplicationRegisteredForUserNotificationsDelegate__Offset;
		public FMulticastScriptDelegate ApplicationRegisteredForUserNotificationsDelegate
		{
			get{ CheckIsValid(); return ((FMulticastScriptDelegate)Marshal.PtrToStructure(_this.Get()+ApplicationRegisteredForUserNotificationsDelegate__Offset, typeof(FMulticastScriptDelegate)));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+ApplicationRegisteredForUserNotificationsDelegate__Offset, false);}
			
		}
		
		static readonly int ApplicationFailedToRegisterForRemoteNotificationsDelegate__Offset;
		public FMulticastScriptDelegate ApplicationFailedToRegisterForRemoteNotificationsDelegate
		{
			get{ CheckIsValid(); return ((FMulticastScriptDelegate)Marshal.PtrToStructure(_this.Get()+ApplicationFailedToRegisterForRemoteNotificationsDelegate__Offset, typeof(FMulticastScriptDelegate)));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+ApplicationFailedToRegisterForRemoteNotificationsDelegate__Offset, false);}
			
		}
		
		static readonly int ApplicationReceivedRemoteNotificationDelegate__Offset;
		public FMulticastScriptDelegate ApplicationReceivedRemoteNotificationDelegate
		{
			get{ CheckIsValid(); return ((FMulticastScriptDelegate)Marshal.PtrToStructure(_this.Get()+ApplicationReceivedRemoteNotificationDelegate__Offset, typeof(FMulticastScriptDelegate)));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+ApplicationReceivedRemoteNotificationDelegate__Offset, false);}
			
		}
		
		static readonly int ApplicationReceivedLocalNotificationDelegate__Offset;
		public FMulticastScriptDelegate ApplicationReceivedLocalNotificationDelegate
		{
			get{ CheckIsValid(); return ((FMulticastScriptDelegate)Marshal.PtrToStructure(_this.Get()+ApplicationReceivedLocalNotificationDelegate__Offset, typeof(FMulticastScriptDelegate)));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+ApplicationReceivedLocalNotificationDelegate__Offset, false);}
			
		}
		
		static readonly int ApplicationReceivedScreenOrientationChangedNotificationDelegate__Offset;
		public FMulticastScriptDelegate ApplicationReceivedScreenOrientationChangedNotificationDelegate
		{
			get{ CheckIsValid(); return ((FMulticastScriptDelegate)Marshal.PtrToStructure(_this.Get()+ApplicationReceivedScreenOrientationChangedNotificationDelegate__Offset, typeof(FMulticastScriptDelegate)));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+ApplicationReceivedScreenOrientationChangedNotificationDelegate__Offset, false);}
			
		}
		
		static UPlatformGameInstance()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("PlatformGameInstance");
			ApplicationWillDeactivateDelegate__Offset=GetPropertyOffset(NativeClassPtr,"ApplicationWillDeactivateDelegate");
			ApplicationHasReactivatedDelegate__Offset=GetPropertyOffset(NativeClassPtr,"ApplicationHasReactivatedDelegate");
			ApplicationWillEnterBackgroundDelegate__Offset=GetPropertyOffset(NativeClassPtr,"ApplicationWillEnterBackgroundDelegate");
			ApplicationHasEnteredForegroundDelegate__Offset=GetPropertyOffset(NativeClassPtr,"ApplicationHasEnteredForegroundDelegate");
			ApplicationWillTerminateDelegate__Offset=GetPropertyOffset(NativeClassPtr,"ApplicationWillTerminateDelegate");
			ApplicationRegisteredForRemoteNotificationsDelegate__Offset=GetPropertyOffset(NativeClassPtr,"ApplicationRegisteredForRemoteNotificationsDelegate");
			ApplicationRegisteredForUserNotificationsDelegate__Offset=GetPropertyOffset(NativeClassPtr,"ApplicationRegisteredForUserNotificationsDelegate");
			ApplicationFailedToRegisterForRemoteNotificationsDelegate__Offset=GetPropertyOffset(NativeClassPtr,"ApplicationFailedToRegisterForRemoteNotificationsDelegate");
			ApplicationReceivedRemoteNotificationDelegate__Offset=GetPropertyOffset(NativeClassPtr,"ApplicationReceivedRemoteNotificationDelegate");
			ApplicationReceivedLocalNotificationDelegate__Offset=GetPropertyOffset(NativeClassPtr,"ApplicationReceivedLocalNotificationDelegate");
			ApplicationReceivedScreenOrientationChangedNotificationDelegate__Offset=GetPropertyOffset(NativeClassPtr,"ApplicationReceivedScreenOrientationChangedNotificationDelegate");
			
		}
		
	}
	
}
#endif
#endif
