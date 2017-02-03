#if WITH_GAME
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class UPlatformInterfaceBase
	{
		static readonly int AllDelegates__Offset;
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
