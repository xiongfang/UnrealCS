#if WITH_GAME
#if PLATFORM_32BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class UBlendSpace
	{
		static readonly int AxisToScaleAnimation__Offset;
		public EBlendSpaceAxis AxisToScaleAnimation
		{
			get{ CheckIsValid();return (EBlendSpaceAxis)Marshal.PtrToStructure(_this.Get()+AxisToScaleAnimation__Offset, typeof(EBlendSpaceAxis));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+AxisToScaleAnimation__Offset, false);}
			
		}
		
		static UBlendSpace()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("BlendSpace");
			AxisToScaleAnimation__Offset=GetPropertyOffset(NativeClassPtr,"AxisToScaleAnimation");
			
		}
		
	}
	
}
#endif
#endif
