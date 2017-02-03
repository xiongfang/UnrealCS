#if WITH_GAME
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class UBlendSpace1D
	{
		static readonly int bScaleAnimation__Offset;
		public bool bScaleAnimation
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bScaleAnimation__Offset, 1, 0, 1, 255);}
			
		}
		
		static UBlendSpace1D()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("BlendSpace1D");
			bScaleAnimation__Offset=GetPropertyOffset(NativeClassPtr,"bScaleAnimation");
			
		}
		
	}
	
}
#endif
#endif
