using System;
namespace UnrealEngine
{
	public partial class AEmitterCameraLensEffectBase:AEmitter
	{
		/// <summary>Particle System to use</summary>
		public UParticleSystem PS_CameraEffect;
		
		/// <summary>The effect to use for non extreme content</summary>
		public UParticleSystem PS_CameraEffectNonExtremeContent;
		
		/// <summary>Camera this emitter is attached to, will be notified when emitter is destroyed</summary>
		public APlayerCameraManager BaseCamera;
		
		/// <summary>
		/// Effect-to-camera transform to allow arbitrary placement of the particle system .
		/// Note the X component of the location will be scaled with camera fov to keep the lens effect the same apparent size.
		/// </summary>
		public FTransform RelativeTransform;
		
		/// <summary>This is the assumed FOV for which the effect was authored. The code will make automatic adjustments to make it look the same at different FOVs</summary>
		public float BaseFOV;
		
		/// <summary>true if multiple instances of this emitter can exist simultaneously, false otherwise.</summary>
		public bool bAllowMultipleInstances;
		
		/// <summary>If bAllowMultipleInstances is true and this effect is retriggered, the particle system will be reset if this is true</summary>
		public bool bResetWhenRetriggered;
		
		/// <summary>DEPRECATED(4.11)</summary>
		public float DistFromCamera;
		
		
	}
	
}
