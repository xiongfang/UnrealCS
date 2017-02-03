#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>Struct used for a particular named instance parameter for this ParticleSystemComponent.</summary>
	[StructLayout(LayoutKind.Explicit,Size=144)]
	public partial struct FParticleSysParam
	{
		/// <summary>The name of the parameter</summary>
		[FieldOffset(0)]
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
		[FieldOffset(12)]
		public EParticleSysParamType ParamType;
		[FieldOffset(16)]
		public float Scalar;
		[FieldOffset(20)]
		public float Scalar_Low;
		[FieldOffset(24)]
		public FVector Vector;
		[FieldOffset(36)]
		public FVector Vector_Low;
		[FieldOffset(48)]
		public FColor Color;
		
	}
	
}
#endif
#endif
