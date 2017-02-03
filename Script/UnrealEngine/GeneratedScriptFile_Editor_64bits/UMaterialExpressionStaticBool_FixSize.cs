#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class UMaterialExpressionStaticBool
	{
		static readonly int Value__Offset;
		public bool Value
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), Value__Offset, 1, 0, 1, 1);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), Value__Offset, 1,0,1,1);}
			
		}
		
		static UMaterialExpressionStaticBool()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("MaterialExpressionStaticBool");
			Value__Offset=GetPropertyOffset(NativeClassPtr,"Value");
			
		}
		
	}
	
}
#endif
#endif
