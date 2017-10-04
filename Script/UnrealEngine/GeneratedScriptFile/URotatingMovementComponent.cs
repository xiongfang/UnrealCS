using System;
namespace UnrealEngine
{
	public partial class URotatingMovementComponent:UMovementComponent
	{
		/// <summary>How fast to update roll/pitch/yaw of the component we update.</summary>
		public FRotator RotationRate;
		
		/// <summary>
		/// Translation of pivot point around which we rotate, relative to current rotation.
		/// For instance, with PivotTranslation set to (X=+100, Y=0, Z=0), rotation will occur
		/// around the point +100 units along the local X axis from the center of the object,
		/// rather than around the object's origin (the default).
		/// </summary>
		public FVector PivotTranslation;
		
		/// <summary>Whether rotation is applied in local or world space.</summary>
		public bool bRotationInLocalSpace;
		
		
	}
	
}
