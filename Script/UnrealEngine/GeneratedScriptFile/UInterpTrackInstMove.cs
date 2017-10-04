using System;
namespace UnrealEngine
{
	public partial class UInterpTrackInstMove:UInterpTrackInst
	{
		/// <summary>Saved position. Used in editor for resetting when quitting Matinee.</summary>
		public FVector ResetLocation;
		
		/// <summary>Saved rotation. Used in editor for resetting when quitting Matinee.</summary>
		public FRotator ResetRotation;
		
		
	}
	
}
