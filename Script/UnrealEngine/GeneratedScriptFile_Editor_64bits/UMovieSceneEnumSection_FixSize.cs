#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>A single enum section.</summary>
	public partial class UMovieSceneEnumSection
	{
		static readonly int EnumCurve__Offset;
		/// <summary>
		/// Ordered curve data // @todo Sequencer This could be optimized by packing the enums separately
		/// // but that may not be worth the effort
		/// </summary>
		public FIntegralCurve EnumCurve
		{
			get{ CheckIsValid();return (FIntegralCurve)Marshal.PtrToStructure(_this.Get()+EnumCurve__Offset, typeof(FIntegralCurve));}
			
		}
		
		static UMovieSceneEnumSection()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("MovieSceneEnumSection");
			EnumCurve__Offset=GetPropertyOffset(NativeClassPtr,"EnumCurve");
			
		}
		
	}
	
}
#endif
#endif
