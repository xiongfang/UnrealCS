using System;
namespace UnrealEngine
{
	public partial class UBrushBuilder:UObject
	{
		public FString BitmapFilename;
		
		/// <summary>localized FString that will be displayed as the name of this brush builder in the editor</summary>
		public FString ToolTip;
		
		/// <summary>If false, disabled the bad param notifications</summary>
		public bool NotifyBadParams;
		
		public FName Layer;
		
		public bool MergeCoplanars;
		
		
	}
	
}
