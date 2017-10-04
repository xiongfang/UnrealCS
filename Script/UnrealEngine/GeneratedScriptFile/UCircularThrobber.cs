using System;
namespace UnrealEngine
{
	public partial class UCircularThrobber:UWidget
	{
		/// <summary>Sets the radius of the circle.</summary>
		public extern void SetRadius(float InRadius);
		/// <summary>Sets the amount of time for a full circle (in seconds).</summary>
		public extern void SetPeriod(float InPeriod);
		/// <summary>Sets how many pieces there are.</summary>
		public extern void SetNumberOfPieces(int InNumberOfPieces);
		/// <summary>How many pieces there are</summary>
		public int NumberOfPieces;
		
		/// <summary>The amount of time for a full circle (in seconds)</summary>
		public float Period;
		
		/// <summary>The radius of the circle. If the throbber is a child of Canvas Panel, the 'Size to Content' option must be enabled in order to set Radius.</summary>
		public float Radius;
		
		/// <summary>Image to use for each segment of the throbber</summary>
		public USlateBrushAsset PieceImage;
		
		public FSlateBrush Image;
		
		public bool bEnableRadius;
		
		
	}
	
}
