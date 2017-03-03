#if WITH_GAME
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	[StructLayout(LayoutKind.Explicit,Size=56)]
	public partial struct FDelegateRuntimeBinding
	{
		[FieldOffset(0)]
		public FString ObjectName;
		[FieldOffset(16)]
		public FName PropertyName;
		[FieldOffset(24)]
		public FName FunctionName;
		[FieldOffset(32)]
		public FDynamicPropertyPath SourcePath;
		
	}
	
}
#endif
#endif
