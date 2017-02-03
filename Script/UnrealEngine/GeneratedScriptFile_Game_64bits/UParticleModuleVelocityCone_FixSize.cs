#if WITH_GAME
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class UParticleModuleVelocityCone
	{
		static readonly int Angle__Offset;
		public FRawDistributionFloat Angle
		{
			get{ CheckIsValid();return (FRawDistributionFloat)Marshal.PtrToStructure(_this.Get()+Angle__Offset, typeof(FRawDistributionFloat));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+Angle__Offset, false);}
			
		}
		
		static readonly int Velocity__Offset;
		public FRawDistributionFloat Velocity
		{
			get{ CheckIsValid();return (FRawDistributionFloat)Marshal.PtrToStructure(_this.Get()+Velocity__Offset, typeof(FRawDistributionFloat));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+Velocity__Offset, false);}
			
		}
		
		static readonly int Direction__Offset;
		public FVector Direction
		{
			get{ CheckIsValid();return (FVector)Marshal.PtrToStructure(_this.Get()+Direction__Offset, typeof(FVector));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+Direction__Offset, false);}
			
		}
		
		static UParticleModuleVelocityCone()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("ParticleModuleVelocityCone");
			Angle__Offset=GetPropertyOffset(NativeClassPtr,"Angle");
			Velocity__Offset=GetPropertyOffset(NativeClassPtr,"Velocity");
			Direction__Offset=GetPropertyOffset(NativeClassPtr,"Direction");
			
		}
		
	}
	
}
#endif
#endif
