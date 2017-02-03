#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class UParticleModuleColorScaleOverLife
	{
		static readonly int ColorScaleOverLife__Offset;
		/// <summary>The scale factor for the color.</summary>
		public FRawDistributionVector ColorScaleOverLife
		{
			get{ CheckIsValid();return (FRawDistributionVector)Marshal.PtrToStructure(_this.Get()+ColorScaleOverLife__Offset, typeof(FRawDistributionVector));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+ColorScaleOverLife__Offset, false);}
			
		}
		
		static readonly int AlphaScaleOverLife__Offset;
		/// <summary>The scale factor for the alpha.</summary>
		public FRawDistributionFloat AlphaScaleOverLife
		{
			get{ CheckIsValid();return (FRawDistributionFloat)Marshal.PtrToStructure(_this.Get()+AlphaScaleOverLife__Offset, typeof(FRawDistributionFloat));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+AlphaScaleOverLife__Offset, false);}
			
		}
		
		static readonly int bEmitterTime__Offset;
		/// <summary>Whether it is EmitterTime or ParticleTime related.</summary>
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
