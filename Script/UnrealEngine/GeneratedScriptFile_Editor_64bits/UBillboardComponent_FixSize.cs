#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>A 2d texture that will be rendered always facing the camera.</summary>
	public partial class UBillboardComponent
	{
		static readonly int Sprite__Offset;
		public UTexture2D Sprite
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + Sprite__Offset); if (v == IntPtr.Zero)return null; UTexture2D retValue = new UTexture2D(); retValue._this = v; return retValue; }
			set{ CheckIsValid(); if (value == null)Marshal.WriteIntPtr(_this.Get() + Sprite__Offset, IntPtr.Zero);else Marshal.WriteIntPtr(_this.Get() + Sprite__Offset, value._this.Get()); }
			
		}
		
		static readonly int bIsScreenSizeScaled__Offset;
		public bool bIsScreenSizeScaled
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bIsScreenSizeScaled__Offset, 1, 0, 1, 1);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bIsScreenSizeScaled__Offset, 1,0,1,1);}
			
		}
		
		static readonly int ScreenSize__Offset;
		public float ScreenSize
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+ScreenSize__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+ScreenSize__Offset, false);}
			
		}
		
		static readonly int U__Offset;
		public float U
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+U__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+U__Offset, false);}
			
		}
		
		static readonly int UL__Offset;
		public float UL
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+UL__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+UL__Offset, false);}
			
		}
		
		static readonly int V__Offset;
		public float V
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+V__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+V__Offset, false);}
			
		}
		
		static readonly int VL__Offset;
		public float VL
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+VL__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+VL__Offset, false);}
			
		}
		
		static readonly int SpriteCategoryName__Offset;
		/// <summary>Sprite category that the component belongs to. Value serves as a key into the localization file.</summary>
		public FName SpriteCategoryName
		{
			get{ CheckIsValid();return (FName)Marshal.PtrToStructure(_this.Get()+SpriteCategoryName__Offset, typeof(FName));}
			
		}
		
		static readonly int SpriteInfo__Offset;
		/// <summary>Sprite category information regarding the component</summary>
		public FSpriteCategoryInfo SpriteInfo
		{
			get{ CheckIsValid();return (FSpriteCategoryInfo)Marshal.PtrToStructure(_this.Get()+SpriteInfo__Offset, typeof(FSpriteCategoryInfo));}
			
		}
		
		static readonly int bUseInEditorScaling__Offset;
		/// <summary>Whether to use in-editor arrow scaling (i.e. to be affected by the global arrow scale)</summary>
		public bool bUseInEditorScaling
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bUseInEditorScaling__Offset, 1, 0, 1, 255);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bUseInEditorScaling__Offset, 1,0,1,255);}
			
		}
		
		static UBillboardComponent()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("BillboardComponent");
			Sprite__Offset=GetPropertyOffset(NativeClassPtr,"Sprite");
			bIsScreenSizeScaled__Offset=GetPropertyOffset(NativeClassPtr,"bIsScreenSizeScaled");
			ScreenSize__Offset=GetPropertyOffset(NativeClassPtr,"ScreenSize");
			U__Offset=GetPropertyOffset(NativeClassPtr,"U");
			UL__Offset=GetPropertyOffset(NativeClassPtr,"UL");
			V__Offset=GetPropertyOffset(NativeClassPtr,"V");
			VL__Offset=GetPropertyOffset(NativeClassPtr,"VL");
			SpriteCategoryName__Offset=GetPropertyOffset(NativeClassPtr,"SpriteCategoryName");
			SpriteInfo__Offset=GetPropertyOffset(NativeClassPtr,"SpriteInfo");
			bUseInEditorScaling__Offset=GetPropertyOffset(NativeClassPtr,"bUseInEditorScaling");
			
		}
		
	}
	
}
#endif
#endif
