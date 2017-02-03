#if WITH_GAME
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class UTexture2DDynamic
	{
		static readonly int Format__Offset;
		public EPixelFormat Format
		{
			get{ CheckIsValid();return (EPixelFormat)Marshal.PtrToStructure(_this.Get()+Format__Offset, typeof(EPixelFormat));}
			
		}
		
		static UTexture2DDynamic()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("Texture2DDynamic");
			Format__Offset=GetPropertyOffset(NativeClassPtr,"Format");
			
		}
		
	}
	
}
#endif
#endif
