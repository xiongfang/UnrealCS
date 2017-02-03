using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine{
public partial class UPawnMovementComponent:UNavMovementComponent 
{
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static IntPtr GetPawnOwner(IntPtr _this);
/// <summary>Return the Pawn that owns UpdatedComponent.</summary>
public  APawn GetPawnOwner()
{
	CheckIsValid();
	IntPtr ___ret = GetPawnOwner(_this.Get());
	if(___ret==IntPtr.Zero) return null; APawn ___ret2= new APawn(){ _this = ___ret }; return ___ret2;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static int IsMoveInputIgnored(IntPtr _this);
/// <summary>Helper to see if move input is ignored. If there is no Pawn or UpdatedComponent, returns true, otherwise defers to the Pawn's implementation of IsMoveInputIgnored().</summary>
public  bool IsMoveInputIgnored()
{
	CheckIsValid();
	int ___ret = IsMoveInputIgnored(_this.Get());
	return ___ret!=0;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static FVector ConsumeInputVector(IntPtr _this);
/// <summary>
/// Returns the pending input vector and resets it to zero.
///        * This should be used during a movement update (by the Pawn or PawnMovementComponent) to prevent accumulation of control input between frames.
///        * Copies the pending input vector to the saved input vector (GetLastMovementInputVector()).
///        * @return The pending input vector.
/// </summary>
public  FVector ConsumeInputVector()
{
	CheckIsValid();
	FVector ___ret = ConsumeInputVector(_this.Get());
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static FVector GetLastInputVector(IntPtr _this);
/// <summary>
/// Return the last input vector in world space that was processed by ConsumeInputVector(), which is usually done by the Pawn or PawnMovementComponent.
/// Any user that needs to know about the input that last affected movement should use this function.
/// @return The last input vector in world space that was processed by ConsumeInputVector().
/// @see AddInputVector(), ConsumeInputVector(), GetPendingInputVector()
/// </summary>
public  FVector GetLastInputVector()
{
	CheckIsValid();
	FVector ___ret = GetLastInputVector(_this.Get());
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static FVector GetPendingInputVector(IntPtr _this);
/// <summary>
/// Return the pending input vector in world space. This is the most up-to-date value of the input vector, pending ConsumeMovementInputVector() which clears it.
/// PawnMovementComponents implementing movement usually want to use either this or ConsumeInputVector() as these functions represent the most recent state of input.
/// @return The pending input vector in world space.
/// @see AddInputVector(), ConsumeInputVector(), GetLastInputVector()
/// </summary>
public  FVector GetPendingInputVector()
{
	CheckIsValid();
	FVector ___ret = GetPendingInputVector(_this.Get());
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void AddInputVector(IntPtr _this,ref FVector WorldVector,int bForce);
/// <summary>
/// Adds the given vector to the accumulated input in world space. Input vectors are usually between 0 and 1 in magnitude.
/// They are accumulated during a frame then applied as acceleration during the movement update.
/// @param WorldDirection        Direction in world space to apply input
/// @param ScaleValue            Scale to apply to input. This can be used for analog input, ie a value of 0.5 applies half the normal value.
/// @param bForce                        If true always add the input, ignoring the result of IsMoveInputIgnored().
/// @see APawn::AddMovementInput()
/// </summary>
public  void AddInputVector(FVector WorldVector,bool bForce=false)
{
	CheckIsValid();
	AddInputVector(_this.Get(),ref WorldVector,bForce?1:0);
	
}
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	public extern static new IntPtr StaticClass();
}
}
