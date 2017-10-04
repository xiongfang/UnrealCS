using System;
namespace UnrealEngine
{
	public partial class AGameState:AGameStateBase
	{
		/// <summary>Gives clients the chance to do something when time gets updates</summary>
		public extern virtual void OnRep_ElapsedTime();
		/// <summary>Match state has changed</summary>
		public extern virtual void OnRep_MatchState();
		/// <summary>What match state we are currently in</summary>
		public FName MatchState;
		
		/// <summary>Previous map state, used to handle if multiple transitions happen per frame</summary>
		public FName PreviousMatchState;
		
		/// <summary>Elapsed game time since match has started.</summary>
		public int ElapsedTime;
		
		
	}
	
}
