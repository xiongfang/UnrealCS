#if WITH_GAME
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	[StructLayout(LayoutKind.Explicit,Size=96)]
	public partial struct FExternalToolDefinition
	{
		[FieldOffset(0)]
		public FString ToolName;
		[FieldOffset(16)]
		public FFilePath ExecutablePath;
		[FieldOffset(32)]
		public FString CommandLineOptions;
		[FieldOffset(48)]
		public FDirectoryPath WorkingDirectory;
		[FieldOffset(64)]
		public FString ScriptExtension;
		[FieldOffset(80)]
		public FDirectoryPath ScriptDirectory;
		
	}
	
}
#endif
#endif
