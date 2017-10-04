using System;
namespace UnrealEngine
{
	/// <summary>
	/// Cached camera POV info, stored as optimization so we only
	/// need to do a full camera update once per tick.
	/// </summary>
	public partial struct FCameraCacheEntry
	{
		/// <summary>World time this entry was created.</summary>
		public float TimeStamp;
		/// <summary>Camera POV to cache.</summary>
		public FMinimalViewInfo POV;
		
	}
	
}
