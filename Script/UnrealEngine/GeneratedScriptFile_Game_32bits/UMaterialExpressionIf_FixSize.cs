#if WITH_GAME
#if PLATFORM_32BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class UMaterialExpressionIf
	{
		static readonly int A__Offset;
		public FExpressionInput A
		{
			get{ CheckIsValid();return (FExpressionInput)Marshal.PtrToStructure(_this.Get()+A__Offset, typeof(FExpressionInput));}
			
		}
		
		static readonly int B__Offset;
		public FExpressionInput B
		{
			get{ CheckIsValid();return (FExpressionInput)Marshal.PtrToStructure(_this.Get()+B__Offset, typeof(FExpressionInput));}
			
		}
		
		static readonly int AGreaterThanB__Offset;
		public FExpressionInput AGreaterThanB
		{
			get{ CheckIsValid();return (FExpressionInput)Marshal.PtrToStructure(_this.Get()+AGreaterThanB__Offset, typeof(FExpressionInput));}
			
		}
		
		static readonly int AEqualsB__Offset;
		public FExpressionInput AEqualsB
		{
			get{ CheckIsValid();return (FExpressionInput)Marshal.PtrToStructure(_this.Get()+AEqualsB__Offset, typeof(FExpressionInput));}
			
		}
		
		static readonly int ALessThanB__Offset;
		public FExpressionInput ALessThanB
		{
			get{ CheckIsValid();return (FExpressionInput)Marshal.PtrToStructure(_this.Get()+ALessThanB__Offset, typeof(FExpressionInput));}
			
		}
		
		static readonly int EqualsThreshold__Offset;
		public float EqualsThreshold
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+EqualsThreshold__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+EqualsThreshold__Offset, false);}
			
		}
		
		static readonly int ConstB__Offset;
		public float ConstB
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+ConstB__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+ConstB__Offset, false);}
			
		}
		
		static readonly int ConstAEqualsB__Offset;
		public float ConstAEqualsB
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+ConstAEqualsB__Offset, typeof(float));}
			
		}
		
		static UMaterialExpressionIf()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("MaterialExpressionIf");
			A__Offset=GetPropertyOffset(NativeClassPtr,"A");
			B__Offset=GetPropertyOffset(NativeClassPtr,"B");
			AGreaterThanB__Offset=GetPropertyOffset(NativeClassPtr,"AGreaterThanB");
			AEqualsB__Offset=GetPropertyOffset(NativeClassPtr,"AEqualsB");
			ALessThanB__Offset=GetPropertyOffset(NativeClassPtr,"ALessThanB");
			EqualsThreshold__Offset=GetPropertyOffset(NativeClassPtr,"EqualsThreshold");
			ConstB__Offset=GetPropertyOffset(NativeClassPtr,"ConstB");
			ConstAEqualsB__Offset=GetPropertyOffset(NativeClassPtr,"ConstAEqualsB");
			
		}
		
	}
	
}
#endif
#endif
