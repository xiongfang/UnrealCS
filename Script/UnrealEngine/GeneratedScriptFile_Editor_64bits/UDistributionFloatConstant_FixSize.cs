#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class UDistributionFloatConstant
	{
		static readonly int Constant__Offset;
		/// <summary>This float will be returned for all values of time.</summary>
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
