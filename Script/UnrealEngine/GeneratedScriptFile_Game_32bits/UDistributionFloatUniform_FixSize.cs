#if WITH_GAME
#if PLATFORM_32BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class UDistributionFloatUniform
	{
		static readonly int Min__Offset;
		public float Min
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+Min__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+Min__Offset, false);}
			
		}
		
		static readonly int Max__Offset;
		public float Max
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+Max__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+Max__Offset, false);}
			
		}
		
		static UDistributionFloatUniform()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("DistributionFloatUniform");
			Min__Offset=GetPropertyOffset(NativeClassPtr,"Min");
			Max__Offset=GetPropertyOffset(NativeClassPtr,"Max");
			
		}
		
	}
	
}
#endif
#endif
