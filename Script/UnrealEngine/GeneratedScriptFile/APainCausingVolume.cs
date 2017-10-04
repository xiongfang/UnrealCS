using System;
namespace UnrealEngine
{
	public partial class APainCausingVolume:APhysicsVolume
	{
		/// <summary>Whether volume currently causes damage.</summary>
		public bool bPainCausing;
		
		/// <summary>Damage done per second to actors in this volume when bPainCausing=true</summary>
		public float DamagePerSec;
		
		/// <summary>Type of damage done</summary>
		public TSubclassOf<UDamageType>  DamageType;
		
		/// <summary>If pain causing, time between damage applications.</summary>
		public float PainInterval;
		
		/// <summary>if bPainCausing, cause pain when something enters the volume in addition to damage each second</summary>
		public bool bEntryPain;
		
		/// <summary>Checkpointed bPainCausing value</summary>
		public bool BACKUP_bPainCausing;
		
		/// <summary>Controller that gets credit for any damage caused by this volume</summary>
		public AController DamageInstigator;
		
		
	}
	
}
