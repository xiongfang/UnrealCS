#if WITH_GAME
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class USphereComponent
	{
		static readonly int SphereRadius__Offset;
		public float SphereRadius
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+SphereRadius__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+SphereRadius__Offset, false);}
			
		}
		
		static USphereComponent()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("SphereComponent");
			SphereRadius__Offset=GetPropertyOffset(NativeClassPtr,"SphereRadius");
			
		}
		
	}
	
}
#endif
#endif
