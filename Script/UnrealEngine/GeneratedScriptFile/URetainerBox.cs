using System;
namespace UnrealEngine
{
	public partial class URetainerBox:UContentWidget
	{
		/// <summary>Sets the name of the texture parameter to set the render target to on the material.</summary>
		public extern void SetTextureParameter(FName TextureParameter);
		/// <summary>Set a new effect material to the retainer widget.</summary>
		public extern void SetEffectMaterial(UMaterialInterface EffectMaterial);
		/// <summary>Get the current dynamic effect material applied to the retainer box.</summary>
		public extern UMaterialInstanceDynamic GetEffectMaterial();
		/// <summary>
		/// The Phase this widget will draw on.
		/// If the Phase is 0, and the PhaseCount is 1, the widget will be drawn fresh every frame.
		/// If the Phase were 0, and the PhaseCount were 2, this retainer would draw a fresh frame every
		/// other frame.  So in a 60Hz game, the UI would render at 30Hz.
		/// </summary>
		public int Phase;
		
		/// <summary>
		/// The PhaseCount controls how many phases are possible know what to modulus the current frame
		/// count by to determine if this is the current frame to draw the widget on.
		/// If the Phase is 0, and the PhaseCount is 1, the widget will be drawn fresh every frame.
		/// If the Phase were 0, and the PhaseCount were 2, this retainer would draw a fresh frame every
		/// other frame.  So in a 60Hz game, the UI would render at 30Hz.
		/// </summary>
		public int PhaseCount;
		
		/// <summary>
		/// The effect to optionally apply to the render target.  We will set the texture sampler based on the name
		/// set in the @TextureParameter property.
		/// If you want to adjust transparency of the final image, make sure you set Blend Mode to AlphaComposite (Pre-Multiplied Alpha)
		/// and make sure to multiply the alpha you're apply across the surface to the color and the alpha of the render target, otherwise
		/// you won't see the expected color.
		/// </summary>
		public UMaterialInterface EffectMaterial;
		
		/// <summary>The texture sampler parameter of the @EffectMaterial, that we'll set to the render target.</summary>
		public FName TextureParameter;
		
		
	}
	
}
