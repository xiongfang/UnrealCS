#if WITH_GAME
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class UScaleBox
	{
		static readonly int Stretch__Offset;
		public EStretch Stretch
		{
			get{ CheckIsValid();return (EStretch)Marshal.PtrToStructure(_this.Get()+Stretch__Offset, typeof(EStretch));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+Stretch__Offset, false);}
			
		}
		
		static readonly int StretchDirection__Offset;
		public EStretchDirection StretchDirection
		{
			get{ CheckIsValid();return (EStretchDirection)Marshal.PtrToStructure(_this.Get()+StretchDirection__Offset, typeof(EStretchDirection));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+StretchDirection__Offset, false);}
			
		}
		
		static readonly int UserSpecifiedScale__Offset;
		public float UserSpecifiedScale
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+UserSpecifiedScale__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+UserSpecifiedScale__Offset, false);}
			
		}
		
		static readonly int IgnoreInheritedScale__Offset;
		public bool IgnoreInheritedScale
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), IgnoreInheritedScale__Offset, 1, 0, 1, 255);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), IgnoreInheritedScale__Offset, 1,0,1,255);}
			
		}
		
		static UScaleBox()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("ScaleBox");
			Stretch__Offset=GetPropertyOffset(NativeClassPtr,"Stretch");
			StretchDirection__Offset=GetPropertyOffset(NativeClassPtr,"StretchDirection");
			UserSpecifiedScale__Offset=GetPropertyOffset(NativeClassPtr,"UserSpecifiedScale");
			IgnoreInheritedScale__Offset=GetPropertyOffset(NativeClassPtr,"IgnoreInheritedScale");
			
		}
		
	}
	
}
#endif
#endif
