using System;
namespace UnrealEngine
{
	/// <summary>One convex hull, used for simplified collision.</summary>
	public partial struct FKConvexElem
	{
		/// <summary>Bounding box of this convex hull.</summary>
		public FBox ElemBox;
		/// <summary>Transform of this element</summary>
		public FTransform Transform;
		
	}
	
}
