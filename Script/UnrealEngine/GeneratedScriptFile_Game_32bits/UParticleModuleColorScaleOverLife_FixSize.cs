#if WITH_GAME
#if PLATFORM_32BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class UParticleModuleColorScaleOverLife
	{
		static readonly int ColorScaleOverLife__Offset;
		public FRawDistributionVector ColorScaleOverLife
		{
			get{ CheckIsValid();return (FRawDistributionVector)Marshal.PtrToStructure(_this.Get()+ColorScaleOverLife__Offset, typeof(FRawDistributionVector));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+ColorScaleOverLife__Offset, false);}
			
		}
		
		static readonly int AlphaScaleOverLife__Offset;
		public FRawDistributionFloat AlphaScaleOverLife
		{
			get{ CheckIsValid();return (FRawDistributionFloat)Marshal.PtrToStructure(_this.Get()+AlphaScaleOverLife__Offset, typeof(FRawDistributionFloat));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+AlphaScaleOverLife__Offset, false);}
			
		}
		
		static readonly int bEmitterTime__Offset;
		public bool bEmitterTime
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bEmitterTime__Offset, 1, 0, 1, 1);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bEmitterTime__Offset, 1,0,1,1);}
			
		}
		
		static UParticleModuleColorScaleOverLife()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("ParticleModuleColorScaleOverLife");
			ColorScaleOverLife__Offset=GetPropertyOffset(NativeClassPtr,"ColorScaleOverLife");
			AlphaScaleOverLife__Offset=GetPropertyOffset(NativeClassPtr,"AlphaScaleOverLife");
			bEmitterTime__Offset=GetPropertyOffset(NativeClassPtr,"bEmitterTime");
			
		}
		
	}
	
}
#endif
#endif
