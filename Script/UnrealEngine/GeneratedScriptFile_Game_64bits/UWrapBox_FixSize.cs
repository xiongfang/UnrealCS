#if WITH_GAME
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class UWrapBox
	{
		static readonly int InnerSlotPadding__Offset;
		public FVector2D InnerSlotPadding
		{
			get{ CheckIsValid();return (FVector2D)Marshal.PtrToStructure(_this.Get()+InnerSlotPadding__Offset, typeof(FVector2D));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+InnerSlotPadding__Offset, false);}
			
		}
		
		static UWrapBox()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("WrapBox");
			InnerSlotPadding__Offset=GetPropertyOffset(NativeClassPtr,"InnerSlotPadding");
			
		}
		
	}
	
}
#endif
#endif
