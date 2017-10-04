using System;
namespace UnrealEngine
{
	public partial class USpotLightComponent:UPointLightComponent
	{
		public extern void SetOuterConeAngle(float NewOuterConeAngle);
		public extern void SetInnerConeAngle(float NewInnerConeAngle);
		/// <summary>Degrees.</summary>
		public float InnerConeAngle;
		
		/// <summary>Degrees.</summary>
		public float OuterConeAngle;
		
		/// <summary>EditAnywhere, BlueprintReadOnly, Category=LightShaft, meta=(UIMin = "1.0", UIMax = "180.0")</summary>
		public float LightShaftConeAngle;
		
		
	}
	
}
