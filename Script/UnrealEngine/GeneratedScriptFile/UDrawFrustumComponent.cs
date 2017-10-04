using System;
namespace UnrealEngine
{
	public partial class UDrawFrustumComponent:UPrimitiveComponent
	{
		/// <summary>Color to draw the wireframe frustum.</summary>
		public FColor FrustumColor;
		
		/// <summary>
		/// Angle of longest dimension of view shape.
		/// If the angle is 0 then an orthographic projection is used
		/// </summary>
		public float FrustumAngle;
		
		/// <summary>Ratio of horizontal size over vertical size.</summary>
		public float FrustumAspectRatio;
		
		/// <summary>Distance from origin to start drawing the frustum.</summary>
		public float FrustumStartDist;
		
		/// <summary>Distance from origin to stop drawing the frustum.</summary>
		public float FrustumEndDist;
		
		/// <summary>optional texture to show on the near plane</summary>
		public UTexture Texture;
		
		
	}
	
}
