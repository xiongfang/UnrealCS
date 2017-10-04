using System;
namespace UnrealEngine
{
	public partial struct FParticleEvent_GenerateInfo
	{
		/// <summary>The type of event.</summary>
		public EParticleEventType Type;
		/// <summary>How often to trigger the event (<= 1 means EVERY time).</summary>
		public int Frequency;
		/// <summary>Only fire the first time (collision only).</summary>
		public int ParticleFrequency;
		/// <summary>Only fire the first time (collision only).</summary>
		public bool FirstTimeOnly;
		/// <summary>Only fire the last time (collision only).</summary>
		public bool LastTimeOnly;
		/// <summary>Use the impact FVector not the hit normal (collision only).</summary>
		public bool UseReflectedImpactVector;
		/// <summary>Use the orbit offset when computing the position at which the event occurred.</summary>
		public bool bUseOrbitOffset;
		/// <summary>Should the event tag with a custom name? Leave blank for the default.</summary>
		public FName CustomName;
		
	}
	
}
