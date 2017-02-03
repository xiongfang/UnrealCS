#if WITH_GAME
#if PLATFORM_32BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class UMaterialExpressionConstant2Vector
	{
		static readonly int R__Offset;
		public float R
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+R__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+R__Offset, false);}
			
		}
		
		static readonly int G__Offset;
		public float G
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+G__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+G__Offset, false);}
			
		}
		
		static UMaterialExpressionConstant2Vector()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("MaterialExpressionConstant2Vector");
			R__Offset=GetPropertyOffset(NativeClassPtr,"R");
			G__Offset=GetPropertyOffset(NativeClassPtr,"G");
			
		}
		
	}
	
}
#endif
#endif
