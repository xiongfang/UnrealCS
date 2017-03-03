#if WITH_GAME
#if PLATFORM_32BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	[StructLayout(LayoutKind.Explicit,Size=40)]
	public partial struct FFormatArgumentData
	{
		[FieldOffset(0)]
		public FString ArgumentName;
		[FieldOffset(12)]
		public EFormatArgumentType ArgumentValueType;
		[FieldOffset(16)]
		public FText ArgumentValue;
		[FieldOffset(28)]
		public int ArgumentValueInt;
		[FieldOffset(32)]
		public float ArgumentValueFloat;
		
	}
	
}
#endif
#endif
