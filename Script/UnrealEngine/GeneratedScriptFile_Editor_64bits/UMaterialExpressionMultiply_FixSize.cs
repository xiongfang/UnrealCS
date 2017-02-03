#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class UMaterialExpressionMultiply
	{
		static readonly int A__Offset;
		/// <summary>Defaults to 'ConstA' if not specified</summary>
		public FExpressionInput A
		{
			get{ CheckIsValid();return (FExpressionInput)Marshal.PtrToStructure(_this.Get()+A__Offset, typeof(FExpressionInput));}
			
		}
		
		static readonly int B__Offset;
		/// <summary>Defaults to 'ConstB' if not specified</summary>
		public FExpressionInput B
		{
			get{ CheckIsValid();return (FExpressionInput)Marshal.PtrToStructure(_this.Get()+B__Offset, typeof(FExpressionInput));}
			
		}
		
		static readonly int ConstA__Offset;
		/// <summary>only used if A is not hooked up</summary>
		public float ConstA
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+ConstA__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+ConstA__Offset, false);}
			
		}
		
		static readonly int ConstB__Offset;
		/// <summary>only used if B is not hooked up</summary>
		public float ConstB
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+ConstB__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+ConstB__Offset, false);}
			
		}
		
		static UMaterialExpressionMultiply()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("MaterialExpressionMultiply");
			A__Offset=GetPropertyOffset(NativeClassPtr,"A");
			B__Offset=GetPropertyOffset(NativeClassPtr,"B");
			ConstA__Offset=GetPropertyOffset(NativeClassPtr,"ConstA");
			ConstB__Offset=GetPropertyOffset(NativeClassPtr,"ConstB");
			
		}
		
	}
	
}
#endif
#endif
