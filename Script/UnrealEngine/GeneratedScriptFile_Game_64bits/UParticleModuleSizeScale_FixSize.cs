#if WITH_GAME
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class UParticleModuleSizeScale
	{
		static readonly int SizeScale__Offset;
		public FRawDistributionVector SizeScale
		{
			get{ CheckIsValid();return (FRawDistributionVector)Marshal.PtrToStructure(_this.Get()+SizeScale__Offset, typeof(FRawDistributionVector));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+SizeScale__Offset, false);}
			
		}
		
		static readonly int EnableX__Offset;
		public bool EnableX
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), EnableX__Offset, 1, 0, 1, 1);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), EnableX__Offset, 1,0,1,1);}
			
		}
		
		static readonly int EnableY__Offset;
		public bool EnableY
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), EnableY__Offset, 1, 0, 2, 2);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), EnableY__Offset, 1,0,2,2);}
			
		}
		
		static readonly int EnableZ__Offset;
		public bool EnableZ
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), EnableZ__Offset, 1, 0, 4, 4);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), EnableZ__Offset, 1,0,4,4);}
			
		}
		
		static UParticleModuleSizeScale()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("ParticleModuleSizeScale");
			SizeScale__Offset=GetPropertyOffset(NativeClassPtr,"SizeScale");
			EnableX__Offset=GetPropertyOffset(NativeClassPtr,"EnableX");
			EnableY__Offset=GetPropertyOffset(NativeClassPtr,"EnableY");
			EnableZ__Offset=GetPropertyOffset(NativeClassPtr,"EnableZ");
			
		}
		
	}
	
}
#endif
#endif
