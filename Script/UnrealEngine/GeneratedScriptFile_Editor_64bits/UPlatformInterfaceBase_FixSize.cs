#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class UPlatformInterfaceBase
	{
		static readonly int AllDelegates__Offset;
		/// <summary>Array of delegate arrays. Only add and remove via helper functions, and call via the helper delegate call function</summary>
		public TStructArray<FDelegateArray> AllDelegates
		{
			get{ CheckIsValid();return new TStructArray<FDelegateArray>((FScriptArray)Marshal.PtrToStructure(_this.Get()+AllDelegates__Offset, typeof(FScriptArray)));}
					set{ CheckIsValid();Marshal.StructureToPtr(value.InterArray, _this.Get()+AllDelegates__Offset, false);}
			
		}
		
		static UPlatformInterfaceBase()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("PlatformInterfaceBase");
			AllDelegates__Offset=GetPropertyOffset(NativeClassPtr,"AllDelegates");
			
		}
		
	}
	
}
#endif
#endif
