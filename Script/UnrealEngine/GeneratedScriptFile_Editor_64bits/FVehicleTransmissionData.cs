#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	[StructLayout(LayoutKind.Explicit,Size=48)]
	public partial struct FVehicleTransmissionData
	{
		/// <summary>Whether to use automatic transmission</summary>
		public bool bUseGearAutoBox
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 0, 1, 0, 1, 255); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 0, 1, 0, 1, 255); } }}
			
		}
		/// <summary>Time it takes to switch gears (seconds)</summary>
		[FieldOffset(4)]
		public float GearSwitchTime;
		/// <summary>Minimum time it takes the automatic transmission to initiate a gear change (seconds)</summary>
		[FieldOffset(8)]
		public float GearAutoBoxLatency;
		/// <summary>The final gear ratio multiplies the transmission gear ratios.</summary>
		[FieldOffset(12)]
		public float FinalRatio;
		/// <summary>Forward gear ratios (up to 30)</summary>
		public TStructArray<FVehicleGearData> ForwardGears
		{
						get{ unsafe { fixed (void* p = &this) { return new TStructArray<FVehicleGearData>((FScriptArray)Marshal.PtrToStructure(new IntPtr(p)+16, typeof(FScriptArray)));}}}
						set{ unsafe { fixed (void* p = &this) { Marshal.StructureToPtr(value.InterArray, new IntPtr(p)+16, false);}}}
			
		}
		/// <summary>Reverse gear ratio</summary>
		[FieldOffset(32)]
		public float ReverseGearRatio;
		/// <summary>Value of engineRevs/maxEngineRevs that is high enough to increment gear</summary>
		[FieldOffset(36)]
		public float NeutralGearUpRatio;
		/// <summary>Strength of clutch (Kgm^2/s)</summary>
		[FieldOffset(40)]
		public float ClutchStrength;
		
	}
	
}
#endif
#endif
