#if WITH_GAME
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class UForceFeedbackAttenuation
	{
		static readonly int Attenuation__Offset;
		public FForceFeedbackAttenuationSettings Attenuation
		{
			get{ CheckIsValid();return (FForceFeedbackAttenuationSettings)Marshal.PtrToStructure(_this.Get()+Attenuation__Offset, typeof(FForceFeedbackAttenuationSettings));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+Attenuation__Offset, false);}
			
		}
		
		static UForceFeedbackAttenuation()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("ForceFeedbackAttenuation");
			Attenuation__Offset=GetPropertyOffset(NativeClassPtr,"Attenuation");
			
		}
		
	}
	
}
#endif
#endif
