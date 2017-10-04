using System;
namespace UnrealEngine
{
	public partial class UMaterialBillboardComponent:UPrimitiveComponent
	{
		/// <summary>Adds an element to the sprite.</summary>
		public extern void AddElement(UMaterialInterface Material,UCurveFloat DistanceToOpacityCurve,bool bSizeIsInScreenSpace,float BaseSizeX,float BaseSizeY,UCurveFloat DistanceToSizeCurve);
		
	}
	
}
