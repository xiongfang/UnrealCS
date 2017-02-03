#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>
	/// FVector_NetQuantizeNormal
	/// 16 bits per component
	/// Valid range: -1..+1 inclusive
	/// </summary>
	[StructLayout(LayoutKind.Explicit,Size=12)]
	public partial struct FVector_NetQuantizeNormal
	{
		[FieldOffset(0)]
		public float X;
		[FieldOffset(4)]
		public float Y;
		[FieldOffset(8)]
		public float Z;
		
	}
	
}
#endif
#endif
