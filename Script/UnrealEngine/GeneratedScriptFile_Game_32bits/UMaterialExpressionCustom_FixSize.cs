#if WITH_GAME
#if PLATFORM_32BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class UMaterialExpressionCustom
	{
		static readonly int Code__Offset;
		public FString Code
		{
			get{ CheckIsValid();return (FString)Marshal.PtrToStructure(_this.Get()+Code__Offset, typeof(FString));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+Code__Offset, false);}
			
		}
		
		static readonly int OutputType__Offset;
		public ECustomMaterialOutputType OutputType
		{
			get{ CheckIsValid();return (ECustomMaterialOutputType)Marshal.PtrToStructure(_this.Get()+OutputType__Offset, typeof(ECustomMaterialOutputType));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+OutputType__Offset, false);}
			
		}
		
		static readonly int Description__Offset;
		public FString Description
		{
			get{ CheckIsValid();return (FString)Marshal.PtrToStructure(_this.Get()+Description__Offset, typeof(FString));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+Description__Offset, false);}
			
		}
		
		static readonly int Inputs__Offset;
		public TStructArray<FCustomInput> Inputs
		{
			get{ CheckIsValid();return new TStructArray<FCustomInput>((FScriptArray)Marshal.PtrToStructure(_this.Get()+Inputs__Offset, typeof(FScriptArray)));}
					set{ CheckIsValid();Marshal.StructureToPtr(value.InterArray, _this.Get()+Inputs__Offset, false);}
			
		}
		
		static UMaterialExpressionCustom()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("MaterialExpressionCustom");
			Code__Offset=GetPropertyOffset(NativeClassPtr,"Code");
			OutputType__Offset=GetPropertyOffset(NativeClassPtr,"OutputType");
			Description__Offset=GetPropertyOffset(NativeClassPtr,"Description");
			Inputs__Offset=GetPropertyOffset(NativeClassPtr,"Inputs");
			
		}
		
	}
	
}
#endif
#endif
