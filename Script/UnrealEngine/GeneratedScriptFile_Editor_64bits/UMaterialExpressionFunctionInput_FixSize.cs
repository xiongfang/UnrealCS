#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class UMaterialExpressionFunctionInput
	{
		static readonly int Preview__Offset;
		/// <summary>Used for previewing when editing the function, or when bUsePreviewValueAsDefault is enabled.</summary>
		public FExpressionInput Preview
		{
			get{ CheckIsValid();return (FExpressionInput)Marshal.PtrToStructure(_this.Get()+Preview__Offset, typeof(FExpressionInput));}
			
		}
		
		static readonly int InputName__Offset;
		/// <summary>The input's name, which will be drawn on the connector in function call expressions that use this function.</summary>
		public FString InputName
		{
			get{ CheckIsValid();return (FString)Marshal.PtrToStructure(_this.Get()+InputName__Offset, typeof(FString));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+InputName__Offset, false);}
			
		}
		
		static readonly int Description__Offset;
		/// <summary>The input's description, which will be used as a tooltip on the connector in function call expressions that use this function.</summary>
		public FString Description
		{
			get{ CheckIsValid();return (FString)Marshal.PtrToStructure(_this.Get()+Description__Offset, typeof(FString));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+Description__Offset, false);}
			
		}
		
		static readonly int Id__Offset;
		/// <summary>Id of this input, used to maintain references through name changes.</summary>
		public FGuid Id
		{
			get{ CheckIsValid();return (FGuid)Marshal.PtrToStructure(_this.Get()+Id__Offset, typeof(FGuid));}
			
		}
		
		static readonly int InputType__Offset;
		/// <summary>
		/// Type of this input.
		/// Input code chunks will be cast to this type, and a compiler error will be emitted if the cast fails.
		/// </summary>
		public EFunctionInputType InputType
		{
			get{ CheckIsValid();return (EFunctionInputType)Marshal.PtrToStructure(_this.Get()+InputType__Offset, typeof(EFunctionInputType));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+InputType__Offset, false);}
			
		}
		
		static readonly int PreviewValue__Offset;
		/// <summary>Value used to preview this input when editing the material function.</summary>
		public FVector4 PreviewValue
		{
			get{ CheckIsValid();return (FVector4)Marshal.PtrToStructure(_this.Get()+PreviewValue__Offset, typeof(FVector4));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+PreviewValue__Offset, false);}
			
		}
		
		static readonly int bUsePreviewValueAsDefault__Offset;
		/// <summary>Whether to use the preview value or texture as the default value for this input.</summary>
		public bool bUsePreviewValueAsDefault
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bUsePreviewValueAsDefault__Offset, 1, 0, 1, 1);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bUsePreviewValueAsDefault__Offset, 1,0,1,1);}
			
		}
		
		static readonly int SortPriority__Offset;
		/// <summary>Controls where the input is displayed relative to the other inputs.</summary>
		public int SortPriority
		{
			get{ CheckIsValid();return (int)Marshal.PtrToStructure(_this.Get()+SortPriority__Offset, typeof(int));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+SortPriority__Offset, false);}
			
		}
		
		static readonly int bCompilingFunctionPreview__Offset;
		/// <summary>
		/// true when this expression is being compiled in a function preview,
		/// false when this expression is being compiled into a material that uses the function.
		/// Only valid in Compile()
		/// </summary>
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
			Id__Offset=GetPropertyOffset(NativeClassPtr,"Id");
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
