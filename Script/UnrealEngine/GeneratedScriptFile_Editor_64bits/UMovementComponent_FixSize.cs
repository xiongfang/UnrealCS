#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>
	/// MovementComponent is an abstract component class that defines functionality for moving a PrimitiveComponent (our UpdatedComponent) each tick.
	/// Base functionality includes:
	///    - Restricting movement to a plane or axis.
	///    - Utility functions for special handling of collision results (SlideAlongSurface(), ComputeSlideVector(), TwoWallAdjust()).
	///    - Utility functions for moving when there may be initial penetration (SafeMoveUpdatedComponent(), ResolvePenetration()).
	///    - Automatically registering the component tick and finding a component to move on the owning Actor.
	/// Normally the root component of the owning actor is moved, however another component may be selected (see SetUpdatedComponent()).
	/// During swept (non-teleporting) movement only collision of UpdatedComponent is considered, attached components will teleport to the end location ignoring collision.
	/// </summary>
	public partial class UMovementComponent
	{
		static readonly int UpdatedComponent__Offset;
		/// <summary>
		/// The component we move and update.
		/// If this is null at startup and bAutoRegisterUpdatedComponent is true, the owning Actor's root component will automatically be set as our UpdatedComponent at startup.
		/// @see bAutoRegisterUpdatedComponent, SetUpdatedComponent(), UpdatedPrimitive
		/// </summary>
		public USceneComponent UpdatedComponent
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + UpdatedComponent__Offset); if (v == IntPtr.Zero)return null; USceneComponent retValue = new USceneComponent(); retValue._this = v; return retValue; }
			
		}
		
		static readonly int UpdatedPrimitive__Offset;
		/// <summary>UpdatedComponent, cast as a UPrimitiveComponent. May be invalid if UpdatedComponent was null or not a UPrimitiveComponent.</summary>
		public UPrimitiveComponent UpdatedPrimitive
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + UpdatedPrimitive__Offset); if (v == IntPtr.Zero)return null; UPrimitiveComponent retValue = new UPrimitiveComponent(); retValue._this = v; return retValue; }
			
		}
		
		static readonly int Velocity__Offset;
		/// <summary>Current velocity of updated component.</summary>
		public FVector Velocity
		{
			get{ CheckIsValid();return (FVector)Marshal.PtrToStructure(_this.Get()+Velocity__Offset, typeof(FVector));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+Velocity__Offset, false);}
			
		}
		
		static readonly int bConstrainToPlane__Offset;
		/// <summary>
		/// If true, movement will be constrained to a plane.
		/// @see PlaneConstraintNormal, PlaneConstraintOrigin, PlaneConstraintAxisSetting
		/// </summary>
		public bool bConstrainToPlane
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bConstrainToPlane__Offset, 1, 0, 1, 1);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bConstrainToPlane__Offset, 1,0,1,1);}
			
		}
		
		static readonly int bSnapToPlaneAtStart__Offset;
		/// <summary>If true and plane constraints are enabled, then the updated component will be snapped to the plane when first attached.</summary>
		public bool bSnapToPlaneAtStart
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bSnapToPlaneAtStart__Offset, 1, 0, 2, 2);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bSnapToPlaneAtStart__Offset, 1,0,2,2);}
			
		}
		
		static readonly int PlaneConstraintNormal__Offset;
		/// <summary>
		/// The normal or axis of the plane that constrains movement, if bConstrainToPlane is enabled.
		/// If for example you wanted to constrain movement to the X-Z plane (so that Y cannot change), the normal would be set to X=0 Y=1 Z=0.
		/// This is recalculated whenever PlaneConstraintAxisSetting changes. It is normalized once the component is registered with the game world.
		/// @see bConstrainToPlane, SetPlaneConstraintNormal(), SetPlaneConstraintFromVectors()
		/// </summary>
		public FVector PlaneConstraintNormal
		{
			get{ CheckIsValid();return (FVector)Marshal.PtrToStructure(_this.Get()+PlaneConstraintNormal__Offset, typeof(FVector));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+PlaneConstraintNormal__Offset, false);}
			
		}
		
		static readonly int PlaneConstraintOrigin__Offset;
		/// <summary>
		/// The origin of the plane that constrains movement, if plane constraint is enabled.
		/// This defines the behavior of snapping a position to the plane, such as by SnapUpdatedComponentToPlane().
		/// @see bConstrainToPlane, SetPlaneConstraintOrigin().
		/// </summary>
		public FVector PlaneConstraintOrigin
		{
			get{ CheckIsValid();return (FVector)Marshal.PtrToStructure(_this.Get()+PlaneConstraintOrigin__Offset, typeof(FVector));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+PlaneConstraintOrigin__Offset, false);}
			
		}
		
		static readonly int bUpdateOnlyIfRendered__Offset;
		/// <summary>If true, skips TickComponent() if UpdatedComponent was not recently rendered.</summary>
		public bool bUpdateOnlyIfRendered
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bUpdateOnlyIfRendered__Offset, 1, 0, 1, 1);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bUpdateOnlyIfRendered__Offset, 1,0,1,1);}
			
		}
		
		static readonly int bAutoUpdateTickRegistration__Offset;
		/// <summary>
		/// If true, whenever the updated component is changed, this component will enable or disable its tick dependent on whether it has something to update.
		/// This will NOT enable tick at startup if bAutoActivate is false, because presumably you have a good reason for not wanting it to start ticking initially.
		/// </summary>
		public bool bAutoUpdateTickRegistration
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bAutoUpdateTickRegistration__Offset, 1, 0, 2, 2);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bAutoUpdateTickRegistration__Offset, 1,0,2,2);}
			
		}
		
		static readonly int bTickBeforeOwner__Offset;
		/// <summary>
		/// If true, after registration we will add a tick dependency to tick before our owner (if we can both tick).
		/// This is important when our tick causes an update in the owner's position, so that when the owner ticks it uses the most recent position without lag.
		/// Disabling this can improve performance if both objects tick but the order of ticks doesn't matter.
		/// </summary>
		public bool bTickBeforeOwner
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bTickBeforeOwner__Offset, 1, 0, 4, 4);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bTickBeforeOwner__Offset, 1,0,4,4);}
			
		}
		
		static readonly int bAutoRegisterUpdatedComponent__Offset;
		/// <summary>If true, registers the owner's Root component as the UpdatedComponent if there is not one currently assigned.</summary>
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
