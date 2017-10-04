using System;
namespace UnrealEngine
{
	public partial class UArrowComponent:UPrimitiveComponent
	{
		/// <summary>Updates the arrow's colour, and tells it to refresh</summary>
		public extern virtual void SetArrowColor_New(FLinearColor NewColor);
		public FColor ArrowColor;
		
		public float ArrowSize;
		
		/// <summary>Set to limit the screen size of this arrow</summary>
		public bool bIsScreenSizeScaled;
		
		/// <summary>The size on screen to limit this arrow to (in screen space)</summary>
		public float ScreenSize;
		
		/// <summary>If true, don't show the arrow when EngineShowFlags.BillboardSprites is disabled.</summary>
		public bool bTreatAsASprite;
		
		/// <summary>Sprite category that the arrow component belongs to, if being treated as a sprite. Value serves as a key into the localization file.</summary>
		public FName SpriteCategoryName;
		
		/// <summary>Sprite category information regarding the arrow component, if being treated as a sprite.</summary>
		public FSpriteCategoryInfo SpriteInfo;
		
		/// <summary>If true, this arrow component is attached to a light actor</summary>
		public bool bLightAttachment;
		
		/// <summary>Whether to use in-editor arrow scaling (i.e. to be affected by the global arrow scale)</summary>
		public bool bUseInEditorScaling;
		
		
	}
	
}
