#if WITH_GAME
#if PLATFORM_32BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class UUserDefinedEnum
	{
		static readonly int DisplayNames__Offset;
		public TStructArray<FText> DisplayNames
		{
			get{ CheckIsValid();return new TStructArray<FText>((FScriptArray)Marshal.PtrToStructure(_this.Get()+DisplayNames__Offset, typeof(FScriptArray)));}
					set{ CheckIsValid();Marshal.StructureToPtr(value.InterArray, _this.Get()+DisplayNames__Offset, false);}
			
		}
		
		static UUserDefinedEnum()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("UserDefinedEnum");
			DisplayNames__Offset=GetPropertyOffset(NativeClassPtr,"DisplayNames");
			
		}
		
	}
	
}
#endif
#endif
