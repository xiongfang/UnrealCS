#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>A panel for defining a region of the UI that should allow users to drag the window on desktop platforms.</summary>
	public partial class UWindowTitleBarArea
	{
		static readonly int bDoubleClickTogglesFullscreen__Offset;
		/// <summary>Should double clicking the title bar area toggle fullscreen instead of maximizing the window.</summary>
		public bool bDoubleClickTogglesFullscreen
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bDoubleClickTogglesFullscreen__Offset, 1, 0, 1, 255);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bDoubleClickTogglesFullscreen__Offset, 1,0,1,255);}
			
		}
		
		static UWindowTitleBarArea()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("WindowTitleBarArea");
			bDoubleClickTogglesFullscreen__Offset=GetPropertyOffset(NativeClassPtr,"bDoubleClickTogglesFullscreen");
			
		}
		
	}
	
}
#endif
#endif
