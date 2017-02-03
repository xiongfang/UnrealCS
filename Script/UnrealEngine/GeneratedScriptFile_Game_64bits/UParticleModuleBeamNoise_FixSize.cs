#if WITH_GAME
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class UParticleModuleBeamNoise
	{
		static readonly int bLowFreq_Enabled__Offset;
		public bool bLowFreq_Enabled
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bLowFreq_Enabled__Offset, 1, 0, 1, 1);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bLowFreq_Enabled__Offset, 1,0,1,1);}
			
		}
		
		static readonly int Frequency__Offset;
		public int Frequency
		{
			get{ CheckIsValid();return (int)Marshal.PtrToStructure(_this.Get()+Frequency__Offset, typeof(int));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+Frequency__Offset, false);}
			
		}
		
		static readonly int Frequency_LowRange__Offset;
		public int Frequency_LowRange
		{
			get{ CheckIsValid();return (int)Marshal.PtrToStructure(_this.Get()+Frequency_LowRange__Offset, typeof(int));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+Frequency_LowRange__Offset, false);}
			
		}
		
		static readonly int NoiseRange__Offset;
		public FRawDistributionVector NoiseRange
		{
			get{ CheckIsValid();return (FRawDistributionVector)Marshal.PtrToStructure(_this.Get()+NoiseRange__Offset, typeof(FRawDistributionVector));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+NoiseRange__Offset, false);}
			
		}
		
		static readonly int NoiseRangeScale__Offset;
		public FRawDistributionFloat NoiseRangeScale
		{
			get{ CheckIsValid();return (FRawDistributionFloat)Marshal.PtrToStructure(_this.Get()+NoiseRangeScale__Offset, typeof(FRawDistributionFloat));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+NoiseRangeScale__Offset, false);}
			
		}
		
		static readonly int bNRScaleEmitterTime__Offset;
		public bool bNRScaleEmitterTime
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bNRScaleEmitterTime__Offset, 1, 0, 1, 1);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bNRScaleEmitterTime__Offset, 1,0,1,1);}
			
		}
		
		static readonly int NoiseSpeed__Offset;
		public FRawDistributionVector NoiseSpeed
		{
			get{ CheckIsValid();return (FRawDistributionVector)Marshal.PtrToStructure(_this.Get()+NoiseSpeed__Offset, typeof(FRawDistributionVector));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+NoiseSpeed__Offset, false);}
			
		}
		
		static readonly int bSmooth__Offset;
		public bool bSmooth
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bSmooth__Offset, 1, 0, 1, 1);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bSmooth__Offset, 1,0,1,1);}
			
		}
		
		static readonly int NoiseLockRadius__Offset;
		public float NoiseLockRadius
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+NoiseLockRadius__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+NoiseLockRadius__Offset, false);}
			
		}
		
		static readonly int bNoiseLock__Offset;
		public bool bNoiseLock
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bNoiseLock__Offset, 1, 0, 1, 1);}
			
		}
		
		static readonly int bOscillate__Offset;
		public bool bOscillate
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bOscillate__Offset, 1, 0, 2, 2);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bOscillate__Offset, 1,0,2,2);}
			
		}
		
		static readonly int NoiseLockTime__Offset;
		public float NoiseLockTime
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+NoiseLockTime__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+NoiseLockTime__Offset, false);}
			
		}
		
		static readonly int NoiseTension__Offset;
		public float NoiseTension
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+NoiseTension__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+NoiseTension__Offset, false);}
			
		}
		
		static readonly int bUseNoiseTangents__Offset;
		public bool bUseNoiseTangents
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bUseNoiseTangents__Offset, 1, 0, 1, 1);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bUseNoiseTangents__Offset, 1,0,1,1);}
			
		}
		
		static readonly int NoiseTangentStrength__Offset;
		public FRawDistributionFloat NoiseTangentStrength
		{
			get{ CheckIsValid();return (FRawDistributionFloat)Marshal.PtrToStructure(_this.Get()+NoiseTangentStrength__Offset, typeof(FRawDistributionFloat));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+NoiseTangentStrength__Offset, false);}
			
		}
		
		static readonly int NoiseTessellation__Offset;
		public int NoiseTessellation
		{
			get{ CheckIsValid();return (int)Marshal.PtrToStructure(_this.Get()+NoiseTessellation__Offset, typeof(int));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+NoiseTessellation__Offset, false);}
			
		}
		
		static readonly int bTargetNoise__Offset;
		public bool bTargetNoise
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bTargetNoise__Offset, 1, 0, 1, 1);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bTargetNoise__Offset, 1,0,1,1);}
			
		}
		
		static readonly int FrequencyDistance__Offset;
		public float FrequencyDistance
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+FrequencyDistance__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+FrequencyDistance__Offset, false);}
			
		}
		
		static readonly int bApplyNoiseScale__Offset;
		public bool bApplyNoiseScale
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bApplyNoiseScale__Offset, 1, 0, 1, 1);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bApplyNoiseScale__Offset, 1,0,1,1);}
			
		}
		
		static readonly int NoiseScale__Offset;
		public FRawDistributionFloat NoiseScale
		{
			get{ CheckIsValid();return (FRawDistributionFloat)Marshal.PtrToStructure(_this.Get()+NoiseScale__Offset, typeof(FRawDistributionFloat));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+NoiseScale__Offset, false);}
			
		}
		
		static UParticleModuleBeamNoise()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("ParticleModuleBeamNoise");
			bLowFreq_Enabled__Offset=GetPropertyOffset(NativeClassPtr,"bLowFreq_Enabled");
			Frequency__Offset=GetPropertyOffset(NativeClassPtr,"Frequency");
			Frequency_LowRange__Offset=GetPropertyOffset(NativeClassPtr,"Frequency_LowRange");
			NoiseRange__Offset=GetPropertyOffset(NativeClassPtr,"NoiseRange");
			NoiseRangeScale__Offset=GetPropertyOffset(NativeClassPtr,"NoiseRangeScale");
			bNRScaleEmitterTime__Offset=GetPropertyOffset(NativeClassPtr,"bNRScaleEmitterTime");
			NoiseSpeed__Offset=GetPropertyOffset(NativeClassPtr,"NoiseSpeed");
			bSmooth__Offset=GetPropertyOffset(NativeClassPtr,"bSmooth");
			NoiseLockRadius__Offset=GetPropertyOffset(NativeClassPtr,"NoiseLockRadius");
			bNoiseLock__Offset=GetPropertyOffset(NativeClassPtr,"bNoiseLock");
			bOscillate__Offset=GetPropertyOffset(NativeClassPtr,"bOscillate");
			NoiseLockTime__Offset=GetPropertyOffset(NativeClassPtr,"NoiseLockTime");
			NoiseTension__Offset=GetPropertyOffset(NativeClassPtr,"NoiseTension");
			bUseNoiseTangents__Offset=GetPropertyOffset(NativeClassPtr,"bUseNoiseTangents");
			NoiseTangentStrength__Offset=GetPropertyOffset(NativeClassPtr,"NoiseTangentStrength");
			NoiseTessellation__Offset=GetPropertyOffset(NativeClassPtr,"NoiseTessellation");
			bTargetNoise__Offset=GetPropertyOffset(NativeClassPtr,"bTargetNoise");
			FrequencyDistance__Offset=GetPropertyOffset(NativeClassPtr,"FrequencyDistance");
			bApplyNoiseScale__Offset=GetPropertyOffset(NativeClassPtr,"bApplyNoiseScale");
			NoiseScale__Offset=GetPropertyOffset(NativeClassPtr,"NoiseScale");
			
		}
		
	}
	
}
#endif
#endif
