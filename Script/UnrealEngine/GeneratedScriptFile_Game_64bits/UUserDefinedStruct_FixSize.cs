#if WITH_GAME
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class UUserDefinedStruct
	{
		static readonly int Guid__Offset;
		public FGuid Guid
		{
			get{ CheckIsValid();return (FGuid)Marshal.PtrToStructure(_this.Get()+Guid__Offset, typeof(FGuid));}
			
		}
		
		static UUserDefinedStruct()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("UserDefinedStruct");
			Guid__Offset=GetPropertyOffset(NativeClassPtr,"Guid");
			
		}
		
	}
	
}
#endif
#endif
