using System;
namespace UnrealEngine
{
	public partial class UMaterialExpression:UObject
	{
		public int MaterialExpressionEditorX;
		
		public int MaterialExpressionEditorY;
		
		/// <summary>Expression's Graph representation</summary>
		public UEdGraphNode GraphNode;
		
		/// <summary>GUID to uniquely identify this node, to help the tutorials out</summary>
		public FGuid MaterialExpressionGuid;
		
		/// <summary>
		/// The material that this expression is currently being compiled in.
		/// This is not necessarily the object which owns this expression, for example a preview material compiling a material function's expressions.
		/// </summary>
		public UMaterial Material;
		
		/// <summary>
		/// The material function that this expression is being used with, if any.
		/// This will be NULL if the expression belongs to a function that is currently being edited,
		/// </summary>
		public UMaterialFunction Function;
		
		/// <summary>A description that level designers can add (shows in the material editor UI).</summary>
		public FString Desc;
		
		/// <summary>Color of the expression's border outline.</summary>
		public FColor BorderColor;
		
		/// <summary>Set to true by RecursiveUpdateRealtimePreview() if the expression's preview needs to be updated in realtime in the material editor.</summary>
		public bool bRealtimePreview;
		
		/// <summary>If true, we should update the preview next render. This is set when changing bRealtimePreview.</summary>
		public bool bNeedToUpdatePreview;
		
		/// <summary>Indicates that this is a 'parameter' type of expression and should always be loaded (ie not cooked away) because we might want the default parameter.</summary>
		public bool bIsParameterExpression;
		
		/// <summary>If true, the comment bubble will be visible in the graph editor</summary>
		public bool bCommentBubbleVisible;
		
		/// <summary>If true, use the output name as the label for the pin</summary>
		public bool bShowOutputNameOnPin;
		
		/// <summary>If true, do not render the preview window for the expression</summary>
		public bool bHidePreviewWindow;
		
		/// <summary>If true, show a collapsed version of the node</summary>
		public bool bCollapsed;
		
		/// <summary>Whether the node represents an input to the shader or not.  Used to color the node's background.</summary>
		public bool bShaderInputData;
		
		/// <summary>Whether to draw the expression's inputs.</summary>
		public bool bShowInputs;
		
		/// <summary>Whether to draw the expression's outputs.</summary>
		public bool bShowOutputs;
		
		
	}
	
}
