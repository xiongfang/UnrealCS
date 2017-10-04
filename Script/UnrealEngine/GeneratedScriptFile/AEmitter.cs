using System;
namespace UnrealEngine
{
	public partial class AEmitter:AActor
	{
		/// <summary>Replication Notification Callbacks</summary>
		public extern virtual void OnRep_bCurrentlyActive();
		public extern virtual void OnParticleSystemFinished(UParticleSystemComponent FinishedComponent);
		public UParticleSystemComponent ParticleSystemComponent;
		
		public bool bDestroyOnSystemFinish;
		
		public bool bPostUpdateTickGroup;
		
		/// <summary>used to update status of toggleable level placed emitters on clients</summary>
		public bool bCurrentlyActive;
		
		public UBillboardComponent SpriteComponent;
		
		public UArrowComponent ArrowComponent;
		
		
	}
	
}
