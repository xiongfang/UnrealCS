using System;
namespace UnrealEngine
{
	public partial class UPhysicsSpringComponent:USceneComponent
	{
		/// <summary>Returns the spring direction from start to resting point</summary>
		public extern FVector GetSpringDirection();
		/// <summary>Returns the spring current end point in world space.</summary>
		public extern FVector GetSpringCurrentEndPoint();
		/// <summary>Returns the spring resting point in world space.</summary>
		public extern FVector GetSpringRestingPoint();
		/// <summary>
		/// Returns the spring compression as a normalized scalar along spring direction.
		/// 0 implies spring is at rest
		/// 1 implies fully compressed
		/// </summary>
		public extern float GetNormalizedCompressionScalar();
		/// <summary>Specifies how much strength the spring has. The higher the SpringStiffness the more force the spring can push on a body with.</summary>
		public float SpringStiffness;
		
		/// <summary>Specifies how quickly the spring can absorb energy of a body. The higher the damping the less oscillation</summary>
		public float SpringDamping;
		
		/// <summary>Determines how long the spring will be along the X-axis at rest. The spring will apply 0 force on a body when it's at rest.</summary>
		public float SpringLengthAtRest;
		
		/// <summary>Determines the radius of the spring.</summary>
		public float SpringRadius;
		
		/// <summary>Strength of thrust force applied to the base object.</summary>
		public ECollisionChannel SpringChannel;
		
		/// <summary>If true, the spring will ignore all components in its own actor</summary>
		public bool bIgnoreSelf;
		
		/// <summary>The current compression of the spring. A spring at rest will have SpringCompression 0.</summary>
		public float SpringCompression;
		
		
	}
	
}
