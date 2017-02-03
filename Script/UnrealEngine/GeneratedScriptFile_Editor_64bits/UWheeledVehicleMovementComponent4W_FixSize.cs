#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class UWheeledVehicleMovementComponent4W
	{
		static readonly int EngineSetup__Offset;
		/// <summary>Engine</summary>
		public FVehicleEngineData EngineSetup
		{
			get{ CheckIsValid();return (FVehicleEngineData)Marshal.PtrToStructure(_this.Get()+EngineSetup__Offset, typeof(FVehicleEngineData));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+EngineSetup__Offset, false);}
			
		}
		
		static readonly int DifferentialSetup__Offset;
		/// <summary>Differential</summary>
		public FVehicleDifferential4WData DifferentialSetup
		{
			get{ CheckIsValid();return (FVehicleDifferential4WData)Marshal.PtrToStructure(_this.Get()+DifferentialSetup__Offset, typeof(FVehicleDifferential4WData));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+DifferentialSetup__Offset, false);}
			
		}
		
		static readonly int TransmissionSetup__Offset;
		/// <summary>Transmission data</summary>
		public FVehicleTransmissionData TransmissionSetup
		{
			get{ CheckIsValid();return (FVehicleTransmissionData)Marshal.PtrToStructure(_this.Get()+TransmissionSetup__Offset, typeof(FVehicleTransmissionData));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+TransmissionSetup__Offset, false);}
			
		}
		
		static readonly int SteeringCurve__Offset;
		/// <summary>Maximum steering versus forward speed (km/h)</summary>
		public FRuntimeFloatCurve SteeringCurve
		{
			get{ CheckIsValid();return (FRuntimeFloatCurve)Marshal.PtrToStructure(_this.Get()+SteeringCurve__Offset, typeof(FRuntimeFloatCurve));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+SteeringCurve__Offset, false);}
			
		}
		
		static readonly int AckermannAccuracy__Offset;
		/// <summary>Accuracy of Ackermann steer calculation (range: 0..1)</summary>
		public float AckermannAccuracy
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+AckermannAccuracy__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+AckermannAccuracy__Offset, false);}
			
		}
		
		static UWheeledVehicleMovementComponent4W()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("WheeledVehicleMovementComponent4W");
			EngineSetup__Offset=GetPropertyOffset(NativeClassPtr,"EngineSetup");
			DifferentialSetup__Offset=GetPropertyOffset(NativeClassPtr,"DifferentialSetup");
			TransmissionSetup__Offset=GetPropertyOffset(NativeClassPtr,"TransmissionSetup");
			SteeringCurve__Offset=GetPropertyOffset(NativeClassPtr,"SteeringCurve");
			AckermannAccuracy__Offset=GetPropertyOffset(NativeClassPtr,"AckermannAccuracy");
			
		}
		
	}
	
}
#endif
#endif
