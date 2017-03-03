#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>DEPRECATED Pairs desired tire friction scale with tire type</summary>
	[StructLayout(LayoutKind.Explicit,Size=16)]
	public partial struct FTireFrictionScalePair
	{
		/// <summary>Tire type</summary>
		/// <summary>Friction scale for this type of tire</summary>
		[FieldOffset(8)]
		public float FrictionScale;
		
	}
	
}
#endif
#endif
