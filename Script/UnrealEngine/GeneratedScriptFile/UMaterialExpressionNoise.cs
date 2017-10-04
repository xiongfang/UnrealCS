using System;
namespace UnrealEngine
{
	public partial class UMaterialExpressionNoise:UMaterialExpression
	{
		/// <summary>2 to 3 dimensional vector</summary>
		public FExpressionInput Position;
		
		/// <summary>scalar, to clamp the Levels at pixel level, can be computed like this: max(length(ddx(Position)), length(ddy(Position))</summary>
		public FExpressionInput FilterWidth;
		
		/// <summary>can also be done with a multiply on the Position</summary>
		public float Scale;
		
		/// <summary>Lower numbers are faster and lower quality, higher numbers are slower and higher quality</summary>
		public int Quality;
		
		/// <summary>Noise function, affects performance and look</summary>
		public ENoiseFunction NoiseFunction;
		
		/// <summary>How multiple frequencies are getting combined</summary>
		public bool bTurbulence;
		
		/// <summary>1 = fast but little detail, .. larger numbers cost more performance</summary>
		public int Levels;
		
		public float OutputMin;
		
		public float OutputMax;
		
		/// <summary>usually 2 but higher values allow efficient use of few levels</summary>
		public float LevelScale;
		
		/// <summary>Whether to use tiling noise pattern, useful for baking to seam-free repeating textures</summary>
		public bool bTiling;
		
		/// <summary>How many units in each tile (if Tiling is on)</summary>
		public uint RepeatSize;
		
		
	}
	
}
