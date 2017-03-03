#if WITH_GAME
#if PLATFORM_32BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class USafeZone
	{
		static readonly int PadLeft__Offset;
		public bool PadLeft
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), PadLeft__Offset, 1, 0, 1, 255);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), PadLeft__Offset, 1,0,1,255);}
			
		}
		
		static readonly int PadRight__Offset;
		public bool PadRight
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), PadRight__Offset, 1, 0, 1, 255);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), PadRight__Offset, 1,0,1,255);}
			
		}
		
		static readonly int PadTop__Offset;
		public bool PadTop
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), PadTop__Offset, 1, 0, 1, 255);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), PadTop__Offset, 1,0,1,255);}
			
		}
		
		static readonly int PadBottom__Offset;
		public bool PadBottom
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), PadBottom__Offset, 1, 0, 1, 255);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), PadBottom__Offset, 1,0,1,255);}
			
		}
		
		static USafeZone()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("SafeZone");
			PadLeft__Offset=GetPropertyOffset(NativeClassPtr,"PadLeft");
			PadRight__Offset=GetPropertyOffset(NativeClassPtr,"PadRight");
			PadTop__Offset=GetPropertyOffset(NativeClassPtr,"PadTop");
			PadBottom__Offset=GetPropertyOffset(NativeClassPtr,"PadBottom");
			
		}
		
	}
	
}
#endif
#endif
