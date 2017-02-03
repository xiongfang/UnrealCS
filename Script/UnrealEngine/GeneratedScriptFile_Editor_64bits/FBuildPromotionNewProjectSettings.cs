#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>Holds settings for the new project stage of the build promotion test</summary>
	[StructLayout(LayoutKind.Explicit,Size=32)]
	public partial struct FBuildPromotionNewProjectSettings
	{
		/// <summary>The path for the new project</summary>
		[FieldOffset(0)]
		public FDirectoryPath NewProjectFolderOverride;
		/// <summary>The name of the project *</summary>
		[FieldOffset(16)]
		public FString NewProjectNameOverride;
		
	}
	
}
#endif
#endif
