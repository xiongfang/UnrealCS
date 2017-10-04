using System;
namespace UnrealEngine
{
	public partial class USoundNodeLooping:USoundNode
	{
		/// <summary>The amount of times to loop</summary>
		public int LoopCount;
		
		/// <summary>If enabled, the node will continue to loop indefinitely regardless of the Loop Count value.</summary>
		public bool bLoopIndefinitely;
		
		
	}
	
}
