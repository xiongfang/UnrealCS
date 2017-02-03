#if WITH_GAME
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class UParticleModuleColor
	{
		static readonly int StartColor__Offset;
		public FRawDistributionVector StartColor
		{
			get{ CheckIsValid();return (FRawDistributionVector)Marshal.PtrToStructure(_this.Get()+StartColor__Offset, typeof(FRawDistributionVector));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+StartColor__Offset, false);}
			
		}
		
		static readonly int StartAlpha__Offset;
		public FRawDistributionFloat StartAlpha
		{
			get{ CheckIsValid();return (FRawDistributionFloat)Marshal.PtrToStructure(_this.Get()+StartAlpha__Offset, typeof(FRawDistributionFloat));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+StartAlpha__Offset, false);}
			
		}
		
		static readonly int bClampAlpha__Offset;
		public bool bClampAlpha
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bClampAlpha__Offset, 1, 0, 1, 1);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bClampAlpha__Offset, 1,0,1,1);}
			
		}
		
		static UParticleModuleColor()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("ParticleModuleColor");
			StartColor__Offset=GetPropertyOffset(NativeClassPtr,"StartColor");
			StartAlpha__Offset=GetPropertyOffset(NativeClassPtr,"StartAlpha");
			bClampAlpha__Offset=GetPropertyOffset(NativeClassPtr,"bClampAlpha");
			
		}
		
	}
	
}
#endif
#endif
