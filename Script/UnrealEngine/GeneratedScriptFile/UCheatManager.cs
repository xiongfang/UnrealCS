using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine{
public partial class UCheatManager:UObject 
{
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void CheatScript(IntPtr _this,string ScriptName);
/// <summary>Executes commands listed in CheatScript.ScriptName ini section of DefaultGame.ini</summary>
public  void CheatScript(string ScriptName)
{
	CheckIsValid();
	CheatScript(_this.Get(),ScriptName);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void InvertMouse(IntPtr _this);
/// <summary>Backwards compatibility exec function for people used to it instead of using InvertAxisKey</summary>
public  void InvertMouse()
{
	CheckIsValid();
	InvertMouse(_this.Get());
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SetMouseSensitivityToDefault(IntPtr _this);
/// <summary>Exec function to return the mouse sensitivity to its default value</summary>
public  void SetMouseSensitivityToDefault()
{
	CheckIsValid();
	SetMouseSensitivityToDefault(_this.Get());
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SetWorldOrigin(IntPtr _this);
/// <summary>Translate world origin to this player position</summary>
public  void SetWorldOrigin()
{
	CheckIsValid();
	SetWorldOrigin(_this.Get());
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void LogLoc(IntPtr _this);
/// <summary>Logs the current location in bugit format without taking screenshot and further routing.</summary>
public  void LogLoc()
{
	CheckIsValid();
	LogLoc(_this.Get());
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void FlushLog(IntPtr _this);
/// <summary>This will force a flush of the output log to file</summary>
public  void FlushLog()
{
	CheckIsValid();
	FlushLog(_this.Get());
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void BugItStringCreator(IntPtr _this,ref FVector ViewLocation,ref FRotator ViewRotation,out string GoString,out string LocString);
/// <summary>This will create a BugItGo string for us.  Nice for calling form c++ where you just want the string and no Screenshots *</summary>
public  void BugItStringCreator(FVector ViewLocation,FRotator ViewRotation,out string GoString,out string LocString)
{
	CheckIsValid();
	BugItStringCreator(_this.Get(),ref ViewLocation,ref ViewRotation,out GoString,out LocString);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void BugIt(IntPtr _this,string ScreenShotDescription);
/// <summary>
/// This function is used to print out the BugIt location.  It prints out copy and paste versions for both IMing someone to type in
/// and also a gameinfo ?options version so that you can append it to your launching url and be taken to the correct place.
/// Additionally, it will take a screen shot so reporting bugs is a one command action!
/// </summary>
public  void BugIt(string ScreenShotDescription)
{
	CheckIsValid();
	BugIt(_this.Get(),ScreenShotDescription);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void BugItGo(IntPtr _this,float X,float Y,float Z,float Pitch,float Yaw,float Roll);
/// <summary>
/// This will move the player and set their rotation to the passed in values.
/// We have this version of the BugIt family as it is easier to type in just raw numbers in the console.
/// </summary>
public  void BugItGo(float X,float Y,float Z,float Pitch,float Yaw,float Roll)
{
	CheckIsValid();
	BugItGo(_this.Get(),X,Y,Z,Pitch,Yaw,Roll);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void DumpVoiceMutingState(IntPtr _this);
/// <summary>Dump current state of voice chat</summary>
public  void DumpVoiceMutingState()
{
	CheckIsValid();
	DumpVoiceMutingState(_this.Get());
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void DumpChatState(IntPtr _this);
/// <summary>Dump known chat information</summary>
public  void DumpChatState()
{
	CheckIsValid();
	DumpChatState(_this.Get());
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void DumpPartyState(IntPtr _this);
/// <summary>Dump known party information</summary>
public  void DumpPartyState()
{
	CheckIsValid();
	DumpPartyState(_this.Get());
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void DumpOnlineSessionState(IntPtr _this);
/// <summary>Dump online session information</summary>
public  void DumpOnlineSessionState()
{
	CheckIsValid();
	DumpOnlineSessionState(_this.Get());
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SetNavDrawDistance(IntPtr _this,float DrawDistance);
/// <summary>Sets navigation drawing distance. Relevant only in non-editor modes. *</summary>
public  void SetNavDrawDistance(float DrawDistance)
{
	CheckIsValid();
	SetNavDrawDistance(_this.Get(),DrawDistance);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void RebuildNavigation(IntPtr _this);
/// <summary>Builds the navigation mesh (or rebuilds it). *</summary>
public  void RebuildNavigation()
{
	CheckIsValid();
	RebuildNavigation(_this.Get());
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void TestCollisionDistance(IntPtr _this);
/// <summary>Test all volumes in the world to the player controller's view location*</summary>
public  void TestCollisionDistance()
{
	CheckIsValid();
	TestCollisionDistance(_this.Get());
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void DebugCapsuleSweepClear(IntPtr _this);
/// <summary>Clear persistent list for trace capture *</summary>
public  void DebugCapsuleSweepClear()
{
	CheckIsValid();
	DebugCapsuleSweepClear(_this.Get());
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void DebugCapsuleSweepPawn(IntPtr _this);
/// <summary>Capture current local PC's pawn's location and add to persistent list *</summary>
public  void DebugCapsuleSweepPawn()
{
	CheckIsValid();
	DebugCapsuleSweepPawn(_this.Get());
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void DebugCapsuleSweepCapture(IntPtr _this);
/// <summary>Capture current trace and add to persistent list *</summary>
public  void DebugCapsuleSweepCapture()
{
	CheckIsValid();
	DebugCapsuleSweepCapture(_this.Get());
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void DebugCapsuleSweepComplex(IntPtr _this,int bTraceComplex);
/// <summary>Change Trace Complex setting *</summary>
public  void DebugCapsuleSweepComplex(bool bTraceComplex)
{
	CheckIsValid();
	DebugCapsuleSweepComplex(_this.Get(),bTraceComplex?1:0);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void DebugCapsuleSweepChannel(IntPtr _this,int Channel);
/// <summary>Change Trace Channel *</summary>
public  void DebugCapsuleSweepChannel(ECollisionChannel Channel)
{
	CheckIsValid();
	DebugCapsuleSweepChannel(_this.Get(),(int)Channel);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void DebugCapsuleSweepSize(IntPtr _this,float HalfHeight,float Radius);
/// <summary>Change Trace capsule size *</summary>
public  void DebugCapsuleSweepSize(float HalfHeight,float Radius)
{
	CheckIsValid();
	DebugCapsuleSweepSize(_this.Get(),HalfHeight,Radius);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void DebugCapsuleSweep(IntPtr _this);
/// <summary>Toggle capsule trace debugging. Will trace a capsule from current view point and show where it hits the world</summary>
public  void DebugCapsuleSweep()
{
	CheckIsValid();
	DebugCapsuleSweep(_this.Get());
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void ServerToggleAILogging(IntPtr _this);
public  void ServerToggleAILogging()
{
	CheckIsValid();
	ServerToggleAILogging(_this.Get());
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void ToggleAILogging(IntPtr _this);
/// <summary>toggles AI logging</summary>
public  void ToggleAILogging()
{
	CheckIsValid();
	ToggleAILogging(_this.Get());
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void ToggleDebugCamera(IntPtr _this);
/// <summary>Toggle between debug camera/player camera without locking gameplay and with locking local player controller input.</summary>
public  void ToggleDebugCamera()
{
	CheckIsValid();
	ToggleDebugCamera(_this.Get());
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void StreamLevelOut(IntPtr _this,string PackageName);
/// <summary>Stream out the given level.</summary>
public  void StreamLevelOut(string PackageName)
{
	CheckIsValid();
	StreamLevelOut(_this.Get(),PackageName);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void OnlyLoadLevel(IntPtr _this,string PackageName);
/// <summary>Load the given level.</summary>
public  void OnlyLoadLevel(string PackageName)
{
	CheckIsValid();
	OnlyLoadLevel(_this.Get(),PackageName);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void StreamLevelIn(IntPtr _this,string PackageName);
/// <summary>Stream in the given level.</summary>
public  void StreamLevelIn(string PackageName)
{
	CheckIsValid();
	StreamLevelIn(_this.Get(),PackageName);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void ViewClass(IntPtr _this,IntPtr DesiredClass);
/// <summary>View from the point of view of an AActor of class DesiredClass.  Each subsequent ViewClass cycles through the list of actors of that class.</summary>
public  void ViewClass(TSubclassOf<AActor>  DesiredClass)
{
	CheckIsValid();
	ViewClass(_this.Get(),DesiredClass.NativeClass);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void ViewActor(IntPtr _this,string ActorName);
/// <summary>View from the point of view of AActor with Name ActorName.</summary>
public  void ViewActor(string ActorName)
{
	CheckIsValid();
	ViewActor(_this.Get(),ActorName);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void ViewPlayer(IntPtr _this,string S);
/// <summary>View from the point of view of player with PlayerName S.</summary>
public  void ViewPlayer(string S)
{
	CheckIsValid();
	ViewPlayer(_this.Get(),S);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void ViewSelf(IntPtr _this);
/// <summary>Make controlled pawn the viewtarget again.</summary>
public  void ViewSelf()
{
	CheckIsValid();
	ViewSelf(_this.Get());
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void PlayersOnly(IntPtr _this);
/// <summary>Freeze everything in the level except for players.</summary>
public  void PlayersOnly()
{
	CheckIsValid();
	PlayersOnly(_this.Get());
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void Summon(IntPtr _this,string ClassName);
/// <summary>Load Classname and spawn an actor of that class</summary>
public  void Summon(string ClassName)
{
	CheckIsValid();
	Summon(_this.Get(),ClassName);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void DestroyPawns(IntPtr _this,IntPtr aClass);
/// <summary>Destroys (by calling destroy directly) all non-player pawns of class aClass in the level</summary>
public  void DestroyPawns(TSubclassOf<APawn>  aClass)
{
	CheckIsValid();
	DestroyPawns(_this.Get(),aClass.NativeClass);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void DestroyAllPawnsExceptTarget(IntPtr _this);
/// <summary>Destroy all pawns except for the (pawn) target.  If no (pawn) target is found we don't destroy anything.</summary>
public  void DestroyAllPawnsExceptTarget()
{
	CheckIsValid();
	DestroyAllPawnsExceptTarget(_this.Get());
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void DestroyAll(IntPtr _this,IntPtr aClass);
/// <summary>Destroy all actors of class aClass</summary>
public  void DestroyAll(TSubclassOf<AActor>  aClass)
{
	CheckIsValid();
	DestroyAll(_this.Get(),aClass.NativeClass);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void DestroyTarget(IntPtr _this);
/// <summary>Destroy the actor you're looking at.</summary>
public  void DestroyTarget()
{
	CheckIsValid();
	DestroyTarget(_this.Get());
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void DamageTarget(IntPtr _this,float DamageAmount);
/// <summary>Damage the actor you're looking at (sourced from the player).</summary>
public  void DamageTarget(float DamageAmount)
{
	CheckIsValid();
	DamageTarget(_this.Get(),DamageAmount);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void Slomo(IntPtr _this,float NewTimeDilation);
/// <summary>Modify time dilation to change apparent speed of passage of time. e.g. "Slomo 0.1" makes everything move very slowly, while "Slomo 10" makes everything move very fast.</summary>
public  void Slomo(float NewTimeDilation)
{
	CheckIsValid();
	Slomo(_this.Get(),NewTimeDilation);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void God(IntPtr _this);
/// <summary>Invulnerability cheat.</summary>
public  void God()
{
	CheckIsValid();
	God(_this.Get());
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void Ghost(IntPtr _this);
/// <summary>Pawn no longer collides with the world, and can fly</summary>
public  void Ghost()
{
	CheckIsValid();
	Ghost(_this.Get());
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void Walk(IntPtr _this);
/// <summary>Return to walking movement mode from Fly or Ghost cheat.</summary>
public  void Walk()
{
	CheckIsValid();
	Walk(_this.Get());
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void Fly(IntPtr _this);
/// <summary>Pawn can fly.</summary>
public  void Fly()
{
	CheckIsValid();
	Fly(_this.Get());
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void ChangeSize(IntPtr _this,float F);
/// <summary>Scale the player's size to be F * default size.</summary>
public  void ChangeSize(float F)
{
	CheckIsValid();
	ChangeSize(_this.Get(),F);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void Teleport(IntPtr _this);
/// <summary>Teleport to surface player is looking at.</summary>
public  void Teleport()
{
	CheckIsValid();
	Teleport(_this.Get());
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void FreezeFrame(IntPtr _this,float Delay);
/// <summary>Pause the game for Delay seconds.</summary>
public  void FreezeFrame(float Delay)
{
	CheckIsValid();
	FreezeFrame(_this.Get(),Delay);
	
}
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	public extern static new IntPtr StaticClass();
}
}
