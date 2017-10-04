using System;
namespace UnrealEngine
{
	public partial class UThrobber:UWidget
	{
		/// <summary>Sets whether the pieces animate their opacity.</summary>
		public extern void SetAnimateOpacity(bool bInAnimateOpacity);
		/// <summary>Sets whether the pieces animate vertically.</summary>
		public extern void SetAnimateVertically(bool bInAnimateVertically);
		/// <summary>Sets whether the pieces animate horizontally.</summary>
		public extern void SetAnimateHorizontally(bool bInAnimateHorizontally);
		/// <summary>Sets how many pieces there are</summary>
		public extern void SetNumberOfPieces(int InNumberOfPieces);
		/// <summary>How many pieces there are</summary>
		public int NumberOfPieces;
		
		/// <summary>Should the pieces animate horizontally?</summary>
		public bool bAnimateHorizontally;
		
		/// <summary>Should the pieces animate vertically?</summary>
		public bool bAnimateVertically;
		
		/// <summary>Should the pieces animate their opacity?</summary>
		public bool bAnimateOpacity;
		
		/// <summary>Image to use for each segment of the throbber</summary>
		public USlateBrushAsset PieceImage;
		
		public FSlateBrush Image;
		
		
	}
	
}
