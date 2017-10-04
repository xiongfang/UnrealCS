using System;
namespace UnrealEngine
{
	public partial class UHeadMountedDisplayFunctionLibrary:UBlueprintFunctionLibrary
	{
		/// <summary>
		/// Returns current state of VR focus.
		/// @param bUseFocus             (out) if set to true, then this App does use VR focus.
		/// @param bHasFocus             (out) if set to true, then this App currently has VR focus.
		/// </summary>
		public extern static void GetVRFocusState(out bool bUseFocus,out bool bHasFocus);
		/// <summary>Returns current tracking origin type (eye level or floor level).</summary>
		public extern static EHMDTrackingOrigin GetTrackingOrigin();
		/// <summary>Sets current tracking origin type (eye level or floor level).</summary>
		public extern static void SetTrackingOrigin(EHMDTrackingOrigin Origin);
		/// <summary>
		/// Returns the World to Meters scale, which corresponds to the scale of the world as perceived by the player
		/// @return       How many Unreal units correspond to one meter in the real world
		/// </summary>
		public extern static float GetWorldToMetersScale(UObject WorldContext);
		/// <summary>
		/// Sets the World to Meters scale, which changes the scale of the world as perceived by the player
		/// @param NewScale       Specifies how many Unreal units correspond to one meter in the real world
		/// </summary>
		public extern static void SetWorldToMetersScale(UObject WorldContext,float NewScale=100.000000f);
		/// <summary>
		/// Returns screen percentage to be used in VR mode.
		/// @return (float)      The screen percentage to be used in VR mode.
		/// </summary>
		public extern static float GetScreenPercentage();
		/// <summary>
		/// Sets near and far clipping planes (NCP and FCP) for stereo rendering. Similar to 'stereo ncp= fcp' console command, but NCP and FCP set by this
		/// call won't be saved in .ini file.
		/// @param Near                          (in) Near clipping plane, in centimeters
		/// @param Far                           (in) Far clipping plane, in centimeters
		/// </summary>
		public extern static void SetClippingPlanes(float Near,float Far);
		/// <summary>
		/// Resets orientation by setting roll and pitch to 0, assuming that current yaw is forward direction and assuming
		/// current position as a 'zero-point' (for positional tracking).
		/// @param Yaw                           (in) the desired yaw to be set after orientation reset.
		/// @param Options                       (in) specifies either position, orientation or both should be reset.
		/// </summary>
		public extern static void ResetOrientationAndPosition(float Yaw=0.000000f,EOrientPositionSelector Options=EOrientPositionSelector.OrientationAndPosition);
		/// <summary>
		/// Switches between low and full persistence modes.
		/// @param bEnable                       (in) 'true' to enable low persistence mode; 'false' otherwise
		/// </summary>
		public extern static void EnableLowPersistenceMode(bool bEnable);
		/// <summary>Returns true, if HMD is in low persistence mode. 'false' otherwise.</summary>
		public extern static bool IsInLowPersistenceMode();
		/// <summary>
		/// If the HMD has a positional sensor, this will return the game-world location of it, as well as the parameters for the bounding region of tracking.
		/// This allows an in-game representation of the legal positional tracking range.  All values will be zeroed if the sensor is not available or the HMD does not support it.
		/// @param Index                         (in) Index of the tracking sensor to query
		/// @param Origin                        (out) Origin, in world-space, of the sensor
		/// @param Rotation                      (out) Rotation, in world-space, of the sensor
		/// @param LeftFOV                       (out) Field-of-view, left from center, in degrees, of the valid tracking zone of the sensor
		/// @param RightFOV                      (out) Field-of-view, right from center, in degrees, of the valid tracking zone of the sensor
		/// @param TopFOV                        (out) Field-of-view, top from center, in degrees, of the valid tracking zone of the sensor
		/// @param BottomFOV                     (out) Field-of-view, bottom from center, in degrees, of the valid tracking zone of the sensor
		/// @param Distance                      (out) Nominal distance to sensor, in world-space
		/// @param NearPlane                     (out) Near plane distance of the tracking volume, in world-space
		/// @param FarPlane                      (out) Far plane distance of the tracking volume, in world-space
		/// @param IsActive                      (out) True, if the query for the specified sensor succeeded.
		/// </summary>
		public extern static void GetTrackingSensorParameters(out FVector Origin,out FRotator Rotation,out float LeftFOV,out float RightFOV,out float TopFOV,out float BottomFOV,out float Distance,out float NearPlane,out float FarPlane,out bool IsActive,int Index=0);
		/// <summary>If the HMD has multiple positional tracking sensors, return a total number of them currently connected.</summary>
		public extern static int GetNumOfTrackingSensors();
		/// <summary>If the HMD supports positional tracking, whether or not we are currently being tracked</summary>
		public extern static bool HasValidTrackingPosition();
		/// <summary>
		/// Grabs the current orientation and position for the HMD.  If positional tracking is not available, DevicePosition will be a zero vector
		/// @param DeviceRotation        (out) The device's current rotation
		/// @param DevicePosition        (out) The device's current position, in its own tracking space
		/// </summary>
		public extern static void GetOrientationAndPosition(out FRotator DeviceRotation,out FVector DevicePosition);
		/// <summary>
		/// Returns the name of the device, so scripts can modify their behaviour appropriately
		/// @return      FName specific to the currently active HMD device type.  "None" implies no device, "Unknown" implies a device with no description.
		/// </summary>
		public extern static FName GetHMDDeviceName();
		/// <summary>
		/// Switches to/from using HMD and stereo rendering.
		/// @param bEnable                       (in) 'true' to enable HMD / stereo; 'false' otherwise
		/// @return (Boolean)            True, if the request was successful.
		/// </summary>
		public extern static bool EnableHMD(bool bEnable);
		/// <summary>
		/// Returns whether or not the HMD hardware is connected and ready to use.  It may or may not actually be in use.
		/// @return (Boolean)  status whether the HMD hardware is connected and ready to use.  It may or may not actually be in use.
		/// </summary>
		public extern static bool IsHeadMountedDisplayConnected();
		/// <summary>
		/// Returns whether or not we are currently using the head mounted display.
		/// @return (Boolean)  status of HMD
		/// </summary>
		public extern static bool IsHeadMountedDisplayEnabled();
		
	}
	
}
