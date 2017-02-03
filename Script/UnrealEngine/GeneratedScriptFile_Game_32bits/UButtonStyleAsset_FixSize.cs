#if WITH_GAME
#if PLATFORM_32BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class UButtonStyleAsset
	{
		static readonly int ButtonStyle__Offset;
		public FButtonStyle ButtonStyle
		{
			get{ CheckIsValid();return (FButtonStyle)Marshal.PtrToStructure(_this.Get()+ButtonStyle__Offset, typeof(FButtonStyle));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+ButtonStyle__Offset, false);}
			
		}
		
		static UButtonStyleAsset()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("ButtonStyleAsset");
			ButtonStyle__Offset=GetPropertyOffset(NativeClassPtr,"ButtonStyle");
			
		}
		
	}
	
}
#endif
#endif
