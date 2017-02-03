#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>
	/// Defines a mapping between an axis and key
	/// @see https://docs.unrealengine.com/latest/INT/Gameplay/Input/index.html
	/// </summary>
	[StructLayout(LayoutKind.Explicit,Size=56)]
	public partial struct FInputAxisKeyMapping
	{
		/// <summary>Friendly name of axis, e.g "MoveForward"</summary>
		[FieldOffset(0)]
		public FName AxisName;
		/// <summary>Key to bind it to.</summary>
		[FieldOffset(16)]
		public FKey Key;
		/// <summary>Multiplier to use for the mapping when accumulating the axis value</summary>
		[FieldOffset(48)]
		public float Scale;
		
	}
	
}
#endif
#endif
