#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>Box shape used for collision</summary>
	[StructLayout(LayoutKind.Explicit,Size=144)]
	public partial struct FKBoxElem
	{
		[FieldOffset(32)]
		public FMatrix TM;
		/// <summary>Position of the box's origin</summary>
		[FieldOffset(96)]
		public FVector Center;
		/// <summary>Orientation of the box</summary>
		[FieldOffset(112)]
		public FQuat Orientation;
		/// <summary>Extent of the box along the y-axis</summary>
		[FieldOffset(128)]
		public float X;
		/// <summary>Extent of the box along the y-axis</summary>
		[FieldOffset(132)]
		public float Y;
		/// <summary>Extent of the box along the z-axis</summary>
		[FieldOffset(136)]
		public float Z;
		
	}
	
}
#endif
#endif
