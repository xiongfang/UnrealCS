#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>A simple arrow rendered using lines. Useful for indicating which way an object is facing.</summary>
	public partial class UArrowComponent
	{
		static readonly int ArrowColor__Offset;
		public FColor ArrowColor
		{
			get{ CheckIsValid();return (FColor)Marshal.PtrToStructure(_this.Get()+ArrowColor__Offset, typeof(FColor));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+ArrowColor__Offset, false);}
			
		}
		
		static readonly int ArrowSize__Offset;
		public float ArrowSize
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+ArrowSize__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+ArrowSize__Offset, false);}
			
		}
		
		static readonly int bIsScreenSizeScaled__Offset;
		/// <summary>Set to limit the screen size of this arrow</summary>
		public bool bIsScreenSizeScaled
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bIsScreenSizeScaled__Offset, 1, 0, 1, 255);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bIsScreenSizeScaled__Offset, 1,0,1,255);}
			
		}
		
		static readonly int ScreenSize__Offset;
		/// <summary>The size on screen to limit this arrow to (in screen space)</summary>
		public float ScreenSize
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+ScreenSize__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+ScreenSize__Offset, false);}
			
		}
		
		static readonly int bTreatAsASprite__Offset;
		/// <summary>If true, don't show the arrow when EngineShowFlags.BillboardSprites is disabled.</summary>
		public bool bTreatAsASprite
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bTreatAsASprite__Offset, 1, 0, 1, 1);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bTreatAsASprite__Offset, 1,0,1,1);}
			
		}
		
		static readonly int SpriteCategoryName__Offset;
		/// <summary>Sprite category that the arrow component belongs to, if being treated as a sprite. Value serves as a key into the localization file.</summary>
		public FName SpriteCategoryName
		{
			get{ CheckIsValid();return (FName)Marshal.PtrToStructure(_this.Get()+SpriteCategoryName__Offset, typeof(FName));}
			
		}
		
		static readonly int SpriteInfo__Offset;
		/// <summary>Sprite category information regarding the arrow component, if being treated as a sprite.</summary>
		public FSpriteCategoryInfo SpriteInfo
		{
			get{ CheckIsValid();return (FSpriteCategoryInfo)Marshal.PtrToStructure(_this.Get()+SpriteInfo__Offset, typeof(FSpriteCategoryInfo));}
			
		}
		
		static readonly int bLightAttachment__Offset;
		/// <summary>If true, this arrow component is attached to a light actor</summary>
		public bool bLightAttachment
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bLightAttachment__Offset, 1, 0, 1, 1);}
			
		}
		
		static readonly int bUseInEditorScaling__Offset;
		/// <summary>Whether to use in-editor arrow scaling (i.e. to be affected by the global arrow scale)</summary>
		public bool bUseInEditorScaling
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bUseInEditorScaling__Offset, 1, 0, 1, 255);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bUseInEditorScaling__Offset, 1,0,1,255);}
			
		}
		
		static UArrowComponent()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("ArrowComponent");
			ArrowColor__Offset=GetPropertyOffset(NativeClassPtr,"ArrowColor");
			ArrowSize__Offset=GetPropertyOffset(NativeClassPtr,"ArrowSize");
			bIsScreenSizeScaled__Offset=GetPropertyOffset(NativeClassPtr,"bIsScreenSizeScaled");
			ScreenSize__Offset=GetPropertyOffset(NativeClassPtr,"ScreenSize");
			bTreatAsASprite__Offset=GetPropertyOffset(NativeClassPtr,"bTreatAsASprite");
			SpriteCategoryName__Offset=GetPropertyOffset(NativeClassPtr,"SpriteCategoryName");
			SpriteInfo__Offset=GetPropertyOffset(NativeClassPtr,"SpriteInfo");
			bLightAttachment__Offset=GetPropertyOffset(NativeClassPtr,"bLightAttachment");
			bUseInEditorScaling__Offset=GetPropertyOffset(NativeClassPtr,"bUseInEditorScaling");
			
		}
		
	}
	
}
#endif
#endif
