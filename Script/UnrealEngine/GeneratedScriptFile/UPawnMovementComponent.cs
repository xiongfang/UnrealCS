using System;
namespace UnrealEngine
{
	public partial class UPawnMovementComponent:UNavMovementComponent
	{
		/// <summary>Return the Pawn that owns UpdatedComponent.</summary>
		public extern APawn GetPawnOwner();
		/// <summary>Helper to see if move input is ignored. If there is no Pawn or UpdatedComponent, returns true, otherwise defers to the Pawn's implementation of IsMoveInputIgnored().</summary>
		public extern virtual bool IsMoveInputIgnored();
		/// <summary>
		/// Returns the pending input vector and resets it to zero.
		///        * This should be used during a movement update (by the Pawn or PawnMovementComponent) to prevent accumulation of control input between frames.
		///        * Copies the pending input vector to the saved input vector (GetLastMovementInputVector()).
		///        * @return The pending input vector.
		/// </summary>
		public extern virtual FVector ConsumeInputVector();
		/// <summary>
		/// Return the last input vector in world space that was processed by ConsumeInputVector(), which is usually done by the Pawn or PawnMovementComponent.
		/// Any user that needs to know about the input that last affected movement should use this function.
		/// @return The last input vector in world space that was processed by ConsumeInputVector().
		/// @see AddInputVector(), ConsumeInputVector(), GetPendingInputVector()
		/// </summary>
		public extern FVector GetLastInputVector();
		/// <summary>
		/// Return the pending input vector in world space. This is the most up-to-date value of the input vector, pending ConsumeMovementInputVector() which clears it.
		/// PawnMovementComponents implementing movement usually want to use either this or ConsumeInputVector() as these functions represent the most recent state of input.
		/// @return The pending input vector in world space.
		/// @see AddInputVector(), ConsumeInputVector(), GetLastInputVector()
		/// </summary>
		public extern FVector GetPendingInputVector();
		/// <summary>
		/// Adds the given vector to the accumulated input in world space. Input vectors are usually between 0 and 1 in magnitude.
		/// They are accumulated during a frame then applied as acceleration during the movement update.
		/// @param WorldDirection        Direction in world space to apply input
		/// @param ScaleValue            Scale to apply to input. This can be used for analog input, ie a value of 0.5 applies half the normal value.
		/// @param bForce                        If true always add the input, ignoring the result of IsMoveInputIgnored().
		/// @see APawn::AddMovementInput()
		/// </summary>
		public extern virtual void AddInputVector(FVector WorldVector,bool bForce=false);
		/// <summary>Pawn that owns this component.</summary>
		public APawn PawnOwner;
		
		
	}
	
}
