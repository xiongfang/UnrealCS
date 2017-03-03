#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	[StructLayout(LayoutKind.Explicit,Size=20)]
	public partial struct FBoneReference
	{
		/// <summary>Name of bone to control. This is the main bone chain to modify from. *</summary>
		[FieldOffset(0)]
		public FName BoneName;
		
	}
	
}
#endif
#endif
