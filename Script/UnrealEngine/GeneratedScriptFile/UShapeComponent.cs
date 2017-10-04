using System;
namespace UnrealEngine
{
	public partial class UShapeComponent:UPrimitiveComponent
	{
		/// <summary>Color used to draw the shape.</summary>
		public FColor ShapeColor;
		
		/// <summary>Description of collision</summary>
		public UBodySetup ShapeBodySetup;
		
		/// <summary>Only show this component if the actor is selected</summary>
		public bool bDrawOnlyIfSelected;
		
		/// <summary>If true it allows Collision when placing even if collision is not enabled</summary>
		public bool bShouldCollideWhenPlacing;
		
		/// <summary>If set, shape will be exported for navigation as dynamic modifier instead of using regular collision data</summary>
		public bool bDynamicObstacle;
		
		/// <summary>Navigation area type (empty = default obstacle)</summary>
		public TSubclassOf<UNavArea>  AreaClass;
		
		
	}
	
}
