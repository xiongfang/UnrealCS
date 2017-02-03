#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class UInterpFilter_Custom
	{
		static readonly int GroupsToInclude__Offset;
		/// <summary>Which groups are included in this filter.</summary>
		public TObjectArray<UInterpGroup>  GroupsToInclude
		{
					get{ CheckIsValid();return new TObjectArray<UInterpGroup>((FScriptArray)Marshal.PtrToStructure(_this.Get()+GroupsToInclude__Offset, typeof(FScriptArray)));}
					set{ CheckIsValid();Marshal.StructureToPtr(value.InterArray, _this.Get()+GroupsToInclude__Offset, false);}
			
		}
		
		static UInterpFilter_Custom()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("InterpFilter_Custom");
			GroupsToInclude__Offset=GetPropertyOffset(NativeClassPtr,"GroupsToInclude");
			
		}
		
	}
	
}
#endif
#endif
