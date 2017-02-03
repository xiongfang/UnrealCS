#if WITH_GAME
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class UMaterialExpressionFunctionInput
	{
		static readonly int Preview__Offset;
		public FExpressionInput Preview
		{
			get{ CheckIsValid();return (FExpressionInput)Marshal.PtrToStructure(_this.Get()+Preview__Offset, typeof(FExpressionInput));}
			
		}
		
		static readonly int InputName__Offset;
		public FString InputName
		{
			get{ CheckIsValid();return (FString)Marshal.PtrToStructure(_this.Get()+InputName__Offset, typeof(FString));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+InputName__Offset, false);}
			
		}
		
		static readonly int Description__Offset;
		public FString Description
		{
			get{ CheckIsValid();return (FString)Marshal.PtrToStructure(_this.Get()+Description__Offset, typeof(FString));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+Description__Offset, false);}
			
		}
		
		static readonly int ID__Offset;
		public FGuid ID
		{
			get{ CheckIsValid();return (FGuid)Marshal.PtrToStructure(_this.Get()+ID__Offset, typeof(FGuid));}
			
		}
		
		static readonly int InputType__Offset;
		public EFunctionInputType InputType
		{
			get{ CheckIsValid();return (EFunctionInputType)Marshal.PtrToStructure(_this.Get()+InputType__Offset, typeof(EFunctionInputType));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+InputType__Offset, false);}
			
		}
		
		static readonly int PreviewValue__Offset;
		public FVector4 PreviewValue
		{
			get{ CheckIsValid();return (FVector4)Marshal.PtrToStructure(_this.Get()+PreviewValue__Offset, typeof(FVector4));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+PreviewValue__Offset, false);}
			
		}
		
		static readonly int bUsePreviewValueAsDefault__Offset;
		public bool bUsePreviewValueAsDefault
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bUsePreviewValueAsDefault__Offset, 1, 0, 1, 1);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bUsePreviewValueAsDefault__Offset, 1,0,1,1);}
			
		}
		
		static readonly int SortPriority__Offset;
		public int SortPriority
		{
			get{ CheckIsValid();return (int)Marshal.PtrToStructure(_this.Get()+SortPriority__Offset, typeof(int));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+SortPriority__Offset, false);}
			
		}
		
		static readonly int bCompilingFunctionPreview__Offset;
		public bool bCompilingFunctionPreview
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bCompilingFunctionPreview__Offset, 1, 0, 1, 1);}
			
		}
		
		static UMaterialExpressionFunctionInput()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("MaterialExpressionFunctionInput");
			Preview__Offset=GetPropertyOffset(NativeClassPtr,"Preview");
			InputName__Offset=GetPropertyOffset(NativeClassPtr,"InputName");
			Description__Offset=GetPropertyOffset(NativeClassPtr,"Description");
			ID__Offset=GetPropertyOffset(NativeClassPtr,"ID");
			InputType__Offset=GetPropertyOffset(NativeClassPtr,"InputType");
			PreviewValue__Offset=GetPropertyOffset(NativeClassPtr,"PreviewValue");
			bUsePreviewValueAsDefault__Offset=GetPropertyOffset(NativeClassPtr,"bUsePreviewValueAsDefault");
			SortPriority__Offset=GetPropertyOffset(NativeClassPtr,"SortPriority");
			bCompilingFunctionPreview__Offset=GetPropertyOffset(NativeClassPtr,"bCompilingFunctionPreview");
			
		}
		
	}
	
}
#endif
#endif
