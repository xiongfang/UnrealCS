#if WITH_GAME
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class UInputActionDelegateBinding
	{
		static readonly int InputActionDelegateBindings__Offset;
		public TStructArray<FBlueprintInputActionDelegateBinding> InputActionDelegateBindings
		{
			get{ CheckIsValid();return new TStructArray<FBlueprintInputActionDelegateBinding>((FScriptArray)Marshal.PtrToStructure(_this.Get()+InputActionDelegateBindings__Offset, typeof(FScriptArray)));}
					set{ CheckIsValid();Marshal.StructureToPtr(value.InterArray, _this.Get()+InputActionDelegateBindings__Offset, false);}
			
		}
		
		static UInputActionDelegateBinding()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("InputActionDelegateBinding");
			InputActionDelegateBindings__Offset=GetPropertyOffset(NativeClassPtr,"InputActionDelegateBindings");
			
		}
		
	}
	
}
#endif
#endif
