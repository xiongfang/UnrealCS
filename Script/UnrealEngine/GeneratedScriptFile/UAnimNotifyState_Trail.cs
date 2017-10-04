using System;
namespace UnrealEngine
{
	public partial class UAnimNotifyState_Trail:UAnimNotifyState
	{
		/// <summary>The particle system to use for this trail.</summary>
		public UParticleSystem PSTemplate;
		
		/// <summary>Name of the first socket defining this trail.</summary>
		public FName FirstSocketName;
		
		/// <summary>Name of the second socket defining this trail.</summary>
		public FName SecondSocketName;
		
		/// <summary>
		/// Controls the way width scale is applied. In each method a width scale of 1.0 will mean the width is unchanged from the position of the sockets. A width scale of 0.0 will cause a trail of zero width.
		/// From Centre = Trail width is scaled outwards from the centre point between the two sockets.
		/// From First = Trail width is scaled outwards from the position of the first socket.
		/// From Second = Trail width is scaled outwards from the position of the Second socket.
		/// </summary>
		public ETrailWidthMode WidthScaleMode;
		
		/// <summary>Name of the curve to drive the width scale.</summary>
		public FName WidthScaleCurve;
		
		public bool bRecycleSpawnedSystems;
		
		/// <summary>If true, render the trail geometry (this should typically be on)</summary>
		public bool bRenderGeometry;
		
		/// <summary>If true, render stars at each spawned particle point along the trail</summary>
		public bool bRenderSpawnPoints;
		
		/// <summary>If true, render a line showing the tangent at each spawned particle point along the trail</summary>
		public bool bRenderTangents;
		
		/// <summary>If true, render the tessellated path between spawned particles</summary>
		public bool bRenderTessellation;
		
		
	}
	
}
