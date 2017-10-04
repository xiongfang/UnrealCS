using System;
namespace UnrealEngine
{
	/// <summary>
	/// Structure that holds info about spline, passed to renderer to deform UStaticMesh.
	/// Also used by Lightmass, so be sure to update Lightmass::FSplineMeshParams and the static lighting code if this changes!
	/// </summary>
	public partial struct FSplineMeshParams
	{
		/// <summary>Start location of spline, in component space.</summary>
		public FVector StartPos;
		/// <summary>Start tangent of spline, in component space.</summary>
		public FVector StartTangent;
		/// <summary>X and Y scale applied to mesh at start of spline.</summary>
		public FVector2D StartScale;
		/// <summary>Roll around spline applied at start</summary>
		public float StartRoll;
		/// <summary>Starting offset of the mesh from the spline, in component space.</summary>
		public FVector2D StartOffset;
		/// <summary>End location of spline, in component space.</summary>
		public FVector EndPos;
		/// <summary>End tangent of spline, in component space.</summary>
		public FVector EndTangent;
		/// <summary>X and Y scale applied to mesh at end of spline.</summary>
		public FVector2D EndScale;
		/// <summary>Roll around spline applied at end.</summary>
		public float EndRoll;
		/// <summary>Ending offset of the mesh from the spline, in component space.</summary>
		public FVector2D EndOffset;
		
	}
	
}
