using System;
namespace UnrealEngine
{
	/// <summary>Structure for defining an external tool</summary>
	public partial struct FExternalToolDefinition
	{
		/// <summary>The name of the tool / test.</summary>
		public FString ToolName;
		/// <summary>The executable to run.</summary>
		public FFilePath ExecutablePath;
		/// <summary>The command line options to pass to the executable.</summary>
		public FString CommandLineOptions;
		/// <summary>The working directory for the new process.</summary>
		public FDirectoryPath WorkingDirectory;
		/// <summary>If set, look for scripts with this extension.</summary>
		public FString ScriptExtension;
		/// <summary>If the ScriptExtension is set, look here for the script files.</summary>
		public FDirectoryPath ScriptDirectory;
		
	}
	
}
