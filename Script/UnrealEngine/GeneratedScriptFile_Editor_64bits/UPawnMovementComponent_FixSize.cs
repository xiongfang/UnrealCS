#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>
	/// PawnMovementComponent can be used to update movement for an associated Pawn.
	/// It also provides ways to accumulate and read directional input in a generic way (with AddInputVector(), ConsumeInputVector(), etc).
	/// @see APawn
	/// </summary>
	public partial class UPawnMovementComponent
	{
		static readonly int PawnOwner__Offset;
		/// <summary>Pawn that owns this component.</summary>
		public APawn PawnOwner
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + PawnOwner__Offset); if (v == IntPtr.Zero)return null; APawn retValue = new APawn(); retValue._this = v; return retValue; }
			
		}
		
		static UPawnMovementComponent()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("PawnMovementComponent");
			PawnOwner__Offset=GetPropertyOffset(NativeClassPtr,"PawnOwner");
			
		}
		
	}
	
}
#endif
#endif
