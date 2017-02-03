using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine{
public partial class USplineComponent:UPrimitiveComponent 
{
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static FTransform FindTransformClosestToWorldLocation(IntPtr _this,ref FVector WorldLocation,int CoordinateSpace,int bUseScale);
/// <summary>Given a location, in world space, return an FTransform closest to that location.</summary>
public  FTransform FindTransformClosestToWorldLocation(FVector WorldLocation,ESplineCoordinateSpace CoordinateSpace,bool bUseScale=false)
{
	CheckIsValid();
	FTransform ___ret = FindTransformClosestToWorldLocation(_this.Get(),ref WorldLocation,(int)CoordinateSpace,bUseScale?1:0);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static FVector FindScaleClosestToWorldLocation(IntPtr _this,ref FVector WorldLocation);
/// <summary>Given a location, in world space, return the spline's scale closest to the location.</summary>
public  FVector FindScaleClosestToWorldLocation(FVector WorldLocation)
{
	CheckIsValid();
	FVector ___ret = FindScaleClosestToWorldLocation(_this.Get(),ref WorldLocation);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static float FindRollClosestToWorldLocation(IntPtr _this,ref FVector WorldLocation,int CoordinateSpace);
/// <summary>Given a location, in world space, return the spline's roll closest to the location, in degrees.</summary>
public  float FindRollClosestToWorldLocation(FVector WorldLocation,ESplineCoordinateSpace CoordinateSpace)
{
	CheckIsValid();
	float ___ret = FindRollClosestToWorldLocation(_this.Get(),ref WorldLocation,(int)CoordinateSpace);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static FVector FindRightVectorClosestToWorldLocation(IntPtr _this,ref FVector WorldLocation,int CoordinateSpace);
/// <summary>Given a location, in world space, return a unit direction vector corresponding to the spline's right vector closest to the location.</summary>
public  FVector FindRightVectorClosestToWorldLocation(FVector WorldLocation,ESplineCoordinateSpace CoordinateSpace)
{
	CheckIsValid();
	FVector ___ret = FindRightVectorClosestToWorldLocation(_this.Get(),ref WorldLocation,(int)CoordinateSpace);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static FVector FindUpVectorClosestToWorldLocation(IntPtr _this,ref FVector WorldLocation,int CoordinateSpace);
/// <summary>Given a location, in world space, return a unit direction vector corresponding to the spline's up vector closest to the location.</summary>
public  FVector FindUpVectorClosestToWorldLocation(FVector WorldLocation,ESplineCoordinateSpace CoordinateSpace)
{
	CheckIsValid();
	FVector ___ret = FindUpVectorClosestToWorldLocation(_this.Get(),ref WorldLocation,(int)CoordinateSpace);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static FRotator FindRotationClosestToWorldLocation(IntPtr _this,ref FVector WorldLocation,int CoordinateSpace);
/// <summary>Given a location, in world space, return rotation corresponding to the spline's rotation closest to the location.</summary>
public  FRotator FindRotationClosestToWorldLocation(FVector WorldLocation,ESplineCoordinateSpace CoordinateSpace)
{
	CheckIsValid();
	FRotator ___ret = FindRotationClosestToWorldLocation(_this.Get(),ref WorldLocation,(int)CoordinateSpace);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static FVector FindTangentClosestToWorldLocation(IntPtr _this,ref FVector WorldLocation,int CoordinateSpace);
/// <summary>Given a location, in world space, return the tangent vector of the spline closest to the location.</summary>
public  FVector FindTangentClosestToWorldLocation(FVector WorldLocation,ESplineCoordinateSpace CoordinateSpace)
{
	CheckIsValid();
	FVector ___ret = FindTangentClosestToWorldLocation(_this.Get(),ref WorldLocation,(int)CoordinateSpace);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static FVector FindDirectionClosestToWorldLocation(IntPtr _this,ref FVector WorldLocation,int CoordinateSpace);
/// <summary>Given a location, in world spcae, return a unit direction vector of the spline tangent closest to the location.</summary>
public  FVector FindDirectionClosestToWorldLocation(FVector WorldLocation,ESplineCoordinateSpace CoordinateSpace)
{
	CheckIsValid();
	FVector ___ret = FindDirectionClosestToWorldLocation(_this.Get(),ref WorldLocation,(int)CoordinateSpace);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static FVector FindLocationClosestToWorldLocation(IntPtr _this,ref FVector WorldLocation,int CoordinateSpace);
/// <summary>Given a location, in world space, return the point on the curve that is closest to the location.</summary>
public  FVector FindLocationClosestToWorldLocation(FVector WorldLocation,ESplineCoordinateSpace CoordinateSpace)
{
	CheckIsValid();
	FVector ___ret = FindLocationClosestToWorldLocation(_this.Get(),ref WorldLocation,(int)CoordinateSpace);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static float FindInputKeyClosestToWorldLocation(IntPtr _this,ref FVector WorldLocation);
/// <summary>Given a location, in world space, return the input key closest to that location.</summary>
public  float FindInputKeyClosestToWorldLocation(FVector WorldLocation)
{
	CheckIsValid();
	float ___ret = FindInputKeyClosestToWorldLocation(_this.Get(),ref WorldLocation);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static FVector GetScaleAtTime(IntPtr _this,float Time,int bUseConstantVelocity);
/// <summary>Given a time from 0 to the spline duration, return the spline's scale there.</summary>
public  FVector GetScaleAtTime(float Time,bool bUseConstantVelocity=false)
{
	CheckIsValid();
	FVector ___ret = GetScaleAtTime(_this.Get(),Time,bUseConstantVelocity?1:0);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static float GetRollAtTime(IntPtr _this,float Time,int CoordinateSpace,int bUseConstantVelocity);
/// <summary>Given a time from 0 to the spline duration, return the spline's roll there, in degrees.</summary>
public  float GetRollAtTime(float Time,ESplineCoordinateSpace CoordinateSpace,bool bUseConstantVelocity=false)
{
	CheckIsValid();
	float ___ret = GetRollAtTime(_this.Get(),Time,(int)CoordinateSpace,bUseConstantVelocity?1:0);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static FTransform GetTransformAtTime(IntPtr _this,float Time,int CoordinateSpace,int bUseConstantVelocity,int bUseScale);
/// <summary>Given a time from 0 to the spline duration, return the spline's transform at the corresponding position.</summary>
public  FTransform GetTransformAtTime(float Time,ESplineCoordinateSpace CoordinateSpace,bool bUseConstantVelocity=false,bool bUseScale=false)
{
	CheckIsValid();
	FTransform ___ret = GetTransformAtTime(_this.Get(),Time,(int)CoordinateSpace,bUseConstantVelocity?1:0,bUseScale?1:0);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static FVector GetRightVectorAtTime(IntPtr _this,float Time,int CoordinateSpace,int bUseConstantVelocity);
/// <summary>Given a time from 0 to the spline duration, return the spline's right vector there.</summary>
public  FVector GetRightVectorAtTime(float Time,ESplineCoordinateSpace CoordinateSpace,bool bUseConstantVelocity=false)
{
	CheckIsValid();
	FVector ___ret = GetRightVectorAtTime(_this.Get(),Time,(int)CoordinateSpace,bUseConstantVelocity?1:0);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static FVector GetUpVectorAtTime(IntPtr _this,float Time,int CoordinateSpace,int bUseConstantVelocity);
/// <summary>Given a time from 0 to the spline duration, return the spline's up vector there.</summary>
public  FVector GetUpVectorAtTime(float Time,ESplineCoordinateSpace CoordinateSpace,bool bUseConstantVelocity=false)
{
	CheckIsValid();
	FVector ___ret = GetUpVectorAtTime(_this.Get(),Time,(int)CoordinateSpace,bUseConstantVelocity?1:0);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static FRotator GetRotationAtTime(IntPtr _this,float Time,int CoordinateSpace,int bUseConstantVelocity);
/// <summary>Given a time from 0 to the spline duration, return a rotation corresponding to the spline's position and direction there.</summary>
public  FRotator GetRotationAtTime(float Time,ESplineCoordinateSpace CoordinateSpace,bool bUseConstantVelocity=false)
{
	CheckIsValid();
	FRotator ___ret = GetRotationAtTime(_this.Get(),Time,(int)CoordinateSpace,bUseConstantVelocity?1:0);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static FVector GetTangentAtTime(IntPtr _this,float Time,int CoordinateSpace,int bUseConstantVelocity);
/// <summary>Given a time from 0 to the spline duration, return the spline's tangent there.</summary>
public  FVector GetTangentAtTime(float Time,ESplineCoordinateSpace CoordinateSpace,bool bUseConstantVelocity=false)
{
	CheckIsValid();
	FVector ___ret = GetTangentAtTime(_this.Get(),Time,(int)CoordinateSpace,bUseConstantVelocity?1:0);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static FVector GetDirectionAtTime(IntPtr _this,float Time,int CoordinateSpace,int bUseConstantVelocity);
/// <summary>Given a time from 0 to the spline duration, return a unit direction vector of the spline tangent there.</summary>
public  FVector GetDirectionAtTime(float Time,ESplineCoordinateSpace CoordinateSpace,bool bUseConstantVelocity=false)
{
	CheckIsValid();
	FVector ___ret = GetDirectionAtTime(_this.Get(),Time,(int)CoordinateSpace,bUseConstantVelocity?1:0);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static FVector GetLocationAtTime(IntPtr _this,float Time,int CoordinateSpace,int bUseConstantVelocity);
/// <summary>Given a time from 0 to the spline duration, return the point in space where this puts you</summary>
public  FVector GetLocationAtTime(float Time,ESplineCoordinateSpace CoordinateSpace,bool bUseConstantVelocity=false)
{
	CheckIsValid();
	FVector ___ret = GetLocationAtTime(_this.Get(),Time,(int)CoordinateSpace,bUseConstantVelocity?1:0);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static FTransform GetTransformAtDistanceAlongSpline(IntPtr _this,float Distance,int CoordinateSpace,int bUseScale);
/// <summary>Given a distance along the length of this spline, return an FTransform corresponding to that point on the spline.</summary>
public  FTransform GetTransformAtDistanceAlongSpline(float Distance,ESplineCoordinateSpace CoordinateSpace,bool bUseScale=false)
{
	CheckIsValid();
	FTransform ___ret = GetTransformAtDistanceAlongSpline(_this.Get(),Distance,(int)CoordinateSpace,bUseScale?1:0);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static FVector GetScaleAtDistanceAlongSpline(IntPtr _this,float Distance);
/// <summary>Given a distance along the length of this spline, return the spline's scale there.</summary>
public  FVector GetScaleAtDistanceAlongSpline(float Distance)
{
	CheckIsValid();
	FVector ___ret = GetScaleAtDistanceAlongSpline(_this.Get(),Distance);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static float GetRollAtDistanceAlongSpline(IntPtr _this,float Distance,int CoordinateSpace);
/// <summary>Given a distance along the length of this spline, return the spline's roll there, in degrees.</summary>
public  float GetRollAtDistanceAlongSpline(float Distance,ESplineCoordinateSpace CoordinateSpace)
{
	CheckIsValid();
	float ___ret = GetRollAtDistanceAlongSpline(_this.Get(),Distance,(int)CoordinateSpace);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static FVector GetRightVectorAtDistanceAlongSpline(IntPtr _this,float Distance,int CoordinateSpace);
/// <summary>Given a distance along the length of this spline, return a unit direction vector corresponding to the spline's right vector there.</summary>
public  FVector GetRightVectorAtDistanceAlongSpline(float Distance,ESplineCoordinateSpace CoordinateSpace)
{
	CheckIsValid();
	FVector ___ret = GetRightVectorAtDistanceAlongSpline(_this.Get(),Distance,(int)CoordinateSpace);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static FVector GetUpVectorAtDistanceAlongSpline(IntPtr _this,float Distance,int CoordinateSpace);
/// <summary>Given a distance along the length of this spline, return a unit direction vector corresponding to the spline's up vector there.</summary>
public  FVector GetUpVectorAtDistanceAlongSpline(float Distance,ESplineCoordinateSpace CoordinateSpace)
{
	CheckIsValid();
	FVector ___ret = GetUpVectorAtDistanceAlongSpline(_this.Get(),Distance,(int)CoordinateSpace);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static FRotator GetRotationAtDistanceAlongSpline(IntPtr _this,float Distance,int CoordinateSpace);
/// <summary>Given a distance along the length of this spline, return a rotation corresponding to the spline's rotation there.</summary>
public  FRotator GetRotationAtDistanceAlongSpline(float Distance,ESplineCoordinateSpace CoordinateSpace)
{
	CheckIsValid();
	FRotator ___ret = GetRotationAtDistanceAlongSpline(_this.Get(),Distance,(int)CoordinateSpace);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static FVector GetTangentAtDistanceAlongSpline(IntPtr _this,float Distance,int CoordinateSpace);
/// <summary>Given a distance along the length of this spline, return the tangent vector of the spline there.</summary>
public  FVector GetTangentAtDistanceAlongSpline(float Distance,ESplineCoordinateSpace CoordinateSpace)
{
	CheckIsValid();
	FVector ___ret = GetTangentAtDistanceAlongSpline(_this.Get(),Distance,(int)CoordinateSpace);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static FVector GetDirectionAtDistanceAlongSpline(IntPtr _this,float Distance,int CoordinateSpace);
/// <summary>Given a distance along the length of this spline, return a unit direction vector of the spline tangent there.</summary>
public  FVector GetDirectionAtDistanceAlongSpline(float Distance,ESplineCoordinateSpace CoordinateSpace)
{
	CheckIsValid();
	FVector ___ret = GetDirectionAtDistanceAlongSpline(_this.Get(),Distance,(int)CoordinateSpace);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static FVector GetLocationAtDistanceAlongSpline(IntPtr _this,float Distance,int CoordinateSpace);
/// <summary>Given a distance along the length of this spline, return the point in space where this puts you</summary>
public  FVector GetLocationAtDistanceAlongSpline(float Distance,ESplineCoordinateSpace CoordinateSpace)
{
	CheckIsValid();
	FVector ___ret = GetLocationAtDistanceAlongSpline(_this.Get(),Distance,(int)CoordinateSpace);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static float GetInputKeyAtDistanceAlongSpline(IntPtr _this,float Distance);
/// <summary>Given a distance along the length of this spline, return the corresponding input key at that point</summary>
public  float GetInputKeyAtDistanceAlongSpline(float Distance)
{
	CheckIsValid();
	float ___ret = GetInputKeyAtDistanceAlongSpline(_this.Get(),Distance);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static FVector GetDefaultUpVector(IntPtr _this,int CoordinateSpace);
/// <summary>Gets the default up vector used by this spline</summary>
public  FVector GetDefaultUpVector(ESplineCoordinateSpace CoordinateSpace)
{
	CheckIsValid();
	FVector ___ret = GetDefaultUpVector(_this.Get(),(int)CoordinateSpace);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SetDefaultUpVector(IntPtr _this,ref FVector UpVector,int CoordinateSpace);
/// <summary>Sets the default up vector used by this spline</summary>
public  void SetDefaultUpVector(FVector UpVector,ESplineCoordinateSpace CoordinateSpace)
{
	CheckIsValid();
	SetDefaultUpVector(_this.Get(),ref UpVector,(int)CoordinateSpace);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static float GetSplineLength(IntPtr _this);
/// <summary>Returns total length along this spline</summary>
public  float GetSplineLength()
{
	CheckIsValid();
	float ___ret = GetSplineLength(_this.Get());
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static float GetDistanceAlongSplineAtSplinePoint(IntPtr _this,int PointIndex);
/// <summary>Get the distance along the spline at the spline point</summary>
public  float GetDistanceAlongSplineAtSplinePoint(int PointIndex)
{
	CheckIsValid();
	float ___ret = GetDistanceAlongSplineAtSplinePoint(_this.Get(),PointIndex);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void GetLocationAndTangentAtSplinePoint(IntPtr _this,int PointIndex,out FVector Location,out FVector Tangent,int CoordinateSpace);
/// <summary>Get location and tangent at a spline point</summary>
public  void GetLocationAndTangentAtSplinePoint(int PointIndex,out FVector Location,out FVector Tangent,ESplineCoordinateSpace CoordinateSpace)
{
	CheckIsValid();
	GetLocationAndTangentAtSplinePoint(_this.Get(),PointIndex,out Location,out Tangent,(int)CoordinateSpace);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static FTransform GetTransformAtSplinePoint(IntPtr _this,int PointIndex,int CoordinateSpace,int bUseScale);
/// <summary>Get the transform at spline point</summary>
public  FTransform GetTransformAtSplinePoint(int PointIndex,ESplineCoordinateSpace CoordinateSpace,bool bUseScale=false)
{
	CheckIsValid();
	FTransform ___ret = GetTransformAtSplinePoint(_this.Get(),PointIndex,(int)CoordinateSpace,bUseScale?1:0);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static FVector GetScaleAtSplinePoint(IntPtr _this,int PointIndex);
/// <summary>Get the scale at spline point</summary>
public  FVector GetScaleAtSplinePoint(int PointIndex)
{
	CheckIsValid();
	FVector ___ret = GetScaleAtSplinePoint(_this.Get(),PointIndex);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static float GetRollAtSplinePoint(IntPtr _this,int PointIndex,int CoordinateSpace);
/// <summary>Get the amount of roll at spline point, in degrees</summary>
public  float GetRollAtSplinePoint(int PointIndex,ESplineCoordinateSpace CoordinateSpace)
{
	CheckIsValid();
	float ___ret = GetRollAtSplinePoint(_this.Get(),PointIndex,(int)CoordinateSpace);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static FVector GetRightVectorAtSplinePoint(IntPtr _this,int PointIndex,int CoordinateSpace);
/// <summary>Get the right vector at spline point</summary>
public  FVector GetRightVectorAtSplinePoint(int PointIndex,ESplineCoordinateSpace CoordinateSpace)
{
	CheckIsValid();
	FVector ___ret = GetRightVectorAtSplinePoint(_this.Get(),PointIndex,(int)CoordinateSpace);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static FVector GetUpVectorAtSplinePoint(IntPtr _this,int PointIndex,int CoordinateSpace);
/// <summary>Get the up vector at spline point</summary>
public  FVector GetUpVectorAtSplinePoint(int PointIndex,ESplineCoordinateSpace CoordinateSpace)
{
	CheckIsValid();
	FVector ___ret = GetUpVectorAtSplinePoint(_this.Get(),PointIndex,(int)CoordinateSpace);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static FRotator GetRotationAtSplinePoint(IntPtr _this,int PointIndex,int CoordinateSpace);
/// <summary>Get the rotation at spline point as a rotator</summary>
public  FRotator GetRotationAtSplinePoint(int PointIndex,ESplineCoordinateSpace CoordinateSpace)
{
	CheckIsValid();
	FRotator ___ret = GetRotationAtSplinePoint(_this.Get(),PointIndex,(int)CoordinateSpace);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static FVector GetLeaveTangentAtSplinePoint(IntPtr _this,int PointIndex,int CoordinateSpace);
/// <summary>Get the leave tangent at spline point</summary>
public  FVector GetLeaveTangentAtSplinePoint(int PointIndex,ESplineCoordinateSpace CoordinateSpace)
{
	CheckIsValid();
	FVector ___ret = GetLeaveTangentAtSplinePoint(_this.Get(),PointIndex,(int)CoordinateSpace);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static FVector GetArriveTangentAtSplinePoint(IntPtr _this,int PointIndex,int CoordinateSpace);
/// <summary>Get the arrive tangent at spline point</summary>
public  FVector GetArriveTangentAtSplinePoint(int PointIndex,ESplineCoordinateSpace CoordinateSpace)
{
	CheckIsValid();
	FVector ___ret = GetArriveTangentAtSplinePoint(_this.Get(),PointIndex,(int)CoordinateSpace);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static FVector GetTangentAtSplinePoint(IntPtr _this,int PointIndex,int CoordinateSpace);
/// <summary>Get the tangent at spline point. This fetches the Leave tangent of the point.</summary>
public  FVector GetTangentAtSplinePoint(int PointIndex,ESplineCoordinateSpace CoordinateSpace)
{
	CheckIsValid();
	FVector ___ret = GetTangentAtSplinePoint(_this.Get(),PointIndex,(int)CoordinateSpace);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static FVector GetDirectionAtSplinePoint(IntPtr _this,int PointIndex,int CoordinateSpace);
/// <summary>Get the location at spline point</summary>
public  FVector GetDirectionAtSplinePoint(int PointIndex,ESplineCoordinateSpace CoordinateSpace)
{
	CheckIsValid();
	FVector ___ret = GetDirectionAtSplinePoint(_this.Get(),PointIndex,(int)CoordinateSpace);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static FVector GetLocationAtSplinePoint(IntPtr _this,int PointIndex,int CoordinateSpace);
/// <summary>Get the location at spline point</summary>
public  FVector GetLocationAtSplinePoint(int PointIndex,ESplineCoordinateSpace CoordinateSpace)
{
	CheckIsValid();
	FVector ___ret = GetLocationAtSplinePoint(_this.Get(),PointIndex,(int)CoordinateSpace);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static int GetNumberOfSplinePoints(IntPtr _this);
/// <summary>Get the number of points that make up this spline</summary>
public  int GetNumberOfSplinePoints()
{
	CheckIsValid();
	int ___ret = GetNumberOfSplinePoints(_this.Get());
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SetSplinePointType(IntPtr _this,int PointIndex,int Type,int bUpdateSpline);
/// <summary>Specify the type of a spline point</summary>
public  void SetSplinePointType(int PointIndex,ESplinePointType Type,bool bUpdateSpline=true)
{
	CheckIsValid();
	SetSplinePointType(_this.Get(),PointIndex,(int)Type,bUpdateSpline?1:0);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static int GetSplinePointType(IntPtr _this,int PointIndex);
/// <summary>Get the type of a spline point</summary>
public  ESplinePointType GetSplinePointType(int PointIndex)
{
	CheckIsValid();
	int ___ret = GetSplinePointType(_this.Get(),PointIndex);
	return (ESplinePointType)___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SetUpVectorAtSplinePoint(IntPtr _this,int PointIndex,ref FVector InUpVector,int CoordinateSpace,int bUpdateSpline);
/// <summary>Specify the up vector at a given spline point</summary>
public  void SetUpVectorAtSplinePoint(int PointIndex,FVector InUpVector,ESplineCoordinateSpace CoordinateSpace,bool bUpdateSpline=true)
{
	CheckIsValid();
	SetUpVectorAtSplinePoint(_this.Get(),PointIndex,ref InUpVector,(int)CoordinateSpace,bUpdateSpline?1:0);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SetTangentsAtSplinePoint(IntPtr _this,int PointIndex,ref FVector InArriveTangent,ref FVector InLeaveTangent,int CoordinateSpace,int bUpdateSpline);
/// <summary>Specify the tangents at a given spline point</summary>
public  void SetTangentsAtSplinePoint(int PointIndex,FVector InArriveTangent,FVector InLeaveTangent,ESplineCoordinateSpace CoordinateSpace,bool bUpdateSpline=true)
{
	CheckIsValid();
	SetTangentsAtSplinePoint(_this.Get(),PointIndex,ref InArriveTangent,ref InLeaveTangent,(int)CoordinateSpace,bUpdateSpline?1:0);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SetTangentAtSplinePoint(IntPtr _this,int PointIndex,ref FVector InTangent,int CoordinateSpace,int bUpdateSpline);
/// <summary>Specify the tangent at a given spline point</summary>
public  void SetTangentAtSplinePoint(int PointIndex,FVector InTangent,ESplineCoordinateSpace CoordinateSpace,bool bUpdateSpline=true)
{
	CheckIsValid();
	SetTangentAtSplinePoint(_this.Get(),PointIndex,ref InTangent,(int)CoordinateSpace,bUpdateSpline?1:0);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SetLocationAtSplinePoint(IntPtr _this,int PointIndex,ref FVector InLocation,int CoordinateSpace,int bUpdateSpline);
/// <summary>Move an existing point to a new location</summary>
public  void SetLocationAtSplinePoint(int PointIndex,FVector InLocation,ESplineCoordinateSpace CoordinateSpace,bool bUpdateSpline=true)
{
	CheckIsValid();
	SetLocationAtSplinePoint(_this.Get(),PointIndex,ref InLocation,(int)CoordinateSpace,bUpdateSpline?1:0);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SetSplinePoints(IntPtr _this,FVector[] Points,int CoordinateSpace,int bUpdateSpline);
/// <summary>Sets the spline to an array of points</summary>
public  void SetSplinePoints(FVector[] Points,ESplineCoordinateSpace CoordinateSpace,bool bUpdateSpline=true)
{
	CheckIsValid();
	SetSplinePoints(_this.Get(),Points,(int)CoordinateSpace,bUpdateSpline?1:0);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void RemoveSplinePoint(IntPtr _this,int Index,int bUpdateSpline);
/// <summary>Removes point at specified index from the spline</summary>
public  void RemoveSplinePoint(int Index,bool bUpdateSpline=true)
{
	CheckIsValid();
	RemoveSplinePoint(_this.Get(),Index,bUpdateSpline?1:0);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void AddSplinePointAtIndex(IntPtr _this,ref FVector Position,int Index,int CoordinateSpace,int bUpdateSpline);
/// <summary>Adds a point to the spline at the specified index</summary>
public  void AddSplinePointAtIndex(FVector Position,int Index,ESplineCoordinateSpace CoordinateSpace,bool bUpdateSpline=true)
{
	CheckIsValid();
	AddSplinePointAtIndex(_this.Get(),ref Position,Index,(int)CoordinateSpace,bUpdateSpline?1:0);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void AddSplinePoint(IntPtr _this,ref FVector Position,int CoordinateSpace,int bUpdateSpline);
/// <summary>Adds a point to the spline</summary>
public  void AddSplinePoint(FVector Position,ESplineCoordinateSpace CoordinateSpace,bool bUpdateSpline=true)
{
	CheckIsValid();
	AddSplinePoint(_this.Get(),ref Position,(int)CoordinateSpace,bUpdateSpline?1:0);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void AddPoints(IntPtr _this,FSplinePoint[] Points,int bUpdateSpline);
/// <summary>Adds an array of FSplinePoints to the spline.</summary>
public  void AddPoints(FSplinePoint[] Points,bool bUpdateSpline=true)
{
	CheckIsValid();
	AddPoints(_this.Get(),Points,bUpdateSpline?1:0);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void AddPoint(IntPtr _this,ref FSplinePoint Point,int bUpdateSpline);
/// <summary>Adds an FSplinePoint to the spline. This contains its input key, position, tangent, rotation and scale.</summary>
public  void AddPoint(FSplinePoint Point,bool bUpdateSpline=true)
{
	CheckIsValid();
	AddPoint(_this.Get(),ref Point,bUpdateSpline?1:0);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void ClearSplinePoints(IntPtr _this,int bUpdateSpline);
/// <summary>Clears all the points in the spline</summary>
public  void ClearSplinePoints(bool bUpdateSpline=true)
{
	CheckIsValid();
	ClearSplinePoints(_this.Get(),bUpdateSpline?1:0);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static int IsClosedLoop(IntPtr _this);
/// <summary>Check whether the spline is a closed loop or not</summary>
public  bool IsClosedLoop()
{
	CheckIsValid();
	int ___ret = IsClosedLoop(_this.Get());
	return ___ret!=0;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SetClosedLoopAtPosition(IntPtr _this,int bInClosedLoop,float Key,int bUpdateSpline);
/// <summary>Specify whether the spline is a closed loop or not, and if so, the input key corresponding to the loop point</summary>
public  void SetClosedLoopAtPosition(bool bInClosedLoop,float Key,bool bUpdateSpline=true)
{
	CheckIsValid();
	SetClosedLoopAtPosition(_this.Get(),bInClosedLoop?1:0,Key,bUpdateSpline?1:0);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SetClosedLoop(IntPtr _this,int bInClosedLoop,int bUpdateSpline);
/// <summary>Specify whether the spline is a closed loop or not. The loop position will be at 1.0 after the last point's input key</summary>
public  void SetClosedLoop(bool bInClosedLoop,bool bUpdateSpline=true)
{
	CheckIsValid();
	SetClosedLoop(_this.Get(),bInClosedLoop?1:0,bUpdateSpline?1:0);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SetDrawDebug(IntPtr _this,int bShow);
/// <summary>Specify whether this spline should be rendered when the Editor/Game spline show flag is set</summary>
public  void SetDrawDebug(bool bShow)
{
	CheckIsValid();
	SetDrawDebug(_this.Get(),bShow?1:0);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SetSelectedSplineSegmentColor(IntPtr _this,ref FLinearColor SegmentColor);
/// <summary>Specify selected spline component segment color in the editor</summary>
public  void SetSelectedSplineSegmentColor(FLinearColor SegmentColor)
{
	CheckIsValid();
	SetSelectedSplineSegmentColor(_this.Get(),ref SegmentColor);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SetUnselectedSplineSegmentColor(IntPtr _this,ref FLinearColor SegmentColor);
/// <summary>Specify unselected spline component segment color in the editor</summary>
public  void SetUnselectedSplineSegmentColor(FLinearColor SegmentColor)
{
	CheckIsValid();
	SetUnselectedSplineSegmentColor(_this.Get(),ref SegmentColor);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void UpdateSpline(IntPtr _this);
/// <summary>Update the spline tangents and SplineReparamTable</summary>
public  void UpdateSpline()
{
	CheckIsValid();
	UpdateSpline(_this.Get());
	
}
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	public extern static new IntPtr StaticClass();
}
}
