using System;
namespace UnrealEngine
{
	public partial class UCommandlet:UObject
	{
		/// <summary>Description of the commandlet's purpose</summary>
		public FString HelpDescription;
		
		/// <summary>Usage template to show for "ucc help"</summary>
		public FString HelpUsage;
		
		/// <summary>Hyperlink for more info</summary>
		public FString HelpWebLink;
		
		/// <summary>
		/// Whether to load objects required in server, client, and editor context.  If IsEditor is set to false, then a
		/// UGameEngine (or whatever the value of /Script/Engine.Engine.GameEngine is) will be created for the commandlet instead
		/// of a UEditorEngine (or /Script/Engine.Engine.EditorEngine), unless the commandlet overrides the CreateCustomEngine method.
		/// </summary>
		public bool IsServer;
		
		public bool IsClient;
		
		public bool IsEditor;
		
		/// <summary>Whether to redirect standard log to the console</summary>
		public bool LogToConsole;
		
		/// <summary>Whether to show standard error and warning count on exit</summary>
		public bool ShowErrorCount;
		
		
	}
	
}
