#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	[StructLayout(LayoutKind.Explicit,Size=40)]
	public partial struct FSimpleMemberReference
	{
		/// <summary>
		/// Most often the Class that this member is defined in. Could be a UPackage
		/// if it is a native delegate signature function (declared globally).
		/// </summary>
		/// <summary>Name of the member</summary>
		[FieldOffset(8)]
		public FName MemberName;
		/// <summary>The Guid of the member</summary>
		[FieldOffset(20)]
		public FGuid MemberGuid;
		
	}
	
}
#endif
#endif
