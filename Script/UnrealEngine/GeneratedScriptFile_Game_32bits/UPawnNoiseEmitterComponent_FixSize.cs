#if WITH_GAME
#if PLATFORM_32BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class UPawnNoiseEmitterComponent
	{
		static readonly int bAIPerceptionSystemCompatibilityMode__Offset;
		public bool bAIPerceptionSystemCompatibilityMode
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bAIPerceptionSystemCompatibilityMode__Offset, 1, 0, 1, 1);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bAIPerceptionSystemCompatibilityMode__Offset, 1,0,1,1);}
			
		}
		
		static readonly int LastRemoteNoisePosition__Offset;
		public FVector LastRemoteNoisePosition
		{
			get{ CheckIsValid();return (FVector)Marshal.PtrToStructure(_this.Get()+LastRemoteNoisePosition__Offset, typeof(FVector));}
			
		}
		
		static readonly int NoiseLifetime__Offset;
		public float NoiseLifetime
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+NoiseLifetime__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+NoiseLifetime__Offset, false);}
			
		}
		
		static readonly int LastRemoteNoiseVolume__Offset;
		public float LastRemoteNoiseVolume
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+LastRemoteNoiseVolume__Offset, typeof(float));}
			
		}
		
		static readonly int LastRemoteNoiseTime__Offset;
		public float LastRemoteNoiseTime
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+LastRemoteNoiseTime__Offset, typeof(float));}
			
		}
		
		static readonly int LastLocalNoiseVolume__Offset;
		public float LastLocalNoiseVolume
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+LastLocalNoiseVolume__Offset, typeof(float));}
			
		}
		
		static readonly int LastLocalNoiseTime__Offset;
		public float LastLocalNoiseTime
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+LastLocalNoiseTime__Offset, typeof(float));}
			
		}
		
		static UPawnNoiseEmitterComponent()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("PawnNoiseEmitterComponent");
			bAIPerceptionSystemCompatibilityMode__Offset=GetPropertyOffset(NativeClassPtr,"bAIPerceptionSystemCompatibilityMode");
			LastRemoteNoisePosition__Offset=GetPropertyOffset(NativeClassPtr,"LastRemoteNoisePosition");
			NoiseLifetime__Offset=GetPropertyOffset(NativeClassPtr,"NoiseLifetime");
			LastRemoteNoiseVolume__Offset=GetPropertyOffset(NativeClassPtr,"LastRemoteNoiseVolume");
			LastRemoteNoiseTime__Offset=GetPropertyOffset(NativeClassPtr,"LastRemoteNoiseTime");
			LastLocalNoiseVolume__Offset=GetPropertyOffset(NativeClassPtr,"LastLocalNoiseVolume");
			LastLocalNoiseTime__Offset=GetPropertyOffset(NativeClassPtr,"LastLocalNoiseTime");
			
		}
		
	}
	
}
#endif
#endif
