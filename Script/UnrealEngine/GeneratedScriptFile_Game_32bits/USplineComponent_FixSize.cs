#if WITH_GAME
#if PLATFORM_32BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class USplineComponent
	{
		static readonly int SplineCurves__Offset;
		public FSplineCurves SplineCurves
		{
			get{ CheckIsValid();return (FSplineCurves)Marshal.PtrToStructure(_this.Get()+SplineCurves__Offset, typeof(FSplineCurves));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+SplineCurves__Offset, false);}
			
		}
		
		static readonly int SplineInfo__Offset;
		public FInterpCurveVector SplineInfo
		{
			get{ CheckIsValid();return (FInterpCurveVector)Marshal.PtrToStructure(_this.Get()+SplineInfo__Offset, typeof(FInterpCurveVector));}
			
		}
		
		static readonly int SplineRotInfo__Offset;
		public FInterpCurveQuat SplineRotInfo
		{
			get{ CheckIsValid();return (FInterpCurveQuat)Marshal.PtrToStructure(_this.Get()+SplineRotInfo__Offset, typeof(FInterpCurveQuat));}
			
		}
		
		static readonly int SplineScaleInfo__Offset;
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
		public int ReparamStepsPerSegment
		{
			get{ CheckIsValid();return (int)Marshal.PtrToStructure(_this.Get()+ReparamStepsPerSegment__Offset, typeof(int));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+ReparamStepsPerSegment__Offset, false);}
			
		}
		
		static readonly int Duration__Offset;
		public float Duration
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+Duration__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+Duration__Offset, false);}
			
		}
		
		static readonly int bStationaryEndpoints__Offset;
		public bool bStationaryEndpoints
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bStationaryEndpoints__Offset, 1, 0, 1, 255);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bStationaryEndpoints__Offset, 1,0,1,255);}
			
		}
		
		static readonly int bSplineHasBeenEdited__Offset;
		public bool bSplineHasBeenEdited
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bSplineHasBeenEdited__Offset, 1, 0, 1, 255);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bSplineHasBeenEdited__Offset, 1,0,1,255);}
			
		}
		
		static readonly int bModifiedByConstructionScript__Offset;
		public bool bModifiedByConstructionScript
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bModifiedByConstructionScript__Offset, 1, 0, 1, 255);}
			
		}
		
		static readonly int bInputSplinePointsToConstructionScript__Offset;
		public bool bInputSplinePointsToConstructionScript
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bInputSplinePointsToConstructionScript__Offset, 1, 0, 1, 255);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bInputSplinePointsToConstructionScript__Offset, 1,0,1,255);}
			
		}
		
		static readonly int bDrawDebug__Offset;
		public bool bDrawDebug
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bDrawDebug__Offset, 1, 0, 1, 255);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bDrawDebug__Offset, 1,0,1,255);}
			
		}
		
		static readonly int bClosedLoop__Offset;
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
		public FVector DefaultUpVector
		{
			get{ CheckIsValid();return (FVector)Marshal.PtrToStructure(_this.Get()+DefaultUpVector__Offset, typeof(FVector));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+DefaultUpVector__Offset, false);}
			
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
			
		}
		
	}
	
}
#endif
#endif
