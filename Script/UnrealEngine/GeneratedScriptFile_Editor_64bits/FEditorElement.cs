#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>Each elements in the grid</summary>
	[StructLayout(LayoutKind.Explicit,Size=24)]
	public partial struct FEditorElement
	{
		[FieldOffset(0)]
		public int Indices;
		[FieldOffset(12)]
		public float Weights;
		
	}
	
}
#endif
#endif
