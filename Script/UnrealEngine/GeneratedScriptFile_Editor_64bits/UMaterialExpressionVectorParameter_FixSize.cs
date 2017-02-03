#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class UMaterialExpressionVectorParameter
	{
		static readonly int DefaultValue__Offset;
		public FLinearColor DefaultValue
		{
			get{ CheckIsValid();return (FLinearColor)Marshal.PtrToStructure(_this.Get()+DefaultValue__Offset, typeof(FLinearColor));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+DefaultValue__Offset, false);}
			
		}
		
		static UMaterialExpressionVectorParameter()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("MaterialExpressionVectorParameter");
			DefaultValue__Offset=GetPropertyOffset(NativeClassPtr,"DefaultValue");
			
		}
		
	}
	
}
#endif
#endif
