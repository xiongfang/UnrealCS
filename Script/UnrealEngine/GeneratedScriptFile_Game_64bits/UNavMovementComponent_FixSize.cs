#if WITH_GAME
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class UNavMovementComponent
	{
		static readonly int NavAgentProps__Offset;
		public FNavAgentProperties NavAgentProps
		{
			get{ CheckIsValid();return (FNavAgentProperties)Marshal.PtrToStructure(_this.Get()+NavAgentProps__Offset, typeof(FNavAgentProperties));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+NavAgentProps__Offset, false);}
			
		}
		
		static readonly int FixedPathBrakingDistance__Offset;
		public float FixedPathBrakingDistance
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+FixedPathBrakingDistance__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+FixedPathBrakingDistance__Offset, false);}
			
		}
		
		static readonly int bUpdateNavAgentWithOwnersCollision__Offset;
		public bool bUpdateNavAgentWithOwnersCollision
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bUpdateNavAgentWithOwnersCollision__Offset, 1, 0, 1, 1);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bUpdateNavAgentWithOwnersCollision__Offset, 1,0,1,1);}
			
		}
		
		static readonly int bUseAccelerationForPaths__Offset;
		public bool bUseAccelerationForPaths
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bUseAccelerationForPaths__Offset, 1, 0, 2, 2);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bUseAccelerationForPaths__Offset, 1,0,2,2);}
			
		}
		
		static readonly int bUseFixedBrakingDistanceForPaths__Offset;
		public bool bUseFixedBrakingDistanceForPaths
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bUseFixedBrakingDistanceForPaths__Offset, 1, 0, 4, 4);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bUseFixedBrakingDistanceForPaths__Offset, 1,0,4,4);}
			
		}
		
		static readonly int MovementState__Offset;
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
