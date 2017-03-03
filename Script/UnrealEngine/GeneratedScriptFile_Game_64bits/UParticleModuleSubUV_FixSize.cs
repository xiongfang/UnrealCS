#if WITH_GAME
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class UParticleModuleSubUV
	{
		static readonly int Animation__Offset;
		public USubUVAnimation Animation
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + Animation__Offset); if (v == IntPtr.Zero)return null; USubUVAnimation retValue = new USubUVAnimation(); retValue._this = v; return retValue; }
			
		}
		
		static readonly int SubImageIndex__Offset;
		public FRawDistributionFloat SubImageIndex
		{
			get{ CheckIsValid();return (FRawDistributionFloat)Marshal.PtrToStructure(_this.Get()+SubImageIndex__Offset, typeof(FRawDistributionFloat));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+SubImageIndex__Offset, false);}
			
		}
		
		static readonly int bUseRealTime__Offset;
		public bool bUseRealTime
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bUseRealTime__Offset, 1, 0, 1, 1);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bUseRealTime__Offset, 1,0,1,1);}
			
		}
		
		static UParticleModuleSubUV()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("ParticleModuleSubUV");
			Animation__Offset=GetPropertyOffset(NativeClassPtr,"Animation");
			SubImageIndex__Offset=GetPropertyOffset(NativeClassPtr,"SubImageIndex");
			bUseRealTime__Offset=GetPropertyOffset(NativeClassPtr,"bUseRealTime");
			
		}
		
	}
	
}
#endif
#endif
