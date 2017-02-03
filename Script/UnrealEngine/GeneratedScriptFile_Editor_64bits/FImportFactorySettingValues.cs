#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>Holds UProperty names and values to customize factory settings</summary>
	[StructLayout(LayoutKind.Explicit,Size=32)]
	public partial struct FImportFactorySettingValues
	{
		/// <summary>Name of the property to change.  Nested settings can be modified using "Outer.Property</summary>
		[FieldOffset(0)]
		public FString SettingName;
		/// <summary>Value to import for the specified property.</summary>
		[FieldOffset(16)]
		public FString Value;
		
	}
	
}
#endif
#endif
