#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>Parameters to describe the application of U,V coordinates on a particular slice within a destructible.</summary>
	[StructLayout(LayoutKind.Explicit,Size=36)]
	public partial struct FFractureMaterial
	{
		/// <summary>
		/// The UV scale (geometric distance/unit texture distance) for interior materials.
		/// Default = (100.0f,100.0f).
		/// </summary>
		[FieldOffset(0)]
		public FVector2D UVScale;
		/// <summary>
		/// A UV origin offset for interior materials.
		/// Default = (0.0f,0.0f).
		/// </summary>
		[FieldOffset(8)]
		public FVector2D UVOffset;
		/// <summary>
		/// Object-space vector specifying surface tangent direction.  If this vector is (0.0f,0.0f,0.0f), then an arbitrary direction will be chosen.
		/// Default = (0.0f,0.0f,0.0f).
		/// </summary>
		[FieldOffset(16)]
		public FVector Tangent;
		/// <summary>
		/// Angle from tangent direction for the u coordinate axis.
		/// Default = 0.0f.
		/// </summary>
		[FieldOffset(28)]
		public float UAngle;
		/// <summary>
		/// The element index to use for the newly-created triangles.
		/// If a negative index is given, a new element will be created for interior triangles.
		/// Default = -1
		/// </summary>
		[FieldOffset(32)]
		public int InteriorElementIndex;
		
	}
	
}
#endif
#endif
