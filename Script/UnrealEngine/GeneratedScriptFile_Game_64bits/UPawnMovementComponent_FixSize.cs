#if WITH_GAME
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class UPawnMovementComponent
	{
		static readonly int PawnOwner__Offset;
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
