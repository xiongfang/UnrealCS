#if WITH_GAME
#if PLATFORM_32BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class UParticleModuleLocationDirect
	{
		static readonly int Location__Offset;
		public FRawDistributionVector Location
		{
			get{ CheckIsValid();return (FRawDistributionVector)Marshal.PtrToStructure(_this.Get()+Location__Offset, typeof(FRawDistributionVector));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+Location__Offset, false);}
			
		}
		
		static readonly int LocationOffset__Offset;
		public FRawDistributionVector LocationOffset
		{
			get{ CheckIsValid();return (FRawDistributionVector)Marshal.PtrToStructure(_this.Get()+LocationOffset__Offset, typeof(FRawDistributionVector));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+LocationOffset__Offset, false);}
			
		}
		
		static readonly int ScaleFactor__Offset;
		public FRawDistributionVector ScaleFactor
		{
			get{ CheckIsValid();return (FRawDistributionVector)Marshal.PtrToStructure(_this.Get()+ScaleFactor__Offset, typeof(FRawDistributionVector));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+ScaleFactor__Offset, false);}
			
		}
		
		static readonly int Direction__Offset;
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
