using System;
namespace UnrealEngine
{
	/// <summary>stores information on a viewer that actors need to be checked against for relevancy</summary>
	public partial struct FNetViewer
	{
		public UNetConnection Connection;
		/// <summary>The "controlling net object" associated with this view (typically player controller)</summary>
		public AActor InViewer;
		/// <summary>The actor that is being directly viewed, usually a pawn.  Could also be the net actor of consequence</summary>
		public AActor ViewTarget;
		/// <summary>Where the viewer is looking from</summary>
		public FVector ViewLocation;
		/// <summary>Direction the viewer is looking</summary>
		public FVector ViewDir;
		
	}
	
}
