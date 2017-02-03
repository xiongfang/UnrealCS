#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>
	/// A Spline Mesh Component is a derivation of a Static Mesh Component which can be deformed using a spline. Only a start and end position (and tangent) can be specified.
	/// @see https://docs.unrealengine.com/latest/INT/Resources/ContentExamples/Blueprint_Splines
	/// </summary>
	public partial class USplineMeshComponent
	{
		static readonly int SplineParams__Offset;
		/// <summary>Spline that is used to deform mesh</summary>
		public FSplineMeshParams SplineParams
		{
			get{ CheckIsValid();return (FSplineMeshParams)Marshal.PtrToStructure(_this.Get()+SplineParams__Offset, typeof(FSplineMeshParams));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+SplineParams__Offset, false);}
			
		}
		
		static readonly int SplineUpDir__Offset;
		/// <summary>Axis (in component space) that is used to determine X axis for co-ordinates along spline</summary>
		public FVector SplineUpDir
		{
			get{ CheckIsValid();return (FVector)Marshal.PtrToStructure(_this.Get()+SplineUpDir__Offset, typeof(FVector));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+SplineUpDir__Offset, false);}
			
		}
		
		static readonly int bAllowSplineEditingPerInstance__Offset;
		/// <summary>If true, spline keys may be edited per instance in the level viewport. Otherwise, the spline should be initialized in the construction script.</summary>
		public bool bAllowSplineEditingPerInstance
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bAllowSplineEditingPerInstance__Offset, 1, 0, 1, 1);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bAllowSplineEditingPerInstance__Offset, 1,0,1,1);}
			
		}
		
		static readonly int bSmoothInterpRollScale__Offset;
		/// <summary>If true, will use smooth interpolation (ease in/out) for Scale, Roll, and Offset along this section of spline. If false, uses linear</summary>
		public bool bSmoothInterpRollScale
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bSmoothInterpRollScale__Offset, 1, 0, 2, 2);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bSmoothInterpRollScale__Offset, 1,0,2,2);}
			
		}
		
		static readonly int ForwardAxis__Offset;
		/// <summary>Chooses the forward axis for the spline mesh orientation</summary>
		public ESplineMeshAxis ForwardAxis
		{
			get{ CheckIsValid();return (ESplineMeshAxis)Marshal.PtrToStructure(_this.Get()+ForwardAxis__Offset, typeof(ESplineMeshAxis));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+ForwardAxis__Offset, false);}
			
		}
		
		static readonly int SplineBoundaryMin__Offset;
		/// <summary>Minimum coordinate along the spline forward axis which corresponds to start of spline. If set to 0.0, will use bounding box to determine bounds</summary>
		public float SplineBoundaryMin
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+SplineBoundaryMin__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+SplineBoundaryMin__Offset, false);}
			
		}
		
		static readonly int SplineBoundaryMax__Offset;
		/// <summary>Maximum coordinate along the spline forward axis which corresponds to end of spline. If set to 0.0, will use bounding box to determine bounds</summary>
		public float SplineBoundaryMax
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+SplineBoundaryMax__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+SplineBoundaryMax__Offset, false);}
			
		}
		
		static readonly int BodySetup__Offset;
		/// <summary>Physics data.</summary>
		public UBodySetup BodySetup
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + BodySetup__Offset); if (v == IntPtr.Zero)return null; UBodySetup retValue = new UBodySetup(); retValue._this = v; return retValue; }
			
		}
		
		static readonly int CachedMeshBodySetupGuid__Offset;
		/// <summary>Used to automatically trigger rebuild of collision data</summary>
		public FGuid CachedMeshBodySetupGuid
		{
			get{ CheckIsValid();return (FGuid)Marshal.PtrToStructure(_this.Get()+CachedMeshBodySetupGuid__Offset, typeof(FGuid));}
			
		}
		
		static readonly int bSelected__Offset;
		public bool bSelected
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bSelected__Offset, 1, 0, 1, 1);}
			
		}
		
		static readonly int bMeshDirty__Offset;
		/// <summary>Indicates that the mesh needs updating</summary>
		public bool bMeshDirty
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bMeshDirty__Offset, 1, 0, 2, 2);}
			
		}
		
		static USplineMeshComponent()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("SplineMeshComponent");
			SplineParams__Offset=GetPropertyOffset(NativeClassPtr,"SplineParams");
			SplineUpDir__Offset=GetPropertyOffset(NativeClassPtr,"SplineUpDir");
			bAllowSplineEditingPerInstance__Offset=GetPropertyOffset(NativeClassPtr,"bAllowSplineEditingPerInstance");
			bSmoothInterpRollScale__Offset=GetPropertyOffset(NativeClassPtr,"bSmoothInterpRollScale");
			ForwardAxis__Offset=GetPropertyOffset(NativeClassPtr,"ForwardAxis");
			SplineBoundaryMin__Offset=GetPropertyOffset(NativeClassPtr,"SplineBoundaryMin");
			SplineBoundaryMax__Offset=GetPropertyOffset(NativeClassPtr,"SplineBoundaryMax");
			BodySetup__Offset=GetPropertyOffset(NativeClassPtr,"BodySetup");
			CachedMeshBodySetupGuid__Offset=GetPropertyOffset(NativeClassPtr,"CachedMeshBodySetupGuid");
			bSelected__Offset=GetPropertyOffset(NativeClassPtr,"bSelected");
			bMeshDirty__Offset=GetPropertyOffset(NativeClassPtr,"bMeshDirty");
			
		}
		
	}
	
}
#endif
#endif
