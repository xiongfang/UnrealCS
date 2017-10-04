using System;
namespace UnrealEngine
{
	public partial struct FSimpleMemberReference
	{
		/// <summary>
		/// Most often the Class that this member is defined in. Could be a UPackage
		/// if it is a native delegate signature function (declared globally).
		/// </summary>
		public UObject MemberParent;
		/// <summary>Name of the member</summary>
		public FName MemberName;
		/// <summary>The Guid of the member</summary>
		public FGuid MemberGuid;
		
	}
	
}
