#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class UBlendSpace1D
	{
		static readonly int bDisplayEditorVertically__Offset;
		public bool bDisplayEditorVertically
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bDisplayEditorVertically__Offset, 1, 0, 1, 255);}
			
		}
		
		static readonly int bScaleAnimation__Offset;
		/// <summary>Drive animation speed by blend input position *</summary>
		public bool bScaleAnimation
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bScaleAnimation__Offset, 1, 0, 1, 255);}
			
		}
		
		static UBlendSpace1D()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("BlendSpace1D");
			bDisplayEditorVertically__Offset=GetPropertyOffset(NativeClassPtr,"bDisplayEditorVertically");
			bScaleAnimation__Offset=GetPropertyOffset(NativeClassPtr,"bScaleAnimation");
			
		}
		
	}
	
}
#endif
#endif
