using System;
namespace UnrealEngine
{
	/// <summary>An intermediary to make UBaseSound available for Slate to play sounds</summary>
	public partial struct FSlateSound
	{
		/// <summary>
		/// Pointer to the USoundBase. Holding onto it as a UObject because USoundBase is not available in Slate core.
		/// Edited via FSlateSoundStructCustomization to ensure you can only set USoundBase assets on it.
		/// </summary>
		public UObject ResourceObject;
		
	}
	
}
