#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>Vehicle-specific wheel setup</summary>
	[StructLayout(LayoutKind.Explicit,Size=32)]
	public partial struct FWheelSetup
	{
		/// <summary>The wheel class to use</summary>
		/// <summary>Bone name on mesh to create wheel at</summary>
		[FieldOffset(8)]
		public FName BoneName;
		/// <summary>Additional offset to give the wheels for this axle.</summary>
		[FieldOffset(20)]
		public FVector AdditionalOffset;
		
	}
	
}
#endif
#endif
