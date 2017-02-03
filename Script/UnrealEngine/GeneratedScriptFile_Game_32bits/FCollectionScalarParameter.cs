#if WITH_GAME
#if PLATFORM_32BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	[StructLayout(LayoutKind.Explicit,Size=28)]
	public partial struct FCollectionScalarParameter
	{
		[FieldOffset(24)]
		public float DefaultValue;
		[FieldOffset(0)]
		public FName ParameterName;
		[FieldOffset(8)]
		public FGuid ID;
		
	}
	
}
#endif
#endif
