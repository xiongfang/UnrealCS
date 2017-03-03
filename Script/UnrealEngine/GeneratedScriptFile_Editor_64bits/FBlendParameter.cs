#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	[StructLayout(LayoutKind.Explicit,Size=32)]
	public partial struct FBlendParameter
	{
		[FieldOffset(0)]
		public FString DisplayName;
		/// <summary>Min value for this parameter.</summary>
		[FieldOffset(16)]
		public float Min;
		/// <summary>Max value for this parameter.</summary>
		[FieldOffset(20)]
		public float Max;
		/// <summary>The number of grid divisions for this parameter (axis).</summary>
		[FieldOffset(24)]
		public int GridNum;
		
	}
	
}
#endif
#endif
