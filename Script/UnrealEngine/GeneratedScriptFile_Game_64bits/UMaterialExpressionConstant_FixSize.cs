#if WITH_GAME
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class UMaterialExpressionConstant
	{
		static readonly int R__Offset;
		public float R
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+R__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+R__Offset, false);}
			
		}
		
		static UMaterialExpressionConstant()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("MaterialExpressionConstant");
			R__Offset=GetPropertyOffset(NativeClassPtr,"R");
			
		}
		
	}
	
}
#endif
#endif
