#if WITH_GAME
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class UPanelSlot
	{
		static readonly int Parent__Offset;
		public UPanelWidget Parent
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + Parent__Offset); if (v == IntPtr.Zero)return null; UPanelWidget retValue = new UPanelWidget(); retValue._this = v; return retValue; }
			
		}
		
		static readonly int Content__Offset;
		public UWidget Content
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + Content__Offset); if (v == IntPtr.Zero)return null; UWidget retValue = new UWidget(); retValue._this = v; return retValue; }
			
		}
		
		static UPanelSlot()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("PanelSlot");
			Parent__Offset=GetPropertyOffset(NativeClassPtr,"Parent");
			Content__Offset=GetPropertyOffset(NativeClassPtr,"Content");
			
		}
		
	}
	
}
#endif
#endif
