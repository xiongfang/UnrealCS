#if WITH_GAME
#if PLATFORM_32BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class UCheckBoxStyleAsset
	{
		static readonly int CheckBoxStyle__Offset;
		public FCheckBoxStyle CheckBoxStyle
		{
			get{ CheckIsValid();return (FCheckBoxStyle)Marshal.PtrToStructure(_this.Get()+CheckBoxStyle__Offset, typeof(FCheckBoxStyle));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+CheckBoxStyle__Offset, false);}
			
		}
		
		static UCheckBoxStyleAsset()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("CheckBoxStyleAsset");
			CheckBoxStyle__Offset=GetPropertyOffset(NativeClassPtr,"CheckBoxStyle");
			
		}
		
	}
	
}
#endif
#endif
