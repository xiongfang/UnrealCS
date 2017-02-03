#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>Float curve data for one track</summary>
	[StructLayout(LayoutKind.Explicit,Size=48)]
	public partial struct FAnimCurveBase
	{
		/// <summary>
		/// Last observed name of the curve. We store this so we can recover from situations that
		/// mean the skeleton doesn't have a mapped name for our UID (such as a user saving the an
		/// animation but not the skeleton).
		/// </summary>
		[FieldOffset(0)]
		public FName LastObservedName;
		[FieldOffset(12)]
		public FSmartName Name;
		/// <summary>Curve Type Flags</summary>
		[FieldOffset(44)]
		public int CurveTypeFlags;
		
	}
	
}
#endif
#endif
