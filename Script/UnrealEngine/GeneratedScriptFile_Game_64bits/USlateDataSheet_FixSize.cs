#if WITH_GAME
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class USlateDataSheet
	{
		static readonly int DataTexture__Offset;
		public UTexture2D DataTexture
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + DataTexture__Offset); if (v == IntPtr.Zero)return null; UTexture2D retValue = new UTexture2D(); retValue._this = v; return retValue; }
			
		}
		
		static USlateDataSheet()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("SlateDataSheet");
			DataTexture__Offset=GetPropertyOffset(NativeClassPtr,"DataTexture");
			
		}
		
	}
	
}
#endif
#endif
