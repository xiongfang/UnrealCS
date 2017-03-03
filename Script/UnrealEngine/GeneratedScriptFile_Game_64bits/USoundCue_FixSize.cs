#if WITH_GAME
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class USoundCue
	{
		static readonly int bOverrideAttenuation__Offset;
		public bool bOverrideAttenuation
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bOverrideAttenuation__Offset, 1, 0, 1, 1);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bOverrideAttenuation__Offset, 1,0,1,1);}
			
		}
		
		static readonly int FirstNode__Offset;
		public USoundNode FirstNode
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + FirstNode__Offset); if (v == IntPtr.Zero)return null; USoundNode retValue = new USoundNode(); retValue._this = v; return retValue; }
			
		}
		
		static readonly int VolumeMultiplier__Offset;
		public float VolumeMultiplier
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+VolumeMultiplier__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+VolumeMultiplier__Offset, false);}
			
		}
		
		static readonly int PitchMultiplier__Offset;
		public float PitchMultiplier
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+PitchMultiplier__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+PitchMultiplier__Offset, false);}
			
		}
		
		static readonly int AttenuationOverrides__Offset;
		public FSoundAttenuationSettings AttenuationOverrides
		{
			get{ CheckIsValid();return (FSoundAttenuationSettings)Marshal.PtrToStructure(_this.Get()+AttenuationOverrides__Offset, typeof(FSoundAttenuationSettings));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+AttenuationOverrides__Offset, false);}
			
		}
		
		static USoundCue()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("SoundCue");
			bOverrideAttenuation__Offset=GetPropertyOffset(NativeClassPtr,"bOverrideAttenuation");
			FirstNode__Offset=GetPropertyOffset(NativeClassPtr,"FirstNode");
			VolumeMultiplier__Offset=GetPropertyOffset(NativeClassPtr,"VolumeMultiplier");
			PitchMultiplier__Offset=GetPropertyOffset(NativeClassPtr,"PitchMultiplier");
			AttenuationOverrides__Offset=GetPropertyOffset(NativeClassPtr,"AttenuationOverrides");
			
		}
		
	}
	
}
#endif
#endif
