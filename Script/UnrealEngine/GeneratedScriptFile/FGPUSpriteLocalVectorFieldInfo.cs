using System;
namespace UnrealEngine
{
	/// <summary>Data needed for local vector fields.</summary>
	public partial struct FGPUSpriteLocalVectorFieldInfo
	{
		/// <summary>Local vector field to apply to this emitter.</summary>
		public UVectorField Field;
		/// <summary>Local vector field transform.</summary>
		public FTransform Transform;
		/// <summary>Minimum initial rotation.</summary>
		public FRotator MinInitialRotation;
		/// <summary>Maximum initial rotation.</summary>
		public FRotator MaxInitialRotation;
		/// <summary>Local vector field rotation rate.</summary>
		public FRotator RotationRate;
		/// <summary>Local vector field intensity.</summary>
		public float Intensity;
		/// <summary>Local vector field tightness.</summary>
		public float Tightness;
		/// <summary>Ignore Components Transform</summary>
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
