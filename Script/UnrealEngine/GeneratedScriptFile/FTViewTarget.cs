using System;
namespace UnrealEngine
{
	/// <summary>A ViewTarget is the primary actor the camera is associated with.</summary>
	public partial struct FTViewTarget
	{
		/// <summary>Target Actor used to compute POV</summary>
		public AActor Target;
		/// <summary>Computed point of view</summary>
		public FMinimalViewInfo POV;
		/// <summary>PlayerState (used to follow same player through pawn transitions, etc., when spectating)</summary>
		public APlayerState PlayerState;
		
	}
	
}
