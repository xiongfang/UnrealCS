#if WITH_GAME
#if PLATFORM_32BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class UMovementComponent
	{
		static readonly int UpdatedComponent__Offset;
		public USceneComponent UpdatedComponent
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + UpdatedComponent__Offset); if (v == IntPtr.Zero)return null; USceneComponent retValue = new USceneComponent(); retValue._this = v; return retValue; }
			
		}
		
		static readonly int UpdatedPrimitive__Offset;
		public UPrimitiveComponent UpdatedPrimitive
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + UpdatedPrimitive__Offset); if (v == IntPtr.Zero)return null; UPrimitiveComponent retValue = new UPrimitiveComponent(); retValue._this = v; return retValue; }
			
		}
		
		static readonly int Velocity__Offset;
		public FVector Velocity
		{
			get{ CheckIsValid();return (FVector)Marshal.PtrToStructure(_this.Get()+Velocity__Offset, typeof(FVector));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+Velocity__Offset, false);}
			
		}
		
		static readonly int bConstrainToPlane__Offset;
		public bool bConstrainToPlane
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bConstrainToPlane__Offset, 1, 0, 1, 1);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bConstrainToPlane__Offset, 1,0,1,1);}
			
		}
		
		static readonly int bSnapToPlaneAtStart__Offset;
		public bool bSnapToPlaneAtStart
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bSnapToPlaneAtStart__Offset, 1, 0, 2, 2);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bSnapToPlaneAtStart__Offset, 1,0,2,2);}
			
		}
		
		static readonly int PlaneConstraintNormal__Offset;
		public FVector PlaneConstraintNormal
		{
			get{ CheckIsValid();return (FVector)Marshal.PtrToStructure(_this.Get()+PlaneConstraintNormal__Offset, typeof(FVector));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+PlaneConstraintNormal__Offset, false);}
			
		}
		
		static readonly int PlaneConstraintOrigin__Offset;
		public FVector PlaneConstraintOrigin
		{
			get{ CheckIsValid();return (FVector)Marshal.PtrToStructure(_this.Get()+PlaneConstraintOrigin__Offset, typeof(FVector));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+PlaneConstraintOrigin__Offset, false);}
			
		}
		
		static readonly int bUpdateOnlyIfRendered__Offset;
		public bool bUpdateOnlyIfRendered
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bUpdateOnlyIfRendered__Offset, 1, 0, 1, 1);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bUpdateOnlyIfRendered__Offset, 1,0,1,1);}
			
		}
		
		static readonly int bAutoUpdateTickRegistration__Offset;
		public bool bAutoUpdateTickRegistration
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bAutoUpdateTickRegistration__Offset, 1, 0, 2, 2);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bAutoUpdateTickRegistration__Offset, 1,0,2,2);}
			
		}
		
		static readonly int bTickBeforeOwner__Offset;
		public bool bTickBeforeOwner
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bTickBeforeOwner__Offset, 1, 0, 4, 4);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bTickBeforeOwner__Offset, 1,0,4,4);}
			
		}
		
		static readonly int bAutoRegisterUpdatedComponent__Offset;
		public bool bAutoRegisterUpdatedComponent
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bAutoRegisterUpdatedComponent__Offset, 1, 0, 8, 8);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bAutoRegisterUpdatedComponent__Offset, 1,0,8,8);}
			
		}
		
		static UMovementComponent()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("MovementComponent");
			UpdatedComponent__Offset=GetPropertyOffset(NativeClassPtr,"UpdatedComponent");
			UpdatedPrimitive__Offset=GetPropertyOffset(NativeClassPtr,"UpdatedPrimitive");
			Velocity__Offset=GetPropertyOffset(NativeClassPtr,"Velocity");
			bConstrainToPlane__Offset=GetPropertyOffset(NativeClassPtr,"bConstrainToPlane");
			bSnapToPlaneAtStart__Offset=GetPropertyOffset(NativeClassPtr,"bSnapToPlaneAtStart");
			PlaneConstraintNormal__Offset=GetPropertyOffset(NativeClassPtr,"PlaneConstraintNormal");
			PlaneConstraintOrigin__Offset=GetPropertyOffset(NativeClassPtr,"PlaneConstraintOrigin");
			bUpdateOnlyIfRendered__Offset=GetPropertyOffset(NativeClassPtr,"bUpdateOnlyIfRendered");
			bAutoUpdateTickRegistration__Offset=GetPropertyOffset(NativeClassPtr,"bAutoUpdateTickRegistration");
			bTickBeforeOwner__Offset=GetPropertyOffset(NativeClassPtr,"bTickBeforeOwner");
			bAutoRegisterUpdatedComponent__Offset=GetPropertyOffset(NativeClassPtr,"bAutoRegisterUpdatedComponent");
			
		}
		
	}
	
}
#endif
#endif
