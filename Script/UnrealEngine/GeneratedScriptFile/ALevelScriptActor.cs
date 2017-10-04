using System;
namespace UnrealEngine
{
	public partial class ALevelScriptActor:AActor
	{
		/// <summary>
		/// Sets the cinematic mode on all PlayerControllers
		/// @param       bInCinematicMode        specify true if the player is entering cinematic mode; false if the player is leaving cinematic mode.
		/// @param       bHidePlayer                     specify true to hide the player's pawn (only relevant if bInCinematicMode is true)
		/// @param       bAffectsHUD                     specify true if we should show/hide the HUD to match the value of bCinematicMode
		/// @param       bAffectsMovement        specify true to disable movement in cinematic mode, enable it when leaving
		/// @param       bAffectsTurning         specify true to disable turning in cinematic mode or enable it when leaving
		/// </summary>
		public extern virtual void SetCinematicMode(bool bCinematicMode,bool bHidePlayer=true,bool bAffectsHUD=true,bool bAffectsMovement=false,bool bAffectsTurning=false);
		/// <summary>Tries to find an event named "EventName" on all other levels, and calls it</summary>
		public extern virtual bool RemoteEvent(FName EventName);
		public bool bInputEnabled;
		
		
	}
	
}
