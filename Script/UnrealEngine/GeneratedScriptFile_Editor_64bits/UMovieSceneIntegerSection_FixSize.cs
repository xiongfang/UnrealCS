#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>A single integer section.</summary>
	public partial class UMovieSceneIntegerSection
	{
		static readonly int IntegerCurve__Offset;
		/// <summary>Ordered curve data</summary>
		public FIntegralCurve IntegerCurve
		{
			get{ CheckIsValid();return (FIntegralCurve)Marshal.PtrToStructure(_this.Get()+IntegerCurve__Offset, typeof(FIntegralCurve));}
			
		}
		
		static UMovieSceneIntegerSection()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("MovieSceneIntegerSection");
			IntegerCurve__Offset=GetPropertyOffset(NativeClassPtr,"IntegerCurve");
			
		}
		
	}
	
}
#endif
#endif
