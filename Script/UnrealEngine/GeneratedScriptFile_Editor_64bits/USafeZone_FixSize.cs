#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class USafeZone
	{
		static readonly int PadLeft__Offset;
		/// <summary>If this safe zone should pad for the left side of the screen's safe zone</summary>
		public bool PadLeft
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), PadLeft__Offset, 1, 0, 1, 255);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), PadLeft__Offset, 1,0,1,255);}
			
		}
		
		static readonly int PadRight__Offset;
		/// <summary>If this safe zone should pad for the right side of the screen's safe zone</summary>
		public bool PadRight
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), PadRight__Offset, 1, 0, 1, 255);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), PadRight__Offset, 1,0,1,255);}
			
		}
		
		static readonly int PadTop__Offset;
		/// <summary>If this safe zone should pad for the top side of the screen's safe zone</summary>
		public bool PadTop
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), PadTop__Offset, 1, 0, 1, 255);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), PadTop__Offset, 1,0,1,255);}
			
		}
		
		static readonly int PadBottom__Offset;
		/// <summary>If this safe zone should pad for the bottom side of the screen's safe zone</summary>
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
