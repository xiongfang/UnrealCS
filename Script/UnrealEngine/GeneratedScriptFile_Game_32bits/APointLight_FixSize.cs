#if WITH_GAME
#if PLATFORM_32BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class APointLight
	{
		static readonly int PointLightComponent__Offset;
		public UPointLightComponent PointLightComponent
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + PointLightComponent__Offset); if (v == IntPtr.Zero)return null; UPointLightComponent retValue = new UPointLightComponent(); retValue._this = v; return retValue; }
			
		}
		
		static APointLight()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("PointLight");
			PointLightComponent__Offset=GetPropertyOffset(NativeClassPtr,"PointLightComponent");
			
		}
		
	}
	
}
#endif
#endif
