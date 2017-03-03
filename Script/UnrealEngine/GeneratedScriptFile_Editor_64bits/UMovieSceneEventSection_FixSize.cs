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
		public FNameCurve Events
		{
			get{ CheckIsValid();return (FNameCurve)Marshal.PtrToStructure(_this.Get()+Events__Offset, typeof(FNameCurve));}
			
		}
		
		static readonly int EventData__Offset;
		public FMovieSceneEventSectionData EventData
		{
			get{ CheckIsValid();return (FMovieSceneEventSectionData)Marshal.PtrToStructure(_this.Get()+EventData__Offset, typeof(FMovieSceneEventSectionData));}
			
		}
		
		static UMovieSceneEventSection()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("MovieSceneEventSection");
			Events__Offset=GetPropertyOffset(NativeClassPtr,"Events");
			EventData__Offset=GetPropertyOffset(NativeClassPtr,"EventData");
			
		}
		
	}
	
}
#endif
#endif
