#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	[StructLayout(LayoutKind.Explicit,Size=40)]
	public partial struct FComponentKey
	{
		[FieldOffset(8)]
		public FName SCSVariableName;
		[FieldOffset(20)]
		public FGuid AssociatedGuid;
		
	}
	
}
#endif
#endif
