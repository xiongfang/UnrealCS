#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class UInheritableComponentHandler
	{
		static readonly int Records__Offset;
		/// <summary>All component records</summary>
		public TStructArray<FComponentOverrideRecord> Records
		{
			get{ CheckIsValid();return new TStructArray<FComponentOverrideRecord>((FScriptArray)Marshal.PtrToStructure(_this.Get()+Records__Offset, typeof(FScriptArray)));}
					set{ CheckIsValid();Marshal.StructureToPtr(value.InterArray, _this.Get()+Records__Offset, false);}
			
		}
		
		static readonly int UnnecessaryComponents__Offset;
		/// <summary>List of components that were marked unnecessary, need to keep these around so it doesn't regenerate them when a child asks for one</summary>
		public TObjectArray<UActorComponent>  UnnecessaryComponents
		{
					get{ CheckIsValid();return new TObjectArray<UActorComponent>((FScriptArray)Marshal.PtrToStructure(_this.Get()+UnnecessaryComponents__Offset, typeof(FScriptArray)));}
					set{ CheckIsValid();Marshal.StructureToPtr(value.InterArray, _this.Get()+UnnecessaryComponents__Offset, false);}
			
		}
		
		static UInheritableComponentHandler()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("InheritableComponentHandler");
			Records__Offset=GetPropertyOffset(NativeClassPtr,"Records");
			UnnecessaryComponents__Offset=GetPropertyOffset(NativeClassPtr,"UnnecessaryComponents");
			
		}
		
	}
	
}
#endif
#endif
