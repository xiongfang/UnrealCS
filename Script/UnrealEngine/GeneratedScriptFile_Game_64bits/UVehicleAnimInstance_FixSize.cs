#if WITH_GAME
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class UVehicleAnimInstance
	{
		static readonly int WheeledVehicleMovementComponent__Offset;
		public UWheeledVehicleMovementComponent WheeledVehicleMovementComponent
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + WheeledVehicleMovementComponent__Offset); if (v == IntPtr.Zero)return null; UWheeledVehicleMovementComponent retValue = new UWheeledVehicleMovementComponent(); retValue._this = v; return retValue; }
			
		}
		
		static UVehicleAnimInstance()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("VehicleAnimInstance");
			WheeledVehicleMovementComponent__Offset=GetPropertyOffset(NativeClassPtr,"WheeledVehicleMovementComponent");
			
		}
		
	}
	
}
#endif
#endif
