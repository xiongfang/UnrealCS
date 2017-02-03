#if WITH_GAME
#if PLATFORM_32BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class UWindowTitleBarArea
	{
		static readonly int bDoubleClickTogglesFullscreen__Offset;
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
