#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>NavMovementComponent defines base functionality for MovementComponents that move any 'agent' that may be involved in AI pathfinding.</summary>
	public partial class UNavMovementComponent
	{
		static readonly int NavAgentProps__Offset;
		/// <summary>Properties that define how the component can move.</summary>
		public FNavAgentProperties NavAgentProps
		{
			get{ CheckIsValid();return (FNavAgentProperties)Marshal.PtrToStructure(_this.Get()+NavAgentProps__Offset, typeof(FNavAgentProperties));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+NavAgentProps__Offset, false);}
			
		}
		
		static readonly int FixedPathBrakingDistance__Offset;
		/// <summary>Braking distance override used with acceleration driven path following (bUseAccelerationForPaths)</summary>
		public float FixedPathBrakingDistance
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+FixedPathBrakingDistance__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+FixedPathBrakingDistance__Offset, false);}
			
		}
		
		static readonly int bUpdateNavAgentWithOwnersCollision__Offset;
		/// <summary>If set to true NavAgentProps' radius and height will be updated with Owner's collision capsule size</summary>
		public bool bUpdateNavAgentWithOwnersCollision
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bUpdateNavAgentWithOwnersCollision__Offset, 1, 0, 1, 1);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bUpdateNavAgentWithOwnersCollision__Offset, 1,0,1,1);}
			
		}
		
		static readonly int bUseAccelerationForPaths__Offset;
		/// <summary>If set, pathfollowing will control character movement via acceleration values. If false, it will set velocities directly.</summary>
		public bool bUseAccelerationForPaths
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bUseAccelerationForPaths__Offset, 1, 0, 2, 2);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bUseAccelerationForPaths__Offset, 1,0,2,2);}
			
		}
		
		static readonly int bUseFixedBrakingDistanceForPaths__Offset;
		/// <summary>If set, FixedPathBrakingDistance will be used for path following deceleration</summary>
		public bool bUseFixedBrakingDistanceForPaths
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bUseFixedBrakingDistanceForPaths__Offset, 1, 0, 4, 4);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bUseFixedBrakingDistanceForPaths__Offset, 1,0,4,4);}
			
		}
		
		static readonly int MovementState__Offset;
		/// <summary>Expresses runtime state of character's movement. Put all temporal changes to movement properties here</summary>
		public FMovementProperties MovementState
		{
			get{ CheckIsValid();return (FMovementProperties)Marshal.PtrToStructure(_this.Get()+MovementState__Offset, typeof(FMovementProperties));}
			
		}
		
		static UNavMovementComponent()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("NavMovementComponent");
			NavAgentProps__Offset=GetPropertyOffset(NativeClassPtr,"NavAgentProps");
			FixedPathBrakingDistance__Offset=GetPropertyOffset(NativeClassPtr,"FixedPathBrakingDistance");
			bUpdateNavAgentWithOwnersCollision__Offset=GetPropertyOffset(NativeClassPtr,"bUpdateNavAgentWithOwnersCollision");
			bUseAccelerationForPaths__Offset=GetPropertyOffset(NativeClassPtr,"bUseAccelerationForPaths");
			bUseFixedBrakingDistanceForPaths__Offset=GetPropertyOffset(NativeClassPtr,"bUseFixedBrakingDistanceForPaths");
			MovementState__Offset=GetPropertyOffset(NativeClassPtr,"MovementState");
			
		}
		
	}
	
}
#endif
#endif
