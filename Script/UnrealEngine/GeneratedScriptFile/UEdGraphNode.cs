using System;
namespace UnrealEngine
{
	public partial class UEdGraphNode:UObject
	{
		/// <summary>X position of node in the editor</summary>
		public int NodePosX;
		
		/// <summary>Y position of node in the editor</summary>
		public int NodePosY;
		
		/// <summary>Width of node in the editor; only used when the node can be resized</summary>
		public int NodeWidth;
		
		/// <summary>Height of node in the editor; only used when the node can be resized</summary>
		public int NodeHeight;
		
		/// <summary>If true, this node can be resized and should be drawn with a resize handle</summary>
		public bool bCanResizeNode;
		
		/// <summary>Flag to check for compile error/warning</summary>
		public bool bHasCompilerMessage;
		
		/// <summary>If true, this node can be renamed in the editor</summary>
		public bool bCanRenameNode;
		
		/// <summary>Note for a node that lingers until saved</summary>
		public FText NodeUpgradeMessage;
		
		/// <summary>Comment string that is drawn on the node</summary>
		public FString NodeComment;
		
		/// <summary>Comment bubble pinned state</summary>
		public bool bCommentBubblePinned;
		
		/// <summary>Comment bubble visibility</summary>
		public bool bCommentBubbleVisible;
		
		/// <summary>Flag to store node specific compile error/warning</summary>
		public int ErrorType;
		
		/// <summary>Error/Warning description</summary>
		public FString ErrorMsg;
		
		/// <summary>GUID to uniquely identify this node, to facilitate diffing versions of this graph</summary>
		public FGuid NodeGuid;
		
		/// <summary>Enum to indicate if a node has advanced-display-pins, and if they are shown</summary>
		public ENodeAdvancedPins AdvancedPinDisplay;
		
		/// <summary>Indicates whether or not the user explicitly set the enabled state</summary>
		public bool bUserSetEnabledState;
		
		/// <summary>(DEPRECATED) FALSE if the node is a disabled, which eliminates it from being compiled</summary>
		public bool bIsNodeEnabled;
		
		
	}
	
}
