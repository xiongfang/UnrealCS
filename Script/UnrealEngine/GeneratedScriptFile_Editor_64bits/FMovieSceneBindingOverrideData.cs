#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>Movie scene binding override data</summary>
	[StructLayout(LayoutKind.Explicit,Size=28)]
	public partial struct FMovieSceneBindingOverrideData
	{
		/// <summary>Specifies the object binding to override.</summary>
		[FieldOffset(0)]
		public FMovieSceneObjectBindingPtr ObjectBindingId;
		/// <summary>Specifies whether the default assignment should remain bound (false) or if this should completely override the default binding (false).</summary>
		public bool bOverridesDefault
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 24, 1, 0, 1, 255); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 24, 1, 0, 1, 255); } }}
			
		}
		
	}
	
}
#endif
#endif
