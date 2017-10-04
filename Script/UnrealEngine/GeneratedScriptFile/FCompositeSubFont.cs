using System;
namespace UnrealEngine
{
	public partial struct FCompositeSubFont
	{
		/// <summary>Typeface data for this sub-font</summary>
		public FTypeface Typeface;
		/// <summary>Amount to scale this sub-font so that it better matches the size of the default font</summary>
		public float ScalingFactor;
		/// <summary>Name of this sub-font. Only used by the editor UI as a convenience to let you state the purpose of the font family.</summary>
		public FName EditorName;
		
	}
	
}
