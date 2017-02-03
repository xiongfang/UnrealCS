#if WITH_GAME
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class UParticleModuleTypeDataGpu
	{
		static readonly int EmitterInfo__Offset;
		public FGPUSpriteEmitterInfo EmitterInfo
		{
			get{ CheckIsValid();return (FGPUSpriteEmitterInfo)Marshal.PtrToStructure(_this.Get()+EmitterInfo__Offset, typeof(FGPUSpriteEmitterInfo));}
			
		}
		
		static readonly int ResourceData__Offset;
		public FGPUSpriteResourceData ResourceData
		{
			get{ CheckIsValid();return (FGPUSpriteResourceData)Marshal.PtrToStructure(_this.Get()+ResourceData__Offset, typeof(FGPUSpriteResourceData));}
			
		}
		
		static readonly int CameraMotionBlurAmount__Offset;
		public float CameraMotionBlurAmount
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+CameraMotionBlurAmount__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+CameraMotionBlurAmount__Offset, false);}
			
		}
		
		static readonly int bClearExistingParticlesOnInit__Offset;
		public bool bClearExistingParticlesOnInit
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bClearExistingParticlesOnInit__Offset, 1, 0, 1, 1);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bClearExistingParticlesOnInit__Offset, 1,0,1,1);}
			
		}
		
		static UParticleModuleTypeDataGpu()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("ParticleModuleTypeDataGpu");
			EmitterInfo__Offset=GetPropertyOffset(NativeClassPtr,"EmitterInfo");
			ResourceData__Offset=GetPropertyOffset(NativeClassPtr,"ResourceData");
			CameraMotionBlurAmount__Offset=GetPropertyOffset(NativeClassPtr,"CameraMotionBlurAmount");
			bClearExistingParticlesOnInit__Offset=GetPropertyOffset(NativeClassPtr,"bClearExistingParticlesOnInit");
			
		}
		
	}
	
}
#endif
#endif
