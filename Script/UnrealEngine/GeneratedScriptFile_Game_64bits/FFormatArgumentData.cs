#if WITH_GAME
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	[StructLayout(LayoutKind.Explicit,Size=64)]
	public partial struct FFormatArgumentData
	{
		[FieldOffset(0)]
		public FString ArgumentName;
		[FieldOffset(16)]
		public EFormatArgumentType ArgumentValueType;
		[FieldOffset(24)]
		public FText ArgumentValue;
		[FieldOffset(48)]
		public int ArgumentValueInt;
		[FieldOffset(52)]
		public float ArgumentValueFloat;
		
	}
	
}
#endif
#endif
