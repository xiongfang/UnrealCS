using System;
namespace UnrealEngine
{
	public partial class UBrushComponent:UPrimitiveComponent
	{
		public UModel Brush;
		
		/// <summary>Description of collision</summary>
		public UBodySetup BrushBodySetup;
		
		/// <summary>Local space translation</summary>
		public FVector PrePivot;
		
		
	}
	
}
