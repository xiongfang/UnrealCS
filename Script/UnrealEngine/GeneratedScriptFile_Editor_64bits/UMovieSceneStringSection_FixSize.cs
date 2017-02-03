#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>A single string section</summary>
	public partial class UMovieSceneStringSection
	{
		static readonly int StringCurve__Offset;
		/// <summary>Curve data</summary>
		public FStringCurve StringCurve
		{
			get{ CheckIsValid();return (FStringCurve)Marshal.PtrToStructure(_this.Get()+StringCurve__Offset, typeof(FStringCurve));}
			
		}
		
		static UMovieSceneStringSection()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("MovieSceneStringSection");
			StringCurve__Offset=GetPropertyOffset(NativeClassPtr,"StringCurve");
			
		}
		
	}
	
}
#endif
#endif
