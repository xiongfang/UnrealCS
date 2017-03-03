#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	[StructLayout(LayoutKind.Explicit,Size=64)]
	public partial struct FDelegateRuntimeBinding
	{
		/// <summary>The widget that will be bound to the live data.</summary>
		[FieldOffset(0)]
		public FString ObjectName;
		/// <summary>The property on the widget that will have a binding placed on it.</summary>
		[FieldOffset(16)]
		public FName PropertyName;
		/// <summary>The function or property we're binding to on the source object.</summary>
		[FieldOffset(28)]
		public FName FunctionName;
		[FieldOffset(40)]
		public FDynamicPropertyPath SourcePath;
		
	}
	
}
#endif
#endif
