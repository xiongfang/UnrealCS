using System;
namespace UnrealEngine
{
	public partial class USphereComponent:UShapeComponent
	{
		/// <summary>
		/// Get the scale used by this shape. This is a uniform scale that is the minimum of any non-uniform scaling.
		/// @return the scale used by this shape.
		/// </summary>
		public extern float GetShapeScale();
		/// <summary>@return the radius of the sphere, ignoring component scale.</summary>
		public extern float GetUnscaledSphereRadius();
		/// <summary>@return the radius of the sphere, with component scale applied.</summary>
		public extern float GetScaledSphereRadius();
		/// <summary>
		/// Change the sphere radius. This is the unscaled radius, before component scale is applied.
		/// @param       InSphereRadius: the new sphere radius
		/// @param       bUpdateOverlaps: if true and this shape is registered and collides, updates touching array for owner actor.
		/// </summary>
		public extern void SetSphereRadius(float InSphereRadius,bool bUpdateOverlaps=true);
		/// <summary>The radius of the sphere *</summary>
		public float SphereRadius;
		
		
	}
	
}
