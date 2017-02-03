#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>One key in a curve of FNames.</summary>
	[StructLayout(LayoutKind.Explicit,Size=16)]
	public partial struct FNameCurveKey
	{
		/// <summary>Time at this key</summary>
		[FieldOffset(0)]
		public float Time;
		/// <summary>Value at this key</summary>
		[FieldOffset(4)]
		public FName Value;
		
	}
	
}
#endif
#endif
