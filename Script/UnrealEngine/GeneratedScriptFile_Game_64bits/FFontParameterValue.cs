#if WITH_GAME
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	[StructLayout(LayoutKind.Explicit,Size=40)]
	public partial struct FFontParameterValue
	{
		[FieldOffset(0)]
		public FName ParameterName;
		[FieldOffset(16)]
		public int FontPage;
		[FieldOffset(20)]
		public FGuid ExpressionGUID;
		
	}
	
}
#endif
#endif
