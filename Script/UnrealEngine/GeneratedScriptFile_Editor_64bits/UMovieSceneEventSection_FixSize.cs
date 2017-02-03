#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>Implements a section in movie scene event tracks.</summary>
	public partial class UMovieSceneEventSection
	{
		static readonly int Events__Offset;
		/// <summary>The section's keys.</summary>
		public FNameCurve Events
		{
			get{ CheckIsValid();return (FNameCurve)Marshal.PtrToStructure(_this.Get()+Events__Offset, typeof(FNameCurve));}
			
		}
		
		static UMovieSceneEventSection()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("MovieSceneEventSection");
			Events__Offset=GetPropertyOffset(NativeClassPtr,"Events");
			
		}
		
	}
	
}
#endif
#endif
