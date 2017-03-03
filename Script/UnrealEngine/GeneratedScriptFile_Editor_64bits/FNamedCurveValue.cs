#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>Name/value pair for retrieving curve values</summary>
	[StructLayout(LayoutKind.Explicit,Size=16)]
	public partial struct FNamedCurveValue
	{
		/// <summary>The name of the curve</summary>
		[FieldOffset(0)]
		public FName Name;
		/// <summary>The value of the curve</summary>
		[FieldOffset(12)]
		public float Value;
		
	}
	
}
#endif
#endif
