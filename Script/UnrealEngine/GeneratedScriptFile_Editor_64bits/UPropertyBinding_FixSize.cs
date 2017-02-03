#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class UPropertyBinding
	{
		static readonly int SourcePath__Offset;
		/// <summary>The property path to trace to resolve this binding on the Source Object</summary>
		public FDynamicPropertyPath SourcePath
		{
			get{ CheckIsValid();return (FDynamicPropertyPath)Marshal.PtrToStructure(_this.Get()+SourcePath__Offset, typeof(FDynamicPropertyPath));}
			
		}
		
		static readonly int DestinationProperty__Offset;
		/// <summary>Used to determine if a binding already exists on the object and if this binding can be safely removed.</summary>
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
