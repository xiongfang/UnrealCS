#if WITH_GAME
#if PLATFORM_32BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class UMovieSceneEnumSection
	{
		static readonly int EnumCurve__Offset;
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
