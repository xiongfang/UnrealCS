using System;
namespace UnrealEngine
{
	/// <summary>Sphere shape used for collision</summary>
	public partial struct FKSphereElem
	{
		public FMatrix TM;
		/// <summary>Position of the sphere's origin</summary>
		public FVector Center;
		/// <summary>Radius of the sphere</summary>
		public float Radius;
		
	}
	
}
