#if WITH_GAME
#if PLATFORM_32BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	[StructLayout(LayoutKind.Explicit,Size=44)]
	public partial struct FDelegateRuntimeBinding
	{
		[FieldOffset(0)]
		public FString ObjectName;
		[FieldOffset(12)]
		public FName PropertyName;
		[FieldOffset(20)]
		public FName FunctionName;
		[FieldOffset(28)]
		public FDynamicPropertyPath SourcePath;
		
	}
	
}
#endif
#endif
