#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>A single changed Blueprint component property.</summary>
	[StructLayout(LayoutKind.Explicit,Size=24)]
	public partial struct FBlueprintComponentChangedPropertyInfo
	{
		/// <summary>The name of the changed property.</summary>
		[FieldOffset(0)]
		public FName PropertyName;
		/// <summary>The array index of the changed property.</summary>
		[FieldOffset(12)]
		public int ArrayIndex;
		/// <summary>The parent struct (owner) of the changed property.</summary>
		
	}
	
}
#endif
#endif
