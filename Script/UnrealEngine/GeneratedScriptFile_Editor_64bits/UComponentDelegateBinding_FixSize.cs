#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class UComponentDelegateBinding
	{
		static readonly int ComponentDelegateBindings__Offset;
		public TStructArray<FBlueprintComponentDelegateBinding> ComponentDelegateBindings
		{
			get{ CheckIsValid();return new TStructArray<FBlueprintComponentDelegateBinding>((FScriptArray)Marshal.PtrToStructure(_this.Get()+ComponentDelegateBindings__Offset, typeof(FScriptArray)));}
					set{ CheckIsValid();Marshal.StructureToPtr(value.InterArray, _this.Get()+ComponentDelegateBindings__Offset, false);}
			
		}
		
		static UComponentDelegateBinding()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("ComponentDelegateBinding");
			ComponentDelegateBindings__Offset=GetPropertyOffset(NativeClassPtr,"ComponentDelegateBindings");
			
		}
		
	}
	
}
#endif
#endif
