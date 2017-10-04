using System;
namespace UnrealEngine
{
	/// <summary>This represents a baked transition</summary>
	public partial struct FAnimationTransitionBetweenStates
	{
		/// <summary>Transition-only: State being transitioned from</summary>
		public int PreviousState;
		/// <summary>Transition-only: State being transitioned to</summary>
		public int NextState;
		public float CrossfadeDuration;
		public int StartNotify;
		public int EndNotify;
		public int InterruptNotify;
		public UCurveFloat CustomCurve;
		public UBlendProfile BlendProfile;
		public ETransitionLogicType LogicType;
		/// <summary>The name of this state</summary>
		public FName StateName;
		
	}
	
}
