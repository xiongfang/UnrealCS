#if WITH_GAME
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class UParticleModuleVectorFieldScaleOverLife
	{
		static readonly int VectorFieldScaleOverLife__Offset;
		public UDistributionFloat VectorFieldScaleOverLife
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + VectorFieldScaleOverLife__Offset); if (v == IntPtr.Zero)return null; UDistributionFloat retValue = new UDistributionFloat(); retValue._this = v; return retValue; }
			
		}
		
		static readonly int VectorFieldScaleOverLifeRaw__Offset;
		public FRawDistributionFloat VectorFieldScaleOverLifeRaw
		{
			get{ CheckIsValid();return (FRawDistributionFloat)Marshal.PtrToStructure(_this.Get()+VectorFieldScaleOverLifeRaw__Offset, typeof(FRawDistributionFloat));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+VectorFieldScaleOverLifeRaw__Offset, false);}
			
		}
		
		static UParticleModuleVectorFieldScaleOverLife()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("ParticleModuleVectorFieldScaleOverLife");
			VectorFieldScaleOverLife__Offset=GetPropertyOffset(NativeClassPtr,"VectorFieldScaleOverLife");
			VectorFieldScaleOverLifeRaw__Offset=GetPropertyOffset(NativeClassPtr,"VectorFieldScaleOverLifeRaw");
			
		}
		
	}
	
}
#endif
#endif
