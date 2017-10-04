using System;
namespace UnrealEngine
{
	public partial class USplineComponent:UPrimitiveComponent
	{
		/// <summary>Given a location, in world space, return an FTransform closest to that location.</summary>
		public extern FTransform FindTransformClosestToWorldLocation(FVector WorldLocation,ESplineCoordinateSpace CoordinateSpace,bool bUseScale=false);
		/// <summary>Given a location, in world space, return the spline's scale closest to the location.</summary>
		public extern FVector FindScaleClosestToWorldLocation(FVector WorldLocation);
		/// <summary>Given a location, in world space, return the spline's roll closest to the location, in degrees.</summary>
		public extern float FindRollClosestToWorldLocation(FVector WorldLocation,ESplineCoordinateSpace CoordinateSpace);
		/// <summary>Given a location, in world space, return a unit direction vector corresponding to the spline's right vector closest to the location.</summary>
		public extern FVector FindRightVectorClosestToWorldLocation(FVector WorldLocation,ESplineCoordinateSpace CoordinateSpace);
		/// <summary>Given a location, in world space, return a unit direction vector corresponding to the spline's up vector closest to the location.</summary>
		public extern FVector FindUpVectorClosestToWorldLocation(FVector WorldLocation,ESplineCoordinateSpace CoordinateSpace);
		/// <summary>Given a location, in world space, return rotation corresponding to the spline's rotation closest to the location.</summary>
		public extern FRotator FindRotationClosestToWorldLocation(FVector WorldLocation,ESplineCoordinateSpace CoordinateSpace);
		/// <summary>Given a location, in world space, return the tangent vector of the spline closest to the location.</summary>
		public extern FVector FindTangentClosestToWorldLocation(FVector WorldLocation,ESplineCoordinateSpace CoordinateSpace);
		/// <summary>Given a location, in world spcae, return a unit direction vector of the spline tangent closest to the location.</summary>
		public extern FVector FindDirectionClosestToWorldLocation(FVector WorldLocation,ESplineCoordinateSpace CoordinateSpace);
		/// <summary>Given a location, in world space, return the point on the curve that is closest to the location.</summary>
		public extern FVector FindLocationClosestToWorldLocation(FVector WorldLocation,ESplineCoordinateSpace CoordinateSpace);
		/// <summary>Given a location, in world space, return the input key closest to that location.</summary>
		public extern float FindInputKeyClosestToWorldLocation(FVector WorldLocation);
		/// <summary>Given a time from 0 to the spline duration, return the spline's scale there.</summary>
		public extern FVector GetScaleAtTime(float Time,bool bUseConstantVelocity=false);
		/// <summary>Given a time from 0 to the spline duration, return the spline's roll there, in degrees.</summary>
		public extern float GetRollAtTime(float Time,ESplineCoordinateSpace CoordinateSpace,bool bUseConstantVelocity=false);
		/// <summary>Given a time from 0 to the spline duration, return the spline's transform at the corresponding position.</summary>
		public extern FTransform GetTransformAtTime(float Time,ESplineCoordinateSpace CoordinateSpace,bool bUseConstantVelocity=false,bool bUseScale=false);
		/// <summary>Given a time from 0 to the spline duration, return the spline's right vector there.</summary>
		public extern FVector GetRightVectorAtTime(float Time,ESplineCoordinateSpace CoordinateSpace,bool bUseConstantVelocity=false);
		/// <summary>Given a time from 0 to the spline duration, return the spline's up vector there.</summary>
		public extern FVector GetUpVectorAtTime(float Time,ESplineCoordinateSpace CoordinateSpace,bool bUseConstantVelocity=false);
		/// <summary>Given a time from 0 to the spline duration, return a rotation corresponding to the spline's position and direction there.</summary>
		public extern FRotator GetRotationAtTime(float Time,ESplineCoordinateSpace CoordinateSpace,bool bUseConstantVelocity=false);
		/// <summary>Given a time from 0 to the spline duration, return the spline's tangent there.</summary>
		public extern FVector GetTangentAtTime(float Time,ESplineCoordinateSpace CoordinateSpace,bool bUseConstantVelocity=false);
		/// <summary>Given a time from 0 to the spline duration, return a unit direction vector of the spline tangent there.</summary>
		public extern FVector GetDirectionAtTime(float Time,ESplineCoordinateSpace CoordinateSpace,bool bUseConstantVelocity=false);
		/// <summary>Given a time from 0 to the spline duration, return the point in space where this puts you</summary>
		public extern FVector GetLocationAtTime(float Time,ESplineCoordinateSpace CoordinateSpace,bool bUseConstantVelocity=false);
		/// <summary>Given a distance along the length of this spline, return an FTransform corresponding to that point on the spline.</summary>
		public extern FTransform GetTransformAtDistanceAlongSpline(float Distance,ESplineCoordinateSpace CoordinateSpace,bool bUseScale=false);
		/// <summary>Given a distance along the length of this spline, return the spline's scale there.</summary>
		public extern FVector GetScaleAtDistanceAlongSpline(float Distance);
		/// <summary>Given a distance along the length of this spline, return the spline's roll there, in degrees.</summary>
		public extern float GetRollAtDistanceAlongSpline(float Distance,ESplineCoordinateSpace CoordinateSpace);
		/// <summary>Given a distance along the length of this spline, return a unit direction vector corresponding to the spline's right vector there.</summary>
		public extern FVector GetRightVectorAtDistanceAlongSpline(float Distance,ESplineCoordinateSpace CoordinateSpace);
		/// <summary>Given a distance along the length of this spline, return a unit direction vector corresponding to the spline's up vector there.</summary>
		public extern FVector GetUpVectorAtDistanceAlongSpline(float Distance,ESplineCoordinateSpace CoordinateSpace);
		/// <summary>Given a distance along the length of this spline, return a rotation corresponding to the spline's rotation there.</summary>
		public extern FRotator GetRotationAtDistanceAlongSpline(float Distance,ESplineCoordinateSpace CoordinateSpace);
		/// <summary>Given a distance along the length of this spline, return the tangent vector of the spline there.</summary>
		public extern FVector GetTangentAtDistanceAlongSpline(float Distance,ESplineCoordinateSpace CoordinateSpace);
		/// <summary>Given a distance along the length of this spline, return a unit direction vector of the spline tangent there.</summary>
		public extern FVector GetDirectionAtDistanceAlongSpline(float Distance,ESplineCoordinateSpace CoordinateSpace);
		/// <summary>Given a distance along the length of this spline, return the point in space where this puts you</summary>
		public extern FVector GetLocationAtDistanceAlongSpline(float Distance,ESplineCoordinateSpace CoordinateSpace);
		/// <summary>Given a distance along the length of this spline, return the corresponding input key at that point</summary>
		public extern float GetInputKeyAtDistanceAlongSpline(float Distance);
		/// <summary>Gets the default up vector used by this spline</summary>
		public extern FVector GetDefaultUpVector(ESplineCoordinateSpace CoordinateSpace);
		/// <summary>Sets the default up vector used by this spline</summary>
		public extern void SetDefaultUpVector(FVector UpVector,ESplineCoordinateSpace CoordinateSpace);
		/// <summary>Returns total length along this spline</summary>
		public extern float GetSplineLength();
		/// <summary>Get the distance along the spline at the spline point</summary>
		public extern float GetDistanceAlongSplineAtSplinePoint(int PointIndex);
		/// <summary>Get location and tangent at a spline point</summary>
		public extern void GetLocationAndTangentAtSplinePoint(int PointIndex,out FVector Location,out FVector Tangent,ESplineCoordinateSpace CoordinateSpace);
		/// <summary>Get the transform at spline point</summary>
		public extern FTransform GetTransformAtSplinePoint(int PointIndex,ESplineCoordinateSpace CoordinateSpace,bool bUseScale=false);
		/// <summary>Get the scale at spline point</summary>
		public extern FVector GetScaleAtSplinePoint(int PointIndex);
		/// <summary>Get the amount of roll at spline point, in degrees</summary>
		public extern float GetRollAtSplinePoint(int PointIndex,ESplineCoordinateSpace CoordinateSpace);
		/// <summary>Get the right vector at spline point</summary>
		public extern FVector GetRightVectorAtSplinePoint(int PointIndex,ESplineCoordinateSpace CoordinateSpace);
		/// <summary>Get the up vector at spline point</summary>
		public extern FVector GetUpVectorAtSplinePoint(int PointIndex,ESplineCoordinateSpace CoordinateSpace);
		/// <summary>Get the rotation at spline point as a rotator</summary>
		public extern FRotator GetRotationAtSplinePoint(int PointIndex,ESplineCoordinateSpace CoordinateSpace);
		/// <summary>Get the leave tangent at spline point</summary>
		public extern FVector GetLeaveTangentAtSplinePoint(int PointIndex,ESplineCoordinateSpace CoordinateSpace);
		/// <summary>Get the arrive tangent at spline point</summary>
		public extern FVector GetArriveTangentAtSplinePoint(int PointIndex,ESplineCoordinateSpace CoordinateSpace);
		/// <summary>Get the tangent at spline point. This fetches the Leave tangent of the point.</summary>
		public extern FVector GetTangentAtSplinePoint(int PointIndex,ESplineCoordinateSpace CoordinateSpace);
		/// <summary>Get the location at spline point</summary>
		public extern FVector GetDirectionAtSplinePoint(int PointIndex,ESplineCoordinateSpace CoordinateSpace);
		/// <summary>Get the location at spline point</summary>
		public extern FVector GetLocationAtSplinePoint(int PointIndex,ESplineCoordinateSpace CoordinateSpace);
		/// <summary>Get the number of points that make up this spline</summary>
		public extern int GetNumberOfSplinePoints();
		/// <summary>Specify the type of a spline point</summary>
		public extern void SetSplinePointType(int PointIndex,ESplinePointType Type,bool bUpdateSpline=true);
		/// <summary>Get the type of a spline point</summary>
		public extern ESplinePointType GetSplinePointType(int PointIndex);
		/// <summary>Specify the up vector at a given spline point</summary>
		public extern void SetUpVectorAtSplinePoint(int PointIndex,FVector InUpVector,ESplineCoordinateSpace CoordinateSpace,bool bUpdateSpline=true);
		/// <summary>Specify the tangents at a given spline point</summary>
		public extern void SetTangentsAtSplinePoint(int PointIndex,FVector InArriveTangent,FVector InLeaveTangent,ESplineCoordinateSpace CoordinateSpace,bool bUpdateSpline=true);
		/// <summary>Specify the tangent at a given spline point</summary>
		public extern void SetTangentAtSplinePoint(int PointIndex,FVector InTangent,ESplineCoordinateSpace CoordinateSpace,bool bUpdateSpline=true);
		/// <summary>Move an existing point to a new location</summary>
		public extern void SetLocationAtSplinePoint(int PointIndex,FVector InLocation,ESplineCoordinateSpace CoordinateSpace,bool bUpdateSpline=true);
		/// <summary>Removes point at specified index from the spline</summary>
		public extern void RemoveSplinePoint(int Index,bool bUpdateSpline=true);
		/// <summary>Adds a point to the spline at the specified index</summary>
		public extern void AddSplinePointAtIndex(FVector Position,int Index,ESplineCoordinateSpace CoordinateSpace,bool bUpdateSpline=true);
		/// <summary>Adds a point to the spline</summary>
		public extern void AddSplinePoint(FVector Position,ESplineCoordinateSpace CoordinateSpace,bool bUpdateSpline=true);
		/// <summary>Adds an FSplinePoint to the spline. This contains its input key, position, tangent, rotation and scale.</summary>
		public extern void AddPoint(FSplinePoint Point,bool bUpdateSpline=true);
		/// <summary>Clears all the points in the spline</summary>
		public extern void ClearSplinePoints(bool bUpdateSpline=true);
		/// <summary>Check whether the spline is a closed loop or not</summary>
		public extern bool IsClosedLoop();
		/// <summary>Specify whether the spline is a closed loop or not, and if so, the input key corresponding to the loop point</summary>
		public extern void SetClosedLoopAtPosition(bool bInClosedLoop,float Key,bool bUpdateSpline=true);
		/// <summary>Specify whether the spline is a closed loop or not. The loop position will be at 1.0 after the last point's input key</summary>
		public extern void SetClosedLoop(bool bInClosedLoop,bool bUpdateSpline=true);
		/// <summary>Specify whether this spline should be rendered when the Editor/Game spline show flag is set</summary>
		public extern void SetDrawDebug(bool bShow);
		/// <summary>Specify selected spline component segment color in the editor</summary>
		public extern void SetSelectedSplineSegmentColor(FLinearColor SegmentColor);
		/// <summary>Specify unselected spline component segment color in the editor</summary>
		public extern void SetUnselectedSplineSegmentColor(FLinearColor SegmentColor);
		/// <summary>Update the spline tangents and SplineReparamTable</summary>
		public extern void UpdateSpline();
		public FSplineCurves SplineCurves;
		
