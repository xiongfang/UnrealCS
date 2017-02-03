#if WITH_GAME
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class UInputAxisDelegateBinding
	{
		static readonly int InputAxisDelegateBindings__Offset;
		public TStructArray<FBlueprintInputAxisDelegateBinding> InputAxisDelegateBindings
		{
			get{ CheckIsValid();return new TStructArray<FBlueprintInputAxisDelegateBinding>((FScriptArray)Marshal.PtrToStructure(_this.Get()+InputAxisDelegateBindings__Offset, typeof(FScriptArray)));}
					set{ CheckIsValid();Marshal.StructureToPtr(value.InterArray, _this.Get()+InputAxisDelegateBindings__Offset, false);}
			
		}
		
		static UInputAxisDelegateBinding()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("InputAxisDelegateBinding");
			InputAxisDelegateBindings__Offset=GetPropertyOffset(NativeClassPtr,"InputAxisDelegateBindings");
			
		}
		
	}
	
}
#endif
#endif
