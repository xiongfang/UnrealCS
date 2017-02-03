#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>
	/// Invalidate
	/// * Single Child
	/// * Caching / Performance
	/// </summary>
	public partial class UInvalidationBox
	{
		static readonly int bCanCache__Offset;
		/// <summary>
		/// Should the invalidation panel cache the widgets?  Making this false makes it so the invalidation
		/// panel stops acting like an invalidation panel, just becomes a simple container widget.
		/// </summary>
		public bool bCanCache
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bCanCache__Offset, 1, 0, 1, 255);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bCanCache__Offset, 1,0,1,255);}
			
		}
		
		static readonly int CacheRelativeTransforms__Offset;
		/// <summary>
		/// Caches the locations for child draw elements relative to the invalidation box,
		/// this adds extra overhead to drawing them every frame.  However, in cases where
		/// the position of the invalidation boxes changes every frame this can be a big savings.
		/// </summary>
		public bool CacheRelativeTransforms
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), CacheRelativeTransforms__Offset, 1, 0, 1, 255);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), CacheRelativeTransforms__Offset, 1,0,1,255);}
			
		}
		
		static UInvalidationBox()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("InvalidationBox");
			bCanCache__Offset=GetPropertyOffset(NativeClassPtr,"bCanCache");
			CacheRelativeTransforms__Offset=GetPropertyOffset(NativeClassPtr,"CacheRelativeTransforms");
			
		}
		
	}
	
}
#endif
#endif
