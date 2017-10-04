using System;
namespace UnrealEngine
{
	public partial class UCapsuleComponent:UShapeComponent
	{
		/// <summary>
		/// Get the scale used by this shape. This is a uniform scale that is the minimum of any non-uniform scaling.
		/// @return the scale used by this shape.
		/// </summary>
		public extern float GetShapeScale();
		/// <summary>
		/// Returns the capsule radius and half-height, ignoring component scaling. Half-height excludes the hemisphere end cap.
		/// @param OutRadius Radius of the capsule, ignoring component scaling.
		/// @param OutHalfHeightWithoutHemisphere Half-height of the capsule, scaled by the component scale. Excludes the hemisphere end cap.
		/// @return The capsule radius and half-height (excluding hemisphere end cap), ignoring component scaling.
		/// </summary>
		public extern void GetUnscaledCapsuleSize_WithoutHemisphere(out float OutRadius,out float OutHalfHeightWithoutHemisphere);
		/// <summary>
		/// Returns the capsule radius and half-height scaled by the component scale. Half-height includes the hemisphere end cap.
		/// @param OutRadius Radius of the capsule, scaled by the component scale.
		/// @param OutHalfHeight Half-height of the capsule, scaled by the component scale. Includes the hemisphere end cap.
		/// @return The capsule radius and half-height scaled by the component scale.
		/// </summary>
		public extern void GetUnscaledCapsuleSize(out float OutRadius,out float OutHalfHeight);
		/// <summary>
		/// Returns the capsule half-height minus radius (to exclude the hemisphere), ignoring component scaling. This excludes the hemisphere end cap.
		/// From the center of the capsule this is the vertical distance along the straight cylindrical portion to the point just before the curve of top hemisphere begins.
		/// @return The capsule half-height minus radius, ignoring component scaling.
		/// </summary>
		public extern float GetUnscaledCapsuleHalfHeight_WithoutHemisphere();
		/// <summary>
		/// Returns the capsule half-height, ignoring component scaling. This includes the hemisphere end cap.
		/// @return The capsule radius, ignoring component scaling.
		/// </summary>
		public extern float GetUnscaledCapsuleHalfHeight();
		/// <summary>
		/// Returns the capsule radius, ignoring component scaling.
		/// @return the capsule radius, ignoring component scaling.
		/// </summary>
		public extern float GetUnscaledCapsuleRadius();
		/// <summary>
		/// Returns the capsule radius and half-height scaled by the component scale. Half-height excludes the hemisphere end cap.
		/// @param OutRadius Radius of the capsule, ignoring component scaling.
		/// @param OutHalfHeightWithoutHemisphere Half-height of the capsule, scaled by the component scale. Excludes the hemisphere end cap.
		/// @return The capsule radius and half-height scaled by the component scale.
		/// </summary>
		public extern void GetScaledCapsuleSize_WithoutHemisphere(out float OutRadius,out float OutHalfHeightWithoutHemisphere);
		/// <summary>
		/// Returns the capsule radius and half-height scaled by the component scale. Half-height includes the hemisphere end cap.
		/// @param OutRadius Radius of the capsule, scaled by the component scale.
		/// @param OutHalfHeight Half-height of the capsule, scaled by the component scale. Includes the hemisphere end cap.
		/// @return The capsule radius and half-height scaled by the component scale.
		/// </summary>
		public extern void GetScaledCapsuleSize(out float OutRadius,out float OutHalfHeight);
		/// <summary>
		/// Returns the capsule half-height minus radius (to exclude the hemisphere), scaled by the component scale.
		/// From the center of the capsule this is the vertical distance along the straight cylindrical portion to the point just before the curve of top hemisphere begins.
		/// @return The capsule half-height minus radius, scaled by the component scale.
		/// </summary>
		public extern float GetScaledCapsuleHalfHeight_WithoutHemisphere();
		/// <summary>
		/// Returns the capsule half-height scaled by the component scale. This includes both the cylinder and hemisphere cap.
		/// @return The capsule half-height scaled by the component scale.
		/// </summary>
		public extern float GetScaledCapsuleHalfHeight();
		/// <summary>
		/// Returns the capsule radius scaled by the component scale.
		/// @return The capsule radius scaled by the component scale.
		/// </summary>
		public extern float GetScaledCapsuleRadius();
		/// <summary>
		/// Set the capsule half-height. This is the unscaled half-height, before component scale is applied.
		/// If this capsule collides, updates touching array for owner actor.
		/// @param       HalfHeight : half-height, from capsule center to end of top or bottom hemisphere.
		/// @param       bUpdateOverlaps: if true and this shape is registered and collides, updates touching array for owner actor.
		/// </summary>
		public extern void SetCapsuleHalfHeight(float HalfHeight,bool bUpdateOverlaps=true);
		/// <summary>
		/// Set the capsule radius. This is the unscaled radius, before component scale is applied.
		/// If this capsule collides, updates touching array for owner actor.
		/// @param       Radius : radius of end-cap hemispheres and center cylinder.
		/// @param       bUpdateOverlaps: if true and this shape is registered and collides, updates touching array for owner actor.
		/// </summary>
		public extern void SetCapsuleRadius(float Radius,bool bUpdateOverlaps=true);
		/// <summary>
		/// Change the capsule size. This is the unscaled size, before component scale is applied.
		/// @param       InRadius : radius of end-cap hemispheres and center cylinder.
		/// @param       InHalfHeight : half-height, from capsule center to end of top or bottom hemisphere.
		/// @param       bUpdateOverlaps: if true and this shape is registered and collides, updates touching array for owner actor.
		/// </summary>
		public extern void SetCapsuleSize(float InRadius,float InHalfHeight,bool bUpdateOverlaps=true);
		/// <summary>
		/// Half-height, from center of capsule to the end of top or bottom hemisphere.
		/// This cannot be less than CapsuleRadius.
		/// </summary>
		public float CapsuleHalfHeight;
		
		/// <summary>
		/// Radius of cap hemispheres and center cylinder.
		/// This cannot be more than CapsuleHalfHeight.
		/// </summary>
		public float CapsuleRadius;
		
		public float CapsuleHeight;
		
		
	}
	
}
