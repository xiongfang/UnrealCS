using System;
namespace UnrealEngine
{
	public partial class ACameraActor:AActor
	{
		/// <summary>Returns index of the player for whom we auto-activate, or INDEX_NONE (-1) if disabled.</summary>
		public extern int GetAutoActivatePlayerIndex();
		/// <summary>Specifies which player controller, if any, should automatically use this Camera when the controller is active.</summary>
		public EAutoReceiveInput AutoActivateForPlayer;
		
		public UCameraComponent CameraComponent;
		
		public USceneComponent SceneComponent;
		
		public bool bConstrainAspectRatio;
		
		public float AspectRatio;
		
		public float FOVAngle;
		
		public float PostProcessBlendWeight;
		
		public FPostProcessSettings PostProcessSettings;
		
		
	}
	
}
