#if WITH_GAME
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	[StructLayout(LayoutKind.Explicit,Size=32)]
	public partial struct FTextureParameterValue
	{
		[FieldOffset(0)]
		public FName ParameterName;
		[FieldOffset(16)]
		public FGuid ExpressionGUID;
		
	}
	
}
#endif
#endif
