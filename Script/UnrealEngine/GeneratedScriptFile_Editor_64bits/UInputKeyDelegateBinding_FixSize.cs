#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class UInputKeyDelegateBinding
	{
		static readonly int InputKeyDelegateBindings__Offset;
		public TStructArray<FBlueprintInputKeyDelegateBinding> InputKeyDelegateBindings
		{
			get{ CheckIsValid();return new TStructArray<FBlueprintInputKeyDelegateBinding>((FScriptArray)Marshal.PtrToStructure(_this.Get()+InputKeyDelegateBindings__Offset, typeof(FScriptArray)));}
					set{ CheckIsValid();Marshal.StructureToPtr(value.InterArray, _this.Get()+InputKeyDelegateBindings__Offset, false);}
			
		}
		
		static UInputKeyDelegateBinding()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("InputKeyDelegateBinding");
			InputKeyDelegateBindings__Offset=GetPropertyOffset(NativeClassPtr,"InputKeyDelegateBindings");
			
		}
		
	}
	
}
#endif
#endif
