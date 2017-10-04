using System;
namespace UnrealEngine
{
	/// <summary>
	/// A bounding box and bounding sphere with the same origin.
	/// The full C++ class is located here : Engine\Source\Runtime\Core\Public\Math\BoxSphereBounds.h
	/// </summary>
	public partial struct FBoxSphereBounds
	{
		public FVector Origin;
		public FVector BoxExtent;
		public float SphereRadius;
		
	}
	
}
