using System;
namespace UnrealEngine
{
	public partial struct FAudioQualitySettings
	{
		public FText DisplayName;
		/// <summary>
		/// The number of audio channels that can be used at once
		/// NOTE: Some platforms may cap this value to a lower setting regardless of what the settings request
		/// </summary>
		public int MaxChannels;
		
	}
	
}
