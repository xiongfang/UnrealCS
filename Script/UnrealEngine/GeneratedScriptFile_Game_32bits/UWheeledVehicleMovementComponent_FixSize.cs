#if WITH_GAME
#if PLATFORM_32BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class UWheeledVehicleMovementComponent
	{
		static readonly int bDeprecatedSpringOffsetMode__Offset;
		public bool bDeprecatedSpringOffsetMode
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bDeprecatedSpringOffsetMode__Offset, 1, 0, 1, 1);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bDeprecatedSpringOffsetMode__Offset, 1,0,1,1);}
			
		}
		
		static readonly int WheelSetups__Offset;
		public TStructArray<FWheelSetup> WheelSetups
		{
			get{ CheckIsValid();return new TStructArray<FWheelSetup>((FScriptArray)Marshal.PtrToStructure(_this.Get()+WheelSetups__Offset, typeof(FScriptArray)));}
					set{ CheckIsValid();Marshal.StructureToPtr(value.InterArray, _this.Get()+WheelSetups__Offset, false);}
			
		}
		
		static readonly int Mass__Offset;
		public float Mass
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+Mass__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+Mass__Offset, false);}
			
		}
		
		static readonly int DragCoefficient__Offset;
		public float DragCoefficient
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+DragCoefficient__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+DragCoefficient__Offset, false);}
			
		}
		
		static readonly int ChassisWidth__Offset;
		public float ChassisWidth
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+ChassisWidth__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+ChassisWidth__Offset, false);}
			
		}
		
		static readonly int ChassisHeight__Offset;
		public float ChassisHeight
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+ChassisHeight__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+ChassisHeight__Offset, false);}
			
		}
		
		static readonly int bReverseAsBrake__Offset;
		public bool bReverseAsBrake
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bReverseAsBrake__Offset, 1, 0, 1, 255);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bReverseAsBrake__Offset, 1,0,1,255);}
			
		}
		
		static readonly int DragArea__Offset;
		public float DragArea
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+DragArea__Offset, typeof(float));}
			
		}
		
		static readonly int EstimatedMaxEngineSpeed__Offset;
		public float EstimatedMaxEngineSpeed
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+EstimatedMaxEngineSpeed__Offset, typeof(float));}
			
		}
		
		static readonly int MaxEngineRPM__Offset;
		public float MaxEngineRPM
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+MaxEngineRPM__Offset, typeof(float));}
			
		}
		
		static readonly int DebugDragMagnitude__Offset;
		public float DebugDragMagnitude
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+DebugDragMagnitude__Offset, typeof(float));}
			
		}
		
		static readonly int InertiaTensorScale__Offset;
		public FVector InertiaTensorScale
		{
			get{ CheckIsValid();return (FVector)Marshal.PtrToStructure(_this.Get()+InertiaTensorScale__Offset, typeof(FVector));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+InertiaTensorScale__Offset, false);}
			
		}
		
		static readonly int MinNormalizedTireLoad__Offset;
		public float MinNormalizedTireLoad
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+MinNormalizedTireLoad__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+MinNormalizedTireLoad__Offset, false);}
			
		}
		
		static readonly int MinNormalizedTireLoadFiltered__Offset;
		public float MinNormalizedTireLoadFiltered
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+MinNormalizedTireLoadFiltered__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+MinNormalizedTireLoadFiltered__Offset, false);}
			
		}
		
		static readonly int MaxNormalizedTireLoad__Offset;
		public float MaxNormalizedTireLoad
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+MaxNormalizedTireLoad__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+MaxNormalizedTireLoad__Offset, false);}
			
		}
		
		static readonly int MaxNormalizedTireLoadFiltered__Offset;
		public float MaxNormalizedTireLoadFiltered
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+MaxNormalizedTireLoadFiltered__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+MaxNormalizedTireLoadFiltered__Offset, false);}
			
		}
		
		static readonly int ThresholdLongitudinalSpeed__Offset;
		public float ThresholdLongitudinalSpeed
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+ThresholdLongitudinalSpeed__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+ThresholdLongitudinalSpeed__Offset, false);}
			
		}
		
		static readonly int LowForwardSpeedSubStepCount__Offset;
		public int LowForwardSpeedSubStepCount
		{
			get{ CheckIsValid();return (int)Marshal.PtrToStructure(_this.Get()+LowForwardSpeedSubStepCount__Offset, typeof(int));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+LowForwardSpeedSubStepCount__Offset, false);}
			
		}
		
		static readonly int HighForwardSpeedSubStepCount__Offset;
		public int HighForwardSpeedSubStepCount
		{
			get{ CheckIsValid();return (int)Marshal.PtrToStructure(_this.Get()+HighForwardSpeedSubStepCount__Offset, typeof(int));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+HighForwardSpeedSubStepCount__Offset, false);}
			
		}
		
		static readonly int Wheels__Offset;
		public TObjectArray<UVehicleWheel>  Wheels
		{
					get{ CheckIsValid();return new TObjectArray<UVehicleWheel>((FScriptArray)Marshal.PtrToStructure(_this.Get()+Wheels__Offset, typeof(FScriptArray)));}
					set{ CheckIsValid();Marshal.StructureToPtr(value.InterArray, _this.Get()+Wheels__Offset, false);}
			
		}
		
		static readonly int bUseRVOAvoidance__Offset;
		public bool bUseRVOAvoidance
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bUseRVOAvoidance__Offset, 1, 0, 1, 1);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bUseRVOAvoidance__Offset, 1,0,1,1);}
			
		}
		
		static readonly int RVOAvoidanceRadius__Offset;
		public float RVOAvoidanceRadius
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+RVOAvoidanceRadius__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+RVOAvoidanceRadius__Offset, false);}
			
		}
		
		static readonly int RVOAvoidanceHeight__Offset;
		public float RVOAvoidanceHeight
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+RVOAvoidanceHeight__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+RVOAvoidanceHeight__Offset, false);}
			
		}
		
		static readonly int AvoidanceConsiderationRadius__Offset;
		public float AvoidanceConsiderationRadius
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+AvoidanceConsiderationRadius__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+AvoidanceConsiderationRadius__Offset, false);}
			
		}
		
		static readonly int RVOSteeringStep__Offset;
		public float RVOSteeringStep
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+RVOSteeringStep__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+RVOSteeringStep__Offset, false);}
			
		}
		
		static readonly int RVOThrottleStep__Offset;
		public float RVOThrottleStep
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+RVOThrottleStep__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+RVOThrottleStep__Offset, false);}
			
		}
		
		static readonly int AvoidanceUID__Offset;
		public int AvoidanceUID
		{
			get{ CheckIsValid();return (int)Marshal.PtrToStructure(_this.Get()+AvoidanceUID__Offset, typeof(int));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+AvoidanceUID__Offset, false);}
			
		}
		
		static readonly int AvoidanceGroup__Offset;
		public FNavAvoidanceMask AvoidanceGroup
		{
			get{ CheckIsValid();return (FNavAvoidanceMask)Marshal.PtrToStructure(_this.Get()+AvoidanceGroup__Offset, typeof(FNavAvoidanceMask));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+AvoidanceGroup__Offset, false);}
			
		}
		
		static readonly int GroupsToAvoid__Offset;
		public FNavAvoidanceMask GroupsToAvoid
		{
			get{ CheckIsValid();return (FNavAvoidanceMask)Marshal.PtrToStructure(_this.Get()+GroupsToAvoid__Offset, typeof(FNavAvoidanceMask));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+GroupsToAvoid__Offset, false);}
			
		}
		
		static readonly int GroupsToIgnore__Offset;
		public FNavAvoidanceMask GroupsToIgnore
		{
			get{ CheckIsValid();return (FNavAvoidanceMask)Marshal.PtrToStructure(_this.Get()+GroupsToIgnore__Offset, typeof(FNavAvoidanceMask));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+GroupsToIgnore__Offset, false);}
			
		}
		
		static readonly int AvoidanceWeight__Offset;
		public float AvoidanceWeight
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+AvoidanceWeight__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+AvoidanceWeight__Offset, false);}
			
		}
		
		static readonly int PendingLaunchVelocity__Offset;
		public FVector PendingLaunchVelocity
		{
			get{ CheckIsValid();return (FVector)Marshal.PtrToStructure(_this.Get()+PendingLaunchVelocity__Offset, typeof(FVector));}
			
		}
		
		static readonly int ReplicatedState__Offset;
		public FReplicatedVehicleState ReplicatedState
		{
			get{ CheckIsValid();return (FReplicatedVehicleState)Marshal.PtrToStructure(_this.Get()+ReplicatedState__Offset, typeof(FReplicatedVehicleState));}
			
		}
		
		static readonly int RawSteeringInput__Offset;
		public float RawSteeringInput
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+RawSteeringInput__Offset, typeof(float));}
			
		}
		
		static readonly int RawThrottleInput__Offset;
		public float RawThrottleInput
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+RawThrottleInput__Offset, typeof(float));}
			
		}
		
		static readonly int RawBrakeInput__Offset;
		public float RawBrakeInput
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+RawBrakeInput__Offset, typeof(float));}
			
		}
		
		static readonly int bRawHandbrakeInput__Offset;
		public bool bRawHandbrakeInput
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bRawHandbrakeInput__Offset, 1, 0, 1, 1);}
			
		}
		
		static readonly int bRawGearUpInput__Offset;
		public bool bRawGearUpInput
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bRawGearUpInput__Offset, 1, 0, 2, 2);}
			
		}
		
		static readonly int bRawGearDownInput__Offset;
		public bool bRawGearDownInput
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bRawGearDownInput__Offset, 1, 0, 4, 4);}
			
		}
		
		static readonly int SteeringInput__Offset;
		public float SteeringInput
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+SteeringInput__Offset, typeof(float));}
			
		}
		
		static readonly int ThrottleInput__Offset;
		public float ThrottleInput
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+ThrottleInput__Offset, typeof(float));}
			
		}
		
		static readonly int BrakeInput__Offset;
		public float BrakeInput
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+BrakeInput__Offset, typeof(float));}
			
		}
		
		static readonly int HandbrakeInput__Offset;
		public float HandbrakeInput
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+HandbrakeInput__Offset, typeof(float));}
			
		}
		
		static readonly int IdleBrakeInput__Offset;
		public float IdleBrakeInput
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+IdleBrakeInput__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+IdleBrakeInput__Offset, false);}
			
		}
		
		static readonly int StopThreshold__Offset;
		public float StopThreshold
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+StopThreshold__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+StopThreshold__Offset, false);}
			
		}
		
		static readonly int WrongDirectionThreshold__Offset;
		public float WrongDirectionThreshold
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+WrongDirectionThreshold__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+WrongDirectionThreshold__Offset, false);}
			
		}
		
		static readonly int ThrottleInputRate__Offset;
		public FVehicleInputRate ThrottleInputRate
		{
			get{ CheckIsValid();return (FVehicleInputRate)Marshal.PtrToStructure(_this.Get()+ThrottleInputRate__Offset, typeof(FVehicleInputRate));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+ThrottleInputRate__Offset, false);}
			
		}
		
		static readonly int BrakeInputRate__Offset;
		public FVehicleInputRate BrakeInputRate
		{
			get{ CheckIsValid();return (FVehicleInputRate)Marshal.PtrToStructure(_this.Get()+BrakeInputRate__Offset, typeof(FVehicleInputRate));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+BrakeInputRate__Offset, false);}
			
		}
		
		static readonly int HandbrakeInputRate__Offset;
		public FVehicleInputRate HandbrakeInputRate
		{
			get{ CheckIsValid();return (FVehicleInputRate)Marshal.PtrToStructure(_this.Get()+HandbrakeInputRate__Offset, typeof(FVehicleInputRate));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+HandbrakeInputRate__Offset, false);}
			
		}
		
		static readonly int SteeringInputRate__Offset;
		public FVehicleInputRate SteeringInputRate
		{
			get{ CheckIsValid();return (FVehicleInputRate)Marshal.PtrToStructure(_this.Get()+SteeringInputRate__Offset, typeof(FVehicleInputRate));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+SteeringInputRate__Offset, false);}
			
		}
		
		static readonly int bWasAvoidanceUpdated__Offset;
		public bool bWasAvoidanceUpdated
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bWasAvoidanceUpdated__Offset, 1, 0, 1, 1);}
			
		}
		
		static UWheeledVehicleMovementComponent()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("WheeledVehicleMovementComponent");
			bDeprecatedSpringOffsetMode__Offset=GetPropertyOffset(NativeClassPtr,"bDeprecatedSpringOffsetMode");
			WheelSetups__Offset=GetPropertyOffset(NativeClassPtr,"WheelSetups");
			Mass__Offset=GetPropertyOffset(NativeClassPtr,"Mass");
			DragCoefficient__Offset=GetPropertyOffset(NativeClassPtr,"DragCoefficient");
			ChassisWidth__Offset=GetPropertyOffset(NativeClassPtr,"ChassisWidth");
			ChassisHeight__Offset=GetPropertyOffset(NativeClassPtr,"ChassisHeight");
			bReverseAsBrake__Offset=GetPropertyOffset(NativeClassPtr,"bReverseAsBrake");
			DragArea__Offset=GetPropertyOffset(NativeClassPtr,"DragArea");
			EstimatedMaxEngineSpeed__Offset=GetPropertyOffset(NativeClassPtr,"EstimatedMaxEngineSpeed");
			MaxEngineRPM__Offset=GetPropertyOffset(NativeClassPtr,"MaxEngineRPM");
			DebugDragMagnitude__Offset=GetPropertyOffset(NativeClassPtr,"DebugDragMagnitude");
			InertiaTensorScale__Offset=GetPropertyOffset(NativeClassPtr,"InertiaTensorScale");
			MinNormalizedTireLoad__Offset=GetPropertyOffset(NativeClassPtr,"MinNormalizedTireLoad");
			MinNormalizedTireLoadFiltered__Offset=GetPropertyOffset(NativeClassPtr,"MinNormalizedTireLoadFiltered");
			MaxNormalizedTireLoad__Offset=GetPropertyOffset(NativeClassPtr,"MaxNormalizedTireLoad");
			MaxNormalizedTireLoadFiltered__Offset=GetPropertyOffset(NativeClassPtr,"MaxNormalizedTireLoadFiltered");
			ThresholdLongitudinalSpeed__Offset=GetPropertyOffset(NativeClassPtr,"ThresholdLongitudinalSpeed");
			LowForwardSpeedSubStepCount__Offset=GetPropertyOffset(NativeClassPtr,"LowForwardSpeedSubStepCount");
			HighForwardSpeedSubStepCount__Offset=GetPropertyOffset(NativeClassPtr,"HighForwardSpeedSubStepCount");
			Wheels__Offset=GetPropertyOffset(NativeClassPtr,"Wheels");
			bUseRVOAvoidance__Offset=GetPropertyOffset(NativeClassPtr,"bUseRVOAvoidance");
			RVOAvoidanceRadius__Offset=GetPropertyOffset(NativeClassPtr,"RVOAvoidanceRadius");
			RVOAvoidanceHeight__Offset=GetPropertyOffset(NativeClassPtr,"RVOAvoidanceHeight");
			AvoidanceConsiderationRadius__Offset=GetPropertyOffset(NativeClassPtr,"AvoidanceConsiderationRadius");
			RVOSteeringStep__Offset=GetPropertyOffset(NativeClassPtr,"RVOSteeringStep");
			RVOThrottleStep__Offset=GetPropertyOffset(NativeClassPtr,"RVOThrottleStep");
			AvoidanceUID__Offset=GetPropertyOffset(NativeClassPtr,"AvoidanceUID");
			AvoidanceGroup__Offset=GetPropertyOffset(NativeClassPtr,"AvoidanceGroup");
			GroupsToAvoid__Offset=GetPropertyOffset(NativeClassPtr,"GroupsToAvoid");
			GroupsToIgnore__Offset=GetPropertyOffset(NativeClassPtr,"GroupsToIgnore");
			AvoidanceWeight__Offset=GetPropertyOffset(NativeClassPtr,"AvoidanceWeight");
			PendingLaunchVelocity__Offset=GetPropertyOffset(NativeClassPtr,"PendingLaunchVelocity");
			ReplicatedState__Offset=GetPropertyOffset(NativeClassPtr,"ReplicatedState");
			RawSteeringInput__Offset=GetPropertyOffset(NativeClassPtr,"RawSteeringInput");
			RawThrottleInput__Offset=GetPropertyOffset(NativeClassPtr,"RawThrottleInput");
			RawBrakeInput__Offset=GetPropertyOffset(NativeClassPtr,"RawBrakeInput");
			bRawHandbrakeInput__Offset=GetPropertyOffset(NativeClassPtr,"bRawHandbrakeInput");
			bRawGearUpInput__Offset=GetPropertyOffset(NativeClassPtr,"bRawGearUpInput");
			bRawGearDownInput__Offset=GetPropertyOffset(NativeClassPtr,"bRawGearDownInput");
			SteeringInput__Offset=GetPropertyOffset(NativeClassPtr,"SteeringInput");
			ThrottleInput__Offset=GetPropertyOffset(NativeClassPtr,"ThrottleInput");
			BrakeInput__Offset=GetPropertyOffset(NativeClassPtr,"BrakeInput");
			HandbrakeInput__Offset=GetPropertyOffset(NativeClassPtr,"HandbrakeInput");
			IdleBrakeInput__Offset=GetPropertyOffset(NativeClassPtr,"IdleBrakeInput");
			StopThreshold__Offset=GetPropertyOffset(NativeClassPtr,"StopThreshold");
			WrongDirectionThreshold__Offset=GetPropertyOffset(NativeClassPtr,"WrongDirectionThreshold");
			ThrottleInputRate__Offset=GetPropertyOffset(NativeClassPtr,"ThrottleInputRate");
			BrakeInputRate__Offset=GetPropertyOffset(NativeClassPtr,"BrakeInputRate");
			HandbrakeInputRate__Offset=GetPropertyOffset(NativeClassPtr,"HandbrakeInputRate");
			SteeringInputRate__Offset=GetPropertyOffset(NativeClassPtr,"SteeringInputRate");
			bWasAvoidanceUpdated__Offset=GetPropertyOffset(NativeClassPtr,"bWasAvoidanceUpdated");
			
		}
		
	}
	
}
#endif
#endif
