using System;
namespace UnrealEngine
{
	public partial class ADecalActor:AActor
	{
		public UDecalComponent Decal;
		
		public UArrowComponent ArrowComponent;
		
		public UBillboardComponent SpriteComponent;
		
		/// <summary>formerly we used this component to draw a box, now we use the DecalComponentVisualizer</summary>
		public UBoxComponent BoxComponent;
		
		
	}
	
}
