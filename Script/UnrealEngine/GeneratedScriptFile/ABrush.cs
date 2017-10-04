using System;
namespace UnrealEngine
{
	public partial class ABrush:AActor
	{
		/// <summary>Type of brush</summary>
		public EBrushType BrushType;
		
		/// <summary>Information.</summary>
		public FColor BrushColor;
		
		public int PolyFlags;
		
		public bool bColored;
		
		public bool bSolidWhenSelected;
		
		/// <summary>If true, this brush class can be placed using the class browser like other simple class types</summary>
		public bool bPlaceableFromClassBrowser;
		
		/// <summary>If true, this brush is a builder or otherwise does not need to be loaded into the game</summary>
		public bool bNotForClientOrServer;
		
		public UModel Brush;
		
		public UBrushComponent BrushComponent;
		
		public UBrushBuilder BrushBuilder;
		
		/// <summary>Flag set when we are in a manipulation (scaling, translation, brush builder param change etc.)</summary>
		public bool bInManipulation;
		
		
	}
	
}
