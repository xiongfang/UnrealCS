#if WITH_GAME
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class UMovieSceneCameraAnimSection
	{
		static readonly int AnimData__Offset;
		public FMovieSceneCameraAnimSectionData AnimData
		{
			get{ CheckIsValid();return (FMovieSceneCameraAnimSectionData)Marshal.PtrToStructure(_this.Get()+AnimData__Offset, typeof(FMovieSceneCameraAnimSectionData));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+AnimData__Offset, false);}
			
		}
		
		static readonly int CameraAnim__Offset;
		public UCameraAnim CameraAnim
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + CameraAnim__Offset); if (v == IntPtr.Zero)return null; UCameraAnim retValue = new UCameraAnim(); retValue._this = v; return retValue; }
			
		}
		
		static readonly int PlayRate__Offset;
		public float PlayRate
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+PlayRate__Offset, typeof(float));}
			
		}
		
		static readonly int PlayScale__Offset;
		public float PlayScale
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+PlayScale__Offset, typeof(float));}
			
		}
		
		static readonly int BlendInTime__Offset;
		public float BlendInTime
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+BlendInTime__Offset, typeof(float));}
			
		}
		
		static readonly int BlendOutTime__Offset;
		public float BlendOutTime
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+BlendOutTime__Offset, typeof(float));}
			
		}
		
		static readonly int bLooping__Offset;
		public bool bLooping
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bLooping__Offset, 1, 0, 1, 255);}
			
		}
		
		static UMovieSceneCameraAnimSection()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("MovieSceneCameraAnimSection");
			AnimData__Offset=GetPropertyOffset(NativeClassPtr,"AnimData");
			CameraAnim__Offset=GetPropertyOffset(NativeClassPtr,"CameraAnim");
			PlayRate__Offset=GetPropertyOffset(NativeClassPtr,"PlayRate");
			PlayScale__Offset=GetPropertyOffset(NativeClassPtr,"PlayScale");
			BlendInTime__Offset=GetPropertyOffset(NativeClassPtr,"BlendInTime");
			BlendOutTime__Offset=GetPropertyOffset(NativeClassPtr,"BlendOutTime");
			bLooping__Offset=GetPropertyOffset(NativeClassPtr,"bLooping");
			
		}
		
	}
	
}
#endif
#endif
