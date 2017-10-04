using System;
namespace UnrealEngine
{
	/// <summary>Struct to hold information about the "base" object the character is standing on.</summary>
	public partial struct FBasedMovementInfo
	{
		/// <summary>Component we are based on</summary>
		public UPrimitiveComponent MovementBase;
		/// <summary>Bone name on component, for skeletal meshes. NAME_None if not a skeletal mesh or if bone is invalid.</summary>
		public FName BoneName;
		/// <summary>Location relative to MovementBase. Only valid if HasRelativeLocation() is true.</summary>
		public FVector_NetQuantize100 Location;
		/// <summary>Rotation: relative to MovementBase if HasRelativeRotation() is true, absolute otherwise.</summary>
		public FRotator Rotation;
		/// <summary>Whether the server says that there is a base. On clients, the component may not have resolved yet.</summary>
		public bool bServerHasBaseComponent;
		/// <summary>Whether rotation is relative to the base or absolute. It can only be relative if location is also relative.</summary>
		public bool bRelativeRotation;
		/// <summary>Whether there is a velocity on the server. Used for forcing replication when velocity goes to zero.</summary>
		public bool bServerHasVelocity;
		
	}
	
}
