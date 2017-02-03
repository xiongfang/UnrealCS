#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class UNavCollision
	{
		static readonly int CylinderCollision__Offset;
		/// <summary>list of nav collision cylinders</summary>
		public TStructArray<FNavCollisionCylinder> CylinderCollision
		{
			get{ CheckIsValid();return new TStructArray<FNavCollisionCylinder>((FScriptArray)Marshal.PtrToStructure(_this.Get()+CylinderCollision__Offset, typeof(FScriptArray)));}
					set{ CheckIsValid();Marshal.StructureToPtr(value.InterArray, _this.Get()+CylinderCollision__Offset, false);}
			
		}
		
		static readonly int BoxCollision__Offset;
		/// <summary>list of nav collision boxes</summary>
		public TStructArray<FNavCollisionBox> BoxCollision
		{
			get{ CheckIsValid();return new TStructArray<FNavCollisionBox>((FScriptArray)Marshal.PtrToStructure(_this.Get()+BoxCollision__Offset, typeof(FScriptArray)));}
					set{ CheckIsValid();Marshal.StructureToPtr(value.InterArray, _this.Get()+BoxCollision__Offset, false);}
			
		}
		
		static readonly int AreaClass__Offset;
		/// <summary>navigation area type (empty = default obstacle)</summary>
		public TSubclassOf<UNavArea>  AreaClass
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + AreaClass__Offset); return v; }
			set{ CheckIsValid(); Marshal.WriteIntPtr(_this.Get() + AreaClass__Offset, value); }
			
		}
		
		static readonly int bIsDynamicObstacle__Offset;
		/// <summary>If set, mesh will be used as dynamic obstacle (don't create navmesh on top, much faster adding/removing)</summary>
		public bool bIsDynamicObstacle
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bIsDynamicObstacle__Offset, 1, 0, 1, 1);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bIsDynamicObstacle__Offset, 1,0,1,1);}
			
		}
		
		static readonly int bGatherConvexGeometry__Offset;
		/// <summary>If set, convex collisions will be exported offline for faster runtime navmesh building (increases memory usage)</summary>
		public bool bGatherConvexGeometry
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bGatherConvexGeometry__Offset, 1, 0, 2, 2);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bGatherConvexGeometry__Offset, 1,0,2,2);}
			
		}
		
		static UNavCollision()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("NavCollision");
			CylinderCollision__Offset=GetPropertyOffset(NativeClassPtr,"CylinderCollision");
			BoxCollision__Offset=GetPropertyOffset(NativeClassPtr,"BoxCollision");
			AreaClass__Offset=GetPropertyOffset(NativeClassPtr,"AreaClass");
			bIsDynamicObstacle__Offset=GetPropertyOffset(NativeClassPtr,"bIsDynamicObstacle");
			bGatherConvexGeometry__Offset=GetPropertyOffset(NativeClassPtr,"bGatherConvexGeometry");
			
		}
		
	}
	
}
#endif
#endif
