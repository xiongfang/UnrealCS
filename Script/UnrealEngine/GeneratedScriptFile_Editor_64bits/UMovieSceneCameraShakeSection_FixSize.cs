#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class UMovieSceneCameraShakeSection
	{
		static readonly int ShakeClass__Offset;
		/// <summary>Class of the camera shake to play</summary>
		public TSubclassOf<UCameraShake>  ShakeClass
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + ShakeClass__Offset); return v; }
			set{ CheckIsValid(); Marshal.WriteIntPtr(_this.Get() + ShakeClass__Offset, value); }
			
		}
		
		static readonly int PlayScale__Offset;
		/// <summary>Scalar that affects shake intensity</summary>
		public float PlayScale
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+PlayScale__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+PlayScale__Offset, false);}
			
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
		
		static UMovieSceneCameraShakeSection()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("MovieSceneCameraShakeSection");
			ShakeClass__Offset=GetPropertyOffset(NativeClassPtr,"ShakeClass");
			PlayScale__Offset=GetPropertyOffset(NativeClassPtr,"PlayScale");
			PlaySpace__Offset=GetPropertyOffset(NativeClassPtr,"PlaySpace");
			UserDefinedPlaySpace__Offset=GetPropertyOffset(NativeClassPtr,"UserDefinedPlaySpace");
			
		}
		
	}
	
}
#endif
#endif
