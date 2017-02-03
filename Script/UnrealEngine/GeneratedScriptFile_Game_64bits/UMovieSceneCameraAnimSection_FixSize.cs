#if WITH_GAME
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class UMovieSceneCameraAnimSection
	{
		static readonly int CameraAnim__Offset;
		public UCameraAnim CameraAnim
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + CameraAnim__Offset); if (v == IntPtr.Zero)return null; UCameraAnim retValue = new UCameraAnim(); retValue._this = v; return retValue; }
			set{ CheckIsValid(); if (value == null)Marshal.WriteIntPtr(_this.Get() + CameraAnim__Offset, IntPtr.Zero);else Marshal.WriteIntPtr(_this.Get() + CameraAnim__Offset, value._this.Get()); }
			
		}
		
		static readonly int PlayRate__Offset;
		public float PlayRate
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+PlayRate__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+PlayRate__Offset, false);}
			
		}
		
		static readonly int PlayScale__Offset;
		public float PlayScale
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+PlayScale__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+PlayScale__Offset, false);}
			
		}
		
		static readonly int BlendInTime__Offset;
		public float BlendInTime
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+BlendInTime__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+BlendInTime__Offset, false);}
			
		}
		
		static readonly int BlendOutTime__Offset;
		public float BlendOutTime
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+BlendOutTime__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+BlendOutTime__Offset, false);}
			
		}
		
		static readonly int bLooping__Offset;
		public bool bLooping
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bLooping__Offset, 1, 0, 1, 255);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bLooping__Offset, 1,0,1,255);}
			
		}
		
		static readonly int PlaySpace__Offset;
		public ECameraAnimPlaySpace PlaySpace
		{
			get{ CheckIsValid();return (ECameraAnimPlaySpace)Marshal.PtrToStructure(_this.Get()+PlaySpace__Offset, typeof(ECameraAnimPlaySpace));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+PlaySpace__Offset, false);}
			
		}
		
		static readonly int UserDefinedPlaySpace__Offset;
		public FRotator UserDefinedPlaySpace
		{
			get{ CheckIsValid();return (FRotator)Marshal.PtrToStructure(_this.Get()+UserDefinedPlaySpace__Offset, typeof(FRotator));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+UserDefinedPlaySpace__Offset, false);}
			
		}
		
		static UMovieSceneCameraAnimSection()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("MovieSceneCameraAnimSection");
			CameraAnim__Offset=GetPropertyOffset(NativeClassPtr,"CameraAnim");
			PlayRate__Offset=GetPropertyOffset(NativeClassPtr,"PlayRate");
			PlayScale__Offset=GetPropertyOffset(NativeClassPtr,"PlayScale");
			BlendInTime__Offset=GetPropertyOffset(NativeClassPtr,"BlendInTime");
			BlendOutTime__Offset=GetPropertyOffset(NativeClassPtr,"BlendOutTime");
			bLooping__Offset=GetPropertyOffset(NativeClassPtr,"bLooping");
			PlaySpace__Offset=GetPropertyOffset(NativeClassPtr,"PlaySpace");
			UserDefinedPlaySpace__Offset=GetPropertyOffset(NativeClassPtr,"UserDefinedPlaySpace");
			
		}
		
	}
	
}
#endif
#endif
