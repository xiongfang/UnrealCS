using System;
namespace UnrealEngine
{
	public partial class USplineMeshComponent:UStaticMeshComponent
	{
		/// <summary>Set the boundary max</summary>
		public extern void SetBoundaryMax(float InBoundaryMax,bool bUpdateMesh=true);
		/// <summary>Get the boundary max</summary>
		public extern float GetBoundaryMax();
		/// <summary>Set the boundary min</summary>
		public extern void SetBoundaryMin(float InBoundaryMin,bool bUpdateMesh=true);
		/// <summary>Get the boundary min</summary>
		public extern float GetBoundaryMin();
		/// <summary>Set the spline up direction</summary>
		public extern void SetSplineUpDir(FVector InSplineUpDir,bool bUpdateMesh=true);
		/// <summary>Get the spline up direction</summary>
		public extern FVector GetSplineUpDir();
		/// <summary>Set the forward axis</summary>
		public extern void SetForwardAxis(ESplineMeshAxis InForwardAxis,bool bUpdateMesh=true);
		/// <summary>Get the forward axis</summary>
		public extern ESplineMeshAxis GetForwardAxis();
		/// <summary>Set the end offset</summary>
		public extern void SetEndOffset(FVector2D EndOffset,bool bUpdateMesh=true);
		/// <summary>Get the end offset</summary>
		public extern FVector2D GetEndOffset();
		/// <summary>Set the end roll</summary>
		public extern void SetEndRoll(float EndRoll,bool bUpdateMesh=true);
		/// <summary>Get the end roll</summary>
		public extern float GetEndRoll();
		/// <summary>Set the end scaling</summary>
		public extern void SetEndScale(FVector2D EndScale=default(FVector2D),bool bUpdateMesh=true);
		/// <summary>Get the end scaling</summary>
		public extern FVector2D GetEndScale();
		/// <summary>Set the start offset</summary>
		public extern void SetStartOffset(FVector2D StartOffset,bool bUpdateMesh=true);
		/// <summary>Get the start offset</summary>
		public extern FVector2D GetStartOffset();
		/// <summary>Set the start roll</summary>
		public extern void SetStartRoll(float StartRoll,bool bUpdateMesh=true);
		/// <summary>Get the start roll</summary>
		public extern float GetStartRoll();
		/// <summary>Set the start scaling</summary>
		public extern void SetStartScale(FVector2D StartScale=default(FVector2D),bool bUpdateMesh=true);
		/// <summary>Get the start scaling</summary>
		public extern FVector2D GetStartScale();
		/// <summary>Set the start and end, position and tangent, all in local space</summary>
		public extern void SetStartAndEnd(FVector StartPos,FVector StartTangent,FVector EndPos,FVector EndTangent,bool bUpdateMesh=true);
		/// <summary>Set the end tangent vector of spline in local space</summary>
		public extern void SetEndTangent(FVector EndTangent,bool bUpdateMesh=true);
		/// <summary>Get the end tangent vector of spline in local space</summary>
		public extern FVector GetEndTangent();
		/// <summary>Set the end position of spline in local space</summary>
		public extern void SetEndPosition(FVector EndPos,bool bUpdateMesh=true);
		/// <summary>Get the end position of spline in local space</summary>
		public extern FVector GetEndPosition();
		/// <summary>Set the start tangent vector of spline in local space</summary>
		public extern void SetStartTangent(FVector StartTangent,bool bUpdateMesh=true);
		/// <summary>Get the start tangent vector of spline in local space</summary>
		public extern FVector GetStartTangent();
		/// <summary>Set the start position of spline in local space</summary>
		public extern void SetStartPosition(FVector StartPos,bool bUpdateMesh=true);
		/// <summary>Get the start position of spline in local space</summary>
		public extern FVector GetStartPosition();
		/// <summary>Update the collision and render state on the spline mesh following changes to its geometry</summary>
		public extern void UpdateMesh();
		/// <summary>Spline that is used to deform mesh</summary>
		public FSplineMeshParams SplineParams;
		
		/// <summary>Axis (in component space) that is used to determine X axis for co-ordinates along spline</summary>
		public FVector SplineUpDir;
		
		/// <summary>If true, spline keys may be edited per instance in the level viewport. Otherwise, the spline should be initialized in the construction script.</summary>
		public bool bAllowSplineEditingPerInstance;
		
		/// <summary>If true, will use smooth interpolation (ease in/out) for Scale, Roll, and Offset along this section of spline. If false, uses linear</summary>
		public bool bSmoothInterpRollScale;
		
		/// <summary>Chooses the forward axis for the spline mesh orientation</summary>
		public ESplineMeshAxis ForwardAxis;
		
		/// <summary>Minimum coordinate along the spline forward axis which corresponds to start of spline. If set to 0.0, will use bounding box to determine bounds</summary>
		public float SplineBoundaryMin;
		
		/// <summary>Maximum coordinate along the spline forward axis which corresponds to end of spline. If set to 0.0, will use bounding box to determine bounds</summary>
		public float SplineBoundaryMax;
		
		/// <summary>Physics data.</summary>
		public UBodySetup BodySetup;
		
		/// <summary>Used to automatically trigger rebuild of collision data</summary>
		public FGuid CachedMeshBodySetupGuid;
		
		public bool bSelected;
		
		/// <summary>Indicates that the mesh needs updating</summary>
		public bool bMeshDirty;
		
		
	}
	
}
