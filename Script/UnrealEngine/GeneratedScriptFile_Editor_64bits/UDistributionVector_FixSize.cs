#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class UDistributionVector
	{
		static readonly int bCanBeBaked__Offset;
		/// <summary>Can this variable be baked out to a FRawDistribution? Should be true 99% of the time</summary>
		public bool bCanBeBaked
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bCanBeBaked__Offset, 1, 0, 1, 1);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bCanBeBaked__Offset, 1,0,1,1);}
			
		}
		
		static readonly int bIsDirty__Offset;
		/// <summary>Set internally when the distribution is updated so that that FRawDistribution can know to update itself</summary>
		public bool bIsDirty
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bIsDirty__Offset, 1, 0, 2, 2);}
			
		}
		
		static readonly int bBakedDataSuccesfully__Offset;
		public bool bBakedDataSuccesfully
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bBakedDataSuccesfully__Offset, 1, 0, 4, 4);}
			
		}
		
		static UDistributionVector()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("DistributionVector");
			bCanBeBaked__Offset=GetPropertyOffset(NativeClassPtr,"bCanBeBaked");
			bIsDirty__Offset=GetPropertyOffset(NativeClassPtr,"bIsDirty");
			bBakedDataSuccesfully__Offset=GetPropertyOffset(NativeClassPtr,"bBakedDataSuccesfully");
			
		}
		
	}
	
}
#endif
#endif
