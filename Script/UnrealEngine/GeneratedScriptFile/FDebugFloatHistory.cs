using System;
namespace UnrealEngine
{
	/// <summary>Structure for recording float values and displaying them as an Histogram through DrawDebugFloatHistory.</summary>
	public partial struct FDebugFloatHistory
	{
		/// <summary>Max Samples to record.</summary>
		public float MaxSamples;
		/// <summary>Min value to record.</summary>
		public float MinValue;
		/// <summary>Max value to record.</summary>
		public float MaxValue;
		/// <summary>Auto adjust Min/Max as new values are recorded?</summary>
		public bool bAutoAdjustMinMax;
		
	}
	
}
