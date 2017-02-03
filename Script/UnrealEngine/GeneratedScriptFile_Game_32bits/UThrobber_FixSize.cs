#if WITH_GAME
#if PLATFORM_32BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class UThrobber
	{
		static readonly int NumberOfPieces__Offset;
		public int NumberOfPieces
		{
			get{ CheckIsValid();return (int)Marshal.PtrToStructure(_this.Get()+NumberOfPieces__Offset, typeof(int));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+NumberOfPieces__Offset, false);}
			
		}
		
		static readonly int bAnimateHorizontally__Offset;
		public bool bAnimateHorizontally
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bAnimateHorizontally__Offset, 1, 0, 1, 255);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bAnimateHorizontally__Offset, 1,0,1,255);}
			
		}
		
		static readonly int bAnimateVertically__Offset;
		public bool bAnimateVertically
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bAnimateVertically__Offset, 1, 0, 1, 255);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bAnimateVertically__Offset, 1,0,1,255);}
			
		}
		
		static readonly int bAnimateOpacity__Offset;
		public bool bAnimateOpacity
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bAnimateOpacity__Offset, 1, 0, 1, 255);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bAnimateOpacity__Offset, 1,0,1,255);}
			
		}
		
		static readonly int PieceImage__Offset;
		public USlateBrushAsset PieceImage
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + PieceImage__Offset); if (v == IntPtr.Zero)return null; USlateBrushAsset retValue = new USlateBrushAsset(); retValue._this = v; return retValue; }
			
		}
		
		static readonly int Image__Offset;
		public FSlateBrush Image
		{
			get{ CheckIsValid();return (FSlateBrush)Marshal.PtrToStructure(_this.Get()+Image__Offset, typeof(FSlateBrush));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+Image__Offset, false);}
			
		}
		
		static UThrobber()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("Throbber");
			NumberOfPieces__Offset=GetPropertyOffset(NativeClassPtr,"NumberOfPieces");
			bAnimateHorizontally__Offset=GetPropertyOffset(NativeClassPtr,"bAnimateHorizontally");
			bAnimateVertically__Offset=GetPropertyOffset(NativeClassPtr,"bAnimateVertically");
			bAnimateOpacity__Offset=GetPropertyOffset(NativeClassPtr,"bAnimateOpacity");
			PieceImage__Offset=GetPropertyOffset(NativeClassPtr,"PieceImage");
			Image__Offset=GetPropertyOffset(NativeClassPtr,"Image");
			
		}
		
	}
	
}
#endif
#endif
