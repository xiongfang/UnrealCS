using System;
namespace UnrealEngine
{
	/// <summary>Capsule shape used for collision</summary>
	public partial struct FKSphylElem
	{
		/// <summary>The transform assumes the sphyl axis points down Z.</summary>
		public FMatrix TM;
		/// <summary>Position of the capsule's origin</summary>
		public FVector Center;
		/// <summary>Orientation of the capsule</summary>
		public FQuat Orientation;
		/// <summary>Radius of the capsule</summary>
		public float Radius;
		/// <summary>This is of line-segment ie. add Radius to both ends to find total length.</summary>
		public float Length;
		
	}
	
}
