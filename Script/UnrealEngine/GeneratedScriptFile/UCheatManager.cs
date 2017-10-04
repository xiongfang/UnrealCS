using System;
namespace UnrealEngine
{
	public partial class UCheatManager:UObject
	{
		/// <summary>Executes commands listed in CheatScript.ScriptName ini section of DefaultGame.ini</summary>
		public extern void CheatScript(FString ScriptName);
		/// <summary>Backwards compatibility exec function for people used to it instead of using InvertAxisKey</summary>
		public extern void InvertMouse();
		/// <summary>Exec function to return the mouse sensitivity to its default value</summary>
		public extern void SetMouseSensitivityToDefault();
		/// <summary>Translate world origin to this player position</summary>
		public extern void SetWorldOrigin();
		/// <summary>Logs the current location in bugit format without taking screenshot and further routing.</summary>
		public extern virtual void LogLoc();
		/// <summary>This will force a flush of the output log to file</summary>
		public extern virtual void FlushLog();
		/// <summary>This will create a BugItGo string for us.  Nice for calling form c++ where you just want the string and no Screenshots *</summary>
		public extern virtual void BugItStringCreator(FVector ViewLocation,FRotator ViewRotation,out FString GoString,out FString LocString);
		/// <summary>
		/// This function is used to print out the BugIt location.  It prints out copy and paste versions for both IMing someone to type in
		/// and also a gameinfo ?options version so that you can append it to your launching url and be taken to the correct place.
		/// Additionally, it will take a screen shot so reporting bugs is a one command action!
		/// </summary>
		public extern virtual void BugIt(FString ScreenShotDescription);
		/// <summary>
		/// This will move the player and set their rotation to the passed in values.
		/// We have this version of the BugIt family as it is easier to type in just raw numbers in the console.
		/// </summary>
		public extern virtual void BugItGo(float X,float Y,float Z,float Pitch,float Yaw,float Roll);
		/// <summary>Dump current state of voice chat</summary>
		public extern virtual void DumpVoiceMutingState();
		/// <summary>Dump known chat information</summary>
		public extern virtual void DumpChatState();
		/// <summary>Dump known party information</summary>
		public extern virtual void DumpPartyState();
		/// <summary>Dump online session information</summary>
		public extern virtual void DumpOnlineSessionState();
		/// <summary>Sets navigation drawing distance. Relevant only in non-editor modes. *</summary>
		public extern void SetNavDrawDistance(float DrawDistance);
		/// <summary>Builds the navigation mesh (or rebuilds it). *</summary>
		public extern virtual void RebuildNavigation();
		/// <summary>Test all volumes in the world to the player controller's view location*</summary>
		public extern virtual void TestCollisionDistance();
		/// <summary>Clear persistent list for trace capture *</summary>
		public extern virtual void DebugCapsuleSweepClear();
		/// <summary>Capture current local PC's pawn's location and add to persistent list *</summary>
		public extern virtual void DebugCapsuleSweepPawn();
		/// <summary>Capture current trace and add to persistent list *</summary>
		public extern virtual void DebugCapsuleSweepCapture();
		/// <summary>Change Trace Complex setting *</summary>
		public extern virtual void DebugCapsuleSweepComplex(bool bTraceComplex);
		/// <summary>Change Trace Channel *</summary>
		public extern virtual void DebugCapsuleSweepChannel(ECollisionChannel Channel);
		/// <summary>Change Trace capsule size *</summary>
		public extern virtual void DebugCapsuleSweepSize(float HalfHeight,float Radius);
		/// <summary>Toggle capsule trace debugging. Will trace a capsule from current view point and show where it hits the world</summary>
		public extern virtual void DebugCapsuleSweep();
		public extern virtual void ServerToggleAILogging();
		/// <summary>toggles AI logging</summary>
		public extern virtual void ToggleAILogging();
		/// <summary>Toggle between debug camera/player camera without locking gameplay and with locking local player controller input.</summary>
		public extern virtual void ToggleDebugCamera();
		/// <summary>Stream out the given level.</summary>
		public extern virtual void StreamLevelOut(FName PackageName);
		/// <summary>Load the given level.</summary>
		public extern virtual void OnlyLoadLevel(FName PackageName);
		/// <summary>Stream in the given level.</summary>
		public extern virtual void StreamLevelIn(FName PackageName);
		/// <summary>View from the point of view of an AActor of class DesiredClass.  Each subsequent ViewClass cycles through the list of actors of that class.</summary>
		public extern virtual void ViewClass(TSubclassOf<AActor>  DesiredClass);
		/// <summary>View from the point of view of AActor with Name ActorName.</summary>
		public extern virtual void ViewActor(FName ActorName);
		/// <summary>View from the point of view of player with PlayerName S.</summary>
		public extern virtual void ViewPlayer(FString S);
		/// <summary>Make controlled pawn the viewtarget again.</summary>
		public extern virtual void ViewSelf();
		/// <summary>Freeze everything in the level except for players.</summary>
		public extern virtual void PlayersOnly();
		/// <summary>Load Classname and spawn an actor of that class</summary>
		public extern virtual void Summon(FString ClassName);
		/// <summary>Destroys (by calling destroy directly) all non-player pawns of class aClass in the level</summary>
		public extern virtual void DestroyPawns(TSubclassOf<APawn>  aClass);
		/// <summary>Destroy all pawns except for the (pawn) target.  If no (pawn) target is found we don't destroy anything.</summary>
		public extern void DestroyAllPawnsExceptTarget();
		/// <summary>Destroy all actors of class aClass</summary>
		public extern virtual void DestroyAll(TSubclassOf<AActor>  aClass);
		/// <summary>Destroy the actor you're looking at.</summary>
		public extern virtual void DestroyTarget();
		/// <summary>Damage the actor you're looking at (sourced from the player).</summary>
		public extern void DamageTarget(float DamageAmount);
		/// <summary>Modify time dilation to change apparent speed of passage of time. e.g. "Slomo 0.1" makes everything move very slowly, while "Slomo 10" makes everything move very fast.</summary>
		public extern virtual void Slomo(float NewTimeDilation);
		/// <summary>Invulnerability cheat.</summary>
		public extern virtual void God();
		/// <summary>Pawn no longer collides with the world, and can fly</summary>
		public extern virtual void Ghost();
		/// <summary>Return to walking movement mode from Fly or Ghost cheat.</summary>
		public extern virtual void Walk();
		/// <summary>Pawn can fly.</summary>
		public extern virtual void Fly();
		/// <summary>Scale the player's size to be F * default size.</summary>
		public extern virtual void ChangeSize(float F);
		/// <summary>Teleport to surface player is looking at.</summary>
		public extern virtual void Teleport();
		/// <summary>Pause the game for Delay seconds.</summary>
		public extern virtual void FreezeFrame(float Delay);
		/// <summary>Debug camera - used to have independent camera without stopping gameplay</summary>
		public ADebugCameraController DebugCameraControllerRef;
		
		/// <summary>Debug camera - used to have independent camera without stopping gameplay</summary>
		public TSubclassOf<ADebugCameraController>  DebugCameraControllerClass;
		
		
	}
	
}
