#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>
	/// A spline component is a spline shape which can be used for other purposes (e.g. animating objects). It contains debug rendering capabilities.
	/// @see https://docs.unrealengine.com/latest/INT/Resources/ContentExamples/Blueprint_Splines
	/// </summary>
	public partial class USplineComponent
	{
		static readonly int SplineCurves__Offset;
		public FSplineCurves SplineCurves
		{
			get{ CheckIsValid();return (FSplineCurves)Marshal.PtrToStructure(_this.Get()+SplineCurves__Offset, typeof(FSplineCurves));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+SplineCurves__Offset, false);}
			
		}
		
		static readonly int SplineInfo__Offset;
		/// <summary>Deprecated - please use GetSplinePointsPosition() to fetch this FInterpCurve</summary>
		public FInterpCurveVector SplineInfo
		{
			get{ CheckIsValid();return (FInterpCurveVector)Marshal.PtrToStructure(_this.Get()+SplineInfo__Offset, typeof(FInterpCurveVector));}
			
		}
		
		static readonly int SplineRotInfo__Offset;
		/// <summary>Deprecated - please use GetSplinePointsRotation() to fetch this FInterpCurve</summary>
		public FInterpCurveQuat SplineRotInfo
		{
			get{ CheckIsValid();return (FInterpCurveQuat)Marshal.PtrToStructure(_this.Get()+SplineRotInfo__Offset, typeof(FInterpCurveQuat));}
			
		}
		
		static readonly int SplineScaleInfo__Offset;
		/// <summary>Deprecated - please use GetSplinePointsScale() to fetch this FInterpCurve</summary>
		public FInterpCurveVector SplineScaleInfo
		{
			get{ CheckIsValid();return (FInterpCurveVector)Marshal.PtrToStructure(_this.Get()+SplineScaleInfo__Offset, typeof(FInterpCurveVector));}
			
		}
		
		static readonly int SplineReparamTable__Offset;
		public FInterpCurveFloat SplineReparamTable
		{
			get{ CheckIsValid();return (FInterpCurveFloat)Marshal.PtrToStructure(_this.Get()+SplineReparamTable__Offset, typeof(FInterpCurveFloat));}
			
		}
		
		static readonly int bAllowSplineEditingPerInstance__Offset;
		public bool bAllowSplineEditingPerInstance
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bAllowSplineEditingPerInstance__Offset, 1, 0, 1, 255);}
			
		}
		
		static readonly int ReparamStepsPerSegment__Offset;
		/// <summary>Number of steps per spline segment to place in the reparameterization table</summary>
		public int ReparamStepsPerSegment
		{
			get{ CheckIsValid();return (int)Marshal.PtrToStructure(_this.Get()+ReparamStepsPerSegment__Offset, typeof(int));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+ReparamStepsPerSegment__Offset, false);}
			
		}
		
		static readonly int Duration__Offset;
		/// <summary>Specifies the duration of the spline in seconds</summary>
		public float Duration
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+Duration__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+Duration__Offset, false);}
			
		}
		
		static readonly int bStationaryEndpoints__Offset;
		/// <summary>Whether the endpoints of the spline are considered stationary when traversing the spline at non-constant velocity.  Essentially this sets the endpoints' tangents to zero vectors.</summary>
		public bool bStationaryEndpoints
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bStationaryEndpoints__Offset, 1, 0, 1, 255);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bStationaryEndpoints__Offset, 1,0,1,255);}
			
		}
		
		static readonly int bSplineHasBeenEdited__Offset;
		/// <summary>Whether the spline has been edited from its default by the spline component visualizer</summary>
		public bool bSplineHasBeenEdited
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bSplineHasBeenEdited__Offset, 1, 0, 1, 255);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bSplineHasBeenEdited__Offset, 1,0,1,255);}
			
		}
		
		static readonly int bModifiedByConstructionScript__Offset;
		/// <summary>Whether the UCS has made changes to the spline points</summary>
		public bool bModifiedByConstructionScript
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bModifiedByConstructionScript__Offset, 1, 0, 1, 255);}
			
		}
		
		static readonly int bInputSplinePointsToConstructionScript__Offset;
		/// <summary>
		/// Whether the spline points should be passed to the User Construction Script so they can be further manipulated by it.
		/// If false, they will not be visible to it, and it will not be able to influence the per-instance positions set in the editor.
		/// </summary>
		public bool bInputSplinePointsToConstructionScript
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bInputSplinePointsToConstructionScript__Offset, 1, 0, 1, 255);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bInputSplinePointsToConstructionScript__Offset, 1,0,1,255);}
			
		}
		
		static readonly int bDrawDebug__Offset;
		/// <summary>If true, the spline will be rendered if the Splines showflag is set.</summary>
		public bool bDrawDebug
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bDrawDebug__Offset, 1, 0, 1, 255);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bDrawDebug__Offset, 1,0,1,255);}
			
		}
		
		static readonly int bClosedLoop__Offset;
		/// <summary>
		/// Whether the spline is to be considered as a closed loop.
		/// Use SetClosedLoop() to set this property, and IsClosedLoop() to read it.
		/// </summary>
		public bool bClosedLoop
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bClosedLoop__Offset, 1, 0, 1, 255);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bClosedLoop__Offset, 1,0,1,255);}
			
		}
		
		static readonly int bLoopPositionOverride__Offset;
		public bool bLoopPositionOverride
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bLoopPositionOverride__Offset, 1, 0, 1, 255);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bLoopPositionOverride__Offset, 1,0,1,255);}
			
		}
		
		static readonly int LoopPosition__Offset;
		public float LoopPosition
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+LoopPosition__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+LoopPosition__Offset, false);}
			
		}
		
		static readonly int DefaultUpVector__Offset;
		/// <summary>Default up vector in local space to be used when calculating transforms along the spline</summary>
		public FVector DefaultUpVector
		{
			get{ CheckIsValid();return (FVector)Marshal.PtrToStructure(_this.Get()+DefaultUpVector__Offset, typeof(FVector));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+DefaultUpVector__Offset, false);}
			
		}
		
		static readonly int EditorUnselectedSplineSegmentColor__Offset;
		/// <summary>Color of an unselected spline component segment in the editor</summary>
		public FLinearColor EditorUnselectedSplineSegmentColor
		{
			get{ CheckIsValid();return (FLinearColor)Marshal.PtrToStructure(_this.Get()+EditorUnselectedSplineSegmentColor__Offset, typeof(FLinearColor));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+EditorUnselectedSplineSegmentColor__Offset, false);}
			
		}
		
		static readonly int EditorSelectedSplineSegmentColor__Offset;
		/// <summary>Color of a selected spline component segment in the editor</summary>
		public FLinearColor EditorSelectedSplineSegmentColor
		{
			get{ CheckIsValid();return (FLinearColor)Marshal.PtrToStructure(_this.Get()+EditorSelectedSplineSegmentColor__Offset, typeof(FLinearColor));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+EditorSelectedSplineSegmentColor__Offset, false);}
			
		}
		
		static readonly int bAllowDiscontinuousSpline__Offset;
		/// <summary>Whether the spline's leave and arrive tangents can be different</summary>
		public bool bAllowDiscontinuousSpline
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bAllowDiscontinuousSpline__Offset, 1, 0, 1, 255);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bAllowDiscontinuousSpline__Offset, 1,0,1,255);}
			
		}
		
		static readonly int bShouldVisualizeScale__Offset;
		/// <summary>Whether scale visualization should be displayed</summary>
		public bool bShouldVisualizeScale
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bShouldVisualizeScale__Offset, 1, 0, 1, 255);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bShouldVisualizeScale__Offset, 1,0,1,255);}
			
		}
		
		static readonly int ScaleVisualizationWidth__Offset;
		/// <summary>Width of spline in editor for use with scale visualization</summary>
		public float ScaleVisualizationWidth
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+ScaleVisualizationWidth__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+ScaleVisualizationWidth__Offset, false);}
			
		}
		
		static USplineComponent()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("SplineComponent");
			SplineCurves__Offset=GetPropertyOffset(NativeClassPtr,"SplineCurves");
			SplineInfo__Offset=GetPropertyOffset(NativeClassPtr,"SplineInfo");
			SplineRotInfo__Offset=GetPropertyOffset(NativeClassPtr,"SplineRotInfo");
			SplineScaleInfo__Offset=GetPropertyOffset(NativeClassPtr,"SplineScaleInfo");
			SplineReparamTable__Offset=GetPropertyOffset(NativeClassPtr,"SplineReparamTable");
			bAllowSplineEditingPerInstance__Offset=GetPropertyOffset(NativeClassPtr,"bAllowSplineEditingPerInstance");
			ReparamStepsPerSegment__Offset=GetPropertyOffset(NativeClassPtr,"ReparamStepsPerSegment");
			Duration__Offset=GetPropertyOffset(NativeClassPtr,"Duration");
			bStationaryEndpoints__Offset=GetPropertyOffset(NativeClassPtr,"bStationaryEndpoints");
			bSplineHasBeenEdited__Offset=GetPropertyOffset(NativeClassPtr,"bSplineHasBeenEdited");
			bModifiedByConstructionScript__Offset=GetPropertyOffset(NativeClassPtr,"bModifiedByConstructionScript");
			bInputSplinePointsToConstructionScript__Offset=GetPropertyOffset(NativeClassPtr,"bInputSplinePointsToConstructionScript");
			bDrawDebug__Offset=GetPropertyOffset(NativeClassPtr,"bDrawDebug");
			bClosedLoop__Offset=GetPropertyOffset(NativeClassPtr,"bClosedLoop");
			bLoopPositionOverride__Offset=GetPropertyOffset(NativeClassPtr,"bLoopPositionOverride");
			LoopPosition__Offset=GetPropertyOffset(NativeClassPtr,"LoopPosition");
			DefaultUpVector__Offset=GetPropertyOffset(NativeClassPtr,"DefaultUpVector");
			EditorUnselectedSplineSegmentColor__Offset=GetPropertyOffset(NativeClassPtr,"EditorUnselectedSplineSegmentColor");
			EditorSelectedSplineSegmentColor__Offset=GetPropertyOffset(NativeClassPtr,"EditorSelectedSplineSegmentColor");
			bAllowDiscontinuousSpline__Offset=GetPropertyOffset(NativeClassPtr,"bAllowDiscontinuousSpline");
			bShouldVisualizeScale__Offset=GetPropertyOffset(NativeClassPtr,"bShouldVisualizeScale");
			ScaleVisualizationWidth__Offset=GetPropertyOffset(NativeClassPtr,"ScaleVisualizationWidth");
			
		}
		
	}
	
}
#endif
#endif
