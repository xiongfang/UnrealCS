using System;
namespace UnrealEngine
{
	public partial class UInvalidationBox:UContentWidget
	{
		public extern void SetCanCache(bool CanCache);
		public extern bool GetCanCache();
		public extern void InvalidateCache();
		/// <summary>
		/// Should the invalidation panel cache the widgets?  Making this false makes it so the invalidation
		/// panel stops acting like an invalidation panel, just becomes a simple container widget.
		/// </summary>
		public bool bCanCache;
		
		/// <summary>
		/// Caches the locations for child draw elements relative to the invalidation box,
		/// this adds extra overhead to drawing them every frame.  However, in cases where
		/// the position of the invalidation boxes changes every frame this can be a big savings.
		/// </summary>
		public bool CacheRelativeTransforms;
		
		
	}
	
}
