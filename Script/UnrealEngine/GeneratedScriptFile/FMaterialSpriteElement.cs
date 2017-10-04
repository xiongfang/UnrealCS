using System;
namespace UnrealEngine
{
	public partial struct FMaterialSpriteElement
	{
		/// <summary>The material that the sprite is rendered with.</summary>
		public UMaterialInterface Material;
		/// <summary>A curve that maps distance on the X axis to the sprite opacity on the Y axis.</summary>
		public UCurveFloat DistanceToOpacityCurve;
		/// <summary>Whether the size is defined in screen-space or world-space.</summary>
		public bool bSizeIsInScreenSpace;
		/// <summary>The base width of the sprite, multiplied with the DistanceToSizeCurve.</summary>
		public float BaseSizeX;
		/// <summary>The base height of the sprite, multiplied with the DistanceToSizeCurve.</summary>
		public float BaseSizeY;
		/// <summary>A curve that maps distance on the X axis to the sprite size on the Y axis.</summary>
		public UCurveFloat DistanceToSizeCurve;
		
	}
	
}
