using System;
namespace UnrealEngine
{
	public partial class UMaterialExpressionFunctionOutput:UMaterialExpression
	{
		/// <summary>The output's name, which will be drawn on the connector in function call expressions that use this function.</summary>
		public FString OutputName;
		
		/// <summary>The output's description, which will be used as a tooltip on the connector in function call expressions that use this function.</summary>
		public FString Description;
		
		/// <summary>Controls where the output is displayed relative to the other outputs.</summary>
		public int SortPriority;
		
		/// <summary>Stores the expression in the material function connected to this output.</summary>
		public FExpressionInput A;
		
		/// <summary>Whether this output was previewed the last time this function was edited.</summary>
		public bool bLastPreviewed;
		
		/// <summary>Id of this input, used to maintain references through name changes.</summary>
		public FGuid Id;
		
		
	}
	
}