		/// <summary>Deprecated - please use GetSplinePointsPosition() to fetch this FInterpCurve</summary>
		public FInterpCurveVector SplineInfo;
		
		/// <summary>Deprecated - please use GetSplinePointsRotation() to fetch this FInterpCurve</summary>
		public FInterpCurveQuat SplineRotInfo;
		
		/// <summary>Deprecated - please use GetSplinePointsScale() to fetch this FInterpCurve</summary>
		public FInterpCurveVector SplineScaleInfo;
		
		public FInterpCurveFloat SplineReparamTable;
		
		public bool bAllowSplineEditingPerInstance;
		
		/// <summary>Number of steps per spline segment to place in the reparameterization table</summary>
		public int ReparamStepsPerSegment;
		
		/// <summary>Specifies the duration of the spline in seconds</summary>
		public float Duration;
		
		/// <summary>Whether the endpoints of the spline are considered stationary when traversing the spline at non-constant velocity.  Essentially this sets the endpoints' tangents to zero vectors.</summary>
		public bool bStationaryEndpoints;
		
		/// <summary>Whether the spline has been edited from its default by the spline component visualizer</summary>
		public bool bSplineHasBeenEdited;
		
		/// <summary>Whether the UCS has made changes to the spline points</summary>
		public bool bModifiedByConstructionScript;
		
