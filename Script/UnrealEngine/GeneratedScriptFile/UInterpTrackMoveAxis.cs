using System;
namespace UnrealEngine
{
	public partial class UInterpTrackMoveAxis:UInterpTrackFloatBase
	{
		/// <summary>The axis which this track will use when transforming an actor</summary>
		public EInterpMoveAxis MoveAxis;
		
		/// <summary>Lookup track to use when looking at different groups for transform information</summary>
		public FInterpLookupTrack LookupTrack;
		
		
	}
	
}
