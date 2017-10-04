using System;
namespace UnrealEngine
{
	public partial class ATriggerBase:AActor
	{
		/// <summary>Shape component used for collision</summary>
		public UShapeComponent CollisionComponent;
		
		/// <summary>Billboard used to see the trigger in the editor</summary>
		public UBillboardComponent SpriteComponent;
		
		
	}
	
}
