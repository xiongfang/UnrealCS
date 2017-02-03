#if WITH_GAME
#if PLATFORM_32BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	[StructLayout(LayoutKind.Explicit,Size=40)]
	public partial struct FVehicleTransmissionData
	{
		public bool bUseGearAutoBox
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 0, 1, 0, 1, 255); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 0, 1, 0, 1, 255); } }}
			
		}
		[FieldOffset(4)]
		public float GearSwitchTime;
		[FieldOffset(8)]
		public float GearAutoBoxLatency;
		[FieldOffset(12)]
		public float FinalRatio;
		public TStructArray<FVehicleGearData> ForwardGears
		{
						get{ unsafe { fixed (void* p = &this) { return new TStructArray<FVehicleGearData>((FScriptArray)Marshal.PtrToStructure(new IntPtr(p)+16, typeof(FScriptArray)));}}}
						set{ unsafe { fixed (void* p = &this) { Marshal.StructureToPtr(value.InterArray, new IntPtr(p)+16, false);}}}
			
		}
		[FieldOffset(28)]
		public float ReverseGearRatio;
		[FieldOffset(32)]
		public float NeutralGearUpRatio;
		[FieldOffset(36)]
		public float ClutchStrength;
		
	}
	
}
#endif
#endif