		/// <summary>
		/// Whether the spline points should be passed to the User Construction Script so they can be further manipulated by it.
		/// If false, they will not be visible to it, and it will not be able to influence the per-instance positions set in the editor.
		/// </summary>
		public bool bInputSplinePointsToConstructionScript;
		
		/// <summary>If true, the spline will be rendered if the Splines showflag is set.</summary>
		public bool bDrawDebug;
		
		/// <summary>
		/// Whether the spline is to be considered as a closed loop.
		/// Use SetClosedLoop() to set this property, and IsClosedLoop() to read it.
		/// </summary>
		public bool bClosedLoop;
		
		public bool bLoopPositionOverride;
		
		public float LoopPosition;
		
		/// <summary>Default up vector in local space to be used when calculating transforms along the spline</summary>
		public FVector DefaultUpVector;
		
		/// <summary>Color of an unselected spline component segment in the editor</summary>
		public FLinearColor EditorUnselectedSplineSegmentColor;
		
		/// <summary>Color of a selected spline component segment in the editor</summary>
		public FLinearColor EditorSelectedSplineSegmentColor;
		
		/// <summary>Whether the spline's leave and arrive tangents can be different</summary>
		public bool bAllowDiscontinuousSpline;
		
		/// <summary>Whether scale visualization should be displayed</summary>
		public bool bShouldVisualizeScale;
		
		/// <summary>Width of spline in editor for use with scale visualization</summary>
		public float ScaleVisualizationWidth;
		
		
	}
	
}
