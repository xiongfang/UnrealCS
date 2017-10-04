using System;
namespace UnrealEngine
{
	public partial class UPlaneReflectionCaptureComponent:UReflectionCaptureComponent
	{
		/// <summary>Radius of the area that can receive reflections from this capture.</summary>
		public float InfluenceRadiusScale;
		
		public UDrawSphereComponent PreviewInfluenceRadius;
		
		public UBoxComponent PreviewCaptureBox;
		
		
	}
	
}
