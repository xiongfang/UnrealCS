#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class UParticleModuleColorOverLife
	{
		static readonly int ColorOverLife__Offset;
		/// <summary>The color to apply to the particle, as a function of the particle RelativeTime.</summary>
		public FRawDistributionVector ColorOverLife
		{
			get{ CheckIsValid();return (FRawDistributionVector)Marshal.PtrToStructure(_this.Get()+ColorOverLife__Offset, typeof(FRawDistributionVector));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+ColorOverLife__Offset, false);}
			
		}
		
		static readonly int AlphaOverLife__Offset;
		/// <summary>The alpha to apply to the particle, as a function of the particle RelativeTime.</summary>
		public FRawDistributionFloat AlphaOverLife
		{
			get{ CheckIsValid();return (FRawDistributionFloat)Marshal.PtrToStructure(_this.Get()+AlphaOverLife__Offset, typeof(FRawDistributionFloat));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+AlphaOverLife__Offset, false);}
			
		}
		
		static readonly int bClampAlpha__Offset;
		/// <summary>If true, the alpha value will be clamped to the [0..1] range.</summary>
		public bool bClampAlpha
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bClampAlpha__Offset, 1, 0, 1, 1);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bClampAlpha__Offset, 1,0,1,1);}
			
		}
		
		static UParticleModuleColorOverLife()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("ParticleModuleColorOverLife");
			ColorOverLife__Offset=GetPropertyOffset(NativeClassPtr,"ColorOverLife");
			AlphaOverLife__Offset=GetPropertyOffset(NativeClassPtr,"AlphaOverLife");
			bClampAlpha__Offset=GetPropertyOffset(NativeClassPtr,"bClampAlpha");
			
		}
		
	}
	
}
#endif
#endif
