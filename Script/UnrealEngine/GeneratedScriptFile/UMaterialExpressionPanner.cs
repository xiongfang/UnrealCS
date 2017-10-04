using System;
namespace UnrealEngine
{
	public partial class UMaterialExpressionPanner:UMaterialExpression
	{
		/// <summary>Defaults to 'ConstCoordinate' if not specified</summary>
		public FExpressionInput Coordinate;
		
		/// <summary>Defaults to Game Time if not specified</summary>
		public FExpressionInput Time;
		
		/// <summary>Vector2 speed scale, if specified</summary>
		public FExpressionInput Speed;
		
		public float SpeedX;
		
		public float SpeedY;
		
		/// <summary>only used if Coordinate is not hooked up</summary>
		public uint ConstCoordinate;
		
		/// <summary>
		/// Output only the fractional part of the pan calculation for greater precision.
		/// Output is greater than or equal to 0 and less than 1.
		/// </summary>
		public bool bFractionalPart;
		
		
	}
	
}
