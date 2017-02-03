#if WITH_GAME
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class UMaterialExpressionPower
	{
		static readonly int Base__Offset;
		public FExpressionInput Base
		{
			get{ CheckIsValid();return (FExpressionInput)Marshal.PtrToStructure(_this.Get()+Base__Offset, typeof(FExpressionInput));}
			
		}
		
		static readonly int Exponent__Offset;
		public FExpressionInput Exponent
		{
			get{ CheckIsValid();return (FExpressionInput)Marshal.PtrToStructure(_this.Get()+Exponent__Offset, typeof(FExpressionInput));}
			
		}
		
		static readonly int ConstExponent__Offset;
		public float ConstExponent
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+ConstExponent__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+ConstExponent__Offset, false);}
			
		}
		
		static UMaterialExpressionPower()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("MaterialExpressionPower");
			Base__Offset=GetPropertyOffset(NativeClassPtr,"Base");
			Exponent__Offset=GetPropertyOffset(NativeClassPtr,"Exponent");
			ConstExponent__Offset=GetPropertyOffset(NativeClassPtr,"ConstExponent");
			
		}
		
	}
	
}
#endif
#endif
