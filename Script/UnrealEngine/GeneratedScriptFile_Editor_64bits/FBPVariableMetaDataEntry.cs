#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>One metadata entry for a variable</summary>
	[StructLayout(LayoutKind.Explicit,Size=32)]
	public partial struct FBPVariableMetaDataEntry
	{
		/// <summary>Name of metadata key</summary>
		[FieldOffset(0)]
		public FName DataKey;
		/// <summary>Name of metadata value</summary>
		[FieldOffset(16)]
		public FString DataValue;
		
	}
	
}
#endif
#endif
