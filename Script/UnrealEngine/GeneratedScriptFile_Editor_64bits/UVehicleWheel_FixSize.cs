#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class UVehicleWheel
	{
		static readonly int CollisionMesh__Offset;
		/// <summary>
		/// Static mesh with collision setup for wheel, will be used to create wheel shape
		/// (if empty, sphere will be added as wheel shape, check bDontCreateShape flag)
		/// </summary>
		public UStaticMesh CollisionMesh
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + CollisionMesh__Offset); if (v == IntPtr.Zero)return null; UStaticMesh retValue = new UStaticMesh(); retValue._this = v; return retValue; }
			set{ CheckIsValid(); if (value == null)Marshal.WriteIntPtr(_this.Get() + CollisionMesh__Offset, IntPtr.Zero);else Marshal.WriteIntPtr(_this.Get() + CollisionMesh__Offset, value._this.Get()); }
			
		}
		
		static readonly int bDontCreateShape__Offset;
		/// <summary>If set, shape won't be created, but mapped from chassis mesh</summary>
		public bool bDontCreateShape
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bDontCreateShape__Offset, 1, 0, 1, 255);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bDontCreateShape__Offset, 1,0,1,255);}
			
		}
		
		static readonly int bAutoAdjustCollisionSize__Offset;
		/// <summary>
		/// If true, ShapeRadius and ShapeWidth will be used to automatically scale collision taken from CollisionMesh to match wheel size.
		/// If false, size of CollisionMesh won't be changed. Use if you want to scale wheels manually.
		/// </summary>
		public bool bAutoAdjustCollisionSize
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bAutoAdjustCollisionSize__Offset, 1, 0, 1, 255);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bAutoAdjustCollisionSize__Offset, 1,0,1,255);}
			
		}
		
		static readonly int Offset__Offset;
		/// <summary>
		/// If BoneName is specified, offset the wheel from the bone's location.
		/// Otherwise this offsets the wheel from the vehicle's origin.
		/// </summary>
		public FVector Offset
		{
			get{ CheckIsValid();return (FVector)Marshal.PtrToStructure(_this.Get()+Offset__Offset, typeof(FVector));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+Offset__Offset, false);}
			
		}
		
		static readonly int ShapeRadius__Offset;
		/// <summary>Radius of the wheel</summary>
		public float ShapeRadius
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+ShapeRadius__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+ShapeRadius__Offset, false);}
			
		}
		
		static readonly int ShapeWidth__Offset;
		/// <summary>Width of the wheel</summary>
		public float ShapeWidth
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+ShapeWidth__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+ShapeWidth__Offset, false);}
			
		}
		
		static readonly int Mass__Offset;
		/// <summary>Mass of this wheel</summary>
		public float Mass
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+Mass__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+Mass__Offset, false);}
			
		}
		
		static readonly int DampingRate__Offset;
		/// <summary>Damping rate for this wheel (Kgm^2/s)</summary>
		public float DampingRate
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+DampingRate__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+DampingRate__Offset, false);}
			
		}
		
		static readonly int SteerAngle__Offset;
		/// <summary>steer angle in degrees for this wheel</summary>
		public float SteerAngle
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+SteerAngle__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+SteerAngle__Offset, false);}
			
		}
		
		static readonly int bAffectedByHandbrake__Offset;
		/// <summary>Whether handbrake should affect this wheel</summary>
		public bool bAffectedByHandbrake
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bAffectedByHandbrake__Offset, 1, 0, 1, 255);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bAffectedByHandbrake__Offset, 1,0,1,255);}
			
		}
		
		static readonly int TireType__Offset;
		/// <summary>Tire type for the wheel. Determines friction</summary>
		public UTireType TireType
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + TireType__Offset); if (v == IntPtr.Zero)return null; UTireType retValue = new UTireType(); retValue._this = v; return retValue; }
			set{ CheckIsValid(); if (value == null)Marshal.WriteIntPtr(_this.Get() + TireType__Offset, IntPtr.Zero);else Marshal.WriteIntPtr(_this.Get() + TireType__Offset, value._this.Get()); }
			
		}
		
		static readonly int LatStiffMaxLoad__Offset;
		/// <summary>Max normalized tire load at which the tire can deliver no more lateral stiffness no matter how much extra load is applied to the tire.</summary>
		public float LatStiffMaxLoad
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+LatStiffMaxLoad__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+LatStiffMaxLoad__Offset, false);}
			
		}
		
		static readonly int LatStiffValue__Offset;
		/// <summary>How much lateral stiffness to have given lateral slip</summary>
		public float LatStiffValue
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+LatStiffValue__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+LatStiffValue__Offset, false);}
			
		}
		
		static readonly int LongStiffValue__Offset;
		/// <summary>How much longitudinal stiffness to have given longitudinal slip</summary>
		public float LongStiffValue
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+LongStiffValue__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+LongStiffValue__Offset, false);}
			
		}
		
		static readonly int SuspensionForceOffset__Offset;
		/// <summary>Vertical offset from vehicle center of mass where suspension forces are applied</summary>
		public float SuspensionForceOffset
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+SuspensionForceOffset__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+SuspensionForceOffset__Offset, false);}
			
		}
		
		static readonly int SuspensionMaxRaise__Offset;
		/// <summary>How far the wheel can go above the resting position</summary>
		public float SuspensionMaxRaise
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+SuspensionMaxRaise__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+SuspensionMaxRaise__Offset, false);}
			
		}
		
		static readonly int SuspensionMaxDrop__Offset;
		/// <summary>How far the wheel can drop below the resting position</summary>
		public float SuspensionMaxDrop
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+SuspensionMaxDrop__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+SuspensionMaxDrop__Offset, false);}
			
		}
		
		static readonly int SuspensionNaturalFrequency__Offset;
		/// <summary>Oscillation frequency of suspension. Standard cars have values between 5 and 10</summary>
		public float SuspensionNaturalFrequency
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+SuspensionNaturalFrequency__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+SuspensionNaturalFrequency__Offset, false);}
			
		}
		
		static readonly int SuspensionDampingRatio__Offset;
		/// <summary>
		/// The rate at which energy is dissipated from the spring. Standard cars have values between 0.8 and 1.2.
		/// values < 1 are more sluggish, values > 1 or more twitchy
		/// </summary>
		public float SuspensionDampingRatio
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+SuspensionDampingRatio__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+SuspensionDampingRatio__Offset, false);}
			
		}
		
		static readonly int MaxBrakeTorque__Offset;
		/// <summary>max brake torque for this wheel (Nm)</summary>
		public float MaxBrakeTorque
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+MaxBrakeTorque__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+MaxBrakeTorque__Offset, false);}
			
		}
		
		static readonly int MaxHandBrakeTorque__Offset;
		/// <summary>
		/// Max handbrake brake torque for this wheel (Nm). A handbrake should have a stronger brake torque
		/// than the brake. This will be ignored for wheels that are not affected by the handbrake.
		/// </summary>
		public float MaxHandBrakeTorque
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+MaxHandBrakeTorque__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+MaxHandBrakeTorque__Offset, false);}
			
		}
		
		static readonly int VehicleSim__Offset;
		/// <summary>The vehicle that owns us</summary>
		public UWheeledVehicleMovementComponent VehicleSim
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + VehicleSim__Offset); if (v == IntPtr.Zero)return null; UWheeledVehicleMovementComponent retValue = new UWheeledVehicleMovementComponent(); retValue._this = v; return retValue; }
			
		}
		
		static readonly int WheelIndex__Offset;
		/// <summary>Our index in the vehicle's (and setup's) wheels array</summary>
		public int WheelIndex
		{
			get{ CheckIsValid();return (int)Marshal.PtrToStructure(_this.Get()+WheelIndex__Offset, typeof(int));}
			
		}
		
		static readonly int DebugLongSlip__Offset;
		/// <summary>Longitudinal slip experienced by the wheel</summary>
		public float DebugLongSlip
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+DebugLongSlip__Offset, typeof(float));}
			
		}
		
		static readonly int DebugLatSlip__Offset;
		/// <summary>Lateral slip experienced by the wheel</summary>
		public float DebugLatSlip
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+DebugLatSlip__Offset, typeof(float));}
			
		}
		
		static readonly int DebugNormalizedTireLoad__Offset;
		/// <summary>How much force the tire experiences at rest devided by how much force it is experiencing now</summary>
		public float DebugNormalizedTireLoad
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+DebugNormalizedTireLoad__Offset, typeof(float));}
			
		}
		
		static readonly int DebugWheelTorque__Offset;
		/// <summary>Wheel torque</summary>
		public float DebugWheelTorque
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+DebugWheelTorque__Offset, typeof(float));}
			
		}
		
		static readonly int DebugLongForce__Offset;
		/// <summary>Longitudinal force the wheel is applying to the chassis</summary>
		public float DebugLongForce
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+DebugLongForce__Offset, typeof(float));}
			
		}
		
		static readonly int DebugLatForce__Offset;
		/// <summary>Lateral force the wheel is applying to the chassis</summary>
		public float DebugLatForce
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+DebugLatForce__Offset, typeof(float));}
			
		}
		
		static readonly int Location__Offset;
		/// <summary>Worldspace location of this wheel</summary>
		public FVector Location
		{
			get{ CheckIsValid();return (FVector)Marshal.PtrToStructure(_this.Get()+Location__Offset, typeof(FVector));}
			
		}
		
		static readonly int OldLocation__Offset;
		/// <summary>Worldspace location of this wheel last frame</summary>
		public FVector OldLocation
		{
			get{ CheckIsValid();return (FVector)Marshal.PtrToStructure(_this.Get()+OldLocation__Offset, typeof(FVector));}
			
		}
		
		static readonly int Velocity__Offset;
		/// <summary>Current velocity of the wheel center (change in location over time)</summary>
		public FVector Velocity
		{
			get{ CheckIsValid();return (FVector)Marshal.PtrToStructure(_this.Get()+Velocity__Offset, typeof(FVector));}
			
		}
		
		static UVehicleWheel()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("VehicleWheel");
			CollisionMesh__Offset=GetPropertyOffset(NativeClassPtr,"CollisionMesh");
			bDontCreateShape__Offset=GetPropertyOffset(NativeClassPtr,"bDontCreateShape");
			bAutoAdjustCollisionSize__Offset=GetPropertyOffset(NativeClassPtr,"bAutoAdjustCollisionSize");
			Offset__Offset=GetPropertyOffset(NativeClassPtr,"Offset");
			ShapeRadius__Offset=GetPropertyOffset(NativeClassPtr,"ShapeRadius");
			ShapeWidth__Offset=GetPropertyOffset(NativeClassPtr,"ShapeWidth");
			Mass__Offset=GetPropertyOffset(NativeClassPtr,"Mass");
			DampingRate__Offset=GetPropertyOffset(NativeClassPtr,"DampingRate");
			SteerAngle__Offset=GetPropertyOffset(NativeClassPtr,"SteerAngle");
			bAffectedByHandbrake__Offset=GetPropertyOffset(NativeClassPtr,"bAffectedByHandbrake");
			TireType__Offset=GetPropertyOffset(NativeClassPtr,"TireType");
			LatStiffMaxLoad__Offset=GetPropertyOffset(NativeClassPtr,"LatStiffMaxLoad");
			LatStiffValue__Offset=GetPropertyOffset(NativeClassPtr,"LatStiffValue");
			LongStiffValue__Offset=GetPropertyOffset(NativeClassPtr,"LongStiffValue");
			SuspensionForceOffset__Offset=GetPropertyOffset(NativeClassPtr,"SuspensionForceOffset");
			SuspensionMaxRaise__Offset=GetPropertyOffset(NativeClassPtr,"SuspensionMaxRaise");
			SuspensionMaxDrop__Offset=GetPropertyOffset(NativeClassPtr,"SuspensionMaxDrop");
			SuspensionNaturalFrequency__Offset=GetPropertyOffset(NativeClassPtr,"SuspensionNaturalFrequency");
			SuspensionDampingRatio__Offset=GetPropertyOffset(NativeClassPtr,"SuspensionDampingRatio");
			MaxBrakeTorque__Offset=GetPropertyOffset(NativeClassPtr,"MaxBrakeTorque");
			MaxHandBrakeTorque__Offset=GetPropertyOffset(NativeClassPtr,"MaxHandBrakeTorque");
			VehicleSim__Offset=GetPropertyOffset(NativeClassPtr,"VehicleSim");
			WheelIndex__Offset=GetPropertyOffset(NativeClassPtr,"WheelIndex");
			DebugLongSlip__Offset=GetPropertyOffset(NativeClassPtr,"DebugLongSlip");
			DebugLatSlip__Offset=GetPropertyOffset(NativeClassPtr,"DebugLatSlip");
			DebugNormalizedTireLoad__Offset=GetPropertyOffset(NativeClassPtr,"DebugNormalizedTireLoad");
			DebugWheelTorque__Offset=GetPropertyOffset(NativeClassPtr,"DebugWheelTorque");
			DebugLongForce__Offset=GetPropertyOffset(NativeClassPtr,"DebugLongForce");
			DebugLatForce__Offset=GetPropertyOffset(NativeClassPtr,"DebugLatForce");
			Location__Offset=GetPropertyOffset(NativeClassPtr,"Location");
			OldLocation__Offset=GetPropertyOffset(NativeClassPtr,"OldLocation");
			Velocity__Offset=GetPropertyOffset(NativeClassPtr,"Velocity");
			
		}
		
	}
	
}
#endif
#endif
