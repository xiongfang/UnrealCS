#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class UMaterialExpressionFontSampleParameter
	{
		static readonly int ParameterName__Offset;
		/// <summary>name to be referenced when we want to find and set thsi parameter</summary>
		public FName ParameterName
		{
			get{ CheckIsValid();return (FName)Marshal.PtrToStructure(_this.Get()+ParameterName__Offset, typeof(FName));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+ParameterName__Offset, false);}
			
		}
		
		static readonly int ExpressionGUID__Offset;
		/// <summary>GUID that should be unique within the material, this is used for parameter renaming.</summary>
		public FGuid ExpressionGUID
		{
			get{ CheckIsValid();return (FGuid)Marshal.PtrToStructure(_this.Get()+ExpressionGUID__Offset, typeof(FGuid));}
			
		}
		
		static readonly int Group__Offset;
		/// <summary>The name of the parameter Group to display in MaterialInstance Editor. Default is None group</summary>
		public FName Group
		{
			get{ CheckIsValid();return (FName)Marshal.PtrToStructure(_this.Get()+Group__Offset, typeof(FName));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+Group__Offset, false);}
			
		}
		
		static UMaterialExpressionFontSampleParameter()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("MaterialExpressionFontSampleParameter");
			ParameterName__Offset=GetPropertyOffset(NativeClassPtr,"ParameterName");
			ExpressionGUID__Offset=GetPropertyOffset(NativeClassPtr,"ExpressionGUID");
			Group__Offset=GetPropertyOffset(NativeClassPtr,"Group");
			
		}
		
	}
	
}
#endif
#endif
