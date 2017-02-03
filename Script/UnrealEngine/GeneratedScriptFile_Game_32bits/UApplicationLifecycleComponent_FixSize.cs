#if WITH_GAME
#if PLATFORM_32BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class UApplicationLifecycleComponent
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
