#if WITH_GAME
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class UMaterialFunction
	{
		static readonly int StateId__Offset;
		public FGuid StateId
		{
			get{ CheckIsValid();return (FGuid)Marshal.PtrToStructure(_this.Get()+StateId__Offset, typeof(FGuid));}
			
		}
		
		static readonly int Description__Offset;
		public FString Description
		{
			get{ CheckIsValid();return (FString)Marshal.PtrToStructure(_this.Get()+Description__Offset, typeof(FString));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+Description__Offset, false);}
			
		}
		
		static readonly int bExposeToLibrary__Offset;
		public bool bExposeToLibrary
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bExposeToLibrary__Offset, 1, 0, 1, 1);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bExposeToLibrary__Offset, 1,0,1,1);}
			
		}
		
		static readonly int FunctionExpressions__Offset;
		public TObjectArray<UMaterialExpression>  FunctionExpressions
		{
					get{ CheckIsValid();return new TObjectArray<UMaterialExpression>((FScriptArray)Marshal.PtrToStructure(_this.Get()+FunctionExpressions__Offset, typeof(FScriptArray)));}
					set{ CheckIsValid();Marshal.StructureToPtr(value.InterArray, _this.Get()+FunctionExpressions__Offset, false);}
			
		}
		
		static readonly int bReentrantFlag__Offset;
		public bool bReentrantFlag
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bReentrantFlag__Offset, 1, 0, 1, 1);}
			
		}
		
		static UMaterialFunction()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("MaterialFunction");
			StateId__Offset=GetPropertyOffset(NativeClassPtr,"StateId");
			Description__Offset=GetPropertyOffset(NativeClassPtr,"Description");
			bExposeToLibrary__Offset=GetPropertyOffset(NativeClassPtr,"bExposeToLibrary");
			FunctionExpressions__Offset=GetPropertyOffset(NativeClassPtr,"FunctionExpressions");
			bReentrantFlag__Offset=GetPropertyOffset(NativeClassPtr,"bReentrantFlag");
			
		}
		
	}
	
}
#endif
#endif
