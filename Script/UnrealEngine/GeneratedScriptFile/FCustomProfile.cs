using System;
namespace UnrealEngine
{
	/// <summary>
	/// Structure for custom profiles.
	/// if you'd like to just add custom channels, not changing anything else engine defined
	/// if you'd like to override all about profile, please use
	/// +Profiles=(Name=NameOfProfileYouLikeToOverwrite,....)
	/// </summary>
	public partial struct FCustomProfile
	{
		public FName Name;
		
	}
	
}
