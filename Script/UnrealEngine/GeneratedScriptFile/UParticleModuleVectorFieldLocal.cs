using System;
namespace UnrealEngine
{
	public partial class UParticleModuleVectorFieldLocal:UParticleModuleVectorFieldBase
	{
		/// <summary>Vector field asset to use.</summary>
		public UVectorField VectorField;
		
		/// <summary>Translation of the vector field relative to the emitter.</summary>
		public FVector RelativeTranslation;
		
		/// <summary>Rotation of the vector field relative to the emitter.</summary>
		public FRotator RelativeRotation;
		
		/// <summary>Scale of the vector field relative to the emitter.</summary>
		public FVector RelativeScale3D;
		
		/// <summary>Intensity of the local vector field.</summary>
		public float Intensity;
		
		/// <summary>Tightness tweak value: 0: Force 1: Velocity.</summary>
		public float Tightness;
		
		/// <summary>Ignore component transform.</summary>
		public bool bIgnoreComponentTransform;
		
		/// <summary>Tile vector field in x axis?</summary>
		public bool bTileX;
		
		/// <summary>Tile vector field in y axis?</summary>
		public bool bTileY;
		
		/// <summary>Tile vector field in z axis?</summary>
		public bool bTileZ;
		
		/// <summary>Use fix delta time in the simulation?</summary>
		public bool bUseFixDT;
		
		
	}
	
}
