#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class UReverbEffect
	{
		static readonly int Density__Offset;
		/// <summary>Density - 0.0 < 1.0 < 1.0 - Coloration of the late reverb - lower value is more grainy</summary>
		public float Density
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+Density__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+Density__Offset, false);}
			
		}
		
		static readonly int Diffusion__Offset;
		/// <summary>Diffusion - 0.0 < 1.0 < 1.0 - Echo density in the reverberation decay - lower is more grainy</summary>
		public float Diffusion
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+Diffusion__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+Diffusion__Offset, false);}
			
		}
		
		static readonly int Gain__Offset;
		/// <summary>Reverb Gain - 0.0 < 0.32 < 1.0 - overall reverb gain - master volume control</summary>
		public float Gain
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+Gain__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+Gain__Offset, false);}
			
		}
		
		static readonly int GainHF__Offset;
		/// <summary>Reverb Gain High Frequency - 0.0 < 0.89 < 1.0 - attenuates the high frequency reflected sound</summary>
		public float GainHF
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+GainHF__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+GainHF__Offset, false);}
			
		}
		
		static readonly int DecayTime__Offset;
		/// <summary>Decay Time - 0.1 < 1.49 < 20.0 Seconds - larger is more reverb</summary>
		public float DecayTime
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+DecayTime__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+DecayTime__Offset, false);}
			
		}
		
		static readonly int DecayHFRatio__Offset;
		/// <summary>Decay High Frequency Ratio - 0.1 < 0.83 < 2.0 - how much the quicker or slower the high frequencies decay relative to the lower frequencies.</summary>
		public float DecayHFRatio
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+DecayHFRatio__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+DecayHFRatio__Offset, false);}
			
		}
		
		static readonly int ReflectionsGain__Offset;
		/// <summary>Reflections Gain - 0.0 < 0.05 < 3.16 - controls the amount of initial reflections</summary>
		public float ReflectionsGain
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+ReflectionsGain__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+ReflectionsGain__Offset, false);}
			
		}
		
		static readonly int ReflectionsDelay__Offset;
		/// <summary>Reflections Delay - 0.0 < 0.007 < 0.3 Seconds - the time between the listener receiving the direct path sound and the first reflection</summary>
		public float ReflectionsDelay
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+ReflectionsDelay__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+ReflectionsDelay__Offset, false);}
			
		}
		
		static readonly int LateGain__Offset;
		/// <summary>Late Reverb Gain - 0.0 < 1.26 < 10.0 - gain of the late reverb</summary>
		public float LateGain
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+LateGain__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+LateGain__Offset, false);}
			
		}
		
		static readonly int LateDelay__Offset;
		/// <summary>Late Reverb Delay - 0.0 < 0.011 < 0.1 Seconds - time difference between late reverb and first reflections</summary>
		public float LateDelay
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+LateDelay__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+LateDelay__Offset, false);}
			
		}
		
		static readonly int AirAbsorptionGainHF__Offset;
		/// <summary>Air Absorption - 0.0 < 0.994 < 1.0 - lower value means more absorption</summary>
		public float AirAbsorptionGainHF
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+AirAbsorptionGainHF__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+AirAbsorptionGainHF__Offset, false);}
			
		}
		
		static readonly int RoomRolloffFactor__Offset;
		/// <summary>Room Rolloff - 0.0 < 0.0 < 10.0 - multiplies the attenuation due to distance</summary>
		public float RoomRolloffFactor
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+RoomRolloffFactor__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+RoomRolloffFactor__Offset, false);}
			
		}
		
		static readonly int bChanged__Offset;
		/// <summary>Transient property used to trigger real-time updates of the reverb for real-time editor previewing</summary>
		public bool bChanged
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bChanged__Offset, 1, 0, 1, 1);}
			
		}
		
		static UReverbEffect()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("ReverbEffect");
			Density__Offset=GetPropertyOffset(NativeClassPtr,"Density");
			Diffusion__Offset=GetPropertyOffset(NativeClassPtr,"Diffusion");
			Gain__Offset=GetPropertyOffset(NativeClassPtr,"Gain");
			GainHF__Offset=GetPropertyOffset(NativeClassPtr,"GainHF");
			DecayTime__Offset=GetPropertyOffset(NativeClassPtr,"DecayTime");
			DecayHFRatio__Offset=GetPropertyOffset(NativeClassPtr,"DecayHFRatio");
			ReflectionsGain__Offset=GetPropertyOffset(NativeClassPtr,"ReflectionsGain");
			ReflectionsDelay__Offset=GetPropertyOffset(NativeClassPtr,"ReflectionsDelay");
			LateGain__Offset=GetPropertyOffset(NativeClassPtr,"LateGain");
			LateDelay__Offset=GetPropertyOffset(NativeClassPtr,"LateDelay");
			AirAbsorptionGainHF__Offset=GetPropertyOffset(NativeClassPtr,"AirAbsorptionGainHF");
			RoomRolloffFactor__Offset=GetPropertyOffset(NativeClassPtr,"RoomRolloffFactor");
			bChanged__Offset=GetPropertyOffset(NativeClassPtr,"bChanged");
			
		}
		
	}
	
}
#endif
#endif
