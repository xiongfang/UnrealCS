#if WITH_GAME
#if PLATFORM_32BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class UVehicleWheel
	{
		static readonly int CollisionMesh__Offset;
		public UStaticMesh CollisionMesh
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + CollisionMesh__Offset); if (v == IntPtr.Zero)return null; UStaticMesh retValue = new UStaticMesh(); retValue._this = v; return retValue; }
			set{ CheckIsValid(); if (value == null)Marshal.WriteIntPtr(_this.Get() + CollisionMesh__Offset, IntPtr.Zero);else Marshal.WriteIntPtr(_this.Get() + CollisionMesh__Offset, value._this.Get()); }
			
		}
		
		static readonly int bDontCreateShape__Offset;
		public bool bDontCreateShape
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bDontCreateShape__Offset, 1, 0, 1, 255);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bDontCreateShape__Offset, 1,0,1,255);}
			
		}
		
		static readonly int bAutoAdjustCollisionSize__Offset;
		public bool bAutoAdjustCollisionSize
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bAutoAdjustCollisionSize__Offset, 1, 0, 1, 255);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bAutoAdjustCollisionSize__Offset, 1,0,1,255);}
			
		}
		
		static readonly int Offset__Offset;
		public FVector Offset
		{
			get{ CheckIsValid();return (FVector)Marshal.PtrToStructure(_this.Get()+Offset__Offset, typeof(FVector));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+Offset__Offset, false);}
			
		}
		
		static readonly int ShapeRadius__Offset;
		public float ShapeRadius
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+ShapeRadius__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+ShapeRadius__Offset, false);}
			
		}
		
		static readonly int ShapeWidth__Offset;
		public float ShapeWidth
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+ShapeWidth__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+ShapeWidth__Offset, false);}
			
		}
		
		static readonly int Mass__Offset;
		public float Mass
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+Mass__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+Mass__Offset, false);}
			
		}
		
		static readonly int DampingRate__Offset;
		public float DampingRate
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+DampingRate__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+DampingRate__Offset, false);}
			
		}
		
		static readonly int SteerAngle__Offset;
		public float SteerAngle
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+SteerAngle__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+SteerAngle__Offset, false);}
			
		}
		
		static readonly int bAffectedByHandbrake__Offset;
		public bool bAffectedByHandbrake
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bAffectedByHandbrake__Offset, 1, 0, 1, 255);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bAffectedByHandbrake__Offset, 1,0,1,255);}
			
		}
		
		static readonly int TireType__Offset;
		public UTireType TireType
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + TireType__Offset); if (v == IntPtr.Zero)return null; UTireType retValue = new UTireType(); retValue._this = v; return retValue; }
			set{ CheckIsValid(); if (value == null)Marshal.WriteIntPtr(_this.Get() + TireType__Offset, IntPtr.Zero);else Marshal.WriteIntPtr(_this.Get() + TireType__Offset, value._this.Get()); }
			
		}
		
		static readonly int LatStiffMaxLoad__Offset;
		public float LatStiffMaxLoad
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+LatStiffMaxLoad__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+LatStiffMaxLoad__Offset, false);}
			
		}
		
		static readonly int LatStiffValue__Offset;
		public float LatStiffValue
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+LatStiffValue__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+LatStiffValue__Offset, false);}
			
		}
		
		static readonly int LongStiffValue__Offset;
		public float LongStiffValue
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+LongStiffValue__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+LongStiffValue__Offset, false);}
			
		}
		
		static readonly int SuspensionForceOffset__Offset;
		public float SuspensionForceOffset
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+SuspensionForceOffset__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+SuspensionForceOffset__Offset, false);}
			
		}
		
		static readonly int SuspensionMaxRaise__Offset;
		public float SuspensionMaxRaise
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+SuspensionMaxRaise__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+SuspensionMaxRaise__Offset, false);}
			
		}
		
		static readonly int SuspensionMaxDrop__Offset;
		public float SuspensionMaxDrop
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+SuspensionMaxDrop__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+SuspensionMaxDrop__Offset, false);}
			
		}
		
		static readonly int SuspensionNaturalFrequency__Offset;
		public float SuspensionNaturalFrequency
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+SuspensionNaturalFrequency__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+SuspensionNaturalFrequency__Offset, false);}
			
		}
		
		static readonly int SuspensionDampingRatio__Offset;
		public float SuspensionDampingRatio
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+SuspensionDampingRatio__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+SuspensionDampingRatio__Offset, false);}
			
		}
		
		static readonly int MaxBrakeTorque__Offset;
		public float MaxBrakeTorque
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+MaxBrakeTorque__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+MaxBrakeTorque__Offset, false);}
			
		}
		
		static readonly int MaxHandBrakeTorque__Offset;
		public float MaxHandBrakeTorque
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+MaxHandBrakeTorque__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+MaxHandBrakeTorque__Offset, false);}
			
		}
		
		static readonly int VehicleSim__Offset;
		public UWheeledVehicleMovementComponent VehicleSim
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + VehicleSim__Offset); if (v == IntPtr.Zero)return null; UWheeledVehicleMovementComponent retValue = new UWheeledVehicleMovementComponent(); retValue._this = v; return retValue; }
			
		}
		
		static readonly int WheelIndex__Offset;
		public int WheelIndex
		{
			get{ CheckIsValid();return (int)Marshal.PtrToStructure(_this.Get()+WheelIndex__Offset, typeof(int));}
			
		}
		
		static readonly int DebugLongSlip__Offset;
		public float DebugLongSlip
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+DebugLongSlip__Offset, typeof(float));}
			
		}
		
		static readonly int DebugLatSlip__Offset;
		public float DebugLatSlip
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+DebugLatSlip__Offset, typeof(float));}
			
		}
		
		static readonly int DebugNormalizedTireLoad__Offset;
		public float DebugNormalizedTireLoad
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+DebugNormalizedTireLoad__Offset, typeof(float));}
			
		}
		
		static readonly int DebugWheelTorque__Offset;
		public float DebugWheelTorque
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+DebugWheelTorque__Offset, typeof(float));}
			
		}
		
		static readonly int DebugLongForce__Offset;
		public float DebugLongForce
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+DebugLongForce__Offset, typeof(float));}
			
		}
		
		static readonly int DebugLatForce__Offset;
		public float DebugLatForce
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+DebugLatForce__Offset, typeof(float));}
			
		}
		
		static readonly int Location__Offset;
		public FVector Location
		{
			get{ CheckIsValid();return (FVector)Marshal.PtrToStructure(_this.Get()+Location__Offset, typeof(FVector));}
			
		}
		
		static readonly int OldLocation__Offset;
		public FVector OldLocation
		{
			get{ CheckIsValid();return (FVector)Marshal.PtrToStructure(_this.Get()+OldLocation__Offset, typeof(FVector));}
			
		}
		
		static readonly int Velocity__Offset;
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
