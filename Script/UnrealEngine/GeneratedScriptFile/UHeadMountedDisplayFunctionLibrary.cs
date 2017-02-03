using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine{
public partial class UHeadMountedDisplayFunctionLibrary:UBlueprintFunctionLibrary 
{
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void GetVRFocusState(IntPtr _this,out int bUseFocus,out int bHasFocus);
/// <summary>
/// Returns current state of VR focus.
/// @param bUseFocus             (out) if set to true, then this App does use VR focus.
/// @param bHasFocus             (out) if set to true, then this App currently has VR focus.
/// </summary>
public static void GetVRFocusState(out bool bUseFocus,out bool bHasFocus)
{
	int bUseFocus_temp;
	int bHasFocus_temp;
	GetVRFocusState(IntPtr.Zero,out bUseFocus_temp,out bHasFocus_temp);
	bUseFocus=bUseFocus_temp!=0;
	bHasFocus=bHasFocus_temp!=0;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static int GetTrackingOrigin(IntPtr _this);
/// <summary>Returns current tracking origin type (eye level or floor level).</summary>
public static EHMDTrackingOrigin GetTrackingOrigin()
{
	int ___ret = GetTrackingOrigin(IntPtr.Zero);
	return (EHMDTrackingOrigin)___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SetTrackingOrigin(IntPtr _this,int Origin);
/// <summary>Sets current tracking origin type (eye level or floor level).</summary>
public static void SetTrackingOrigin(EHMDTrackingOrigin Origin)
{
	SetTrackingOrigin(IntPtr.Zero,(int)Origin);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static float GetWorldToMetersScale(IntPtr _this,IntPtr WorldContext);
/// <summary>
/// Returns the World to Meters scale, which corresponds to the scale of the world as perceived by the player
/// @return       How many Unreal units correspond to one meter in the real world
/// </summary>
public static float GetWorldToMetersScale(UObject WorldContext)
{
	float ___ret = GetWorldToMetersScale(IntPtr.Zero,WorldContext);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SetWorldToMetersScale(IntPtr _this,IntPtr WorldContext,float NewScale);
/// <summary>
/// Sets the World to Meters scale, which changes the scale of the world as perceived by the player
/// @param NewScale       Specifies how many Unreal units correspond to one meter in the real world
/// </summary>
public static void SetWorldToMetersScale(UObject WorldContext,float NewScale=100.000000f)
{
	SetWorldToMetersScale(IntPtr.Zero,WorldContext,NewScale);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static float GetScreenPercentage(IntPtr _this);
/// <summary>
/// Returns screen percentage to be used in VR mode.
/// @return (float)      The screen percentage to be used in VR mode.
/// </summary>
public static float GetScreenPercentage()
{
	float ___ret = GetScreenPercentage(IntPtr.Zero);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SetClippingPlanes(IntPtr _this,float Near,float Far);
/// <summary>
/// Sets near and far clipping planes (NCP and FCP) for stereo rendering. Similar to 'stereo ncp= fcp' console command, but NCP and FCP set by this
/// call won't be saved in .ini file.
/// @param Near                          (in) Near clipping plane, in centimeters
/// @param Far                           (in) Far clipping plane, in centimeters
/// </summary>
public static void SetClippingPlanes(float Near,float Far)
{
	SetClippingPlanes(IntPtr.Zero,Near,Far);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void ResetOrientationAndPosition(IntPtr _this,float Yaw,int Options);
/// <summary>
/// Resets orientation by setting roll and pitch to 0, assuming that current yaw is forward direction and assuming
/// current position as a 'zero-point' (for positional tracking).
/// @param Yaw                           (in) the desired yaw to be set after orientation reset.
/// @param Options                       (in) specifies either position, orientation or both should be reset.
/// </summary>
public static void ResetOrientationAndPosition(float Yaw=0.000000f,EOrientPositionSelector Options=EOrientPositionSelector.OrientationAndPosition)
{
	ResetOrientationAndPosition(IntPtr.Zero,Yaw,(int)Options);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void EnableLowPersistenceMode(IntPtr _this,int bEnable);
/// <summary>
/// Switches between low and full persistence modes.
/// @param bEnable                       (in) 'true' to enable low persistence mode; 'false' otherwise
/// </summary>
public static void EnableLowPersistenceMode(bool bEnable)
{
	EnableLowPersistenceMode(IntPtr.Zero,bEnable?1:0);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static int IsInLowPersistenceMode(IntPtr _this);
/// <summary>Returns true, if HMD is in low persistence mode. 'false' otherwise.</summary>
public static bool IsInLowPersistenceMode()
{
	int ___ret = IsInLowPersistenceMode(IntPtr.Zero);
	return ___ret!=0;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void GetTrackingSensorParameters(IntPtr _this,out FVector Origin,out FRotator Rotation,out float LeftFOV,out float RightFOV,out float TopFOV,out float BottomFOV,out float Distance,out float NearPlane,out float FarPlane,out int IsActive,int Index);
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
public static void GetTrackingSensorParameters(out FVector Origin,out FRotator Rotation,out float LeftFOV,out float RightFOV,out float TopFOV,out float BottomFOV,out float Distance,out float NearPlane,out float FarPlane,out bool IsActive,int Index=0)
{
	int IsActive_temp;
	GetTrackingSensorParameters(IntPtr.Zero,out Origin,out Rotation,out LeftFOV,out RightFOV,out TopFOV,out BottomFOV,out Distance,out NearPlane,out FarPlane,out IsActive_temp,Index);
	IsActive=IsActive_temp!=0;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static int GetNumOfTrackingSensors(IntPtr _this);
/// <summary>If the HMD has multiple positional tracking sensors, return a total number of them currently connected.</summary>
public static int GetNumOfTrackingSensors()
{
	int ___ret = GetNumOfTrackingSensors(IntPtr.Zero);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static int HasValidTrackingPosition(IntPtr _this);
/// <summary>If the HMD supports positional tracking, whether or not we are currently being tracked</summary>
public static bool HasValidTrackingPosition()
{
	int ___ret = HasValidTrackingPosition(IntPtr.Zero);
	return ___ret!=0;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void GetOrientationAndPosition(IntPtr _this,out FRotator DeviceRotation,out FVector DevicePosition);
/// <summary>
/// Grabs the current orientation and position for the HMD.  If positional tracking is not available, DevicePosition will be a zero vector
/// @param DeviceRotation        (out) The device's current rotation
/// @param DevicePosition        (out) The device's current position, in its own tracking space
/// </summary>
public static void GetOrientationAndPosition(out FRotator DeviceRotation,out FVector DevicePosition)
{
	GetOrientationAndPosition(IntPtr.Zero,out DeviceRotation,out DevicePosition);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static string GetHMDDeviceName(IntPtr _this);
/// <summary>
/// Returns the name of the device, so scripts can modify their behaviour appropriately
/// @return      FName specific to the currently active HMD device type.  "None" implies no device, "Unknown" implies a device with no description.
/// </summary>
public static string GetHMDDeviceName()
{
	string ___ret = GetHMDDeviceName(IntPtr.Zero);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static int EnableHMD(IntPtr _this,int bEnable);
/// <summary>
/// Switches to/from using HMD and stereo rendering.
/// @param bEnable                       (in) 'true' to enable HMD / stereo; 'false' otherwise
/// @return (Boolean)            True, if the request was successful.
/// </summary>
public static bool EnableHMD(bool bEnable)
{
	int ___ret = EnableHMD(IntPtr.Zero,bEnable?1:0);
	return ___ret!=0;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static int IsHeadMountedDisplayEnabled(IntPtr _this);
/// <summary>
/// Returns whether or not we are currently using the head mounted display.
/// @return (Boolean)  status of HMD
/// </summary>
public static bool IsHeadMountedDisplayEnabled()
{
	int ___ret = IsHeadMountedDisplayEnabled(IntPtr.Zero);
	return ___ret!=0;
	
}
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	public extern static new IntPtr StaticClass();
}
}
