#if WITH_GAME
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class UParticleModuleSizeMultiplyLife
	{
		static readonly int LifeMultiplier__Offset;
		public FRawDistributionVector LifeMultiplier
		{
			get{ CheckIsValid();return (FRawDistributionVector)Marshal.PtrToStructure(_this.Get()+LifeMultiplier__Offset, typeof(FRawDistributionVector));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+LifeMultiplier__Offset, false);}
			
		}
		
		static readonly int MultiplyX__Offset;
		public bool MultiplyX
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), MultiplyX__Offset, 1, 0, 1, 1);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), MultiplyX__Offset, 1,0,1,1);}
			
		}
		
		static readonly int MultiplyY__Offset;
		public bool MultiplyY
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), MultiplyY__Offset, 1, 0, 2, 2);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), MultiplyY__Offset, 1,0,2,2);}
			
		}
		
		static readonly int MultiplyZ__Offset;
		public bool MultiplyZ
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), MultiplyZ__Offset, 1, 0, 4, 4);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), MultiplyZ__Offset, 1,0,4,4);}
			
		}
		
		static UParticleModuleSizeMultiplyLife()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("ParticleModuleSizeMultiplyLife");
			LifeMultiplier__Offset=GetPropertyOffset(NativeClassPtr,"LifeMultiplier");
			MultiplyX__Offset=GetPropertyOffset(NativeClassPtr,"MultiplyX");
			MultiplyY__Offset=GetPropertyOffset(NativeClassPtr,"MultiplyY");
			MultiplyZ__Offset=GetPropertyOffset(NativeClassPtr,"MultiplyZ");
			
		}
		
	}
	
}
#endif
#endif
