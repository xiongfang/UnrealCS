#if WITH_GAME
#if PLATFORM_32BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class UForceFeedbackComponent
	{
		static readonly int ForceFeedbackEffect__Offset;
		public UForceFeedbackEffect ForceFeedbackEffect
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + ForceFeedbackEffect__Offset); if (v == IntPtr.Zero)return null; UForceFeedbackEffect retValue = new UForceFeedbackEffect(); retValue._this = v; return retValue; }
			set{ CheckIsValid(); if (value == null)Marshal.WriteIntPtr(_this.Get() + ForceFeedbackEffect__Offset, IntPtr.Zero);else Marshal.WriteIntPtr(_this.Get() + ForceFeedbackEffect__Offset, value._this.Get()); }
			
		}
		
		static readonly int bAutoDestroy__Offset;
		public bool bAutoDestroy
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bAutoDestroy__Offset, 1, 0, 1, 1);}
			
		}
		
		static readonly int bStopWhenOwnerDestroyed__Offset;
		public bool bStopWhenOwnerDestroyed
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bStopWhenOwnerDestroyed__Offset, 1, 0, 2, 2);}
			
		}
		
		static readonly int bLooping__Offset;
		public bool bLooping
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bLooping__Offset, 1, 0, 4, 4);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bLooping__Offset, 1,0,4,4);}
			
		}
		
		static readonly int bOverrideAttenuation__Offset;
		public bool bOverrideAttenuation
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bOverrideAttenuation__Offset, 1, 0, 8, 8);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bOverrideAttenuation__Offset, 1,0,8,8);}
			
		}
		
		static readonly int IntensityMultiplier__Offset;
		public float IntensityMultiplier
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+IntensityMultiplier__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+IntensityMultiplier__Offset, false);}
			
		}
		
		static readonly int AttenuationSettings__Offset;
		public UForceFeedbackAttenuation AttenuationSettings
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + AttenuationSettings__Offset); if (v == IntPtr.Zero)return null; UForceFeedbackAttenuation retValue = new UForceFeedbackAttenuation(); retValue._this = v; return retValue; }
			set{ CheckIsValid(); if (value == null)Marshal.WriteIntPtr(_this.Get() + AttenuationSettings__Offset, IntPtr.Zero);else Marshal.WriteIntPtr(_this.Get() + AttenuationSettings__Offset, value._this.Get()); }
			
		}
		
		static readonly int AttenuationOverrides__Offset;
		public FForceFeedbackAttenuationSettings AttenuationOverrides
		{
			get{ CheckIsValid();return (FForceFeedbackAttenuationSettings)Marshal.PtrToStructure(_this.Get()+AttenuationOverrides__Offset, typeof(FForceFeedbackAttenuationSettings));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+AttenuationOverrides__Offset, false);}
			
		}
		
		static readonly int OnForceFeedbackFinished__Offset;
		public FMulticastScriptDelegate OnForceFeedbackFinished
		{
			get{ CheckIsValid(); return ((FMulticastScriptDelegate)Marshal.PtrToStructure(_this.Get()+OnForceFeedbackFinished__Offset, typeof(FMulticastScriptDelegate)));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+OnForceFeedbackFinished__Offset, false);}
			
		}
		
		static UForceFeedbackComponent()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("ForceFeedbackComponent");
			ForceFeedbackEffect__Offset=GetPropertyOffset(NativeClassPtr,"ForceFeedbackEffect");
			bAutoDestroy__Offset=GetPropertyOffset(NativeClassPtr,"bAutoDestroy");
			bStopWhenOwnerDestroyed__Offset=GetPropertyOffset(NativeClassPtr,"bStopWhenOwnerDestroyed");
			bLooping__Offset=GetPropertyOffset(NativeClassPtr,"bLooping");
			bOverrideAttenuation__Offset=GetPropertyOffset(NativeClassPtr,"bOverrideAttenuation");
			IntensityMultiplier__Offset=GetPropertyOffset(NativeClassPtr,"IntensityMultiplier");
			AttenuationSettings__Offset=GetPropertyOffset(NativeClassPtr,"AttenuationSettings");
			AttenuationOverrides__Offset=GetPropertyOffset(NativeClassPtr,"AttenuationOverrides");
			OnForceFeedbackFinished__Offset=GetPropertyOffset(NativeClassPtr,"OnForceFeedbackFinished");
			
		}
		
	}
	
}
#endif
#endif
