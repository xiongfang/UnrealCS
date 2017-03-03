#if WITH_GAME
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class UEdGraphNode
	{
		static readonly int DeprecatedPins__Offset;
		public TObjectArray<UEdGraphPin_Deprecated>  DeprecatedPins
		{
					get{ CheckIsValid();return new TObjectArray<UEdGraphPin_Deprecated>((FScriptArray)Marshal.PtrToStructure(_this.Get()+DeprecatedPins__Offset, typeof(FScriptArray)));}
					set{ CheckIsValid();Marshal.StructureToPtr(value.InterArray, _this.Get()+DeprecatedPins__Offset, false);}
			
		}
		
		static readonly int NodePosX__Offset;
		public int NodePosX
		{
			get{ CheckIsValid();return (int)Marshal.PtrToStructure(_this.Get()+NodePosX__Offset, typeof(int));}
			
		}
		
		static readonly int NodePosY__Offset;
		public int NodePosY
		{
			get{ CheckIsValid();return (int)Marshal.PtrToStructure(_this.Get()+NodePosY__Offset, typeof(int));}
			
		}
		
		static readonly int NodeWidth__Offset;
		public int NodeWidth
		{
			get{ CheckIsValid();return (int)Marshal.PtrToStructure(_this.Get()+NodeWidth__Offset, typeof(int));}
			
		}
		
		static readonly int NodeHeight__Offset;
		public int NodeHeight
		{
			get{ CheckIsValid();return (int)Marshal.PtrToStructure(_this.Get()+NodeHeight__Offset, typeof(int));}
			
		}
		
		static readonly int bHasCompilerMessage__Offset;
		public bool bHasCompilerMessage
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bHasCompilerMessage__Offset, 1, 0, 1, 1);}
			
		}
		
		static readonly int NodeComment__Offset;
		public FString NodeComment
		{
			get{ CheckIsValid();return (FString)Marshal.PtrToStructure(_this.Get()+NodeComment__Offset, typeof(FString));}
			
		}
		
		static readonly int bCommentBubblePinned__Offset;
		public bool bCommentBubblePinned
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bCommentBubblePinned__Offset, 1, 0, 1, 255);}
			
		}
		
		static readonly int bCommentBubbleVisible__Offset;
		public bool bCommentBubbleVisible
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bCommentBubbleVisible__Offset, 1, 0, 1, 255);}
			
		}
		
		static readonly int ErrorType__Offset;
		public int ErrorType
		{
			get{ CheckIsValid();return (int)Marshal.PtrToStructure(_this.Get()+ErrorType__Offset, typeof(int));}
			
		}
		
		static readonly int ErrorMsg__Offset;
		public FString ErrorMsg
		{
			get{ CheckIsValid();return (FString)Marshal.PtrToStructure(_this.Get()+ErrorMsg__Offset, typeof(FString));}
			
		}
		
		static readonly int NodeGuid__Offset;
		public FGuid NodeGuid
		{
			get{ CheckIsValid();return (FGuid)Marshal.PtrToStructure(_this.Get()+NodeGuid__Offset, typeof(FGuid));}
			
		}
		
		static readonly int AdvancedPinDisplay__Offset;
		public ENodeAdvancedPins AdvancedPinDisplay
		{
			get{ CheckIsValid();return (ENodeAdvancedPins)Marshal.PtrToStructure(_this.Get()+AdvancedPinDisplay__Offset, typeof(ENodeAdvancedPins));}
			
		}
		
		static readonly int bUserSetEnabledState__Offset;
		public bool bUserSetEnabledState
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bUserSetEnabledState__Offset, 1, 0, 1, 255);}
			
		}
		
		static readonly int bIsNodeEnabled__Offset;
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
			bHasCompilerMessage__Offset=GetPropertyOffset(NativeClassPtr,"bHasCompilerMessage");
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
