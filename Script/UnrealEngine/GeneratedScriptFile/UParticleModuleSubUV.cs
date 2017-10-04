using System;
namespace UnrealEngine
{
	public partial class UParticleModuleSubUV:UParticleModuleSubUVBase
	{
		/// <summary>
		/// SubUV animation asset to use.
		/// When specified, optimal bounding geometry for each SubUV frame will be used when rendering the sprites for this emitter instead of full quads.
		/// This reduction in overdraw can reduce the GPU cost of rendering the emitter by 2x or 3x, depending on how much unused space was in the texture.
		/// The bounding geometry is generated off of the texture alpha setup in the SubUV Animation asset, so that has to match what the material is using for opacity, or clipping will occur.
		/// When specified, SubImages_Horizontal and SubImages_Vertical will come from the asset instead of the Required Module.
		/// </summary>
		public USubUVAnimation Animation;
		
		/// <summary>
		/// The index of the sub-image that should be used for the particle.
		/// The value is retrieved using the RelativeTime of the particles.
		/// </summary>
		public FRawDistributionFloat SubImageIndex;
		
		/// <summary>
		/// If true, use *real* time when updating the image index.
		/// The movie will update regardless of the slomo settings of the game.
		/// </summary>
		public bool bUseRealTime;
		
		
	}
	
}
