#if WITH_GAME
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class UMaterialExpression
	{
		static readonly int Material__Offset;
		public UMaterial Material
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + Material__Offset); if (v == IntPtr.Zero)return null; UMaterial retValue = new UMaterial(); retValue._this = v; return retValue; }
			
		}
		
		static readonly int Function__Offset;
		public UMaterialFunction Function
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + Function__Offset); if (v == IntPtr.Zero)return null; UMaterialFunction retValue = new UMaterialFunction(); retValue._this = v; return retValue; }
			
		}
		
		static readonly int Desc__Offset;
		public FString Desc
		{
			get{ CheckIsValid();return (FString)Marshal.PtrToStructure(_this.Get()+Desc__Offset, typeof(FString));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+Desc__Offset, false);}
			
		}
		
		static readonly int BorderColor__Offset;
		public FColor BorderColor
		{
			get{ CheckIsValid();return (FColor)Marshal.PtrToStructure(_this.Get()+BorderColor__Offset, typeof(FColor));}
			
		}
		
		static readonly int bRealtimePreview__Offset;
		public bool bRealtimePreview
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bRealtimePreview__Offset, 1, 0, 1, 1);}
			
		}
		
		static readonly int bNeedToUpdatePreview__Offset;
		public bool bNeedToUpdatePreview
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bNeedToUpdatePreview__Offset, 1, 0, 2, 2);}
			
		}
		
		static readonly int bIsParameterExpression__Offset;
		public bool bIsParameterExpression
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bIsParameterExpression__Offset, 1, 0, 4, 4);}
			
		}
		
		static readonly int bCommentBubbleVisible__Offset;
		public bool bCommentBubbleVisible
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bCommentBubbleVisible__Offset, 1, 0, 8, 8);}
			
		}
		
		static readonly int bShowOutputNameOnPin__Offset;
		public bool bShowOutputNameOnPin
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bShowOutputNameOnPin__Offset, 1, 0, 16, 16);}
			
		}
		
		static readonly int bHidePreviewWindow__Offset;
		public bool bHidePreviewWindow
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bHidePreviewWindow__Offset, 1, 0, 32, 32);}
			
		}
		
		static readonly int bCollapsed__Offset;
		public bool bCollapsed
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bCollapsed__Offset, 1, 0, 64, 64);}
			
		}
		
		static readonly int bShaderInputData__Offset;
		public bool bShaderInputData
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bShaderInputData__Offset, 1, 0, 128, 128);}
			
		}
		
		static readonly int bShowInputs__Offset;
		public bool bShowInputs
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bShowInputs__Offset, 1, 0, 1, 1);}
			
		}
		
		static readonly int bShowOutputs__Offset;
		public bool bShowOutputs
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bShowOutputs__Offset, 1, 0, 2, 2);}
			
		}
		
		static readonly int Outputs__Offset;
		public TStructArray<FExpressionOutput> Outputs
		{
			get{ CheckIsValid();return new TStructArray<FExpressionOutput>((FScriptArray)Marshal.PtrToStructure(_this.Get()+Outputs__Offset, typeof(FScriptArray)));}
					set{ CheckIsValid();Marshal.StructureToPtr(value.InterArray, _this.Get()+Outputs__Offset, false);}
			
		}
		
		static UMaterialExpression()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("MaterialExpression");
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
			Outputs__Offset=GetPropertyOffset(NativeClassPtr,"Outputs");
			
		}
		
	}
	
}
#endif
#endif
