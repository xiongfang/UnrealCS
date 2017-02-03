#if WITH_GAME
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class UInputAxisKeyDelegateBinding
	{
		static readonly int InputAxisKeyDelegateBindings__Offset;
		public TStructArray<FBlueprintInputAxisKeyDelegateBinding> InputAxisKeyDelegateBindings
		{
			get{ CheckIsValid();return new TStructArray<FBlueprintInputAxisKeyDelegateBinding>((FScriptArray)Marshal.PtrToStructure(_this.Get()+InputAxisKeyDelegateBindings__Offset, typeof(FScriptArray)));}
					set{ CheckIsValid();Marshal.StructureToPtr(value.InterArray, _this.Get()+InputAxisKeyDelegateBindings__Offset, false);}
			
		}
		
		static UInputAxisKeyDelegateBinding()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("InputAxisKeyDelegateBinding");
			InputAxisKeyDelegateBindings__Offset=GetPropertyOffset(NativeClassPtr,"InputAxisKeyDelegateBindings");
			
		}
		
	}
	
}
#endif
#endif
