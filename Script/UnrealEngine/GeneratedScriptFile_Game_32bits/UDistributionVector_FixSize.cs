#if WITH_GAME
#if PLATFORM_32BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class UDistributionVector
	{
		static readonly int bCanBeBaked__Offset;
		public bool bCanBeBaked
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bCanBeBaked__Offset, 1, 0, 1, 1);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bCanBeBaked__Offset, 1,0,1,1);}
			
		}
		
		static readonly int bIsDirty__Offset;
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
