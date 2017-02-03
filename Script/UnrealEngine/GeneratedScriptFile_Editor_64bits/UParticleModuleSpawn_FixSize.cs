#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class UParticleModuleSpawn
	{
		static readonly int Rate__Offset;
		/// <summary>The rate at which to spawn particles.</summary>
		public FRawDistributionFloat Rate
		{
			get{ CheckIsValid();return (FRawDistributionFloat)Marshal.PtrToStructure(_this.Get()+Rate__Offset, typeof(FRawDistributionFloat));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+Rate__Offset, false);}
			
		}
		
		static readonly int RateScale__Offset;
		/// <summary>The scalar to apply to the rate.</summary>
		public FRawDistributionFloat RateScale
		{
			get{ CheckIsValid();return (FRawDistributionFloat)Marshal.PtrToStructure(_this.Get()+RateScale__Offset, typeof(FRawDistributionFloat));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+RateScale__Offset, false);}
			
		}
		
		static readonly int ParticleBurstMethod__Offset;
		/// <summary>The method to utilize when burst-emitting particles.</summary>
		public EParticleBurstMethod ParticleBurstMethod
		{
			get{ CheckIsValid();return (EParticleBurstMethod)Marshal.PtrToStructure(_this.Get()+ParticleBurstMethod__Offset, typeof(EParticleBurstMethod));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+ParticleBurstMethod__Offset, false);}
			
		}
		
		static readonly int BurstList__Offset;
		/// <summary>The array of burst entries.</summary>
		public TStructArray<FParticleBurst> BurstList
		{
			get{ CheckIsValid();return new TStructArray<FParticleBurst>((FScriptArray)Marshal.PtrToStructure(_this.Get()+BurstList__Offset, typeof(FScriptArray)));}
					set{ CheckIsValid();Marshal.StructureToPtr(value.InterArray, _this.Get()+BurstList__Offset, false);}
			
		}
		
		static readonly int BurstScale__Offset;
		/// <summary>Scale all burst entries by this amount.</summary>
		public FRawDistributionFloat BurstScale
		{
			get{ CheckIsValid();return (FRawDistributionFloat)Marshal.PtrToStructure(_this.Get()+BurstScale__Offset, typeof(FRawDistributionFloat));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+BurstScale__Offset, false);}
			
		}
		
		static readonly int bApplyGlobalSpawnRateScale__Offset;
		/// <summary>If true, the SpawnRate will be scaled by the global CVar r.EmitterSpawnRateScale</summary>
		public bool bApplyGlobalSpawnRateScale
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bApplyGlobalSpawnRateScale__Offset, 1, 0, 1, 1);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bApplyGlobalSpawnRateScale__Offset, 1,0,1,1);}
			
		}
		
		static UParticleModuleSpawn()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("ParticleModuleSpawn");
			Rate__Offset=GetPropertyOffset(NativeClassPtr,"Rate");
			RateScale__Offset=GetPropertyOffset(NativeClassPtr,"RateScale");
			ParticleBurstMethod__Offset=GetPropertyOffset(NativeClassPtr,"ParticleBurstMethod");
			BurstList__Offset=GetPropertyOffset(NativeClassPtr,"BurstList");
			BurstScale__Offset=GetPropertyOffset(NativeClassPtr,"BurstScale");
			bApplyGlobalSpawnRateScale__Offset=GetPropertyOffset(NativeClassPtr,"bApplyGlobalSpawnRateScale");
			
		}
		
	}
	
}
#endif
#endif
