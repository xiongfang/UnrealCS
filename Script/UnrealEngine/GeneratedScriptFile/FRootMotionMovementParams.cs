using System;
namespace UnrealEngine
{
	/// <summary>Utility struct to accumulate root motion.</summary>
	public partial struct FRootMotionMovementParams
	{
		public bool bHasRootMotion;
		public float BlendWeight;
		public FTransform RootMotionTransform;
		
	}
	
}
