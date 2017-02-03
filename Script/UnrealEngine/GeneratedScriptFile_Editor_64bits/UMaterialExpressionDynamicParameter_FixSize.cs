#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class UMaterialExpressionDynamicParameter
	{
		static readonly int ParamNames__Offset;
		/// <summary>
		/// The names of the parameters.
		/// These will show up in Cascade when editing a particle system
		/// that uses the material it is in...
		/// </summary>
		public TStructArray<FString> ParamNames
		{
			get{ CheckIsValid();return new TStructArray<FString>((FScriptArray)Marshal.PtrToStructure(_this.Get()+ParamNames__Offset, typeof(FScriptArray)));}
					set{ CheckIsValid();Marshal.StructureToPtr(value.InterArray, _this.Get()+ParamNames__Offset, false);}
			
		}
		
		static readonly int DefaultValue__Offset;
		public FLinearColor DefaultValue
		{
			get{ CheckIsValid();return (FLinearColor)Marshal.PtrToStructure(_this.Get()+DefaultValue__Offset, typeof(FLinearColor));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+DefaultValue__Offset, false);}
			
		}
		
		static UMaterialExpressionDynamicParameter()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("MaterialExpressionDynamicParameter");
			ParamNames__Offset=GetPropertyOffset(NativeClassPtr,"ParamNames");
			DefaultValue__Offset=GetPropertyOffset(NativeClassPtr,"DefaultValue");
			
		}
		
	}
	
}
#endif
#endif
