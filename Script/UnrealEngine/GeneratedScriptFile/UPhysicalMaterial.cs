using System;
namespace UnrealEngine
{
	public partial class UPhysicalMaterial:UObject
	{
		/// <summary>Friction value of surface, controls how easily things can slide on this surface</summary>
		public float Friction;
		
		/// <summary>Friction combine mode, controls how friction is computed for multiple materials.</summary>
		public EFrictionCombineMode FrictionCombineMode;
		
		/// <summary>If set we will use the FrictionCombineMode of this material, instead of the FrictionCombineMode found in the project settings.</summary>
		public bool bOverrideFrictionCombineMode;
		
		/// <summary>Restitution or 'bounciness' of this surface, between 0 (no bounce) and 1 (outgoing velocity is same as incoming).</summary>
		public float Restitution;
		
		/// <summary>Restitution combine mode, controls how restitution is computed for multiple materials.</summary>
		public EFrictionCombineMode RestitutionCombineMode;
		
		/// <summary>If set we will use the RestitutionCombineMode of this material, instead of the RestitutionCombineMode found in the project settings.</summary>
		public bool bOverrideRestitutionCombineMode;
		
		/// <summary>Used with the shape of the object to calculate its mass properties. The higher the number, the heavier the object. g per cubic cm.</summary>
		public float Density;
		
		/// <summary>
		/// Used to adjust the way that mass increases as objects get larger. This is applied to the mass as calculated based on a 'solid' object.
		/// In actuality, larger objects do not tend to be solid, and become more like 'shells' (e.g. a car is not a solid piece of metal).
		/// Values are clamped to 1 or less.
		/// </summary>
		public float RaiseMassToPower;
		
		/// <summary>How much to scale the damage threshold by on any destructible we are applied to</summary>
		public float DestructibleDamageThresholdScale;
		
		/// <summary>deprecated</summary>
		public UDEPRECATED_PhysicalMaterialPropertyBase PhysicalMaterialProperty;
		
		/// <summary>To edit surface type for your project, use ProjectSettings/Physics/PhysicalSurface section</summary>
		public EPhysicalSurface SurfaceType;
		
		/// <summary>DEPRECATED - Overall tire friction scalar for every type of tire. This value is multiplied against our parents' values.</summary>
		public float TireFrictionScale;
		
		
	}
	
}
