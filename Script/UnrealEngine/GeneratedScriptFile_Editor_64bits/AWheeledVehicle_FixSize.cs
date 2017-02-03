#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>
	/// WheeledVehicle is the base wheeled vehicle pawn actor.
	/// By default it uses UWheeledVehicleMovementComponent4W for its simulation, but this can be overridden by inheriting from the class and modifying its constructor like so:
	/// Super(ObjectInitializer.SetDefautSubobjectClass<UMyMovement>(VehicleMovementComponentName))
	/// Where UMyMovement is the new movement type that inherits from UWheeledVehicleMovementComponent
	/// @see https://docs.unrealengine.com/latest/INT/Engine/Physics/Vehicles/VehicleUserGuide/
	/// @see UWheeledVehicleMovementComponent4W
	/// </summary>
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
