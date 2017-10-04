using System;
namespace UnrealEngine
{
	public partial class UMaterialExpressionScalarParameter:UMaterialExpressionParameter
	{
		public float DefaultValue;
		
		/// <summary>Sets the lower bound for the slider on this parameter in the material instance editor.</summary>
		public float SliderMin;
		
		/// <summary>
		/// Sets the upper bound for the slider on this parameter in the material instance editor.
		/// The slider will be disabled if SliderMax <= SliderMin.
		/// </summary>
		public float SliderMax;
		
		
	}
	
}
