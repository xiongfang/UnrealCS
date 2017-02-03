#if WITH_GAME
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class UReverbEffect
	{
		static readonly int Density__Offset;
		public float Density
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+Density__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+Density__Offset, false);}
			
		}
		
		static readonly int Diffusion__Offset;
		public float Diffusion
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+Diffusion__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+Diffusion__Offset, false);}
			
		}
		
		static readonly int Gain__Offset;
		public float Gain
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+Gain__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+Gain__Offset, false);}
			
		}
		
		static readonly int GainHF__Offset;
		public float GainHF
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+GainHF__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+GainHF__Offset, false);}
			
		}
		
		static readonly int DecayTime__Offset;
		public float DecayTime
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+DecayTime__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+DecayTime__Offset, false);}
			
		}
		
		static readonly int DecayHFRatio__Offset;
		public float DecayHFRatio
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+DecayHFRatio__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+DecayHFRatio__Offset, false);}
			
		}
		
		static readonly int ReflectionsGain__Offset;
		public float ReflectionsGain
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+ReflectionsGain__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+ReflectionsGain__Offset, false);}
			
		}
		
		static readonly int ReflectionsDelay__Offset;
		public float ReflectionsDelay
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+ReflectionsDelay__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+ReflectionsDelay__Offset, false);}
			
		}
		
		static readonly int LateGain__Offset;
		public float LateGain
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+LateGain__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+LateGain__Offset, false);}
			
		}
		
		static readonly int LateDelay__Offset;
		public float LateDelay
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+LateDelay__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+LateDelay__Offset, false);}
			
		}
		
		static readonly int AirAbsorptionGainHF__Offset;
		public float AirAbsorptionGainHF
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+AirAbsorptionGainHF__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+AirAbsorptionGainHF__Offset, false);}
			
		}
		
		static readonly int RoomRolloffFactor__Offset;
		public float RoomRolloffFactor
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+RoomRolloffFactor__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+RoomRolloffFactor__Offset, false);}
			
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
			
		}
		
	}
	
}
#endif
#endif
