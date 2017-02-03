#if WITH_GAME
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class UImage
	{
		static readonly int Image__Offset;
		public USlateBrushAsset Image
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + Image__Offset); if (v == IntPtr.Zero)return null; USlateBrushAsset retValue = new USlateBrushAsset(); retValue._this = v; return retValue; }
			
		}
		
		static readonly int Brush__Offset;
		public FSlateBrush Brush
		{
			get{ CheckIsValid();return (FSlateBrush)Marshal.PtrToStructure(_this.Get()+Brush__Offset, typeof(FSlateBrush));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+Brush__Offset, false);}
			
		}
		
		static readonly int ColorAndOpacity__Offset;
		public FLinearColor ColorAndOpacity
		{
			get{ CheckIsValid();return (FLinearColor)Marshal.PtrToStructure(_this.Get()+ColorAndOpacity__Offset, typeof(FLinearColor));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+ColorAndOpacity__Offset, false);}
			
		}
		
		static UImage()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("Image");
			Image__Offset=GetPropertyOffset(NativeClassPtr,"Image");
			Brush__Offset=GetPropertyOffset(NativeClassPtr,"Brush");
			ColorAndOpacity__Offset=GetPropertyOffset(NativeClassPtr,"ColorAndOpacity");
			
		}
		
	}
	
}
#endif
#endif
