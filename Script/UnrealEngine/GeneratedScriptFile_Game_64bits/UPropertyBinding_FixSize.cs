#if WITH_GAME
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class UPropertyBinding
	{
		static readonly int SourcePath__Offset;
		public FDynamicPropertyPath SourcePath
		{
			get{ CheckIsValid();return (FDynamicPropertyPath)Marshal.PtrToStructure(_this.Get()+SourcePath__Offset, typeof(FDynamicPropertyPath));}
			
		}
		
		static readonly int DestinationProperty__Offset;
		public FName DestinationProperty
		{
			get{ CheckIsValid();return (FName)Marshal.PtrToStructure(_this.Get()+DestinationProperty__Offset, typeof(FName));}
			
		}
		
		static UPropertyBinding()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("PropertyBinding");
			SourcePath__Offset=GetPropertyOffset(NativeClassPtr,"SourcePath");
			DestinationProperty__Offset=GetPropertyOffset(NativeClassPtr,"DestinationProperty");
			
		}
		
	}
	
}
#endif
#endif
