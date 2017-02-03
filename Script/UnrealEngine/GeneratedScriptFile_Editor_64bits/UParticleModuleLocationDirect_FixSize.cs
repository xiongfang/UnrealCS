#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class UParticleModuleLocationDirect
	{
		static readonly int Location__Offset;
		/// <summary>
		/// The location of the particle at a give time. Retrieved using the particle RelativeTime.
		/// IMPORTANT: the particle location is set to this value, thereby over-writing any previous module impacts.
		/// </summary>
		public FRawDistributionVector Location
		{
			get{ CheckIsValid();return (FRawDistributionVector)Marshal.PtrToStructure(_this.Get()+Location__Offset, typeof(FRawDistributionVector));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+Location__Offset, false);}
			
		}
		
		static readonly int LocationOffset__Offset;
		/// <summary>
		/// An offset to apply to the position retrieved from the Location calculation.
		/// The offset is retrieved using the EmitterTime.
		/// The offset will remain constant over the life of the particle.
		/// </summary>
		public FRawDistributionVector LocationOffset
		{
			get{ CheckIsValid();return (FRawDistributionVector)Marshal.PtrToStructure(_this.Get()+LocationOffset__Offset, typeof(FRawDistributionVector));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+LocationOffset__Offset, false);}
			
		}
		
		static readonly int ScaleFactor__Offset;
		/// <summary>Scales the velocity of the object at a given point in the time-line.</summary>
		public FRawDistributionVector ScaleFactor
		{
			get{ CheckIsValid();return (FRawDistributionVector)Marshal.PtrToStructure(_this.Get()+ScaleFactor__Offset, typeof(FRawDistributionVector));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+ScaleFactor__Offset, false);}
			
		}
		
		static readonly int Direction__Offset;
		/// <summary>Currently unused.</summary>
		public FRawDistributionVector Direction
		{
			get{ CheckIsValid();return (FRawDistributionVector)Marshal.PtrToStructure(_this.Get()+Direction__Offset, typeof(FRawDistributionVector));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+Direction__Offset, false);}
			
		}
		
		static UParticleModuleLocationDirect()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("ParticleModuleLocationDirect");
			Location__Offset=GetPropertyOffset(NativeClassPtr,"Location");
			LocationOffset__Offset=GetPropertyOffset(NativeClassPtr,"LocationOffset");
			ScaleFactor__Offset=GetPropertyOffset(NativeClassPtr,"ScaleFactor");
			Direction__Offset=GetPropertyOffset(NativeClassPtr,"Direction");
			
		}
		
	}
	
}
#endif
#endif
