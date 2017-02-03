#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>Structure for defining an external tool</summary>
	[StructLayout(LayoutKind.Explicit,Size=96)]
	public partial struct FExternalToolDefinition
	{
		/// <summary>The name of the tool / test.</summary>
		[FieldOffset(0)]
		public FString ToolName;
		/// <summary>The executable to run.</summary>
		[FieldOffset(16)]
		public FFilePath ExecutablePath;
		/// <summary>The command line options to pass to the executable.</summary>
		[FieldOffset(32)]
		public FString CommandLineOptions;
		/// <summary>The working directory for the new process.</summary>
		[FieldOffset(48)]
		public FDirectoryPath WorkingDirectory;
		/// <summary>If set, look for scripts with this extension.</summary>
		[FieldOffset(64)]
		public FString ScriptExtension;
		/// <summary>If the ScriptExtension is set, look here for the script files.</summary>
		[FieldOffset(80)]
		public FDirectoryPath ScriptDirectory;
		
	}
	
}
#endif
#endif
