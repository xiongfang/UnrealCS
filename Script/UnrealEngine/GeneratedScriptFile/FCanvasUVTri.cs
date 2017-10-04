using System;
namespace UnrealEngine
{
	/// <summary>Simple 2d triangle with UVs</summary>
	public partial struct FCanvasUVTri
	{
		/// <summary>Position of first vertex</summary>
		public FVector2D V0_Pos;
		/// <summary>UV of first vertex</summary>
		public FVector2D V0_UV;
		/// <summary>Color of first vertex</summary>
		public FLinearColor V0_Color;
		/// <summary>Position of second vertex</summary>
		public FVector2D V1_Pos;
		/// <summary>UV of second vertex</summary>
		public FVector2D V1_UV;
		/// <summary>Color of second vertex</summary>
		public FLinearColor V1_Color;
		/// <summary>Position of third vertex</summary>
		public FVector2D V2_Pos;
		/// <summary>UV of third vertex</summary>
		public FVector2D V2_UV;
		/// <summary>Color of third vertex</summary>
		public FLinearColor V2_Color;
		
	}
	
}
