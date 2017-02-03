#if WITH_GAME
#if PLATFORM_32BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class UWidgetSwitcher
	{
		static readonly int ActiveWidgetIndex__Offset;
		public int ActiveWidgetIndex
		{
			get{ CheckIsValid();return (int)Marshal.PtrToStructure(_this.Get()+ActiveWidgetIndex__Offset, typeof(int));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+ActiveWidgetIndex__Offset, false);}
			
		}
		
		static UWidgetSwitcher()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("WidgetSwitcher");
			ActiveWidgetIndex__Offset=GetPropertyOffset(NativeClassPtr,"ActiveWidgetIndex");
			
		}
		
	}
	
}
#endif
#endif
