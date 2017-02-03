using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public enum ETranslucencyLightingMode:byte
	{
		/// <summary>
		/// Lighting will be calculated for a volume, without directionality.  Use this on particle effects like smoke and dust.
		/// This is the cheapest per-pixel lighting method, however the material normal is not taken into account.
		/// </summary>
		TLM_VolumetricNonDirectional=0,
		/// <summary>
		/// Lighting will be calculated for a volume, with directionality so that the normal of the material is taken into account.
		/// Note that the default particle tangent space is facing the camera, so enable bGenerateSphericalParticleNormals to get a more useful tangent space.
		/// </summary>
		TLM_VolumetricDirectional=1,
		/// <summary>
		/// Same as Volumetric Non Directional, but lighting is only evaluated at vertices so the pixel shader cost is significantly less.
		/// Note that lighting still comes from a volume texture, so it is limited in range.  Directional lights become unshadowed in the distance.
		/// </summary>
		TLM_VolumetricPerVertexNonDirectional=2,
		/// <summary>
		/// Same as Volumetric Directional, but lighting is only evaluated at vertices so the pixel shader cost is significantly less.
		/// Note that lighting still comes from a volume texture, so it is limited in range.  Directional lights become unshadowed in the distance.
		/// </summary>
		TLM_VolumetricPerVertexDirectional=3,
		/// <summary>
		/// Lighting will be calculated for a surface. The light in accumulated in a volume so the result is blurry,
		/// limited distance but the per pixel cost is very low. Use this on translucent surfaces like glass and water.
		/// Only diffuse lighting is supported.
		/// </summary>
		TLM_Surface=4,
		/// <summary>
		/// Lighting will be calculated for a surface. Use this on translucent surfaces like glass and water.
		/// This is implemented with forward shading so specular highlights from local lights are supported, however many deferred-only features are not.
		/// This is the most expensive translucency lighting method as each light's contribution is computed per-pixel.
		/// </summary>
		TLM_SurfacePerPixelLighting=5,
		TLM_MAX=6,
		
	}
	
}
