#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>Implements a cinematic shot section.</summary>
	public partial class UMovieSceneCinematicShotSection
	{
		static readonly int DisplayName__Offset;
		/// <summary>The Shot's display name</summary>
		public string DisplayName
		{
			get{ CheckIsValid(); return ((FText)Marshal.PtrToStructure(_this.Get()+DisplayName__Offset, typeof(FText))).ToString();}
			
		}
		
		static readonly int ThumbnailReferenceOffset__Offset;
		/// <summary>The shot's reference frame offset for single thumbnail rendering</summary>
		public float ThumbnailReferenceOffset
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+ThumbnailReferenceOffset__Offset, typeof(float));}
			
		}
		
		static UMovieSceneCinematicShotSection()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("MovieSceneCinematicShotSection");
			DisplayName__Offset=GetPropertyOffset(NativeClassPtr,"DisplayName");
			ThumbnailReferenceOffset__Offset=GetPropertyOffset(NativeClassPtr,"ThumbnailReferenceOffset");
			
		}
		
	}
	
}
#endif
#endif
