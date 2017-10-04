using System;
namespace UnrealEngine
{
	public partial class AAudioVolume:AVolume
	{
		public extern void SetInteriorSettings(FInteriorSettings NewInteriorSettings);
		public extern void SetReverbSettings(FReverbSettings NewReverbSettings);
		public extern void SetEnabled(bool bNewEnabled);
		public extern void SetPriority(float NewPriority);
		/// <summary>
		/// Priority of this volume. In the case of overlapping volumes the one with the highest priority
		/// is chosen. The order is undefined if two or more overlapping volumes have the same priority.
		/// </summary>
		public float Priority;
		
		/// <summary>whether this volume is currently enabled and able to affect sounds</summary>
		public bool bEnabled;
		
		/// <summary>Reverb settings to use for this volume.</summary>
		public FReverbSettings Settings;
		
		/// <summary>Interior settings used for this volume</summary>
		public FInteriorSettings AmbientZoneSettings;
		
		
	}
	
}
