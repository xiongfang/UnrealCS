using System;
namespace UnrealEngine
{
	/// <summary>Box shape used for collision</summary>
	public partial struct FKBoxElem
	{
		public FMatrix TM;
		/// <summary>Position of the box's origin</summary>
		public FVector Center;
		/// <summary>Orientation of the box</summary>
		public FQuat Orientation;
		/// <summary>Extent of the box along the y-axis</summary>
		public float X;
		/// <summary>Extent of the box along the y-axis</summary>
		public float Y;
		/// <summary>Extent of the box along the z-axis</summary>
		public float Z;
		
	}
	
}
