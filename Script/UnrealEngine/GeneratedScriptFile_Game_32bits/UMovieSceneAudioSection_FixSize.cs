#if WITH_GAME
#if PLATFORM_32BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class UMovieSceneAudioSection
	{
		static readonly int Sound__Offset;
		public USoundBase Sound
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + Sound__Offset); if (v == IntPtr.Zero)return null; USoundBase retValue = new USoundBase(); retValue._this = v; return retValue; }
			set{ CheckIsValid(); if (value == null)Marshal.WriteIntPtr(_this.Get() + Sound__Offset, IntPtr.Zero);else Marshal.WriteIntPtr(_this.Get() + Sound__Offset, value._this.Get()); }
			
		}
		
		static readonly int AudioStartTime__Offset;
		public float AudioStartTime
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+AudioStartTime__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+AudioStartTime__Offset, false);}
			
		}
		
		static readonly int AudioDilationFactor__Offset;
		public float AudioDilationFactor
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+AudioDilationFactor__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+AudioDilationFactor__Offset, false);}
			
		}
		
		static readonly int AudioVolume__Offset;
		public float AudioVolume
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+AudioVolume__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+AudioVolume__Offset, false);}
			
		}
		
		static UMovieSceneAudioSection()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("MovieSceneAudioSection");
			Sound__Offset=GetPropertyOffset(NativeClassPtr,"Sound");
			AudioStartTime__Offset=GetPropertyOffset(NativeClassPtr,"AudioStartTime");
			AudioDilationFactor__Offset=GetPropertyOffset(NativeClassPtr,"AudioDilationFactor");
			AudioVolume__Offset=GetPropertyOffset(NativeClassPtr,"AudioVolume");
			
		}
		
	}
	
}
#endif
#endif
