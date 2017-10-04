using System;
namespace UnrealEngine
{
	public partial class UBillboardComponent:UPrimitiveComponent
	{
		/// <summary>Change the sprite texture and the UV's used by this component</summary>
		public extern virtual void SetSpriteAndUV(UTexture2D NewSprite,int NewU,int NewUL,int NewV,int NewVL);
		/// <summary>Change the sprite's UVs</summary>
		public extern virtual void SetUV(int NewU,int NewUL,int NewV,int NewVL);
		/// <summary>Change the sprite texture used by this component</summary>
		public extern virtual void SetSprite(UTexture2D NewSprite);
		public UTexture2D Sprite;
		
		public bool bIsScreenSizeScaled;
		
		public float ScreenSize;
		
		public float U;
		
		public float UL;
		
		public float V;
		
		public float VL;
		
		/// <summary>Sprite category that the component belongs to. Value serves as a key into the localization file.</summary>
		public FName SpriteCategoryName;
		
		/// <summary>Sprite category information regarding the component</summary>
		public FSpriteCategoryInfo SpriteInfo;
		
		/// <summary>Whether to use in-editor arrow scaling (i.e. to be affected by the global arrow scale)</summary>
		public bool bUseInEditorScaling;
		
		
	}
	
}
