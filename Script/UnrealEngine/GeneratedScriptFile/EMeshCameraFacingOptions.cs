using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public enum EMeshCameraFacingOptions:byte
	{
		XAxisFacing_NoUp=0,
		XAxisFacing_ZUp=1,
		XAxisFacing_NegativeZUp=2,
		XAxisFacing_YUp=3,
		XAxisFacing_NegativeYUp=4,
		LockedAxis_ZAxisFacing=5,
		LockedAxis_NegativeZAxisFacing=6,
		LockedAxis_YAxisFacing=7,
		LockedAxis_NegativeYAxisFacing=8,
		VelocityAligned_ZAxisFacing=9,
		VelocityAligned_NegativeZAxisFacing=10,
		VelocityAligned_YAxisFacing=11,
		VelocityAligned_NegativeYAxisFacing=12,
		AX=13,
		
	}
	
}
