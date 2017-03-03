#if WITH_GAME
#if PLATFORM_32BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class UMovieSceneCameraShakeSection
	{
		static readonly int ShakeData__Offset;
		public FMovieSceneCameraShakeSectionData ShakeData
		{
			get{ CheckIsValid();return (FMovieSceneCameraShakeSectionData)Marshal.PtrToStructure(_this.Get()+ShakeData__Offset, typeof(FMovieSceneCameraShakeSectionData));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+ShakeData__Offset, false);}
			
		}
		
		static readonly int ShakeClass__Offset;
		public TSubclassOf<UCameraShake>  ShakeClass
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + ShakeClass__Offset); return v; }
			
		}
		
		static readonly int PlayScale__Offset;
		public float PlayScale
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+PlayScale__Offset, typeof(float));}
			
		}
		
		static readonly int PlaySpace__Offset;
		public ECameraAnimPlaySpace PlaySpace
		{
			get{ CheckIsValid();return (ECameraAnimPlaySpace)Marshal.PtrToStructure(_this.Get()+PlaySpace__Offset, typeof(ECameraAnimPlaySpace));}
			
		}
		
		static readonly int UserDefinedPlaySpace__Offset;
		public FRotator UserDefinedPlaySpace
		{
			get{ CheckIsValid();return (FRotator)Marshal.PtrToStructure(_this.Get()+UserDefinedPlaySpace__Offset, typeof(FRotator));}
			
		}
		
		static UMovieSceneCameraShakeSection()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("MovieSceneCameraShakeSection");
			ShakeData__Offset=GetPropertyOffset(NativeClassPtr,"ShakeData");
			ShakeClass__Offset=GetPropertyOffset(NativeClassPtr,"ShakeClass");
			PlayScale__Offset=GetPropertyOffset(NativeClassPtr,"PlayScale");
			PlaySpace__Offset=GetPropertyOffset(NativeClassPtr,"PlaySpace");
			UserDefinedPlaySpace__Offset=GetPropertyOffset(NativeClassPtr,"UserDefinedPlaySpace");
			
		}
		
	}
	
}
#endif
#endif
