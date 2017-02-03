#if WITH_GAME
#if PLATFORM_32BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class UCircularThrobber
	{
		static readonly int NumberOfPieces__Offset;
		public int NumberOfPieces
		{
			get{ CheckIsValid();return (int)Marshal.PtrToStructure(_this.Get()+NumberOfPieces__Offset, typeof(int));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+NumberOfPieces__Offset, false);}
			
		}
		
		static readonly int Period__Offset;
		public float Period
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+Period__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+Period__Offset, false);}
			
		}
		
		static readonly int Radius__Offset;
		public float Radius
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+Radius__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+Radius__Offset, false);}
			
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
		
		static readonly int bEnableRadius__Offset;
		public bool bEnableRadius
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bEnableRadius__Offset, 1, 0, 1, 255);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bEnableRadius__Offset, 1,0,1,255);}
			
		}
		
		static UCircularThrobber()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("CircularThrobber");
			NumberOfPieces__Offset=GetPropertyOffset(NativeClassPtr,"NumberOfPieces");
			Period__Offset=GetPropertyOffset(NativeClassPtr,"Period");
			Radius__Offset=GetPropertyOffset(NativeClassPtr,"Radius");
			PieceImage__Offset=GetPropertyOffset(NativeClassPtr,"PieceImage");
			Image__Offset=GetPropertyOffset(NativeClassPtr,"Image");
			bEnableRadius__Offset=GetPropertyOffset(NativeClassPtr,"bEnableRadius");
			
		}
		
	}
	
}
#endif
#endif
