#if WITH_GAME
#if PLATFORM_32BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	[StructLayout(LayoutKind.Explicit,Size=24)]
	public partial struct FBlueprintComponentDelegateBinding
	{
		[FieldOffset(0)]
		public FName ComponentPropertyName;
		[FieldOffset(8)]
		public FName DelegatePropertyName;
		[FieldOffset(16)]
		public FName FunctionNameToBind;
		
	}
	
}
#endif
#endif
