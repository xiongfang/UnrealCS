using System;
namespace UnrealEngine
{
	public partial class UMaterialExpressionBumpOffset:UMaterialExpression
	{
		/// <summary>Defaults to 'ConstCoordinate' if not specified</summary>
		public FExpressionInput Coordinate;
		
		public FExpressionInput Height;
		
		public FExpressionInput HeightRatioInput;
		
		public float HeightRatio;
		
		/// <summary>Perceived height as a fraction of width.</summary>
		public float ReferencePlane;
		
		/// <summary>only used if Coordinate is not hooked up</summary>
		public uint ConstCoordinate;
		
		
	}
	
}
