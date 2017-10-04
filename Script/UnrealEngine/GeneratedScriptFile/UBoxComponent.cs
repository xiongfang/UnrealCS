using System;
namespace UnrealEngine
{
	public partial class UBoxComponent:UShapeComponent
	{
		/// <summary>@return the box extent, ignoring component scale.</summary>
		public extern FVector GetUnscaledBoxExtent();
		/// <summary>@return the box extent, scaled by the component scale.</summary>
		public extern FVector GetScaledBoxExtent();
		/// <summary>
		/// Change the box extent size. This is the unscaled size, before component scale is applied.
		/// @param       InBoxExtent: new extent (radius) for the box.
		/// @param       bUpdateOverlaps: if true and this shape is registered and collides, updates touching array for owner actor.
		/// </summary>
		public extern void SetBoxExtent(FVector InBoxExtent,bool bUpdateOverlaps=true);
		/// <summary>The extents (radii dimensions) of the box *</summary>
		public FVector BoxExtent;
		
		
	}
	
}
