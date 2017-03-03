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
		public FSoundAttenuationSettings Attenuation
		{
			get{ CheckIsValid();return (FSoundAttenuationSettings)Marshal.PtrToStructure(_this.Get()+Attenuation__Offset, typeof(FSoundAttenuationSettings));}
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
