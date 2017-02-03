#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class UParticleModuleBeamNoise
	{
		static readonly int bLowFreq_Enabled__Offset;
		/// <summary>Is low frequency noise enabled.</summary>
		public bool bLowFreq_Enabled
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bLowFreq_Enabled__Offset, 1, 0, 1, 1);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bLowFreq_Enabled__Offset, 1,0,1,1);}
			
		}
		
		static readonly int Frequency__Offset;
		/// <summary>The frequency of noise points.</summary>
		public int Frequency
		{
			get{ CheckIsValid();return (int)Marshal.PtrToStructure(_this.Get()+Frequency__Offset, typeof(int));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+Frequency__Offset, false);}
			
		}
		
		static readonly int Frequency_LowRange__Offset;
		/// <summary>
		/// If not 0, then the frequency will select a random value in the range
		///         [Frequency_LowRange..Frequency]
		/// </summary>
		public int Frequency_LowRange
		{
			get{ CheckIsValid();return (int)Marshal.PtrToStructure(_this.Get()+Frequency_LowRange__Offset, typeof(int));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+Frequency_LowRange__Offset, false);}
			
		}
		
		static readonly int NoiseRange__Offset;
		/// <summary>The noise point ranges.</summary>
		public FRawDistributionVector NoiseRange
		{
			get{ CheckIsValid();return (FRawDistributionVector)Marshal.PtrToStructure(_this.Get()+NoiseRange__Offset, typeof(FRawDistributionVector));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+NoiseRange__Offset, false);}
			
		}
		
		static readonly int NoiseRangeScale__Offset;
		/// <summary>A scale factor that will be applied to the noise range.</summary>
		public FRawDistributionFloat NoiseRangeScale
		{
			get{ CheckIsValid();return (FRawDistributionFloat)Marshal.PtrToStructure(_this.Get()+NoiseRangeScale__Offset, typeof(FRawDistributionFloat));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+NoiseRangeScale__Offset, false);}
			
		}
		
		static readonly int bNRScaleEmitterTime__Offset;
		/// <summary>
		/// If true,  the NoiseRangeScale will be grabbed based on the emitter time.
		/// If false, the NoiseRangeScale will be grabbed based on the particle time.
		/// </summary>
		public bool bNRScaleEmitterTime
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bNRScaleEmitterTime__Offset, 1, 0, 1, 1);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bNRScaleEmitterTime__Offset, 1,0,1,1);}
			
		}
		
		static readonly int NoiseSpeed__Offset;
		/// <summary>The speed with which to move each noise point.</summary>
		public FRawDistributionVector NoiseSpeed
		{
			get{ CheckIsValid();return (FRawDistributionVector)Marshal.PtrToStructure(_this.Get()+NoiseSpeed__Offset, typeof(FRawDistributionVector));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+NoiseSpeed__Offset, false);}
			
		}
		
		static readonly int bSmooth__Offset;
		/// <summary>Whether the noise movement should be smooth or 'jerky'.</summary>
		public bool bSmooth
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bSmooth__Offset, 1, 0, 1, 1);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bSmooth__Offset, 1,0,1,1);}
			
		}
		
		static readonly int NoiseLockRadius__Offset;
		/// <summary>Default target-point information to use if the beam method is endpoint.</summary>
		public float NoiseLockRadius
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+NoiseLockRadius__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+NoiseLockRadius__Offset, false);}
			
		}
		
		static readonly int bNoiseLock__Offset;
		/// <summary>INTERNAL - Whether the noise points should be locked.</summary>
		public bool bNoiseLock
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bNoiseLock__Offset, 1, 0, 1, 1);}
			
		}
		
		static readonly int bOscillate__Offset;
		/// <summary>Whether the noise points should be oscillate.</summary>
		public bool bOscillate
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bOscillate__Offset, 1, 0, 2, 2);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bOscillate__Offset, 1,0,2,2);}
			
		}
		
		static readonly int NoiseLockTime__Offset;
		/// <summary>How long the  noise points should be locked - 0.0 indicates forever.</summary>
		public float NoiseLockTime
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+NoiseLockTime__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+NoiseLockTime__Offset, false);}
			
		}
		
		static readonly int NoiseTension__Offset;
		/// <summary>The tension to apply to the tessellated noise line.</summary>
		public float NoiseTension
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+NoiseTension__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+NoiseTension__Offset, false);}
			
		}
		
		static readonly int bUseNoiseTangents__Offset;
		/// <summary>If true, calculate tangents at each noise point.</summary>
		public bool bUseNoiseTangents
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bUseNoiseTangents__Offset, 1, 0, 1, 1);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bUseNoiseTangents__Offset, 1,0,1,1);}
			
		}
		
		static readonly int NoiseTangentStrength__Offset;
		/// <summary>The strength of noise tangents, if enabled.</summary>
		public FRawDistributionFloat NoiseTangentStrength
		{
			get{ CheckIsValid();return (FRawDistributionFloat)Marshal.PtrToStructure(_this.Get()+NoiseTangentStrength__Offset, typeof(FRawDistributionFloat));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+NoiseTangentStrength__Offset, false);}
			
		}
		
		static readonly int NoiseTessellation__Offset;
		/// <summary>The amount of tessellation between noise points.</summary>
		public int NoiseTessellation
		{
			get{ CheckIsValid();return (int)Marshal.PtrToStructure(_this.Get()+NoiseTessellation__Offset, typeof(int));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+NoiseTessellation__Offset, false);}
			
		}
		
		static readonly int bTargetNoise__Offset;
		/// <summary>
		/// Whether to apply noise to the target point (or end of line in distance mode...)
		/// If true, the beam could potentially 'leave' the target...
		/// </summary>
		public bool bTargetNoise
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bTargetNoise__Offset, 1, 0, 1, 1);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bTargetNoise__Offset, 1,0,1,1);}
			
		}
		
		static readonly int FrequencyDistance__Offset;
		/// <summary>
		/// The distance at which to deposit noise points.
		/// If 0.0, then use the static frequency value.
		/// If not, distribute noise points at the given distance, up to the static Frequency value.
		/// At that point, evenly distribute them along the beam.
		/// </summary>
		public float FrequencyDistance
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+FrequencyDistance__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+FrequencyDistance__Offset, false);}
			
		}
		
		static readonly int bApplyNoiseScale__Offset;
		/// <summary>If true, apply the noise scale to the beam.</summary>
		public bool bApplyNoiseScale
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bApplyNoiseScale__Offset, 1, 0, 1, 1);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bApplyNoiseScale__Offset, 1,0,1,1);}
			
		}
		
		static readonly int NoiseScale__Offset;
		/// <summary>
		/// The scale factor to apply to noise range.
		/// The lookup value is determined by dividing the number of noise points present by the
		/// maximum number of noise points (Frequency).
		/// </summary>
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
