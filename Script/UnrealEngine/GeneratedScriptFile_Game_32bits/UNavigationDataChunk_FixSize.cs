#if WITH_GAME
#if PLATFORM_32BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class UNavigationDataChunk
	{
		static readonly int NavigationDataName__Offset;
		public FName NavigationDataName
		{
			get{ CheckIsValid();return (FName)Marshal.PtrToStructure(_this.Get()+NavigationDataName__Offset, typeof(FName));}
			
		}
		
		static UNavigationDataChunk()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("NavigationDataChunk");
			NavigationDataName__Offset=GetPropertyOffset(NativeClassPtr,"NavigationDataName");
			
		}
		
	}
	
}
#endif
#endif
