#if WITH_GAME
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class UParticleModuleCollisionGPU
	{
		static readonly int Resilience__Offset;
		public FRawDistributionFloat Resilience
		{
			get{ CheckIsValid();return (FRawDistributionFloat)Marshal.PtrToStructure(_this.Get()+Resilience__Offset, typeof(FRawDistributionFloat));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+Resilience__Offset, false);}
			
		}
		
		static readonly int ResilienceScaleOverLife__Offset;
		public FRawDistributionFloat ResilienceScaleOverLife
		{
			get{ CheckIsValid();return (FRawDistributionFloat)Marshal.PtrToStructure(_this.Get()+ResilienceScaleOverLife__Offset, typeof(FRawDistributionFloat));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+ResilienceScaleOverLife__Offset, false);}
			
		}
		
		static readonly int Friction__Offset;
		public float Friction
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+Friction__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+Friction__Offset, false);}
			
		}
		
		static readonly int RandomSpread__Offset;
		public float RandomSpread
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+RandomSpread__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+RandomSpread__Offset, false);}
			
		}
		
		static readonly int RandomDistribution__Offset;
		public float RandomDistribution
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+RandomDistribution__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+RandomDistribution__Offset, false);}
			
		}
		
		static readonly int RadiusScale__Offset;
		public float RadiusScale
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+RadiusScale__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+RadiusScale__Offset, false);}
			
		}
		
		static readonly int RadiusBias__Offset;
		public float RadiusBias
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+RadiusBias__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+RadiusBias__Offset, false);}
			
		}
		
		static readonly int Response__Offset;
		public EParticleCollisionResponse Response
		{
			get{ CheckIsValid();return (EParticleCollisionResponse)Marshal.PtrToStructure(_this.Get()+Response__Offset, typeof(EParticleCollisionResponse));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+Response__Offset, false);}
			
		}
		
		static readonly int CollisionMode__Offset;
		public EParticleCollisionMode CollisionMode
		{
			get{ CheckIsValid();return (EParticleCollisionMode)Marshal.PtrToStructure(_this.Get()+CollisionMode__Offset, typeof(EParticleCollisionMode));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+CollisionMode__Offset, false);}
			
		}
		
		static UParticleModuleCollisionGPU()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("ParticleModuleCollisionGPU");
			Resilience__Offset=GetPropertyOffset(NativeClassPtr,"Resilience");
			ResilienceScaleOverLife__Offset=GetPropertyOffset(NativeClassPtr,"ResilienceScaleOverLife");
			Friction__Offset=GetPropertyOffset(NativeClassPtr,"Friction");
			RandomSpread__Offset=GetPropertyOffset(NativeClassPtr,"RandomSpread");
			RandomDistribution__Offset=GetPropertyOffset(NativeClassPtr,"RandomDistribution");
			RadiusScale__Offset=GetPropertyOffset(NativeClassPtr,"RadiusScale");
			RadiusBias__Offset=GetPropertyOffset(NativeClassPtr,"RadiusBias");
			Response__Offset=GetPropertyOffset(NativeClassPtr,"Response");
			CollisionMode__Offset=GetPropertyOffset(NativeClassPtr,"CollisionMode");
			
		}
		
	}
	
}
#endif
#endif
