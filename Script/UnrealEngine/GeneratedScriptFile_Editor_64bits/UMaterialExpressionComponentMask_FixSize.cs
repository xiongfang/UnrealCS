#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class UMaterialExpressionComponentMask
	{
		static readonly int Input__Offset;
		public FExpressionInput Input
		{
			get{ CheckIsValid();return (FExpressionInput)Marshal.PtrToStructure(_this.Get()+Input__Offset, typeof(FExpressionInput));}
			
		}
		
		static readonly int R__Offset;
		public bool R
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), R__Offset, 1, 0, 1, 1);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), R__Offset, 1,0,1,1);}
			
		}
		
		static readonly int G__Offset;
		public bool G
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), G__Offset, 1, 0, 2, 2);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), G__Offset, 1,0,2,2);}
			
		}
		
		static readonly int B__Offset;
		public bool B
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), B__Offset, 1, 0, 4, 4);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), B__Offset, 1,0,4,4);}
			
		}
		
		static readonly int A__Offset;
		public bool A
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), A__Offset, 1, 0, 8, 8);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), A__Offset, 1,0,8,8);}
			
		}
		
		static UMaterialExpressionComponentMask()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("MaterialExpressionComponentMask");
			Input__Offset=GetPropertyOffset(NativeClassPtr,"Input");
			R__Offset=GetPropertyOffset(NativeClassPtr,"R");
			G__Offset=GetPropertyOffset(NativeClassPtr,"G");
			B__Offset=GetPropertyOffset(NativeClassPtr,"B");
			A__Offset=GetPropertyOffset(NativeClassPtr,"A");
			
		}
		
	}
	
}
#endif
#endif
