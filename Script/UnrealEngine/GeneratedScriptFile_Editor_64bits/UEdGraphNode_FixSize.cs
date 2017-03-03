#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class UEdGraphNode
	{
		static readonly int DeprecatedPins__Offset;
		/// <summary>List of connector pins</summary>
		public TObjectArray<UEdGraphPin_Deprecated>  DeprecatedPins
		{
					get{ CheckIsValid();return new TObjectArray<UEdGraphPin_Deprecated>((FScriptArray)Marshal.PtrToStructure(_this.Get()+DeprecatedPins__Offset, typeof(FScriptArray)));}
					set{ CheckIsValid();Marshal.StructureToPtr(value.InterArray, _this.Get()+DeprecatedPins__Offset, false);}
			
		}
		
		static readonly int NodePosX__Offset;
		/// <summary>X position of node in the editor</summary>
		public int NodePosX
		{
			get{ CheckIsValid();return (int)Marshal.PtrToStructure(_this.Get()+NodePosX__Offset, typeof(int));}
			
		}
		
		static readonly int NodePosY__Offset;
		/// <summary>Y position of node in the editor</summary>
		public int NodePosY
		{
			get{ CheckIsValid();return (int)Marshal.PtrToStructure(_this.Get()+NodePosY__Offset, typeof(int));}
			
		}
		
		static readonly int NodeWidth__Offset;
		/// <summary>Width of node in the editor; only used when the node can be resized</summary>
		public int NodeWidth
		{
			get{ CheckIsValid();return (int)Marshal.PtrToStructure(_this.Get()+NodeWidth__Offset, typeof(int));}
			
		}
		
		static readonly int NodeHeight__Offset;
		/// <summary>Height of node in the editor; only used when the node can be resized</summary>
		public int NodeHeight
		{
			get{ CheckIsValid();return (int)Marshal.PtrToStructure(_this.Get()+NodeHeight__Offset, typeof(int));}
			
		}
		
		static readonly int bCanResizeNode__Offset;
		/// <summary>If true, this node can be resized and should be drawn with a resize handle</summary>
		public bool bCanResizeNode
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bCanResizeNode__Offset, 1, 0, 1, 1);}
			
		}
		
		static readonly int bHasCompilerMessage__Offset;
		/// <summary>Flag to check for compile error/warning</summary>
		public bool bHasCompilerMessage
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bHasCompilerMessage__Offset, 1, 0, 2, 2);}
			
		}
		
		static readonly int bCanRenameNode__Offset;
		/// <summary>If true, this node can be renamed in the editor</summary>
		public bool bCanRenameNode
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bCanRenameNode__Offset, 1, 0, 4, 4);}
			
		}
		
		static readonly int NodeUpgradeMessage__Offset;
		/// <summary>Note for a node that lingers until saved</summary>
		public string NodeUpgradeMessage
		{
			get{ CheckIsValid(); return ((FText)Marshal.PtrToStructure(_this.Get()+NodeUpgradeMessage__Offset, typeof(FText))).ToString();}
			
		}
		
		static readonly int NodeComment__Offset;
		/// <summary>Comment string that is drawn on the node</summary>
		public FString NodeComment
		{
			get{ CheckIsValid();return (FString)Marshal.PtrToStructure(_this.Get()+NodeComment__Offset, typeof(FString));}
			
		}
		
		static readonly int bCommentBubblePinned__Offset;
		/// <summary>Comment bubble pinned state</summary>
		public bool bCommentBubblePinned
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bCommentBubblePinned__Offset, 1, 0, 1, 255);}
			
		}
		
		static readonly int bCommentBubbleVisible__Offset;
		/// <summary>Comment bubble visibility</summary>
		public bool bCommentBubbleVisible
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bCommentBubbleVisible__Offset, 1, 0, 1, 255);}
			
		}
		
		static readonly int ErrorType__Offset;
		/// <summary>Flag to store node specific compile error/warning</summary>
		public int ErrorType
		{
			get{ CheckIsValid();return (int)Marshal.PtrToStructure(_this.Get()+ErrorType__Offset, typeof(int));}
			
		}
		
		static readonly int ErrorMsg__Offset;
		/// <summary>Error/Warning description</summary>
		public FString ErrorMsg
		{
			get{ CheckIsValid();return (FString)Marshal.PtrToStructure(_this.Get()+ErrorMsg__Offset, typeof(FString));}
			
		}
		
		static readonly int NodeGuid__Offset;
		/// <summary>GUID to uniquely identify this node, to facilitate diffing versions of this graph</summary>
		public FGuid NodeGuid
		{
			get{ CheckIsValid();return (FGuid)Marshal.PtrToStructure(_this.Get()+NodeGuid__Offset, typeof(FGuid));}
			
		}
		
		static readonly int AdvancedPinDisplay__Offset;
		/// <summary>Enum to indicate if a node has advanced-display-pins, and if they are shown</summary>
		public ENodeAdvancedPins AdvancedPinDisplay
		{
			get{ CheckIsValid();return (ENodeAdvancedPins)Marshal.PtrToStructure(_this.Get()+AdvancedPinDisplay__Offset, typeof(ENodeAdvancedPins));}
			
		}
		
		static readonly int bUserSetEnabledState__Offset;
		/// <summary>Indicates whether or not the user explicitly set the enabled state</summary>
		public bool bUserSetEnabledState
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bUserSetEnabledState__Offset, 1, 0, 1, 255);}
			
		}
		
		static readonly int bIsNodeEnabled__Offset;
		/// <summary>(DEPRECATED) FALSE if the node is a disabled, which eliminates it from being compiled</summary>
		public bool bIsNodeEnabled
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bIsNodeEnabled__Offset, 1, 0, 1, 255);}
			
		}
		
		static UEdGraphNode()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("EdGraphNode");
			DeprecatedPins__Offset=GetPropertyOffset(NativeClassPtr,"DeprecatedPins");
			NodePosX__Offset=GetPropertyOffset(NativeClassPtr,"NodePosX");
			NodePosY__Offset=GetPropertyOffset(NativeClassPtr,"NodePosY");
			NodeWidth__Offset=GetPropertyOffset(NativeClassPtr,"NodeWidth");
			NodeHeight__Offset=GetPropertyOffset(NativeClassPtr,"NodeHeight");
			bCanResizeNode__Offset=GetPropertyOffset(NativeClassPtr,"bCanResizeNode");
			bHasCompilerMessage__Offset=GetPropertyOffset(NativeClassPtr,"bHasCompilerMessage");
			bCanRenameNode__Offset=GetPropertyOffset(NativeClassPtr,"bCanRenameNode");
			NodeUpgradeMessage__Offset=GetPropertyOffset(NativeClassPtr,"NodeUpgradeMessage");
			NodeComment__Offset=GetPropertyOffset(NativeClassPtr,"NodeComment");
			bCommentBubblePinned__Offset=GetPropertyOffset(NativeClassPtr,"bCommentBubblePinned");
			bCommentBubbleVisible__Offset=GetPropertyOffset(NativeClassPtr,"bCommentBubbleVisible");
			ErrorType__Offset=GetPropertyOffset(NativeClassPtr,"ErrorType");
			ErrorMsg__Offset=GetPropertyOffset(NativeClassPtr,"ErrorMsg");
			NodeGuid__Offset=GetPropertyOffset(NativeClassPtr,"NodeGuid");
			AdvancedPinDisplay__Offset=GetPropertyOffset(NativeClassPtr,"AdvancedPinDisplay");
			bUserSetEnabledState__Offset=GetPropertyOffset(NativeClassPtr,"bUserSetEnabledState");
			bIsNodeEnabled__Offset=GetPropertyOffset(NativeClassPtr,"bIsNodeEnabled");
			
		}
		
	}
	
}
#endif
#endif
