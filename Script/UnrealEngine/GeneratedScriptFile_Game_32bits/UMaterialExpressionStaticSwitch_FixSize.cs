#if WITH_GAME
#if PLATFORM_32BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class UMaterialExpressionStaticSwitch
	{
		static readonly int DefaultValue__Offset;
		public bool DefaultValue
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), DefaultValue__Offset, 1, 0, 1, 1);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), DefaultValue__Offset, 1,0,1,1);}
			
		}
		
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
		
		static readonly int Value__Offset;
		public FExpressionInput Value
		{
			get{ CheckIsValid();return (FExpressionInput)Marshal.PtrToStructure(_this.Get()+Value__Offset, typeof(FExpressionInput));}
			
		}
		
		static UMaterialExpressionStaticSwitch()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("MaterialExpressionStaticSwitch");
			DefaultValue__Offset=GetPropertyOffset(NativeClassPtr,"DefaultValue");
			A__Offset=GetPropertyOffset(NativeClassPtr,"A");
			B__Offset=GetPropertyOffset(NativeClassPtr,"B");
			Value__Offset=GetPropertyOffset(NativeClassPtr,"Value");
			
		}
		
	}
	
}
#endif
#endif
