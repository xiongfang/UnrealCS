#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>
	/// Represents the position, size, and absolute position of a Widget in Slate.
	/// The absolute location of a geometry is usually screen space or
	/// window space depending on where the geometry originated.
	/// Geometries are usually paired with a SWidget pointer in order
	/// to provide information about a specific widget (see FArrangedWidget).
	/// A Geometry's parent is generally thought to be the Geometry of the
	/// the corresponding parent widget.
	/// </summary>
	[StructLayout(LayoutKind.Explicit,Size=52)]
	public partial struct FGeometry
	{
		
	}
	
}
#endif
#endif
