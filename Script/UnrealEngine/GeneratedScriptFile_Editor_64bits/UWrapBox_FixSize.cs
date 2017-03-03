#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>
	/// Arranges widgets left-to-right.  When the widgets exceed the Width it will place widgets on the next line.
	/// * Many Children
	/// * Flows
	/// * Wraps
	/// </summary>
	public partial class UWrapBox
	{
		static readonly int InnerSlotPadding__Offset;
		/// <summary>The inner slot padding goes between slots sharing borders</summary>
		public FVector2D InnerSlotPadding
		{
			get{ CheckIsValid();return (FVector2D)Marshal.PtrToStructure(_this.Get()+InnerSlotPadding__Offset, typeof(FVector2D));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+InnerSlotPadding__Offset, false);}
			
		}
		
		static readonly int WrapWidth__Offset;
		/// <summary>When this width is exceeded, elements will start appearing on the next line.</summary>
		public float WrapWidth
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+WrapWidth__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+WrapWidth__Offset, false);}
			
		}
		
		static readonly int bExplicitWrapWidth__Offset;
		/// <summary>Use explicit wrap width whenever possible. It greatly simplifies layout calculations and reduces likelihood of "wiggling UI"</summary>
		public bool bExplicitWrapWidth
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bExplicitWrapWidth__Offset, 1, 0, 1, 255);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bExplicitWrapWidth__Offset, 1,0,1,255);}
			
		}
		
		static UWrapBox()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("WrapBox");
			InnerSlotPadding__Offset=GetPropertyOffset(NativeClassPtr,"InnerSlotPadding");
			WrapWidth__Offset=GetPropertyOffset(NativeClassPtr,"WrapWidth");
			bExplicitWrapWidth__Offset=GetPropertyOffset(NativeClassPtr,"bExplicitWrapWidth");
			
		}
		
	}
	
}
#endif
#endif
