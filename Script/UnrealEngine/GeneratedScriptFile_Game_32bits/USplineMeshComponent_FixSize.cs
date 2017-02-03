#if WITH_GAME
#if PLATFORM_32BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class USplineMeshComponent
	{
		static readonly int SplineParams__Offset;
		public FSplineMeshParams SplineParams
		{
			get{ CheckIsValid();return (FSplineMeshParams)Marshal.PtrToStructure(_this.Get()+SplineParams__Offset, typeof(FSplineMeshParams));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+SplineParams__Offset, false);}
			
		}
		
		static readonly int SplineUpDir__Offset;
		public FVector SplineUpDir
		{
			get{ CheckIsValid();return (FVector)Marshal.PtrToStructure(_this.Get()+SplineUpDir__Offset, typeof(FVector));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+SplineUpDir__Offset, false);}
			
		}
		
		static readonly int bAllowSplineEditingPerInstance__Offset;
		public bool bAllowSplineEditingPerInstance
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bAllowSplineEditingPerInstance__Offset, 1, 0, 1, 1);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bAllowSplineEditingPerInstance__Offset, 1,0,1,1);}
			
		}
		
		static readonly int bSmoothInterpRollScale__Offset;
		public bool bSmoothInterpRollScale
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bSmoothInterpRollScale__Offset, 1, 0, 2, 2);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bSmoothInterpRollScale__Offset, 1,0,2,2);}
			
		}
		
		static readonly int ForwardAxis__Offset;
		public ESplineMeshAxis ForwardAxis
		{
			get{ CheckIsValid();return (ESplineMeshAxis)Marshal.PtrToStructure(_this.Get()+ForwardAxis__Offset, typeof(ESplineMeshAxis));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+ForwardAxis__Offset, false);}
			
		}
		
		static readonly int SplineBoundaryMin__Offset;
		public float SplineBoundaryMin
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+SplineBoundaryMin__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+SplineBoundaryMin__Offset, false);}
			
		}
		
		static readonly int SplineBoundaryMax__Offset;
		public float SplineBoundaryMax
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+SplineBoundaryMax__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+SplineBoundaryMax__Offset, false);}
			
		}
		
		static readonly int BodySetup__Offset;
		public UBodySetup BodySetup
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + BodySetup__Offset); if (v == IntPtr.Zero)return null; UBodySetup retValue = new UBodySetup(); retValue._this = v; return retValue; }
			
		}
		
		static readonly int CachedMeshBodySetupGuid__Offset;
		public FGuid CachedMeshBodySetupGuid
		{
			get{ CheckIsValid();return (FGuid)Marshal.PtrToStructure(_this.Get()+CachedMeshBodySetupGuid__Offset, typeof(FGuid));}
			
		}
		
		static readonly int bMeshDirty__Offset;
		public bool bMeshDirty
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bMeshDirty__Offset, 1, 0, 1, 1);}
			
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
			bMeshDirty__Offset=GetPropertyOffset(NativeClassPtr,"bMeshDirty");
			
		}
		
	}
	
}
#endif
#endif
