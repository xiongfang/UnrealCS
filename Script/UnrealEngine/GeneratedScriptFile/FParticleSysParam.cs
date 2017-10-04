using System;
namespace UnrealEngine
{
	/// <summary>Struct used for a particular named instance parameter for this ParticleSystemComponent.</summary>
	public partial struct FParticleSysParam
	{
		/// <summary>The name of the parameter</summary>
		public FName Name;
		/// <summary>
		/// The type of parameters
		/// PSPT_None       - There is no data type
		/// PSPT_Scalar     - Use the scalar value
		/// PSPT_ScalarRand - Select a scalar value in the range [Scalar_Low..Scalar)
		/// PSPT_Vector     - Use the vector value
		/// PSPT_VectorRand - Select a vector value in the range [Vector_Low..Vector)
		/// PSPT_Color      - Use the color value
		/// PSPT_Actor      - Use the actor value
		/// PSPT_Material   - Use the material value
		/// </summary>
		public EParticleSysParamType ParamType;
		public float Scalar;
		public float Scalar_Low;
		public FVector Vector;
		public FVector Vector_Low;
		public FColor Color;
		public AActor Actor;
		public UMaterialInterface Material;
		
	}
	
}
