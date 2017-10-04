using System;
namespace UnrealEngine
{
	public partial class APostProcessVolume:AVolume
	{
		/// <summary>Post process settings to use for this volume.</summary>
		public FPostProcessSettings Settings;
		
		/// <summary>
		/// Priority of this volume. In the case of overlapping volumes the one with the highest priority
		/// overrides the lower priority ones. The order is undefined if two or more overlapping volumes have the same priority.
		/// </summary>
		public float Priority;
		
		/// <summary>World space radius around the volume that is used for blending (only if not unbound).</summary>
		public float BlendRadius;
		
		/// <summary>0:no effect, 1:full effect</summary>
		public float BlendWeight;
		
		/// <summary>Whether this volume is enabled or not.</summary>
		public bool bEnabled;
		
		/// <summary>Whether this volume bounds are used or it affects the whole world.</summary>
		public bool bUnbound;
		
		
	}
	
}
