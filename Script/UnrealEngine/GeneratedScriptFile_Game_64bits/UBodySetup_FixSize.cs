#if WITH_GAME
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class UBodySetup
	{
		static readonly int AggGeom__Offset;
		public FKAggregateGeom AggGeom
		{
			get{ CheckIsValid();return (FKAggregateGeom)Marshal.PtrToStructure(_this.Get()+AggGeom__Offset, typeof(FKAggregateGeom));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+AggGeom__Offset, false);}
			
		}
		
		static readonly int BoneName__Offset;
		public FName BoneName
		{
			get{ CheckIsValid();return (FName)Marshal.PtrToStructure(_this.Get()+BoneName__Offset, typeof(FName));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+BoneName__Offset, false);}
			
		}
		
		static readonly int PhysicsType__Offset;
		public EPhysicsType PhysicsType
		{
			get{ CheckIsValid();return (EPhysicsType)Marshal.PtrToStructure(_this.Get()+PhysicsType__Offset, typeof(EPhysicsType));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+PhysicsType__Offset, false);}
			
		}
		
		static readonly int bAlwaysFullAnimWeight__Offset;
		public bool bAlwaysFullAnimWeight
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bAlwaysFullAnimWeight__Offset, 1, 0, 1, 1);}
			
		}
		
		static readonly int bConsiderForBounds__Offset;
		public bool bConsiderForBounds
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bConsiderForBounds__Offset, 1, 0, 2, 2);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bConsiderForBounds__Offset, 1,0,2,2);}
			
		}
		
		static readonly int bMeshCollideAll__Offset;
		public bool bMeshCollideAll
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bMeshCollideAll__Offset, 1, 0, 4, 4);}
			
		}
		
		static readonly int bDoubleSidedGeometry__Offset;
		public bool bDoubleSidedGeometry
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bDoubleSidedGeometry__Offset, 1, 0, 8, 8);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bDoubleSidedGeometry__Offset, 1,0,8,8);}
			
		}
		
		static readonly int bGenerateNonMirroredCollision__Offset;
		public bool bGenerateNonMirroredCollision
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bGenerateNonMirroredCollision__Offset, 1, 0, 16, 16);}
			
		}
		
		static readonly int bSharedCookedData__Offset;
		public bool bSharedCookedData
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bSharedCookedData__Offset, 1, 0, 32, 32);}
			
		}
		
		static readonly int bGenerateMirroredCollision__Offset;
		public bool bGenerateMirroredCollision
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bGenerateMirroredCollision__Offset, 1, 0, 64, 64);}
			
		}
		
		static readonly int PhysMaterial__Offset;
		public UPhysicalMaterial PhysMaterial
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + PhysMaterial__Offset); if (v == IntPtr.Zero)return null; UPhysicalMaterial retValue = new UPhysicalMaterial(); retValue._this = v; return retValue; }
			set{ CheckIsValid(); if (value == null)Marshal.WriteIntPtr(_this.Get() + PhysMaterial__Offset, IntPtr.Zero);else Marshal.WriteIntPtr(_this.Get() + PhysMaterial__Offset, value._this.Get()); }
			
		}
		
		static readonly int CollisionReponse__Offset;
		public EBodyCollisionResponse CollisionReponse
		{
			get{ CheckIsValid();return (EBodyCollisionResponse)Marshal.PtrToStructure(_this.Get()+CollisionReponse__Offset, typeof(EBodyCollisionResponse));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+CollisionReponse__Offset, false);}
			
		}
		
		static readonly int CollisionTraceFlag__Offset;
		public ECollisionTraceFlag CollisionTraceFlag
		{
			get{ CheckIsValid();return (ECollisionTraceFlag)Marshal.PtrToStructure(_this.Get()+CollisionTraceFlag__Offset, typeof(ECollisionTraceFlag));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+CollisionTraceFlag__Offset, false);}
			
		}
		
		static readonly int DefaultInstance__Offset;
		public FBodyInstance DefaultInstance
		{
			get{ CheckIsValid();return (FBodyInstance)Marshal.PtrToStructure(_this.Get()+DefaultInstance__Offset, typeof(FBodyInstance));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+DefaultInstance__Offset, false);}
			
		}
		
		static readonly int WalkableSlopeOverride__Offset;
		public FWalkableSlopeOverride WalkableSlopeOverride
		{
			get{ CheckIsValid();return (FWalkableSlopeOverride)Marshal.PtrToStructure(_this.Get()+WalkableSlopeOverride__Offset, typeof(FWalkableSlopeOverride));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+WalkableSlopeOverride__Offset, false);}
			
		}
		
		static readonly int BuildScale__Offset;
		public float BuildScale
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+BuildScale__Offset, typeof(float));}
			
		}
		
		static readonly int BuildScale3D__Offset;
		public FVector BuildScale3D
		{
			get{ CheckIsValid();return (FVector)Marshal.PtrToStructure(_this.Get()+BuildScale3D__Offset, typeof(FVector));}
			
		}
		
		static UBodySetup()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("BodySetup");
			AggGeom__Offset=GetPropertyOffset(NativeClassPtr,"AggGeom");
			BoneName__Offset=GetPropertyOffset(NativeClassPtr,"BoneName");
			PhysicsType__Offset=GetPropertyOffset(NativeClassPtr,"PhysicsType");
			bAlwaysFullAnimWeight__Offset=GetPropertyOffset(NativeClassPtr,"bAlwaysFullAnimWeight");
			bConsiderForBounds__Offset=GetPropertyOffset(NativeClassPtr,"bConsiderForBounds");
			bMeshCollideAll__Offset=GetPropertyOffset(NativeClassPtr,"bMeshCollideAll");
			bDoubleSidedGeometry__Offset=GetPropertyOffset(NativeClassPtr,"bDoubleSidedGeometry");
			bGenerateNonMirroredCollision__Offset=GetPropertyOffset(NativeClassPtr,"bGenerateNonMirroredCollision");
			bSharedCookedData__Offset=GetPropertyOffset(NativeClassPtr,"bSharedCookedData");
			bGenerateMirroredCollision__Offset=GetPropertyOffset(NativeClassPtr,"bGenerateMirroredCollision");
			PhysMaterial__Offset=GetPropertyOffset(NativeClassPtr,"PhysMaterial");
			CollisionReponse__Offset=GetPropertyOffset(NativeClassPtr,"CollisionReponse");
			CollisionTraceFlag__Offset=GetPropertyOffset(NativeClassPtr,"CollisionTraceFlag");
			DefaultInstance__Offset=GetPropertyOffset(NativeClassPtr,"DefaultInstance");
			WalkableSlopeOverride__Offset=GetPropertyOffset(NativeClassPtr,"WalkableSlopeOverride");
			BuildScale__Offset=GetPropertyOffset(NativeClassPtr,"BuildScale");
			BuildScale3D__Offset=GetPropertyOffset(NativeClassPtr,"BuildScale3D");
			
		}
		
	}
	
}
#endif
#endif
