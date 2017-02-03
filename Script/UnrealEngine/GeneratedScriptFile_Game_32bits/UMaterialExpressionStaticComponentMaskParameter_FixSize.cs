#if WITH_GAME
#if PLATFORM_32BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class UMaterialExpressionStaticComponentMaskParameter
	{
		static readonly int Input__Offset;
		public FExpressionInput Input
		{
			get{ CheckIsValid();return (FExpressionInput)Marshal.PtrToStructure(_this.Get()+Input__Offset, typeof(FExpressionInput));}
			
		}
		
		static readonly int DefaultR__Offset;
		public bool DefaultR
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), DefaultR__Offset, 1, 0, 1, 1);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), DefaultR__Offset, 1,0,1,1);}
			
		}
		
		static readonly int DefaultG__Offset;
		public bool DefaultG
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), DefaultG__Offset, 1, 0, 2, 2);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), DefaultG__Offset, 1,0,2,2);}
			
		}
		
		static readonly int DefaultB__Offset;
		public bool DefaultB
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), DefaultB__Offset, 1, 0, 4, 4);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), DefaultB__Offset, 1,0,4,4);}
			
		}
		
		static readonly int DefaultA__Offset;
		public bool DefaultA
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), DefaultA__Offset, 1, 0, 8, 8);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), DefaultA__Offset, 1,0,8,8);}
			
		}
		
		static UMaterialExpressionStaticComponentMaskParameter()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("MaterialExpressionStaticComponentMaskParameter");
			Input__Offset=GetPropertyOffset(NativeClassPtr,"Input");
			DefaultR__Offset=GetPropertyOffset(NativeClassPtr,"DefaultR");
			DefaultG__Offset=GetPropertyOffset(NativeClassPtr,"DefaultG");
			DefaultB__Offset=GetPropertyOffset(NativeClassPtr,"DefaultB");
			DefaultA__Offset=GetPropertyOffset(NativeClassPtr,"DefaultA");
			
		}
		
	}
	
}
#endif
#endif
