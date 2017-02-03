#if WITH_GAME
#if PLATFORM_32BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class UMaterialExpressionMaterialFunctionCall
	{
		static readonly int MaterialFunction__Offset;
		public UMaterialFunction MaterialFunction
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + MaterialFunction__Offset); if (v == IntPtr.Zero)return null; UMaterialFunction retValue = new UMaterialFunction(); retValue._this = v; return retValue; }
			set{ CheckIsValid(); if (value == null)Marshal.WriteIntPtr(_this.Get() + MaterialFunction__Offset, IntPtr.Zero);else Marshal.WriteIntPtr(_this.Get() + MaterialFunction__Offset, value._this.Get()); }
			
		}
		
		static readonly int FunctionInputs__Offset;
		public TStructArray<FFunctionExpressionInput> FunctionInputs
		{
			get{ CheckIsValid();return new TStructArray<FFunctionExpressionInput>((FScriptArray)Marshal.PtrToStructure(_this.Get()+FunctionInputs__Offset, typeof(FScriptArray)));}
					set{ CheckIsValid();Marshal.StructureToPtr(value.InterArray, _this.Get()+FunctionInputs__Offset, false);}
			
		}
		
		static readonly int FunctionOutputs__Offset;
		public TStructArray<FFunctionExpressionOutput> FunctionOutputs
		{
			get{ CheckIsValid();return new TStructArray<FFunctionExpressionOutput>((FScriptArray)Marshal.PtrToStructure(_this.Get()+FunctionOutputs__Offset, typeof(FScriptArray)));}
					set{ CheckIsValid();Marshal.StructureToPtr(value.InterArray, _this.Get()+FunctionOutputs__Offset, false);}
			
		}
		
		static UMaterialExpressionMaterialFunctionCall()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("MaterialExpressionMaterialFunctionCall");
			MaterialFunction__Offset=GetPropertyOffset(NativeClassPtr,"MaterialFunction");
			FunctionInputs__Offset=GetPropertyOffset(NativeClassPtr,"FunctionInputs");
			FunctionOutputs__Offset=GetPropertyOffset(NativeClassPtr,"FunctionOutputs");
			
		}
		
	}
	
}
#endif
#endif
