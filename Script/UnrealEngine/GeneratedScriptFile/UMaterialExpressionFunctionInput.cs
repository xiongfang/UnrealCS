using System;
namespace UnrealEngine
{
	public partial class UMaterialExpressionFunctionInput:UMaterialExpression
	{
		/// <summary>Used for previewing when editing the function, or when bUsePreviewValueAsDefault is enabled.</summary>
		public FExpressionInput Preview;
		
		/// <summary>The input's name, which will be drawn on the connector in function call expressions that use this function.</summary>
		public FString InputName;
		
		/// <summary>The input's description, which will be used as a tooltip on the connector in function call expressions that use this function.</summary>
		public FString Description;
		
		/// <summary>Id of this input, used to maintain references through name changes.</summary>
		public FGuid Id;
		
		/// <summary>
		/// Type of this input.
		/// Input code chunks will be cast to this type, and a compiler error will be emitted if the cast fails.
		/// </summary>
		public EFunctionInputType InputType;
		
		/// <summary>Value used to preview this input when editing the material function.</summary>
		public FVector4 PreviewValue;
		
		/// <summary>Whether to use the preview value or texture as the default value for this input.</summary>
		public bool bUsePreviewValueAsDefault;
		
		/// <summary>Controls where the input is displayed relative to the other inputs.</summary>
		public int SortPriority;
		
		/// <summary>
		/// true when this expression is being compiled in a function preview,
		/// false when this expression is being compiled into a material that uses the function.
		/// Only valid in Compile()
		/// </summary>
		public bool bCompilingFunctionPreview;
		
		
	}
	
}
