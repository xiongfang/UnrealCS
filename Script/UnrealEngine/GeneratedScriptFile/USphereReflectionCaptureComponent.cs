using System;
namespace UnrealEngine
{
	public partial class USphereReflectionCaptureComponent:UReflectionCaptureComponent
	{
		/// <summary>Radius of the area that can receive reflections from this capture.</summary>
		public float InfluenceRadius;
		
		/// <summary>Not needed anymore, not yet removed in case the artist setup values are needed in the future</summary>
		public float CaptureDistanceScale;
		
		public UDrawSphereComponent PreviewInfluenceRadius;
		
		
	}
	
}
