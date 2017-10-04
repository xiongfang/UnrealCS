using System;
namespace UnrealEngine
{
	public partial class UMaterialExpressionSpeedTree:UMaterialExpression
	{
		/// <summary>The type of SpeedTree geometry on which this material will be used</summary>
		public ESpeedTreeGeometryType GeometryType;
		
		/// <summary>The type of wind effect used on this tree. This can only go as high as it was in the SpeedTree Modeler, but you can set it to a lower option for lower quality wind and faster rendering.</summary>
		public ESpeedTreeWindType WindType;
		
		/// <summary>The type of LOD to use</summary>
		public ESpeedTreeLODType LODType;
		
		/// <summary>The threshold for triangles to be removed from the bilboard mesh when not facing the camera (0 = none pass, 1 = all pass).</summary>
		public float BillboardThreshold;
		
		/// <summary>Support accurate velocities from wind. This will incur extra cost per vertex.</summary>
		public bool bAccurateWindVelocities;
		
		
	}
	
}
