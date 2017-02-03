#if WITH_GAME
#if PLATFORM_32BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class UParticleModuleVectorFieldScale
	{
		static readonly int VectorFieldScale__Offset;
		public UDistributionFloat VectorFieldScale
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + VectorFieldScale__Offset); if (v == IntPtr.Zero)return null; UDistributionFloat retValue = new UDistributionFloat(); retValue._this = v; return retValue; }
			
		}
		
		static readonly int VectorFieldScaleRaw__Offset;
		public FRawDistributionFloat VectorFieldScaleRaw
		{
			get{ CheckIsValid();return (FRawDistributionFloat)Marshal.PtrToStructure(_this.Get()+VectorFieldScaleRaw__Offset, typeof(FRawDistributionFloat));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+VectorFieldScaleRaw__Offset, false);}
			
		}
		
		static UParticleModuleVectorFieldScale()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("ParticleModuleVectorFieldScale");
			VectorFieldScale__Offset=GetPropertyOffset(NativeClassPtr,"VectorFieldScale");
			VectorFieldScaleRaw__Offset=GetPropertyOffset(NativeClassPtr,"VectorFieldScaleRaw");
			
		}
		
	}
	
}
#endif
#endif
