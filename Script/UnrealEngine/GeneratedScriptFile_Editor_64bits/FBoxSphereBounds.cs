#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>
	/// A bounding box and bounding sphere with the same origin.
	/// The full C++ class is located here : Engine\Source\Runtime\Core\Public\Math\BoxSphereBounds.h
	/// </summary>
	[StructLayout(LayoutKind.Explicit,Size=28)]
	public partial struct FBoxSphereBounds
	{
		[FieldOffset(0)]
		public FVector Origin;
		[FieldOffset(12)]
		public FVector BoxExtent;
		[FieldOffset(24)]
		public float SphereRadius;
		
	}
	
}
#endif
#endif
