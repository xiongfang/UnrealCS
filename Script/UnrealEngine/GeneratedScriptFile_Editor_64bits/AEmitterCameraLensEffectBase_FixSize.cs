#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class AEmitterCameraLensEffectBase
	{
		static readonly int PS_CameraEffect__Offset;
		/// <summary>Particle System to use</summary>
		public UParticleSystem PS_CameraEffect
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + PS_CameraEffect__Offset); if (v == IntPtr.Zero)return null; UParticleSystem retValue = new UParticleSystem(); retValue._this = v; return retValue; }
			set{ CheckIsValid(); if (value == null)Marshal.WriteIntPtr(_this.Get() + PS_CameraEffect__Offset, IntPtr.Zero);else Marshal.WriteIntPtr(_this.Get() + PS_CameraEffect__Offset, value._this.Get()); }
			
		}
		
		static readonly int PS_CameraEffectNonExtremeContent__Offset;
		/// <summary>The effect to use for non extreme content</summary>
		public UParticleSystem PS_CameraEffectNonExtremeContent
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + PS_CameraEffectNonExtremeContent__Offset); if (v == IntPtr.Zero)return null; UParticleSystem retValue = new UParticleSystem(); retValue._this = v; return retValue; }
			
		}
		
		static readonly int BaseCamera__Offset;
		/// <summary>Camera this emitter is attached to, will be notified when emitter is destroyed</summary>
		public APlayerCameraManager BaseCamera
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + BaseCamera__Offset); if (v == IntPtr.Zero)return null; APlayerCameraManager retValue = new APlayerCameraManager(); retValue._this = v; return retValue; }
			
		}
		
		static readonly int RelativeTransform__Offset;
		/// <summary>
		/// Effect-to-camera transform to allow arbitrary placement of the particle system .
		/// Note the X component of the location will be scaled with camera fov to keep the lens effect the same apparent size.
		/// </summary>
		public FTransform RelativeTransform
		{
			get{ CheckIsValid();return (FTransform)Marshal.PtrToStructure(_this.Get()+RelativeTransform__Offset, typeof(FTransform));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+RelativeTransform__Offset, false);}
			
		}
		
		static readonly int BaseFOV__Offset;
		/// <summary>This is the assumed FOV for which the effect was authored. The code will make automatic adjustments to make it look the same at different FOVs</summary>
		public float BaseFOV
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+BaseFOV__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+BaseFOV__Offset, false);}
			
		}
		
		static readonly int bAllowMultipleInstances__Offset;
		/// <summary>true if multiple instances of this emitter can exist simultaneously, false otherwise.</summary>
		public bool bAllowMultipleInstances
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bAllowMultipleInstances__Offset, 1, 0, 1, 1);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bAllowMultipleInstances__Offset, 1,0,1,1);}
			
		}
		
		static readonly int bResetWhenRetriggered__Offset;
		/// <summary>If bAllowMultipleInstances is true and this effect is retriggered, the particle system will be reset if this is true</summary>
		public bool bResetWhenRetriggered
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bResetWhenRetriggered__Offset, 1, 0, 2, 2);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bResetWhenRetriggered__Offset, 1,0,2,2);}
			
		}
		
		static readonly int EmittersToTreatAsSame__Offset;
		/// <summary>
		/// If an emitter class in this array is currently playing, do not play this effect.
		/// Useful for preventing multiple similar or expensive camera effects from playing simultaneously.
		/// </summary>
		public TObjectArray<UClass>  EmittersToTreatAsSame
		{
					get{ CheckIsValid();return new TObjectArray<UClass>((FScriptArray)Marshal.PtrToStructure(_this.Get()+EmittersToTreatAsSame__Offset, typeof(FScriptArray)));}
					set{ CheckIsValid();Marshal.StructureToPtr(value.InterArray, _this.Get()+EmittersToTreatAsSame__Offset, false);}
			
		}
		
		static readonly int DistFromCamera__Offset;
		/// <summary>DEPRECATED(4.11)</summary>
		public float DistFromCamera
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+DistFromCamera__Offset, typeof(float));}
			
		}
		
		static AEmitterCameraLensEffectBase()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("EmitterCameraLensEffectBase");
			PS_CameraEffect__Offset=GetPropertyOffset(NativeClassPtr,"PS_CameraEffect");
			PS_CameraEffectNonExtremeContent__Offset=GetPropertyOffset(NativeClassPtr,"PS_CameraEffectNonExtremeContent");
			BaseCamera__Offset=GetPropertyOffset(NativeClassPtr,"BaseCamera");
			RelativeTransform__Offset=GetPropertyOffset(NativeClassPtr,"RelativeTransform");
			BaseFOV__Offset=GetPropertyOffset(NativeClassPtr,"BaseFOV");
			bAllowMultipleInstances__Offset=GetPropertyOffset(NativeClassPtr,"bAllowMultipleInstances");
			bResetWhenRetriggered__Offset=GetPropertyOffset(NativeClassPtr,"bResetWhenRetriggered");
			EmittersToTreatAsSame__Offset=GetPropertyOffset(NativeClassPtr,"EmittersToTreatAsSame");
			DistFromCamera__Offset=GetPropertyOffset(NativeClassPtr,"DistFromCamera");
			
		}
		
	}
	
}
#endif
#endif
