#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class UBoneMaskFilter
	{
		static readonly int BlendPoses__Offset;
		public TStructArray<FInputBlendPose> BlendPoses
		{
			get{ CheckIsValid();return new TStructArray<FInputBlendPose>((FScriptArray)Marshal.PtrToStructure(_this.Get()+BlendPoses__Offset, typeof(FScriptArray)));}
					set{ CheckIsValid();Marshal.StructureToPtr(value.InterArray, _this.Get()+BlendPoses__Offset, false);}
			
		}
		
		static UBoneMaskFilter()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("BoneMaskFilter");
			BlendPoses__Offset=GetPropertyOffset(NativeClassPtr,"BlendPoses");
			
		}
		
	}
	
}
#endif
#endif
