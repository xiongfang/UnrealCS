#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class UParticleModuleLocation
	{
		static readonly int StartLocation__Offset;
		/// <summary>
		/// The location the particle should be emitted.
		/// Relative in local space to the emitter by default.
		/// Relative in world space as a WorldOffset module or when the emitter's UseLocalSpace is off.
		/// Retrieved using the EmitterTime at the spawn of the particle.
		/// </summary>
		public FRawDistributionVector StartLocation
		{
			get{ CheckIsValid();return (FRawDistributionVector)Marshal.PtrToStructure(_this.Get()+StartLocation__Offset, typeof(FRawDistributionVector));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+StartLocation__Offset, false);}
			
		}
		
		static readonly int DistributeOverNPoints__Offset;
		/// <summary>
		/// When set to a non-zero value this will force the particles to only spawn on evenly distributed
		/// positions between the two points specified.
		/// </summary>
		public float DistributeOverNPoints
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+DistributeOverNPoints__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+DistributeOverNPoints__Offset, false);}
			
		}
		
		static readonly int DistributeThreshold__Offset;
		/// <summary>
		/// When DistributeOverNPoints is set to a non-zero value, this specifies the ratio of particles spawned
		/// that should use the distribution.  (For example setting this to 1 will cause all the particles to
		/// be distributed evenly whereas .75 would cause 1/4 of the particles to be randomly placed).
		/// </summary>
		public float DistributeThreshold
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+DistributeThreshold__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+DistributeThreshold__Offset, false);}
			
		}
		
		static UParticleModuleLocation()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("ParticleModuleLocation");
			StartLocation__Offset=GetPropertyOffset(NativeClassPtr,"StartLocation");
			DistributeOverNPoints__Offset=GetPropertyOffset(NativeClassPtr,"DistributeOverNPoints");
			DistributeThreshold__Offset=GetPropertyOffset(NativeClassPtr,"DistributeThreshold");
			
		}
		
	}
	
}
#endif
#endif
