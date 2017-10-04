using System;
namespace UnrealEngine
{
	public partial class UStereoLayerComponent:USceneComponent
	{
		/// <summary>Manually mark the stereo layer texture for updating</summary>
		public extern void MarkTextureForUpdate();
		/// <summary>@return the render priority</summary>
		public extern int GetPriority();
		/// <summary>
		/// Change the layer's render priority, higher priorities render on top of lower priorities
		/// @param       InPriority: Priority value
		/// </summary>
		public extern void SetPriority(int InPriority);
		/// <summary>@return the UV coordinates mapped to the quad face</summary>
		public extern FBox2D GetUVRect();
		/// <summary>
		/// Change the UV coordinates mapped to the quad face
		/// @param       InUVRect: Min and Max UV coordinates
		/// </summary>
		public extern void SetUVRect(FBox2D InUVRect);
		/// <summary>@return the height and width of the rendered quad</summary>
		public extern FVector2D GetQuadSize();
		/// <summary>
		/// Change the quad size. This is the unscaled height and width, before component scale is applied.
		/// @param       InQuadSize: new quad size.
		/// </summary>
		public extern void SetQuadSize(FVector2D InQuadSize);
		/// <summary>@return the texture mapped to the stereo layer quad</summary>
		public extern UTexture GetTexture();
		/// <summary>
		/// Change the texture displayed on the stereo layer quad
		/// @param       InTexture: new Texture2D
		/// </summary>
		public extern void SetTexture(UTexture InTexture);
		/// <summary>True if the stereo layer texture needs to update itself every frame(scene capture, video, etc.)</summary>
		public bool bLiveTexture;
		
		/// <summary>True if the stereo layer needs to support depth intersections with the scene geometry, if available on the platform</summary>
		public bool bSupportsDepth;
		
		/// <summary>True if the texture should not use its own alpha channel (1.0 will be substituted)</summary>
		public bool bNoAlphaChannel;
		
		/// <summary>Texture displayed on the stereo layer (is stereocopic textures are supported on the platfrom and more than one texture is provided, this will be the right eye) *</summary>
		public UTexture Texture;
		
		/// <summary>Texture displayed on the stereo layer for left eye, if stereoscopic textures are supported on the platform *</summary>
		public UTexture LeftTexture;
		
		/// <summary>True if the quad should internally set it's Y value based on the set texture's dimensions</summary>
		public bool bQuadPreserveTextureRatio;
		
		/// <summary>Size of the rendered stereo layer quad *</summary>
		public FVector2D QuadSize;
		
		/// <summary>UV coordinates mapped to the quad face *</summary>
		public FBox2D UVRect;
		
		/// <summary>Radial size of the rendered stereo layer cylinder *</summary>
		public float CylinderRadius;
		
		/// <summary>Arc angle for the stereo layer cylinder *</summary>
		public float CylinderOverlayArc;
		
		/// <summary>Height of the stereo layer cylinder *</summary>
		public int CylinderHeight;
		
		/// <summary>Specifies how and where the quad is rendered to the screen *</summary>
		public EStereoLayerType StereoLayerType;
		
		/// <summary>Specifies which type of layer it is.  Note that some shapes will be supported only on certain platforms! *</summary>
		public EStereoLayerShape StereoLayerShape;
		
		/// <summary>Render priority among all stereo layers, higher priority render on top of lower priority *</summary>
		public int Priority;
		
		
	}
	
}
