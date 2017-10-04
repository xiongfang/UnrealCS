using System;
namespace UnrealEngine
{
	/// <summary>
	/// Container for describing various types of netdrivers available to the engine
	/// The engine will try to construct a netdriver of a given type and, failing that,
	/// the fallback version.
	/// </summary>
	public partial struct FNetDriverDefinition
	{
		/// <summary>Unique name of this net driver definition</summary>
		public FName DefName;
		/// <summary>Class name of primary net driver</summary>
		public FName DriverClassName;
		/// <summary>Class name of the fallback net driver if the main net driver class fails to initialize</summary>
		public FName DriverClassNameFallback;
		
	}
	
}
