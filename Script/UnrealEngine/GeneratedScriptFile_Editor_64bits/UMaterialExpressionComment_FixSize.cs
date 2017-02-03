#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class UMaterialExpressionComment
	{
		static readonly int SizeX__Offset;
		public int SizeX
		{
			get{ CheckIsValid();return (int)Marshal.PtrToStructure(_this.Get()+SizeX__Offset, typeof(int));}
			
		}
		
		static readonly int SizeY__Offset;
		public int SizeY
		{
			get{ CheckIsValid();return (int)Marshal.PtrToStructure(_this.Get()+SizeY__Offset, typeof(int));}
			
		}
		
		static readonly int Text__Offset;
		public FString Text
		{
			get{ CheckIsValid();return (FString)Marshal.PtrToStructure(_this.Get()+Text__Offset, typeof(FString));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+Text__Offset, false);}
			
		}
		
		static readonly int CommentColor__Offset;
		/// <summary>Color to style comment with</summary>
		public FLinearColor CommentColor
		{
			get{ CheckIsValid();return (FLinearColor)Marshal.PtrToStructure(_this.Get()+CommentColor__Offset, typeof(FLinearColor));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+CommentColor__Offset, false);}
			
		}
		
		static UMaterialExpressionComment()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("MaterialExpressionComment");
			SizeX__Offset=GetPropertyOffset(NativeClassPtr,"SizeX");
			SizeY__Offset=GetPropertyOffset(NativeClassPtr,"SizeY");
			Text__Offset=GetPropertyOffset(NativeClassPtr,"Text");
			CommentColor__Offset=GetPropertyOffset(NativeClassPtr,"CommentColor");
			
		}
		
	}
	
}
#endif
#endif
