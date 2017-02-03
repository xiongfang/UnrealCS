#if WITH_GAME
#if PLATFORM_32BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class APlayerStart
	{
		static readonly int PlayerStartTag__Offset;
		public FName PlayerStartTag
		{
			get{ CheckIsValid();return (FName)Marshal.PtrToStructure(_this.Get()+PlayerStartTag__Offset, typeof(FName));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+PlayerStartTag__Offset, false);}
			
		}
		
		static APlayerStart()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("PlayerStart");
			PlayerStartTag__Offset=GetPropertyOffset(NativeClassPtr,"PlayerStartTag");
			
		}
		
	}
	
}
#endif
#endif
