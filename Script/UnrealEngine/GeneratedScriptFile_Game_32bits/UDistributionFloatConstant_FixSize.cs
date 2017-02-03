#if WITH_GAME
#if PLATFORM_32BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class UDistributionFloatConstant
	{
		static readonly int Constant__Offset;
		public float Constant
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+Constant__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+Constant__Offset, false);}
			
		}
		
		static UDistributionFloatConstant()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("DistributionFloatConstant");
			Constant__Offset=GetPropertyOffset(NativeClassPtr,"Constant");
			
		}
		
	}
	
}
#endif
#endif
