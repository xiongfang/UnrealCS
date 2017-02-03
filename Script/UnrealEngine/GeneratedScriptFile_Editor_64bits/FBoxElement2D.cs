#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>Box shape used for collision</summary>
	[StructLayout(LayoutKind.Explicit,Size=20)]
	public partial struct FBoxElement2D
	{
		/// <summary>Center of the box</summary>
		[FieldOffset(0)]
		public FVector2D Center;
		/// <summary>Width of the box</summary>
		[FieldOffset(8)]
		public float Width;
		/// <summary>Height of the box</summary>
		[FieldOffset(12)]
		public float Height;
		/// <summary>Rotation of the box (in degrees)</summary>
		[FieldOffset(16)]
		public float Angle;
		
	}
	
}
#endif
#endif
