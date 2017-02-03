#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>
	/// This is used for redirecting old name to new name
	/// We use manually parsing array, but that makes harder to modify from property setting
	/// So adding this USTRUCT to support it properly
	/// </summary>
	[StructLayout(LayoutKind.Explicit,Size=24)]
	public partial struct FRedirector
	{
		[FieldOffset(0)]
		public FName OldName;
		/// <summary>Types of objects that this physics objects will collide with.</summary>
		[FieldOffset(12)]
		public FName NewName;
		
	}
	
}
#endif
#endif
