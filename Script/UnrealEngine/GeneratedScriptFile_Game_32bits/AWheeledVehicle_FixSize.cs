#if WITH_GAME
#if PLATFORM_32BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class AWheeledVehicle
	{
		static readonly int Mesh__Offset;
		public USkeletalMeshComponent Mesh
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + Mesh__Offset); if (v == IntPtr.Zero)return null; USkeletalMeshComponent retValue = new USkeletalMeshComponent(); retValue._this = v; return retValue; }
			set{ CheckIsValid(); if (value == null)Marshal.WriteIntPtr(_this.Get() + Mesh__Offset, IntPtr.Zero);else Marshal.WriteIntPtr(_this.Get() + Mesh__Offset, value._this.Get()); }
			
		}
		
		static readonly int VehicleMovement__Offset;
		public UWheeledVehicleMovementComponent VehicleMovement
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + VehicleMovement__Offset); if (v == IntPtr.Zero)return null; UWheeledVehicleMovementComponent retValue = new UWheeledVehicleMovementComponent(); retValue._this = v; return retValue; }
			set{ CheckIsValid(); if (value == null)Marshal.WriteIntPtr(_this.Get() + VehicleMovement__Offset, IntPtr.Zero);else Marshal.WriteIntPtr(_this.Get() + VehicleMovement__Offset, value._this.Get()); }
			
		}
		
		static AWheeledVehicle()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("WheeledVehicle");
			Mesh__Offset=GetPropertyOffset(NativeClassPtr,"Mesh");
			VehicleMovement__Offset=GetPropertyOffset(NativeClassPtr,"VehicleMovement");
			
		}
		
	}
	
}
#endif
#endif
