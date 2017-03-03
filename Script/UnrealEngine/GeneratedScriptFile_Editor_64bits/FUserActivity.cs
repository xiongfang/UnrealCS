#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>The description of a user activity</summary>
	[StructLayout(LayoutKind.Explicit,Size=24)]
	public partial struct FUserActivity
	{
		/// <summary>Describes the user's activity</summary>
		[FieldOffset(0)]
		public FString ActionName;
		
	}
	
}
#endif
#endif
