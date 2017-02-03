#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>Rigid body error correction data</summary>
	[StructLayout(LayoutKind.Explicit,Size=28)]
	public partial struct FRigidBodyErrorCorrection
	{
		/// <summary>max squared position difference to perform velocity adjustment</summary>
		[FieldOffset(0)]
		public float LinearDeltaThresholdSq;
		/// <summary>strength of snapping to desired linear velocity</summary>
		[FieldOffset(4)]
		public float LinearInterpAlpha;
		/// <summary>inverted duration after which linear velocity adjustment will fix error</summary>
		[FieldOffset(8)]
		public float LinearRecipFixTime;
		/// <summary>max squared angle difference (in radians) to perform velocity adjustment</summary>
		[FieldOffset(12)]
		public float AngularDeltaThreshold;
		/// <summary>strength of snapping to desired angular velocity</summary>
		[FieldOffset(16)]
		public float AngularInterpAlpha;
		/// <summary>inverted duration after which angular velocity adjustment will fix error</summary>
		[FieldOffset(20)]
		public float AngularRecipFixTime;
		/// <summary>min squared body speed to perform velocity adjustment</summary>
		[FieldOffset(24)]
		public float BodySpeedThresholdSq;
		
	}
	
}
#endif
#endif
