#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>Sphere shape used for collision</summary>
	[StructLayout(LayoutKind.Explicit,Size=112)]
	public partial struct FKSphereElem
	{
		[FieldOffset(32)]
		public FMatrix TM;
		/// <summary>Position of the sphere's origin</summary>
		[FieldOffset(96)]
		public FVector Center;
		/// <summary>Radius of the sphere</summary>
		[FieldOffset(108)]
		public float Radius;
		
	}
	
}
#endif
#endif
