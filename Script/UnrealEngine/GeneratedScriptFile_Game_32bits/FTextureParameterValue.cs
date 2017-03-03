#if WITH_GAME
#if PLATFORM_32BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	[StructLayout(LayoutKind.Explicit,Size=28)]
	public partial struct FTextureParameterValue
	{
		[FieldOffset(0)]
		public FName ParameterName;
		[FieldOffset(12)]
		public FGuid ExpressionGUID;
		
	}
	
}
#endif
#endif
