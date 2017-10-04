using System;
namespace UnrealEngine
{
	public partial class UParticleModuleLocationPrimitiveBase:UParticleModuleLocationBase
	{
		/// <summary>Whether the positive X axis is valid for spawning.</summary>
		public bool Positive_X;
		
		/// <summary>Whether the positive Y axis is valid for spawning.</summary>
		public bool Positive_Y;
		
		/// <summary>Whether the positive Z axis is valid for spawning.</summary>
		public bool Positive_Z;
		
		/// <summary>Whether the negative X axis is valid for spawning.</summary>
		public bool Negative_X;
		
		/// <summary>Whether the negative Y axis is valid for spawning.</summary>
		public bool Negative_Y;
		
		/// <summary>Whether the negative Zaxis is valid for spawning.</summary>
		public bool Negative_Z;
		
		/// <summary>Whether particles will only spawn on the surface of the primitive.</summary>
		public bool SurfaceOnly;
		
		/// <summary>Whether the particle should get its velocity from the position within the primitive.</summary>
		public bool Velocity;
		
		/// <summary>The scale applied to the velocity. (Only used if 'Velocity' is checked).</summary>
		public FRawDistributionFloat VelocityScale;
		
		/// <summary>The location of the bounding primitive relative to the position of the emitter.</summary>
		public FRawDistributionVector StartLocation;
		
		
	}
	
}
