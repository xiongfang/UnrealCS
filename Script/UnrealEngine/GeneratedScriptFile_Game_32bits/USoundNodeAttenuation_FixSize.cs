#if WITH_GAME
#if PLATFORM_32BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class USoundNodeAttenuation
	{
		static readonly int AttenuationSettings__Offset;
		public USoundAttenuation AttenuationSettings
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + AttenuationSettings__Offset); if (v == IntPtr.Zero)return null; USoundAttenuation retValue = new USoundAttenuation(); retValue._this = v; return retValue; }
			set{ CheckIsValid(); if (value == null)Marshal.WriteIntPtr(_this.Get() + AttenuationSettings__Offset, IntPtr.Zero);else Marshal.WriteIntPtr(_this.Get() + AttenuationSettings__Offset, value._this.Get()); }
			
		}
		
		static readonly int AttenuationOverrides__Offset;
		public FSoundAttenuationSettings AttenuationOverrides
		{
			get{ CheckIsValid();return (FSoundAttenuationSettings)Marshal.PtrToStructure(_this.Get()+AttenuationOverrides__Offset, typeof(FSoundAttenuationSettings));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+AttenuationOverrides__Offset, false);}
			
		}
		
		static readonly int bOverrideAttenuation__Offset;
		public bool bOverrideAttenuation
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bOverrideAttenuation__Offset, 1, 0, 1, 1);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bOverrideAttenuation__Offset, 1,0,1,1);}
			
		}
		
		static USoundNodeAttenuation()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("SoundNodeAttenuation");
			AttenuationSettings__Offset=GetPropertyOffset(NativeClassPtr,"AttenuationSettings");
			AttenuationOverrides__Offset=GetPropertyOffset(NativeClassPtr,"AttenuationOverrides");
			bOverrideAttenuation__Offset=GetPropertyOffset(NativeClassPtr,"bOverrideAttenuation");
			
		}
		
	}
	
}
#endif
#endif
