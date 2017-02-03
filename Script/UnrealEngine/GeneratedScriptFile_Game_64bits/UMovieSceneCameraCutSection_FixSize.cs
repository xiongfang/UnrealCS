#if WITH_GAME
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class UMovieSceneCameraCutSection
	{
		static readonly int CameraGuid__Offset;
		public FGuid CameraGuid
		{
			get{ CheckIsValid();return (FGuid)Marshal.PtrToStructure(_this.Get()+CameraGuid__Offset, typeof(FGuid));}
			
		}
		
		static UMovieSceneCameraCutSection()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("MovieSceneCameraCutSection");
			CameraGuid__Offset=GetPropertyOffset(NativeClassPtr,"CameraGuid");
			
		}
		
	}
	
}
#endif
#endif
