#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class UParticleModuleVelocityCone
	{
		static readonly int Angle__Offset;
		/// <summary>The Min value represents the inner cone angle value and the Max value represents the outer cone angle value.</summary>
		public FRawDistributionFloat Angle
		{
			get{ CheckIsValid();return (FRawDistributionFloat)Marshal.PtrToStructure(_this.Get()+Angle__Offset, typeof(FRawDistributionFloat));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+Angle__Offset, false);}
			
		}
		
		static readonly int Velocity__Offset;
		/// <summary>The initial velocity of the particles.</summary>
		public FRawDistributionFloat Velocity
		{
			get{ CheckIsValid();return (FRawDistributionFloat)Marshal.PtrToStructure(_this.Get()+Velocity__Offset, typeof(FRawDistributionFloat));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+Velocity__Offset, false);}
			
		}
		
		static readonly int Direction__Offset;
		/// <summary>The direction FVector of the cone.</summary>
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
