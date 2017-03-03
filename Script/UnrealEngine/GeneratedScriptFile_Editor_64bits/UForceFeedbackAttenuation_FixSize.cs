#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>
	/// Wrapper class that can be created as an asset for force feedback attenuation properties which allows reuse
	/// of the properties for multiple attenuation components
	/// </summary>
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
