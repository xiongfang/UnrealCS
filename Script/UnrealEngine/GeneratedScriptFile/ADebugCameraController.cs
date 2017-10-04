using System;
namespace UnrealEngine
{
	public partial class ADebugCameraController:APlayerController
	{
		/// <summary>Sets the pawn movement speed scale.</summary>
		public extern void SetPawnMovementSpeedScale(float NewSpeedScale);
		public extern AActor GetSelectedActor();
		/// <summary>Toggles the display of debug info and input commands for the Debug Camera.</summary>
		public extern void ToggleDisplay();
		/// <summary>@todo document</summary>
		public extern virtual void ShowDebugSelectedInfo();
		/// <summary>Whether to show information about the selected actor on the debug camera HUD.</summary>
		public bool bShowSelectedInfo;
		
		/// <summary>@todo document</summary>
		public bool bIsFrozenRendering;
		
		/// <summary>@todo document</summary>
		public UDrawFrustumComponent DrawFrustum;
		
		/// <summary>Allows control over the speed of the spectator pawn. This scales the speed based on the InitialMaxSpeed. Use Set Pawn Movement Speed Scale during runtime</summary>
		public float SpeedScale;
		
		/// <summary>Initial max speed of the spectator pawn when we start possession.</summary>
		public float InitialMaxSpeed;
		
		/// <summary>Initial acceleration of the spectator pawn when we start possession.</summary>
		public float InitialAccel;
		
		/// <summary>Initial deceleration of the spectator pawn when we start possession.</summary>
		public float InitialDecel;
		
		
	}
	
}
