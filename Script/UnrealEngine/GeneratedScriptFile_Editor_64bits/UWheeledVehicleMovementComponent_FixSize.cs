#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>Component to handle the vehicle simulation for an actor.</summary>
	public partial class UWheeledVehicleMovementComponent
	{
		static readonly int WheelSetups__Offset;
		/// <summary>Wheels to create</summary>
		public TStructArray<FWheelSetup> WheelSetups
		{
			get{ CheckIsValid();return new TStructArray<FWheelSetup>((FScriptArray)Marshal.PtrToStructure(_this.Get()+WheelSetups__Offset, typeof(FScriptArray)));}
					set{ CheckIsValid();Marshal.StructureToPtr(value.InterArray, _this.Get()+WheelSetups__Offset, false);}
			
		}
		
		static readonly int Mass__Offset;
		/// <summary>
		/// Mass to set the vehicle chassis to. It's much easier to tweak vehicle settings when
		/// the mass doesn't change due to tweaks with the physics asset. [kg]
		/// </summary>
		public float Mass
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+Mass__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+Mass__Offset, false);}
			
		}
		
		static readonly int DragCoefficient__Offset;
		/// <summary>DragCoefficient of the vehicle chassis.</summary>
		public float DragCoefficient
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+DragCoefficient__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+DragCoefficient__Offset, false);}
			
		}
		
		static readonly int ChassisWidth__Offset;
		/// <summary>Chassis width used for drag force computation (cm)</summary>
		public float ChassisWidth
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+ChassisWidth__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+ChassisWidth__Offset, false);}
			
		}
		
		static readonly int ChassisHeight__Offset;
		/// <summary>Chassis height used for drag force computation (cm)</summary>
		public float ChassisHeight
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+ChassisHeight__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+ChassisHeight__Offset, false);}
			
		}
		
		static readonly int DragArea__Offset;
		/// <summary>Drag area in cm^2</summary>
		public float DragArea
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+DragArea__Offset, typeof(float));}
			
		}
		
		static readonly int EstimatedMaxEngineSpeed__Offset;
		/// <summary>Estimated mad speed for engine</summary>
		public float EstimatedMaxEngineSpeed
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+EstimatedMaxEngineSpeed__Offset, typeof(float));}
			
		}
		
		static readonly int MaxEngineRPM__Offset;
		/// <summary>Max RPM for engine</summary>
		public float MaxEngineRPM
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+MaxEngineRPM__Offset, typeof(float));}
			
		}
		
		static readonly int DebugDragMagnitude__Offset;
		/// <summary>Debug drag magnitude last applied</summary>
		public float DebugDragMagnitude
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+DebugDragMagnitude__Offset, typeof(float));}
			
		}
		
		static readonly int InertiaTensorScale__Offset;
		/// <summary>Scales the vehicle's inertia in each direction (forward, right, up)</summary>
		public FVector InertiaTensorScale
		{
			get{ CheckIsValid();return (FVector)Marshal.PtrToStructure(_this.Get()+InertiaTensorScale__Offset, typeof(FVector));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+InertiaTensorScale__Offset, false);}
			
		}
		
		static readonly int MinNormalizedTireLoad__Offset;
		/// <summary>Clamp normalized tire load to this value</summary>
		public float MinNormalizedTireLoad
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+MinNormalizedTireLoad__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+MinNormalizedTireLoad__Offset, false);}
			
		}
		
		static readonly int MinNormalizedTireLoadFiltered__Offset;
		/// <summary>Clamp normalized tire load to this value</summary>
		public float MinNormalizedTireLoadFiltered
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+MinNormalizedTireLoadFiltered__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+MinNormalizedTireLoadFiltered__Offset, false);}
			
		}
		
		static readonly int MaxNormalizedTireLoad__Offset;
		/// <summary>Clamp normalized tire load to this value</summary>
		public float MaxNormalizedTireLoad
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+MaxNormalizedTireLoad__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+MaxNormalizedTireLoad__Offset, false);}
			
		}
		
		static readonly int MaxNormalizedTireLoadFiltered__Offset;
		/// <summary>Clamp normalized tire load to this value</summary>
		public float MaxNormalizedTireLoadFiltered
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+MaxNormalizedTireLoadFiltered__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+MaxNormalizedTireLoadFiltered__Offset, false);}
			
		}
		
		static readonly int ThresholdLongitudinalSpeed__Offset;
		/// <summary>
		/// PhysX sub-steps
		///     More sub-steps provides better stability but with greater computational cost.
		///     Typically, vehicles require more sub-steps at very low forward speeds.
		///     The threshold longitudinal speed has a default value of 5 metres per second.
		/// </summary>
		public float ThresholdLongitudinalSpeed
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+ThresholdLongitudinalSpeed__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+ThresholdLongitudinalSpeed__Offset, false);}
			
		}
		
		static readonly int LowForwardSpeedSubStepCount__Offset;
		/// <summary>The sub-step count below the threshold longitudinal speed has a default of 3.</summary>
		public int LowForwardSpeedSubStepCount
		{
			get{ CheckIsValid();return (int)Marshal.PtrToStructure(_this.Get()+LowForwardSpeedSubStepCount__Offset, typeof(int));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+LowForwardSpeedSubStepCount__Offset, false);}
			
		}
		
		static readonly int HighForwardSpeedSubStepCount__Offset;
		/// <summary>The sub-step count above the threshold longitudinal speed has a default of 1.</summary>
		public int HighForwardSpeedSubStepCount
		{
			get{ CheckIsValid();return (int)Marshal.PtrToStructure(_this.Get()+HighForwardSpeedSubStepCount__Offset, typeof(int));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+HighForwardSpeedSubStepCount__Offset, false);}
			
		}
		
		static readonly int Wheels__Offset;
		/// <summary>Our instanced wheels</summary>
		public TObjectArray<UVehicleWheel>  Wheels
		{
					get{ CheckIsValid();return new TObjectArray<UVehicleWheel>((FScriptArray)Marshal.PtrToStructure(_this.Get()+Wheels__Offset, typeof(FScriptArray)));}
					set{ CheckIsValid();Marshal.StructureToPtr(value.InterArray, _this.Get()+Wheels__Offset, false);}
			
		}
		
		static readonly int bUseRVOAvoidance__Offset;
		/// <summary>If set, component will use RVO avoidance</summary>
		public bool bUseRVOAvoidance
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bUseRVOAvoidance__Offset, 1, 0, 1, 1);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bUseRVOAvoidance__Offset, 1,0,1,1);}
			
		}
		
		static readonly int RVOAvoidanceRadius__Offset;
		/// <summary>Vehicle Radius to use for RVO avoidance (usually half of vehicle width)</summary>
		public float RVOAvoidanceRadius
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+RVOAvoidanceRadius__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+RVOAvoidanceRadius__Offset, false);}
			
		}
		
		static readonly int RVOAvoidanceHeight__Offset;
		/// <summary>Vehicle Height to use for RVO avoidance (usually vehicle height)</summary>
		public float RVOAvoidanceHeight
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+RVOAvoidanceHeight__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+RVOAvoidanceHeight__Offset, false);}
			
		}
		
		static readonly int AvoidanceConsiderationRadius__Offset;
		/// <summary>Area Radius to consider for RVO avoidance</summary>
		public float AvoidanceConsiderationRadius
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+AvoidanceConsiderationRadius__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+AvoidanceConsiderationRadius__Offset, false);}
			
		}
		
		static readonly int RVOSteeringStep__Offset;
		/// <summary>Value by which to alter steering per frame based on calculated avoidance</summary>
		public float RVOSteeringStep
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+RVOSteeringStep__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+RVOSteeringStep__Offset, false);}
			
		}
		
		static readonly int RVOThrottleStep__Offset;
		/// <summary>Value by which to alter throttle per frame based on calculated avoidance</summary>
		public float RVOThrottleStep
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+RVOThrottleStep__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+RVOThrottleStep__Offset, false);}
			
		}
		
		static readonly int AvoidanceUID__Offset;
		/// <summary>No default value, for now it's assumed to be valid if GetAvoidanceManager() returns non-NULL.</summary>
		public int AvoidanceUID
		{
			get{ CheckIsValid();return (int)Marshal.PtrToStructure(_this.Get()+AvoidanceUID__Offset, typeof(int));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+AvoidanceUID__Offset, false);}
			
		}
		
		static readonly int AvoidanceGroup__Offset;
		/// <summary>Moving actor's group mask</summary>
		public FNavAvoidanceMask AvoidanceGroup
		{
			get{ CheckIsValid();return (FNavAvoidanceMask)Marshal.PtrToStructure(_this.Get()+AvoidanceGroup__Offset, typeof(FNavAvoidanceMask));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+AvoidanceGroup__Offset, false);}
			
		}
		
		static readonly int GroupsToAvoid__Offset;
		/// <summary>Will avoid other agents if they are in one of specified groups</summary>
		public FNavAvoidanceMask GroupsToAvoid
		{
			get{ CheckIsValid();return (FNavAvoidanceMask)Marshal.PtrToStructure(_this.Get()+GroupsToAvoid__Offset, typeof(FNavAvoidanceMask));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+GroupsToAvoid__Offset, false);}
			
		}
		
		static readonly int GroupsToIgnore__Offset;
		/// <summary>Will NOT avoid other agents if they are in one of specified groups, higher priority than GroupsToAvoid</summary>
		public FNavAvoidanceMask GroupsToIgnore
		{
			get{ CheckIsValid();return (FNavAvoidanceMask)Marshal.PtrToStructure(_this.Get()+GroupsToIgnore__Offset, typeof(FNavAvoidanceMask));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+GroupsToIgnore__Offset, false);}
			
		}
		
		static readonly int AvoidanceWeight__Offset;
		/// <summary>De facto default value 0.5 (due to that being the default in the avoidance registration function), indicates RVO behavior.</summary>
		public float AvoidanceWeight
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+AvoidanceWeight__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+AvoidanceWeight__Offset, false);}
			
		}
		
		static readonly int PendingLaunchVelocity__Offset;
		/// <summary>Temporarily holds launch velocity when pawn is to be launched so it happens at end of movement.</summary>
		public FVector PendingLaunchVelocity
		{
			get{ CheckIsValid();return (FVector)Marshal.PtrToStructure(_this.Get()+PendingLaunchVelocity__Offset, typeof(FVector));}
			
		}
		
		static readonly int ReplicatedState__Offset;
		/// <summary>replicated state of vehicle</summary>
		public FReplicatedVehicleState ReplicatedState
		{
			get{ CheckIsValid();return (FReplicatedVehicleState)Marshal.PtrToStructure(_this.Get()+ReplicatedState__Offset, typeof(FReplicatedVehicleState));}
			
		}
		
		static readonly int RawSteeringInput__Offset;
		/// <summary>What the player has the steering set to. Range -1...1</summary>
		public float RawSteeringInput
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+RawSteeringInput__Offset, typeof(float));}
			
		}
		
		static readonly int RawThrottleInput__Offset;
		/// <summary>What the player has the accelerator set to. Range -1...1</summary>
		public float RawThrottleInput
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+RawThrottleInput__Offset, typeof(float));}
			
		}
		
		static readonly int bRawHandbrakeInput__Offset;
		/// <summary>True if the player is holding the handbrake</summary>
		public bool bRawHandbrakeInput
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bRawHandbrakeInput__Offset, 1, 0, 1, 1);}
			
		}
		
		static readonly int bRawGearUpInput__Offset;
		/// <summary>True if the player is holding gear up</summary>
		public bool bRawGearUpInput
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bRawGearUpInput__Offset, 1, 0, 2, 2);}
			
		}
		
		static readonly int bRawGearDownInput__Offset;
		/// <summary>True if the player is holding gear down</summary>
		public bool bRawGearDownInput
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bRawGearDownInput__Offset, 1, 0, 4, 4);}
			
		}
		
		static readonly int SteeringInput__Offset;
		/// <summary>Steering output to physics system. Range -1...1</summary>
		public float SteeringInput
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+SteeringInput__Offset, typeof(float));}
			
		}
		
		static readonly int ThrottleInput__Offset;
		/// <summary>Accelerator output to physics system. Range 0...1</summary>
		public float ThrottleInput
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+ThrottleInput__Offset, typeof(float));}
			
		}
		
		static readonly int BrakeInput__Offset;
		/// <summary>Brake output to physics system. Range 0...1</summary>
		public float BrakeInput
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+BrakeInput__Offset, typeof(float));}
			
		}
		
		static readonly int HandbrakeInput__Offset;
		/// <summary>Handbrake output to physics system. Range 0...1</summary>
		public float HandbrakeInput
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+HandbrakeInput__Offset, typeof(float));}
			
		}
		
		static readonly int IdleBrakeInput__Offset;
		/// <summary>How much to press the brake when the player has release throttle</summary>
		public float IdleBrakeInput
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+IdleBrakeInput__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+IdleBrakeInput__Offset, false);}
			
		}
		
		static readonly int StopThreshold__Offset;
		/// <summary>Auto-brake when absolute vehicle forward speed is less than this (cm/s)</summary>
		public float StopThreshold
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+StopThreshold__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+StopThreshold__Offset, false);}
			
		}
		
		static readonly int WrongDirectionThreshold__Offset;
		/// <summary>Auto-brake when vehicle forward speed is opposite of player input by at least this much (cm/s)</summary>
		public float WrongDirectionThreshold
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+WrongDirectionThreshold__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+WrongDirectionThreshold__Offset, false);}
			
		}
		
		static readonly int ThrottleInputRate__Offset;
		/// <summary>Rate at which input throttle can rise and fall</summary>
		public FVehicleInputRate ThrottleInputRate
		{
			get{ CheckIsValid();return (FVehicleInputRate)Marshal.PtrToStructure(_this.Get()+ThrottleInputRate__Offset, typeof(FVehicleInputRate));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+ThrottleInputRate__Offset, false);}
			
		}
		
		static readonly int BrakeInputRate__Offset;
		/// <summary>Rate at which input brake can rise and fall</summary>
		public FVehicleInputRate BrakeInputRate
		{
			get{ CheckIsValid();return (FVehicleInputRate)Marshal.PtrToStructure(_this.Get()+BrakeInputRate__Offset, typeof(FVehicleInputRate));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+BrakeInputRate__Offset, false);}
			
		}
		
		static readonly int HandbrakeInputRate__Offset;
		/// <summary>Rate at which input handbrake can rise and fall</summary>
		public FVehicleInputRate HandbrakeInputRate
		{
			get{ CheckIsValid();return (FVehicleInputRate)Marshal.PtrToStructure(_this.Get()+HandbrakeInputRate__Offset, typeof(FVehicleInputRate));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+HandbrakeInputRate__Offset, false);}
			
		}
		
		static readonly int SteeringInputRate__Offset;
		/// <summary>Rate at which input steering can rise and fall</summary>
		public FVehicleInputRate SteeringInputRate
		{
			get{ CheckIsValid();return (FVehicleInputRate)Marshal.PtrToStructure(_this.Get()+SteeringInputRate__Offset, typeof(FVehicleInputRate));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+SteeringInputRate__Offset, false);}
			
		}
		
		static readonly int bWasAvoidanceUpdated__Offset;
		/// <summary>Was avoidance updated in this frame?</summary>
		public bool bWasAvoidanceUpdated
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bWasAvoidanceUpdated__Offset, 1, 0, 1, 1);}
			
		}
		
		static UWheeledVehicleMovementComponent()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("WheeledVehicleMovementComponent");
			WheelSetups__Offset=GetPropertyOffset(NativeClassPtr,"WheelSetups");
			Mass__Offset=GetPropertyOffset(NativeClassPtr,"Mass");
			DragCoefficient__Offset=GetPropertyOffset(NativeClassPtr,"DragCoefficient");
			ChassisWidth__Offset=GetPropertyOffset(NativeClassPtr,"ChassisWidth");
			ChassisHeight__Offset=GetPropertyOffset(NativeClassPtr,"ChassisHeight");
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
