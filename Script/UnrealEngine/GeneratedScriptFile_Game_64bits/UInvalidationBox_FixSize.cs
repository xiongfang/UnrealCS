#if WITH_GAME
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class UInvalidationBox
	{
		static readonly int bCanCache__Offset;
		public bool bCanCache
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bCanCache__Offset, 1, 0, 1, 255);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bCanCache__Offset, 1,0,1,255);}
			
		}
		
		static readonly int CacheRelativeTransforms__Offset;
		public bool CacheRelativeTransforms
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), CacheRelativeTransforms__Offset, 1, 0, 1, 255);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), CacheRelativeTransforms__Offset, 1,0,1,255);}
			
		}
		
		static UInvalidationBox()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("InvalidationBox");
			bCanCache__Offset=GetPropertyOffset(NativeClassPtr,"bCanCache");
			CacheRelativeTransforms__Offset=GetPropertyOffset(NativeClassPtr,"CacheRelativeTransforms");
			
		}
		
	}
	
}
#endif
#endif
