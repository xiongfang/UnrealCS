#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>Capsule shape used for collision</summary>
	[StructLayout(LayoutKind.Explicit,Size=144)]
	public partial struct FKSphylElem
	{
		/// <summary>The transform assumes the sphyl axis points down Z.</summary>
		[FieldOffset(32)]
		public FMatrix TM;
		/// <summary>Position of the capsule's origin</summary>
		[FieldOffset(96)]
		public FVector Center;
		/// <summary>Orientation of the capsule</summary>
		[FieldOffset(112)]
		public FQuat Orientation;
		/// <summary>Radius of the capsule</summary>
		[FieldOffset(128)]
		public float Radius;
		/// <summary>This is of line-segment ie. add Radius to both ends to find total length.</summary>
		[FieldOffset(132)]
		public float Length;
		
	}
	
}
#endif
#endif
