#if WITH_GAME
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class UPlatformEventsComponent
	{
		static readonly int PlatformChangedToLaptopModeDelegate__Offset;
		public FMulticastScriptDelegate PlatformChangedToLaptopModeDelegate
		{
			get{ CheckIsValid(); return ((FMulticastScriptDelegate)Marshal.PtrToStructure(_this.Get()+PlatformChangedToLaptopModeDelegate__Offset, typeof(FMulticastScriptDelegate)));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+PlatformChangedToLaptopModeDelegate__Offset, false);}
			
		}
		
		static readonly int PlatformChangedToTabletModeDelegate__Offset;
		public FMulticastScriptDelegate PlatformChangedToTabletModeDelegate
		{
			get{ CheckIsValid(); return ((FMulticastScriptDelegate)Marshal.PtrToStructure(_this.Get()+PlatformChangedToTabletModeDelegate__Offset, typeof(FMulticastScriptDelegate)));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+PlatformChangedToTabletModeDelegate__Offset, false);}
			
		}
		
		static UPlatformEventsComponent()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("PlatformEventsComponent");
			PlatformChangedToLaptopModeDelegate__Offset=GetPropertyOffset(NativeClassPtr,"PlatformChangedToLaptopModeDelegate");
			PlatformChangedToTabletModeDelegate__Offset=GetPropertyOffset(NativeClassPtr,"PlatformChangedToTabletModeDelegate");
			
		}
		
	}
	
}
#endif
#endif
