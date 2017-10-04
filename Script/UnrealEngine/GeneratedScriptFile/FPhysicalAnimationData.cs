using System;
namespace UnrealEngine
{
	/// <summary>Stores info on the type of motor that will be used for a given bone</summary>
	public partial struct FPhysicalAnimationData
	{
		/// <summary>The body we will be driving. We specifically hide this from users since they provide the body name and bodies below in the component API.</summary>
		public FName BodyName;
		/// <summary>Whether the drive targets are in world space or local</summary>
		public bool bIsLocalSimulation;
		/// <summary>The strength used to correct orientation error</summary>
		public float OrientationStrength;
		/// <summary>The strength used to correct angular velocity error</summary>
		public float AngularVelocityStrength;
		/// <summary>The strength used to correct linear position error. Only used for non-local simulation</summary>
		public float PositionStrength;
		/// <summary>The strength used to correct linear velocity error. Only used for non-local simulation</summary>
		public float VelocityStrength;
		/// <summary>The max force used to correct linear errors</summary>
		public float MaxLinearForce;
		/// <summary>The max force used to correct angular errors</summary>
		public float MaxAngularForce;
		
	}
	
}
