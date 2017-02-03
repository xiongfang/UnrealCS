#if WITH_GAME
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class UInputTouchDelegateBinding
	{
		static readonly int InputTouchDelegateBindings__Offset;
		public TStructArray<FBlueprintInputTouchDelegateBinding> InputTouchDelegateBindings
		{
			get{ CheckIsValid();return new TStructArray<FBlueprintInputTouchDelegateBinding>((FScriptArray)Marshal.PtrToStructure(_this.Get()+InputTouchDelegateBindings__Offset, typeof(FScriptArray)));}
					set{ CheckIsValid();Marshal.StructureToPtr(value.InterArray, _this.Get()+InputTouchDelegateBindings__Offset, false);}
			
		}
		
		static UInputTouchDelegateBinding()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("InputTouchDelegateBinding");
			InputTouchDelegateBindings__Offset=GetPropertyOffset(NativeClassPtr,"InputTouchDelegateBindings");
			
		}
		
	}
	
}
#endif
#endif
