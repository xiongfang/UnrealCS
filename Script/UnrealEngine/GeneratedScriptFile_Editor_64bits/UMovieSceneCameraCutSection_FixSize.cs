#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>Movie CameraCuts are sections on the CameraCuts track, that show what the viewer "sees"</summary>
	public partial class UMovieSceneCameraCutSection
	{
		static readonly int CameraGuid__Offset;
		/// <summary>The camera possessable or spawnable that this movie CameraCut uses</summary>
		public FGuid CameraGuid
		{
			get{ CheckIsValid();return (FGuid)Marshal.PtrToStructure(_this.Get()+CameraGuid__Offset, typeof(FGuid));}
			
		}
		
		static readonly int ThumbnailReferenceOffset__Offset;
		/// <summary>The reference frame offset for single thumbnail rendering</summary>
		public float ThumbnailReferenceOffset
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+ThumbnailReferenceOffset__Offset, typeof(float));}
			
		}
		
		static UMovieSceneCameraCutSection()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("MovieSceneCameraCutSection");
			CameraGuid__Offset=GetPropertyOffset(NativeClassPtr,"CameraGuid");
			ThumbnailReferenceOffset__Offset=GetPropertyOffset(NativeClassPtr,"ThumbnailReferenceOffset");
			
		}
		
	}
	
}
#endif
#endif
