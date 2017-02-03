#if WITH_GAME
#if PLATFORM_32BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class USoundAttenuation
	{
		static readonly int Attenuation__Offset;
		public FAttenuationSettings Attenuation
		{
			get{ CheckIsValid();return (FAttenuationSettings)Marshal.PtrToStructure(_this.Get()+Attenuation__Offset, typeof(FAttenuationSettings));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+Attenuation__Offset, false);}
			
		}
		
		static USoundAttenuation()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("SoundAttenuation");
			Attenuation__Offset=GetPropertyOffset(NativeClassPtr,"Attenuation");
			
		}
		
	}
	
}
#endif
#endif
