using System;
namespace UnrealEngine
{
	/// <summary>Rigid body error correction data</summary>
	public partial struct FRigidBodyErrorCorrection
	{
		/// <summary>max squared position difference to perform velocity adjustment</summary>
		public float LinearDeltaThresholdSq;
		/// <summary>strength of snapping to desired linear velocity</summary>
		public float LinearInterpAlpha;
		/// <summary>inverted duration after which linear velocity adjustment will fix error</summary>
		public float LinearRecipFixTime;
		/// <summary>max squared angle difference (in radians) to perform velocity adjustment</summary>
		public float AngularDeltaThreshold;
		/// <summary>strength of snapping to desired angular velocity</summary>
		public float AngularInterpAlpha;
		/// <summary>inverted duration after which angular velocity adjustment will fix error</summary>
		public float AngularRecipFixTime;
		/// <summary>min squared body speed to perform velocity adjustment</summary>
		public float BodySpeedThresholdSq;
		
	}
	
}
