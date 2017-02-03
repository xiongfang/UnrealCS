#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>Struct used to specify the property name of the component to constrain</summary>
	[StructLayout(LayoutKind.Explicit,Size=12)]
	public partial struct FConstrainComponentPropName
	{
		/// <summary>Name of property</summary>
		[FieldOffset(0)]
		public FName ComponentName;
		
	}
	
}
#endif
#endif
