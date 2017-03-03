#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class UMaterialExpression
	{
		static readonly int MaterialExpressionEditorX__Offset;
		public int MaterialExpressionEditorX
		{
			get{ CheckIsValid();return (int)Marshal.PtrToStructure(_this.Get()+MaterialExpressionEditorX__Offset, typeof(int));}
			
		}
		
		static readonly int MaterialExpressionEditorY__Offset;
		public int MaterialExpressionEditorY
		{
			get{ CheckIsValid();return (int)Marshal.PtrToStructure(_this.Get()+MaterialExpressionEditorY__Offset, typeof(int));}
			
		}
		
		static readonly int GraphNode__Offset;
		/// <summary>Expression's Graph representation</summary>
		public UEdGraphNode GraphNode
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + GraphNode__Offset); if (v == IntPtr.Zero)return null; UEdGraphNode retValue = new UEdGraphNode(); retValue._this = v; return retValue; }
			
		}
		
		static readonly int MaterialExpressionGuid__Offset;
		/// <summary>GUID to uniquely identify this node, to help the tutorials out</summary>
		public FGuid MaterialExpressionGuid
		{
			get{ CheckIsValid();return (FGuid)Marshal.PtrToStructure(_this.Get()+MaterialExpressionGuid__Offset, typeof(FGuid));}
			
		}
		
		static readonly int Material__Offset;
		/// <summary>
		/// The material that this expression is currently being compiled in.
		/// This is not necessarily the object which owns this expression, for example a preview material compiling a material function's expressions.
		/// </summary>
		public UMaterial Material
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + Material__Offset); if (v == IntPtr.Zero)return null; UMaterial retValue = new UMaterial(); retValue._this = v; return retValue; }
			
		}
		
		static readonly int Function__Offset;
		/// <summary>
		/// The material function that this expression is being used with, if any.
		/// This will be NULL if the expression belongs to a function that is currently being edited,
		/// </summary>
		public UMaterialFunction Function
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + Function__Offset); if (v == IntPtr.Zero)return null; UMaterialFunction retValue = new UMaterialFunction(); retValue._this = v; return retValue; }
			
		}
		
		static readonly int Desc__Offset;
		/// <summary>A description that level designers can add (shows in the material editor UI).</summary>
		public FString Desc
		{
			get{ CheckIsValid();return (FString)Marshal.PtrToStructure(_this.Get()+Desc__Offset, typeof(FString));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+Desc__Offset, false);}
			
		}
		
		static readonly int BorderColor__Offset;
		/// <summary>Color of the expression's border outline.</summary>
		public FColor BorderColor
		{
			get{ CheckIsValid();return (FColor)Marshal.PtrToStructure(_this.Get()+BorderColor__Offset, typeof(FColor));}
			
		}
		
		static readonly int bRealtimePreview__Offset;
		/// <summary>Set to true by RecursiveUpdateRealtimePreview() if the expression's preview needs to be updated in realtime in the material editor.</summary>
		public bool bRealtimePreview
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bRealtimePreview__Offset, 1, 0, 1, 1);}
			
		}
		
		static readonly int bNeedToUpdatePreview__Offset;
		/// <summary>If true, we should update the preview next render. This is set when changing bRealtimePreview.</summary>
		public bool bNeedToUpdatePreview
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bNeedToUpdatePreview__Offset, 1, 0, 2, 2);}
			
		}
		
		static readonly int bIsParameterExpression__Offset;
		/// <summary>Indicates that this is a 'parameter' type of expression and should always be loaded (ie not cooked away) because we might want the default parameter.</summary>
		public bool bIsParameterExpression
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bIsParameterExpression__Offset, 1, 0, 4, 4);}
			
		}
		
		static readonly int bCommentBubbleVisible__Offset;
		/// <summary>If true, the comment bubble will be visible in the graph editor</summary>
		public bool bCommentBubbleVisible
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bCommentBubbleVisible__Offset, 1, 0, 8, 8);}
			
		}
		
		static readonly int bShowOutputNameOnPin__Offset;
		/// <summary>If true, use the output name as the label for the pin</summary>
		public bool bShowOutputNameOnPin
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bShowOutputNameOnPin__Offset, 1, 0, 16, 16);}
			
		}
		
		static readonly int bHidePreviewWindow__Offset;
		/// <summary>If true, do not render the preview window for the expression</summary>
		public bool bHidePreviewWindow
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bHidePreviewWindow__Offset, 1, 0, 32, 32);}
			
		}
		
		static readonly int bCollapsed__Offset;
		/// <summary>If true, show a collapsed version of the node</summary>
		public bool bCollapsed
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bCollapsed__Offset, 1, 0, 64, 64);}
			
		}
		
		static readonly int bShaderInputData__Offset;
		/// <summary>Whether the node represents an input to the shader or not.  Used to color the node's background.</summary>
		public bool bShaderInputData
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bShaderInputData__Offset, 1, 0, 128, 128);}
			
		}
		
		static readonly int bShowInputs__Offset;
		/// <summary>Whether to draw the expression's inputs.</summary>
		public bool bShowInputs
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bShowInputs__Offset, 1, 0, 1, 1);}
			
		}
		
		static readonly int bShowOutputs__Offset;
		/// <summary>Whether to draw the expression's outputs.</summary>
		public bool bShowOutputs
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bShowOutputs__Offset, 1, 0, 2, 2);}
			
		}
		
		static readonly int MenuCategories__Offset;
		/// <summary>Localized categories to sort this expression into...</summary>
		public TStructArray<FText> MenuCategories
		{
			get{ CheckIsValid();return new TStructArray<FText>((FScriptArray)Marshal.PtrToStructure(_this.Get()+MenuCategories__Offset, typeof(FScriptArray)));}
					set{ CheckIsValid();Marshal.StructureToPtr(value.InterArray, _this.Get()+MenuCategories__Offset, false);}
			
		}
		
		static readonly int Outputs__Offset;
		/// <summary>The expression's outputs, which are set in default properties by derived classes.</summary>
		public TStructArray<FExpressionOutput> Outputs
		{
			get{ CheckIsValid();return new TStructArray<FExpressionOutput>((FScriptArray)Marshal.PtrToStructure(_this.Get()+Outputs__Offset, typeof(FScriptArray)));}
					set{ CheckIsValid();Marshal.StructureToPtr(value.InterArray, _this.Get()+Outputs__Offset, false);}
			
		}
		
		static UMaterialExpression()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("MaterialExpression");
			MaterialExpressionEditorX__Offset=GetPropertyOffset(NativeClassPtr,"MaterialExpressionEditorX");
			MaterialExpressionEditorY__Offset=GetPropertyOffset(NativeClassPtr,"MaterialExpressionEditorY");
			GraphNode__Offset=GetPropertyOffset(NativeClassPtr,"GraphNode");
			MaterialExpressionGuid__Offset=GetPropertyOffset(NativeClassPtr,"MaterialExpressionGuid");
			Material__Offset=GetPropertyOffset(NativeClassPtr,"Material");
			Function__Offset=GetPropertyOffset(NativeClassPtr,"Function");
			Desc__Offset=GetPropertyOffset(NativeClassPtr,"Desc");
			BorderColor__Offset=GetPropertyOffset(NativeClassPtr,"BorderColor");
			bRealtimePreview__Offset=GetPropertyOffset(NativeClassPtr,"bRealtimePreview");
			bNeedToUpdatePreview__Offset=GetPropertyOffset(NativeClassPtr,"bNeedToUpdatePreview");
			bIsParameterExpression__Offset=GetPropertyOffset(NativeClassPtr,"bIsParameterExpression");
			bCommentBubbleVisible__Offset=GetPropertyOffset(NativeClassPtr,"bCommentBubbleVisible");
			bShowOutputNameOnPin__Offset=GetPropertyOffset(NativeClassPtr,"bShowOutputNameOnPin");
			bHidePreviewWindow__Offset=GetPropertyOffset(NativeClassPtr,"bHidePreviewWindow");
			bCollapsed__Offset=GetPropertyOffset(NativeClassPtr,"bCollapsed");
			bShaderInputData__Offset=GetPropertyOffset(NativeClassPtr,"bShaderInputData");
			bShowInputs__Offset=GetPropertyOffset(NativeClassPtr,"bShowInputs");
			bShowOutputs__Offset=GetPropertyOffset(NativeClassPtr,"bShowOutputs");
			MenuCategories__Offset=GetPropertyOffset(NativeClassPtr,"MenuCategories");
			Outputs__Offset=GetPropertyOffset(NativeClassPtr,"Outputs");
			
		}
		
	}
	
}
#endif
#endif
