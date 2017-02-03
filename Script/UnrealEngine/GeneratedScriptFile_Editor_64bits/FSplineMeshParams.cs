#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>
	/// Structure that holds info about spline, passed to renderer to deform UStaticMesh.
	/// Also used by Lightmass, so be sure to update Lightmass::FSplineMeshParams and the static lighting code if this changes!
	/// </summary>
	[StructLayout(LayoutKind.Explicit,Size=88)]
	public partial struct FSplineMeshParams
	{
		/// <summary>Start location of spline, in component space.</summary>
		[FieldOffset(0)]
		public FVector StartPos;
		/// <summary>Start tangent of spline, in component space.</summary>
		[FieldOffset(12)]
		public FVector StartTangent;
		/// <summary>X and Y scale applied to mesh at start of spline.</summary>
		[FieldOffset(24)]
		public FVector2D StartScale;
		/// <summary>Roll around spline applied at start</summary>
		[FieldOffset(32)]
		public float StartRoll;
		/// <summary>Starting offset of the mesh from the spline, in component space.</summary>
		[FieldOffset(36)]
		public FVector2D StartOffset;
		/// <summary>End location of spline, in component space.</summary>
		[FieldOffset(44)]
		public FVector EndPos;
		/// <summary>End tangent of spline, in component space.</summary>
		[FieldOffset(56)]
		public FVector EndTangent;
		/// <summary>X and Y scale applied to mesh at end of spline.</summary>
		[FieldOffset(68)]
		public FVector2D EndScale;
		/// <summary>Roll around spline applied at end.</summary>
		[FieldOffset(76)]
		public float EndRoll;
		/// <summary>Ending offset of the mesh from the spline, in component space.</summary>
		[FieldOffset(80)]
		public FVector2D EndOffset;
		
	}
	
}
#endif
#endif
