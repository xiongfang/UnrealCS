#if WITH_GAME
#if PLATFORM_32BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	[StructLayout(LayoutKind.Explicit,Size=72)]
	public partial struct FExternalToolDefinition
	{
		[FieldOffset(0)]
		public FString ToolName;
		[FieldOffset(12)]
		public FFilePath ExecutablePath;
		[FieldOffset(24)]
		public FString CommandLineOptions;
		[FieldOffset(36)]
		public FDirectoryPath WorkingDirectory;
		[FieldOffset(48)]
		public FString ScriptExtension;
		[FieldOffset(60)]
		public FDirectoryPath ScriptDirectory;
		
	}
	
}
#endif
#endif
