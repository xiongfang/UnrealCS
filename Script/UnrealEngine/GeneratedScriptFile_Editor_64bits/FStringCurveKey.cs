#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>One key in a curve of FStrings.</summary>
	[StructLayout(LayoutKind.Explicit,Size=24)]
	public partial struct FStringCurveKey
	{
		/// <summary>Time at this key</summary>
		[FieldOffset(0)]
		public float Time;
		/// <summary>Value at this key</summary>
		[FieldOffset(8)]
		public FString Value;
		
	}
	
}
#endif
#endif
