#if WITH_GAME
#if PLATFORM_32BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	[StructLayout(LayoutKind.Explicit,Size=40)]
	public partial struct FCollectionVectorParameter
	{
		[FieldOffset(24)]
		public FLinearColor DefaultValue;
		[FieldOffset(0)]
		public FName ParameterName;
		[FieldOffset(8)]
		public FGuid ID;
		
	}
	
}
#endif
#endif
