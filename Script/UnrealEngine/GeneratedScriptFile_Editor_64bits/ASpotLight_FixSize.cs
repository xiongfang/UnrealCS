#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class ASpotLight
	{
		static readonly int SpotLightComponent__Offset;
		public USpotLightComponent SpotLightComponent
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + SpotLightComponent__Offset); if (v == IntPtr.Zero)return null; USpotLightComponent retValue = new USpotLightComponent(); retValue._this = v; return retValue; }
			
		}
		
		static readonly int ArrowComponent__Offset;
		public UArrowComponent ArrowComponent
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + ArrowComponent__Offset); if (v == IntPtr.Zero)return null; UArrowComponent retValue = new UArrowComponent(); retValue._this = v; return retValue; }
			
		}
		
		static ASpotLight()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("SpotLight");
			SpotLightComponent__Offset=GetPropertyOffset(NativeClassPtr,"SpotLightComponent");
			ArrowComponent__Offset=GetPropertyOffset(NativeClassPtr,"ArrowComponent");
			
		}
		
	}
	
}
#endif
#endif
