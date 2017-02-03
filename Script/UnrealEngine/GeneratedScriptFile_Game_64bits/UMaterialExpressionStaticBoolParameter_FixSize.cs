#if WITH_GAME
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class UMaterialExpressionStaticBoolParameter
	{
		static readonly int DefaultValue__Offset;
		public bool DefaultValue
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), DefaultValue__Offset, 1, 0, 1, 1);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), DefaultValue__Offset, 1,0,1,1);}
			
		}
		
		static UMaterialExpressionStaticBoolParameter()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("MaterialExpressionStaticBoolParameter");
			DefaultValue__Offset=GetPropertyOffset(NativeClassPtr,"DefaultValue");
			
		}
		
	}
	
}
#endif
#endif
