using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine{
public partial class UCapsuleComponent:UShapeComponent 
{
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static float GetShapeScale(IntPtr _this);
/// <summary>
/// Get the scale used by this shape. This is a uniform scale that is the minimum of any non-uniform scaling.
/// @return the scale used by this shape.
/// </summary>
public  float GetShapeScale()
{
	CheckIsValid();
	float ___ret = GetShapeScale(_this.Get());
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void GetUnscaledCapsuleSize_WithoutHemisphere(IntPtr _this,out float OutRadius,out float OutHalfHeightWithoutHemisphere);
/// <summary>
/// Returns the capsule radius and half-height, ignoring component scaling. Half-height excludes the hemisphere end cap.
/// @param OutRadius Radius of the capsule, ignoring component scaling.
/// @param OutHalfHeightWithoutHemisphere Half-height of the capsule, scaled by the component scale. Excludes the hemisphere end cap.
/// @return The capsule radius and half-height (excluding hemisphere end cap), ignoring component scaling.
/// </summary>
public  void GetUnscaledCapsuleSize_WithoutHemisphere(out float OutRadius,out float OutHalfHeightWithoutHemisphere)
{
	CheckIsValid();
	GetUnscaledCapsuleSize_WithoutHemisphere(_this.Get(),out OutRadius,out OutHalfHeightWithoutHemisphere);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void GetUnscaledCapsuleSize(IntPtr _this,out float OutRadius,out float OutHalfHeight);
/// <summary>
/// Returns the capsule radius and half-height scaled by the component scale. Half-height includes the hemisphere end cap.
/// @param OutRadius Radius of the capsule, scaled by the component scale.
/// @param OutHalfHeight Half-height of the capsule, scaled by the component scale. Includes the hemisphere end cap.
/// @return The capsule radius and half-height scaled by the component scale.
/// </summary>
public  void GetUnscaledCapsuleSize(out float OutRadius,out float OutHalfHeight)
{
	CheckIsValid();
	GetUnscaledCapsuleSize(_this.Get(),out OutRadius,out OutHalfHeight);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static float GetUnscaledCapsuleHalfHeight_WithoutHemisphere(IntPtr _this);
/// <summary>
/// Returns the capsule half-height minus radius (to exclude the hemisphere), ignoring component scaling. This excludes the hemisphere end cap.
/// From the center of the capsule this is the vertical distance along the straight cylindrical portion to the point just before the curve of top hemisphere begins.
/// @return The capsule half-height minus radius, ignoring component scaling.
/// </summary>
public  float GetUnscaledCapsuleHalfHeight_WithoutHemisphere()
{
	CheckIsValid();
	float ___ret = GetUnscaledCapsuleHalfHeight_WithoutHemisphere(_this.Get());
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static float GetUnscaledCapsuleHalfHeight(IntPtr _this);
/// <summary>
/// Returns the capsule half-height, ignoring component scaling. This includes the hemisphere end cap.
/// @return The capsule radius, ignoring component scaling.
/// </summary>
public  float GetUnscaledCapsuleHalfHeight()
{
	CheckIsValid();
	float ___ret = GetUnscaledCapsuleHalfHeight(_this.Get());
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static float GetUnscaledCapsuleRadius(IntPtr _this);
/// <summary>
/// Returns the capsule radius, ignoring component scaling.
/// @return the capsule radius, ignoring component scaling.
/// </summary>
public  float GetUnscaledCapsuleRadius()
{
	CheckIsValid();
	float ___ret = GetUnscaledCapsuleRadius(_this.Get());
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void GetScaledCapsuleSize_WithoutHemisphere(IntPtr _this,out float OutRadius,out float OutHalfHeightWithoutHemisphere);
/// <summary>
/// Returns the capsule radius and half-height scaled by the component scale. Half-height excludes the hemisphere end cap.
/// @param OutRadius Radius of the capsule, ignoring component scaling.
/// @param OutHalfHeightWithoutHemisphere Half-height of the capsule, scaled by the component scale. Excludes the hemisphere end cap.
/// @return The capsule radius and half-height scaled by the component scale.
/// </summary>
public  void GetScaledCapsuleSize_WithoutHemisphere(out float OutRadius,out float OutHalfHeightWithoutHemisphere)
{
	CheckIsValid();
	GetScaledCapsuleSize_WithoutHemisphere(_this.Get(),out OutRadius,out OutHalfHeightWithoutHemisphere);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void GetScaledCapsuleSize(IntPtr _this,out float OutRadius,out float OutHalfHeight);
/// <summary>
/// Returns the capsule radius and half-height scaled by the component scale. Half-height includes the hemisphere end cap.
/// @param OutRadius Radius of the capsule, scaled by the component scale.
/// @param OutHalfHeight Half-height of the capsule, scaled by the component scale. Includes the hemisphere end cap.
/// @return The capsule radius and half-height scaled by the component scale.
/// </summary>
public  void GetScaledCapsuleSize(out float OutRadius,out float OutHalfHeight)
{
	CheckIsValid();
	GetScaledCapsuleSize(_this.Get(),out OutRadius,out OutHalfHeight);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static float GetScaledCapsuleHalfHeight_WithoutHemisphere(IntPtr _this);
/// <summary>
/// Returns the capsule half-height minus radius (to exclude the hemisphere), scaled by the component scale.
/// From the center of the capsule this is the vertical distance along the straight cylindrical portion to the point just before the curve of top hemisphere begins.
/// @return The capsule half-height minus radius, scaled by the component scale.
/// </summary>
public  float GetScaledCapsuleHalfHeight_WithoutHemisphere()
{
	CheckIsValid();
	float ___ret = GetScaledCapsuleHalfHeight_WithoutHemisphere(_this.Get());
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static float GetScaledCapsuleHalfHeight(IntPtr _this);
/// <summary>
/// Returns the capsule half-height scaled by the component scale. This includes both the cylinder and hemisphere cap.
/// @return The capsule half-height scaled by the component scale.
/// </summary>
public  float GetScaledCapsuleHalfHeight()
{
	CheckIsValid();
	float ___ret = GetScaledCapsuleHalfHeight(_this.Get());
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static float GetScaledCapsuleRadius(IntPtr _this);
/// <summary>
/// Returns the capsule radius scaled by the component scale.
/// @return The capsule radius scaled by the component scale.
/// </summary>
public  float GetScaledCapsuleRadius()
{
	CheckIsValid();
	float ___ret = GetScaledCapsuleRadius(_this.Get());
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SetCapsuleHalfHeight(IntPtr _this,float HalfHeight,int bUpdateOverlaps);
/// <summary>
/// Set the capsule half-height. This is the unscaled half-height, before component scale is applied.
/// If this capsule collides, updates touching array for owner actor.
/// @param       HalfHeight : half-height, from capsule center to end of top or bottom hemisphere.
/// @param       bUpdateOverlaps: if true and this shape is registered and collides, updates touching array for owner actor.
/// </summary>
public  void SetCapsuleHalfHeight(float HalfHeight,bool bUpdateOverlaps=true)
{
	CheckIsValid();
	SetCapsuleHalfHeight(_this.Get(),HalfHeight,bUpdateOverlaps?1:0);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SetCapsuleRadius(IntPtr _this,float Radius,int bUpdateOverlaps);
/// <summary>
/// Set the capsule radius. This is the unscaled radius, before component scale is applied.
/// If this capsule collides, updates touching array for owner actor.
/// @param       Radius : radius of end-cap hemispheres and center cylinder.
/// @param       bUpdateOverlaps: if true and this shape is registered and collides, updates touching array for owner actor.
/// </summary>
public  void SetCapsuleRadius(float Radius,bool bUpdateOverlaps=true)
{
	CheckIsValid();
	SetCapsuleRadius(_this.Get(),Radius,bUpdateOverlaps?1:0);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SetCapsuleSize(IntPtr _this,float InRadius,float InHalfHeight,int bUpdateOverlaps);
/// <summary>
/// Change the capsule size. This is the unscaled size, before component scale is applied.
/// @param       InRadius : radius of end-cap hemispheres and center cylinder.
/// @param       InHalfHeight : half-height, from capsule center to end of top or bottom hemisphere.
/// @param       bUpdateOverlaps: if true and this shape is registered and collides, updates touching array for owner actor.
/// </summary>
public  void SetCapsuleSize(float InRadius,float InHalfHeight,bool bUpdateOverlaps=true)
{
	CheckIsValid();
	SetCapsuleSize(_this.Get(),InRadius,InHalfHeight,bUpdateOverlaps?1:0);
	
}
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	public extern static new IntPtr StaticClass();
}
}
