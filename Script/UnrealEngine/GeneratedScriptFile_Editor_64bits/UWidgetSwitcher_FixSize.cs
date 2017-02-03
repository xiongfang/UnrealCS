#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>A widget switcher is like a tab control, but without tabs. At most one widget is visible at time.</summary>
	public partial class UWidgetSwitcher
	{
		static readonly int ActiveWidgetIndex__Offset;
		/// <summary>The slot index to display</summary>
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
