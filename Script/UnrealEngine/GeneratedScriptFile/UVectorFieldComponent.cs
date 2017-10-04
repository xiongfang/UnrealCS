using System;
namespace UnrealEngine
{
	public partial class UVectorFieldComponent:UPrimitiveComponent
	{
		/// <summary>
		/// Set the intensity of the vector field.
		/// @param NewIntensity - The new intensity of the vector field.
		/// </summary>
		public extern virtual void SetIntensity(float NewIntensity);
		/// <summary>The vector field asset.</summary>
		public UVectorField VectorField;
		
		/// <summary>The intensity at which the vector field is applied.</summary>
		public float Intensity;
		
		/// <summary>How tightly particles follow the vector field.</summary>
		public float Tightness;
		
		/// <summary>If true, the vector field is only used for preview visualizations.</summary>
		public bool bPreviewVectorField;
		
		
	}
	
}
