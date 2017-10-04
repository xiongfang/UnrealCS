using System;
namespace UnrealEngine
{
	/// <summary>
	/// This is used for redirecting old name to new name
	/// We use manually parsing array, but that makes harder to modify from property setting
	/// So adding this USTRUCT to support it properly
	/// </summary>
	public partial struct FRedirector
	{
		public FName OldName;
		/// <summary>Types of objects that this physics objects will collide with.</summary>
		public FName NewName;
		
	}
	
}
