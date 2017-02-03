using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine{
public partial class AGameState:AGameStateBase 
{
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void OnRep_ElapsedTime(IntPtr _this);
/// <summary>Gives clients the chance to do something when time gets updates</summary>
public  void OnRep_ElapsedTime()
{
	CheckIsValid();
	OnRep_ElapsedTime(_this.Get());
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void OnRep_MatchState(IntPtr _this);
/// <summary>Match state has changed</summary>
public  void OnRep_MatchState()
{
	CheckIsValid();
	OnRep_MatchState(_this.Get());
	
}
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	public extern static new IntPtr StaticClass();
}
}
