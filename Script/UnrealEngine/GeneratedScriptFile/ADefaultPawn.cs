using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine{
public partial class ADefaultPawn:APawn 
{
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void LookUpAtRate(IntPtr _this,float Rate);
/// <summary>
/// Called via input to look up at a given rate (or down if Rate is negative).
/// @param Rate   This is a normalized rate, i.e. 1.0 means 100% of desired turn rate
/// </summary>
public  void LookUpAtRate(float Rate)
{
	CheckIsValid();
	LookUpAtRate(_this.Get(),Rate);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void TurnAtRate(IntPtr _this,float Rate);
/// <summary>
/// Called via input to turn at a given rate.
/// @param Rate  This is a normalized rate, i.e. 1.0 means 100% of desired turn rate
/// </summary>
public  void TurnAtRate(float Rate)
{
	CheckIsValid();
	TurnAtRate(_this.Get(),Rate);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void MoveUp_World(IntPtr _this,float Val);
/// <summary>
/// Input callback to move up in world space (or down if Val is negative).
/// @param Val Amount of movement in the world up direction (or down if negative).
/// @see APawn::AddMovementInput()
/// </summary>
public  void MoveUp_World(float Val)
{
	CheckIsValid();
	MoveUp_World(_this.Get(),Val);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void MoveRight(IntPtr _this,float Val);
/// <summary>
/// Input callback to strafe right in local space (or left if Val is negative).
/// @param Val Amount of movement in the right direction (or left if negative).
/// @see APawn::AddMovementInput()
/// </summary>
public  void MoveRight(float Val)
{
	CheckIsValid();
	MoveRight(_this.Get(),Val);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void MoveForward(IntPtr _this,float Val);
/// <summary>
/// Input callback to move forward in local space (or backward if Val is negative).
/// @param Val Amount of movement in the forward direction (or backward if negative).
/// @see APawn::AddMovementInput()
/// </summary>
public  void MoveForward(float Val)
{
	CheckIsValid();
	MoveForward(_this.Get(),Val);
	
}
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	public extern static new IntPtr StaticClass();
}
}
