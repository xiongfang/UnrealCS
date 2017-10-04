using System;
namespace UnrealEngine
{
	public partial class UTextRenderComponent:UPrimitiveComponent
	{
		/// <summary>Get world space size of text</summary>
		public extern FVector GetTextWorldSize();
		/// <summary>Get local size of text</summary>
		public extern FVector GetTextLocalSize();
		/// <summary>Change the world size of the text and signal the primitives to be rebuilt</summary>
		public extern void SetWorldSize(float Value);
		/// <summary>Change the text vertical spacing adjustment and signal the primitives to be rebuilt</summary>
		public extern void SetVertSpacingAdjust(float Value);
		/// <summary>Change the text horizontal spacing adjustment and signal the primitives to be rebuilt</summary>
		public extern void SetHorizSpacingAdjust(float Value);
		/// <summary>Change the text Y scale and signal the primitives to be rebuilt</summary>
		public extern void SetYScale(float Value);
		/// <summary>Change the text X scale and signal the primitives to be rebuilt</summary>
		public extern void SetXScale(float Value);
		/// <summary>Change the text render color and signal the primitives to be rebuilt</summary>
		public extern void SetTextRenderColor(FColor Value);
		/// <summary>Change the vertical alignment and signal the primitives to be rebuilt</summary>
		public extern void SetVerticalAlignment(EVerticalTextAligment Value);
		/// <summary>Change the horizontal alignment and signal the primitives to be rebuilt</summary>
		public extern void SetHorizontalAlignment(EHorizTextAligment Value);
		/// <summary>Change the font and signal the primitives to be rebuilt</summary>
		public extern void SetFont(UFont Value);
		/// <summary>Change the text material and signal the primitives to be rebuilt</summary>
		public extern void SetTextMaterial(UMaterialInterface Material);
		/// <summary>Change the text value and signal the primitives to be rebuilt</summary>
		public extern void K2_SetText(FText Value);
		/// <summary>Text content, can be multi line using <br> as line separator</summary>
		public FText Text;
		
		/// <summary>Text material</summary>
		public UMaterialInterface TextMaterial;
		
		/// <summary>Text font</summary>
		public UFont Font;
		
		/// <summary>Horizontal text alignment</summary>
		public EHorizTextAligment HorizontalAlignment;
		
		/// <summary>Vertical text alignment</summary>
		public EVerticalTextAligment VerticalAlignment;
		
		/// <summary>Color of the text, can be accessed as vertex color</summary>
		public FColor TextRenderColor;
		
		/// <summary>Horizontal scale, default is 1.0</summary>
		public float XScale;
		
		/// <summary>Vertical scale, default is 1.0</summary>
		public float YScale;
		
		/// <summary>Vertical size of the fonts largest character in world units. Transform, XScale and YScale will affect final size.</summary>
		public float WorldSize;
		
		/// <summary>The inverse of the Font's character height.</summary>
		public float InvDefaultSize;
		
		/// <summary>Horizontal adjustment per character, default is 0.0</summary>
		public float HorizSpacingAdjust;
		
		/// <summary>Vertical adjustment per character, default is 0.0</summary>
		public float VertSpacingAdjust;
		
		/// <summary>Allows text to draw unmodified when using debug visualization modes. *</summary>
		public bool bAlwaysRenderAsText;
		
		
	}
	
}
