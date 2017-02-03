#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>A Material Function is a collection of material expressions that can be reused in different materials</summary>
	public partial class UMaterialFunction
	{
		static readonly int StateId__Offset;
		/// <summary>Used by materials using this function to know when to recompile.</summary>
		public FGuid StateId
		{
			get{ CheckIsValid();return (FGuid)Marshal.PtrToStructure(_this.Get()+StateId__Offset, typeof(FGuid));}
			
		}
		
		static readonly int ParentFunction__Offset;
		/// <summary>Used in the material editor, points to the function asset being edited, which this function is just a preview for.</summary>
		public UMaterialFunction ParentFunction
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + ParentFunction__Offset); if (v == IntPtr.Zero)return null; UMaterialFunction retValue = new UMaterialFunction(); retValue._this = v; return retValue; }
			
		}
		
		static readonly int Description__Offset;
		/// <summary>Description of the function which will be displayed as a tooltip wherever the function is used.</summary>
		public FString Description
		{
			get{ CheckIsValid();return (FString)Marshal.PtrToStructure(_this.Get()+Description__Offset, typeof(FString));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+Description__Offset, false);}
			
		}
		
		static readonly int bExposeToLibrary__Offset;
		/// <summary>Whether to list this function in the material function library, which is a window in the material editor that lists categorized functions.</summary>
		public bool bExposeToLibrary
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bExposeToLibrary__Offset, 1, 0, 1, 1);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bExposeToLibrary__Offset, 1,0,1,1);}
			
		}
		
		static readonly int LibraryCategories__Offset;
		/// <summary>
		/// Categories that this function belongs to in the material function library.
		/// Ideally categories should be chosen carefully so that there are not too many.
		/// </summary>
		public TStructArray<FString> LibraryCategories
		{
			get{ CheckIsValid();return new TStructArray<FString>((FScriptArray)Marshal.PtrToStructure(_this.Get()+LibraryCategories__Offset, typeof(FScriptArray)));}
					set{ CheckIsValid();Marshal.StructureToPtr(value.InterArray, _this.Get()+LibraryCategories__Offset, false);}
			
		}
		
		static readonly int LibraryCategoriesText__Offset;
		/// <summary>
		/// Categories that this function belongs to in the material function library.
		/// Ideally categories should be chosen carefully so that there are not too many.
		/// </summary>
		public TStructArray<FText> LibraryCategoriesText
		{
			get{ CheckIsValid();return new TStructArray<FText>((FScriptArray)Marshal.PtrToStructure(_this.Get()+LibraryCategoriesText__Offset, typeof(FScriptArray)));}
					set{ CheckIsValid();Marshal.StructureToPtr(value.InterArray, _this.Get()+LibraryCategoriesText__Offset, false);}
			
		}
		
		static readonly int FunctionExpressions__Offset;
		/// <summary>Array of material expressions, excluding Comments.  Used by the material editor.</summary>
		public TObjectArray<UMaterialExpression>  FunctionExpressions
		{
					get{ CheckIsValid();return new TObjectArray<UMaterialExpression>((FScriptArray)Marshal.PtrToStructure(_this.Get()+FunctionExpressions__Offset, typeof(FScriptArray)));}
					set{ CheckIsValid();Marshal.StructureToPtr(value.InterArray, _this.Get()+FunctionExpressions__Offset, false);}
			
		}
		
		static readonly int FunctionEditorComments__Offset;
		/// <summary>Array of comments associated with this material; viewed in the material editor.</summary>
		public TObjectArray<UMaterialExpressionComment>  FunctionEditorComments
		{
					get{ CheckIsValid();return new TObjectArray<UMaterialExpressionComment>((FScriptArray)Marshal.PtrToStructure(_this.Get()+FunctionEditorComments__Offset, typeof(FScriptArray)));}
					set{ CheckIsValid();Marshal.StructureToPtr(value.InterArray, _this.Get()+FunctionEditorComments__Offset, false);}
			
		}
		
		static readonly int PreviewMaterial__Offset;
		public UMaterial PreviewMaterial
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + PreviewMaterial__Offset); if (v == IntPtr.Zero)return null; UMaterial retValue = new UMaterial(); retValue._this = v; return retValue; }
			
		}
		
		static readonly int bReentrantFlag__Offset;
		/// <summary>Transient flag used to track re-entrance in recursive functions like IsDependent.</summary>
		public bool bReentrantFlag
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bReentrantFlag__Offset, 1, 0, 1, 1);}
			
		}
		
		static readonly int CombinedInputTypes__Offset;
		public uint CombinedInputTypes
		{
			get{ CheckIsValid();return (uint)Marshal.PtrToStructure(_this.Get()+CombinedInputTypes__Offset, typeof(uint));}
			
		}
		
		static readonly int CombinedOutputTypes__Offset;
		public uint CombinedOutputTypes
		{
			get{ CheckIsValid();return (uint)Marshal.PtrToStructure(_this.Get()+CombinedOutputTypes__Offset, typeof(uint));}
			
		}
		
		static readonly int ThumbnailInfo__Offset;
		/// <summary>Information for thumbnail rendering</summary>
		public UThumbnailInfo ThumbnailInfo
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + ThumbnailInfo__Offset); if (v == IntPtr.Zero)return null; UThumbnailInfo retValue = new UThumbnailInfo(); retValue._this = v; return retValue; }
			set{ CheckIsValid(); if (value == null)Marshal.WriteIntPtr(_this.Get() + ThumbnailInfo__Offset, IntPtr.Zero);else Marshal.WriteIntPtr(_this.Get() + ThumbnailInfo__Offset, value._this.Get()); }
			
		}
		
		static UMaterialFunction()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("MaterialFunction");
			StateId__Offset=GetPropertyOffset(NativeClassPtr,"StateId");
			ParentFunction__Offset=GetPropertyOffset(NativeClassPtr,"ParentFunction");
			Description__Offset=GetPropertyOffset(NativeClassPtr,"Description");
			bExposeToLibrary__Offset=GetPropertyOffset(NativeClassPtr,"bExposeToLibrary");
			LibraryCategories__Offset=GetPropertyOffset(NativeClassPtr,"LibraryCategories");
			LibraryCategoriesText__Offset=GetPropertyOffset(NativeClassPtr,"LibraryCategoriesText");
			FunctionExpressions__Offset=GetPropertyOffset(NativeClassPtr,"FunctionExpressions");
			FunctionEditorComments__Offset=GetPropertyOffset(NativeClassPtr,"FunctionEditorComments");
			PreviewMaterial__Offset=GetPropertyOffset(NativeClassPtr,"PreviewMaterial");
			bReentrantFlag__Offset=GetPropertyOffset(NativeClassPtr,"bReentrantFlag");
			CombinedInputTypes__Offset=GetPropertyOffset(NativeClassPtr,"CombinedInputTypes");
			CombinedOutputTypes__Offset=GetPropertyOffset(NativeClassPtr,"CombinedOutputTypes");
			ThumbnailInfo__Offset=GetPropertyOffset(NativeClassPtr,"ThumbnailInfo");
			
		}
		
	}
	
}
#endif
#endif
