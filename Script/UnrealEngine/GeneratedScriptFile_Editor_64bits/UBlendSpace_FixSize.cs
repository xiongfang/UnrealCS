#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>Contains a grid of data points with weights from sample points in the space</summary>
	public partial class UBlendSpace
	{
		static readonly int AxisToScaleAnimation__Offset;
		/// <summary>If you have input interpolation, which axis to drive animation speed (scale) - i.e. for locomotion animation, speed axis will drive animation speed (thus scale)*</summary>
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
