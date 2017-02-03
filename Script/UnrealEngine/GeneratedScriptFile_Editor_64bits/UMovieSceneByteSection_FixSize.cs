#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>A single byte section.</summary>
	public partial class UMovieSceneByteSection
	{
		static readonly int ByteCurve__Offset;
		/// <summary>
		/// Ordered curve data // @todo Sequencer This could be optimized by packing the bytes separately
		/// // but that may not be worth the effort
		/// </summary>
		public FIntegralCurve ByteCurve
		{
			get{ CheckIsValid();return (FIntegralCurve)Marshal.PtrToStructure(_this.Get()+ByteCurve__Offset, typeof(FIntegralCurve));}
			
		}
		
		static UMovieSceneByteSection()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("MovieSceneByteSection");
			ByteCurve__Offset=GetPropertyOffset(NativeClassPtr,"ByteCurve");
			
		}
		
	}
	
}
#endif
#endif
