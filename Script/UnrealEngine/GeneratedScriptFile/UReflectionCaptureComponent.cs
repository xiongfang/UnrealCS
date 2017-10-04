using System;
namespace UnrealEngine
{
	public partial class UReflectionCaptureComponent:USceneComponent
	{
		public UBillboardComponent CaptureOffsetComponent;
		
		/// <summary>Cubemap to use for reflection if ReflectionSourceType is set to RS_SpecifiedCubemap.</summary>
		public UTextureCube Cubemap;
		
		/// <summary>Angle to rotate the source cubemap when SourceType is set to SLS_SpecifiedCubemap.</summary>
		public float SourceCubemapAngle;
		
		/// <summary>A brightness control to scale the captured scene's reflection intensity.</summary>
		public float Brightness;
		
		/// <summary>World space offset to apply before capturing.</summary>
		public FVector CaptureOffset;
		
		public FGuid StateId;
		
		
	}
	
}
