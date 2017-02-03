#if WITH_GAME
#if PLATFORM_32BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class UParticleModuleVelocityOverLifetime
	{
		static readonly int VelOverLife__Offset;
		public FRawDistributionVector VelOverLife
		{
			get{ CheckIsValid();return (FRawDistributionVector)Marshal.PtrToStructure(_this.Get()+VelOverLife__Offset, typeof(FRawDistributionVector));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+VelOverLife__Offset, false);}
			
		}
		
		static readonly int Absolute__Offset;
		public bool Absolute
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), Absolute__Offset, 1, 0, 1, 1);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), Absolute__Offset, 1,0,1,1);}
			
		}
		
		static UParticleModuleVelocityOverLifetime()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("ParticleModuleVelocityOverLifetime");
			VelOverLife__Offset=GetPropertyOffset(NativeClassPtr,"VelOverLife");
			Absolute__Offset=GetPropertyOffset(NativeClassPtr,"Absolute");
			
		}
		
	}
	
}
#endif
#endif
