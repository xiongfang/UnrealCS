using System;
namespace UnrealEngine
{
	public partial struct FBlendParameter
	{
		public FString DisplayName;
		/// <summary>Min value for this parameter.</summary>
		public float Min;
		/// <summary>Max value for this parameter.</summary>
		public float Max;
		/// <summary>The number of grid divisions for this parameter (axis).</summary>
		public int GridNum;
		
	}
	
}
