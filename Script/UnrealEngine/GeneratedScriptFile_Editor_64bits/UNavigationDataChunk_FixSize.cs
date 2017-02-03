#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class UNavigationDataChunk
	{
		static readonly int NavigationDataName__Offset;
		/// <summary>Name of NavigationData actor that owns this chunk</summary>
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
