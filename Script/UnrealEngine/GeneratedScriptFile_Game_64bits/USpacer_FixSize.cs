#if WITH_GAME
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class USpacer
	{
		static readonly int Size__Offset;
		public FVector2D Size
		{
			get{ CheckIsValid();return (FVector2D)Marshal.PtrToStructure(_this.Get()+Size__Offset, typeof(FVector2D));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+Size__Offset, false);}
			
		}
		
		static USpacer()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("Spacer");
			Size__Offset=GetPropertyOffset(NativeClassPtr,"Size");
			
		}
		
	}
	
}
#endif
#endif
