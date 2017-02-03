#if WITH_GAME
#if PLATFORM_32BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	[StructLayout(LayoutKind.Explicit,Size=16)]
	public partial struct FBlueprintComponentChangedPropertyInfo
	{
		[FieldOffset(0)]
		public FName PropertyName;
		[FieldOffset(8)]
		public int ArrayIndex;
		
	}
	
}
#endif
#endif
