#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class UUMGSequencePlayer
	{
		static readonly int Animation__Offset;
		/// <summary>Animation being played</summary>
		public UWidgetAnimation Animation
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + Animation__Offset); if (v == IntPtr.Zero)return null; UWidgetAnimation retValue = new UWidgetAnimation(); retValue._this = v; return retValue; }
			
		}
		
		static UUMGSequencePlayer()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("UMGSequencePlayer");
			Animation__Offset=GetPropertyOffset(NativeClassPtr,"Animation");
			
		}
		
	}
	
}
#endif
#endif
