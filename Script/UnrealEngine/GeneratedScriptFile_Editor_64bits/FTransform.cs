#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>
	/// Transform composed of Quat/Translation/Scale.
	/// The full C++ class is located here: Engine\Source\Runtime\Core\Public\Math\Transform.h
	/// </summary>
	[StructLayout(LayoutKind.Explicit,Size=48)]
	public partial struct FTransform
	{
		[FieldOffset(0)]
		public FQuat Rotation;
		[FieldOffset(16)]
		public FVector Translation;
		[FieldOffset(32)]
		public FVector Scale3D;
		
	}
	
}
#endif
#endif
