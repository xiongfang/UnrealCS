#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>
	/// Allows you to place content with a desired size and have it scale to meet the constraints placed on this box's alloted area.  If
	/// you needed to have a background image scale to fill an area but not become distorted with different aspect ratios, or if you need
	/// to auto fit some text to an area, this is the control for you.
	/// * Single Child
	/// * Aspect Ratio
	/// </summary>
	public partial class UScaleBox
	{
		static readonly int Stretch__Offset;
		/// <summary>The stretching rule to apply when content is stretched</summary>
		public EStretch Stretch
		{
			get{ CheckIsValid();return (EStretch)Marshal.PtrToStructure(_this.Get()+Stretch__Offset, typeof(EStretch));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+Stretch__Offset, false);}
			
		}
		
		static readonly int StretchDirection__Offset;
		/// <summary>Controls in what direction content can be scaled</summary>
		public EStretchDirection StretchDirection
		{
			get{ CheckIsValid();return (EStretchDirection)Marshal.PtrToStructure(_this.Get()+StretchDirection__Offset, typeof(EStretchDirection));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+StretchDirection__Offset, false);}
			
		}
		
		static readonly int UserSpecifiedScale__Offset;
		/// <summary>Optional scale that can be specified by the User. Used only for UserSpecified stretching.</summary>
		public float UserSpecifiedScale
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+UserSpecifiedScale__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+UserSpecifiedScale__Offset, false);}
			
		}
		
		static readonly int IgnoreInheritedScale__Offset;
		/// <summary>Optional bool to ignore the inherited scale. Applies inverse scaling to counteract parents before applying the local scale operation.</summary>
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
