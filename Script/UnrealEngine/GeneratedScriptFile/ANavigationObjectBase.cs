using System;
namespace UnrealEngine
{
	public partial class ANavigationObjectBase:AActor
	{
		public UCapsuleComponent CapsuleComponent;
		
		public UBillboardComponent GoodSprite;
		
		public UBillboardComponent BadSprite;
		
		/// <summary>True if this nav point was spawned to be a PIE player start.</summary>
		public bool bIsPIEPlayerStart;
		
		
	}
	
}
