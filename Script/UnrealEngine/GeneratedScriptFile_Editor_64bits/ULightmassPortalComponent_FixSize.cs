#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class ULightmassPortalComponent
	{
		static readonly int PreviewBox__Offset;
		public UBoxComponent PreviewBox
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + PreviewBox__Offset); if (v == IntPtr.Zero)return null; UBoxComponent retValue = new UBoxComponent(); retValue._this = v; return retValue; }
			
		}
		
		static ULightmassPortalComponent()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("LightmassPortalComponent");
			PreviewBox__Offset=GetPropertyOffset(NativeClassPtr,"PreviewBox");
			
		}
		
	}
	
}
#endif
#endif
