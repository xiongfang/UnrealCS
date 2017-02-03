#if WITH_GAME
#if PLATFORM_32BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class UParticleModuleAccelerationDragScaleOverLife
	{
		static readonly int DragScale__Offset;
		public UDistributionFloat DragScale
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + DragScale__Offset); if (v == IntPtr.Zero)return null; UDistributionFloat retValue = new UDistributionFloat(); retValue._this = v; return retValue; }
			
		}
		
		static readonly int DragScaleRaw__Offset;
		public FRawDistributionFloat DragScaleRaw
		{
			get{ CheckIsValid();return (FRawDistributionFloat)Marshal.PtrToStructure(_this.Get()+DragScaleRaw__Offset, typeof(FRawDistributionFloat));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+DragScaleRaw__Offset, false);}
			
		}
		
		static UParticleModuleAccelerationDragScaleOverLife()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("ParticleModuleAccelerationDragScaleOverLife");
			DragScale__Offset=GetPropertyOffset(NativeClassPtr,"DragScale");
			DragScaleRaw__Offset=GetPropertyOffset(NativeClassPtr,"DragScaleRaw");
			
		}
		
	}
	
}
#endif
#endif
