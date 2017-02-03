#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>Component to handle receiving notifications from the OS about application state (activated, suspended, termination, etc).</summary>
	public partial class UApplicationLifecycleComponent
	{
		static readonly int ApplicationWillDeactivateDelegate__Offset;
		/// <summary>
		/// This is called when the application is about to be deactivated (e.g., due to a phone call or SMS or the sleep button).
		/// The game should be paused if possible, etc...
		/// </summary>
		public FMulticastScriptDelegate ApplicationWillDeactivateDelegate
		{
			get{ CheckIsValid(); return ((FMulticastScriptDelegate)Marshal.PtrToStructure(_this.Get()+ApplicationWillDeactivateDelegate__Offset, typeof(FMulticastScriptDelegate)));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+ApplicationWillDeactivateDelegate__Offset, false);}
			
		}
		
		static readonly int ApplicationHasReactivatedDelegate__Offset;
		/// <summary>Called when the application has been reactivated (reverse any processing done in the Deactivate delegate)</summary>
		public FMulticastScriptDelegate ApplicationHasReactivatedDelegate
		{
			get{ CheckIsValid(); return ((FMulticastScriptDelegate)Marshal.PtrToStructure(_this.Get()+ApplicationHasReactivatedDelegate__Offset, typeof(FMulticastScriptDelegate)));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+ApplicationHasReactivatedDelegate__Offset, false);}
			
		}
		
		static readonly int ApplicationWillEnterBackgroundDelegate__Offset;
		/// <summary>
		/// This is called when the application is being backgrounded (e.g., due to switching
		/// to another app or closing it via the home button)
		/// The game should release shared resources, save state, etc..., since it can be
		/// terminated from the background state without any further warning.
		/// </summary>
		public FMulticastScriptDelegate ApplicationWillEnterBackgroundDelegate
		{
			get{ CheckIsValid(); return ((FMulticastScriptDelegate)Marshal.PtrToStructure(_this.Get()+ApplicationWillEnterBackgroundDelegate__Offset, typeof(FMulticastScriptDelegate)));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+ApplicationWillEnterBackgroundDelegate__Offset, false);}
			
		}
		
		static readonly int ApplicationHasEnteredForegroundDelegate__Offset;
		/// <summary>Called when the application is returning to the foreground (reverse any processing done in the EnterBackground delegate)</summary>
		public FMulticastScriptDelegate ApplicationHasEnteredForegroundDelegate
		{
			get{ CheckIsValid(); return ((FMulticastScriptDelegate)Marshal.PtrToStructure(_this.Get()+ApplicationHasEnteredForegroundDelegate__Offset, typeof(FMulticastScriptDelegate)));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+ApplicationHasEnteredForegroundDelegate__Offset, false);}
			
		}
		
		static readonly int ApplicationWillTerminateDelegate__Offset;
		/// <summary>
		/// This *may* be called when the application is getting terminated by the OS.
		/// There is no guarantee that this will ever be called on a mobile device,
		/// save state when ApplicationWillEnterBackgroundDelegate is called instead.
		/// </summary>
		public FMulticastScriptDelegate ApplicationWillTerminateDelegate
		{
			get{ CheckIsValid(); return ((FMulticastScriptDelegate)Marshal.PtrToStructure(_this.Get()+ApplicationWillTerminateDelegate__Offset, typeof(FMulticastScriptDelegate)));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+ApplicationWillTerminateDelegate__Offset, false);}
			
		}
		
		static UApplicationLifecycleComponent()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("ApplicationLifecycleComponent");
			ApplicationWillDeactivateDelegate__Offset=GetPropertyOffset(NativeClassPtr,"ApplicationWillDeactivateDelegate");
			ApplicationHasReactivatedDelegate__Offset=GetPropertyOffset(NativeClassPtr,"ApplicationHasReactivatedDelegate");
			ApplicationWillEnterBackgroundDelegate__Offset=GetPropertyOffset(NativeClassPtr,"ApplicationWillEnterBackgroundDelegate");
			ApplicationHasEnteredForegroundDelegate__Offset=GetPropertyOffset(NativeClassPtr,"ApplicationHasEnteredForegroundDelegate");
			ApplicationWillTerminateDelegate__Offset=GetPropertyOffset(NativeClassPtr,"ApplicationWillTerminateDelegate");
			
		}
		
	}
	
}
#endif
#endif
