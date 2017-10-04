using System;
namespace UnrealEngine
{
	public partial class UPhysicsHandleComponent:UActorComponent
	{
		/// <summary>Set interpolation speed</summary>
		public extern void SetInterpolationSpeed(float NewInterpolationSpeed);
		/// <summary>Set angular stiffness</summary>
		public extern void SetAngularStiffness(float NewAngularStiffness);
		/// <summary>Set angular damping</summary>
		public extern void SetAngularDamping(float NewAngularDamping);
		/// <summary>Set linear stiffness</summary>
		public extern void SetLinearStiffness(float NewLinearStiffness);
		/// <summary>Set linear damping</summary>
		public extern void SetLinearDamping(float NewLinearDamping);
		/// <summary>Get the current location and rotation</summary>
		public extern void GetTargetLocationAndRotation(out FVector TargetLocation,out FRotator TargetRotation);
		/// <summary>Set target location and rotation</summary>
		public extern void SetTargetLocationAndRotation(FVector NewLocation,FRotator NewRotation);
		/// <summary>Set the target rotation</summary>
		public extern void SetTargetRotation(FRotator NewRotation);
		/// <summary>Set the target location</summary>
		public extern void SetTargetLocation(FVector NewLocation);
		/// <summary>Returns the currently grabbed component, or null if nothing is grabbed.</summary>
		public extern UPrimitiveComponent GetGrabbedComponent();
		/// <summary>Release the currently held component</summary>
		public extern virtual void ReleaseComponent();
		/// <summary>Grab the specified component at a given location and rotation. Constrains rotation.</summary>
		public extern void GrabComponentAtLocationWithRotation(UPrimitiveComponent Component,FName InBoneName,FVector Location,FRotator Rotation);
		/// <summary>Grab the specified component at a given location. Does NOT constraint rotation which means the handle will pivot about GrabLocation.</summary>
		public extern void GrabComponentAtLocation(UPrimitiveComponent Component,FName InBoneName,FVector GrabLocation);
		/// <summary>Component we are currently holding</summary>
		public UPrimitiveComponent GrabbedComponent;
		
		public bool bSoftAngularConstraint;
		
		public bool bSoftLinearConstraint;
		
		public bool bInterpolateTarget;
		
		/// <summary>Linear damping of the handle spring.</summary>
		public float LinearDamping;
		
		/// <summary>Linear stiffness of the handle spring</summary>
		public float LinearStiffness;
		
		/// <summary>Angular stiffness of the handle spring</summary>
		public float AngularDamping;
		
		/// <summary>Angular stiffness of the handle spring</summary>
		public float AngularStiffness;
		
		/// <summary>How quickly we interpolate the physics target transform</summary>
		public float InterpolationSpeed;
		
		
	}
	
}
