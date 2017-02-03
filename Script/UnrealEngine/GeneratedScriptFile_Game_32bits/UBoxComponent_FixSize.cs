#if WITH_GAME
#if PLATFORM_32BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class UBoxComponent
	{
		static readonly int BoxExtent__Offset;
		public FVector BoxExtent
		{
			get{ CheckIsValid();return (FVector)Marshal.PtrToStructure(_this.Get()+BoxExtent__Offset, typeof(FVector));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+BoxExtent__Offset, false);}
			
		}
		
		static UBoxComponent()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("BoxComponent");
			BoxExtent__Offset=GetPropertyOffset(NativeClassPtr,"BoxExtent");
			
		}
		
	}
	
}
#endif
#endif
