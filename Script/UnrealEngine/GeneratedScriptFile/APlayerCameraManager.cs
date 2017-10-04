using System;
namespace UnrealEngine
{
	public partial class APlayerCameraManager:AActor
	{
		/// <summary>
		/// Stop playing all CameraAnims on this CameraManager.
		/// @param bImmediate    True to stop it right now and ignore blend out, false to let it blend out as indicated.
		/// </summary>
		public extern virtual void StopAllCameraAnims(bool bImmediate=false);
		/// <summary>
		/// Stops the given CameraAnimInst from playing.  The given pointer should be considered invalid after this.
		/// @param bImmediate    True to stop it right now and ignore blend out, false to let it blend out as indicated.
		/// </summary>
		public extern virtual void StopCameraAnimInst(UCameraAnimInst AnimInst,bool bImmediate=false);
		/// <summary>
		/// Stop playing all instances of the indicated CameraAnim.
		/// @param bImmediate    True to stop it right now and ignore blend out, false to let it blend out as indicated.
		/// </summary>
		public extern virtual void StopAllInstancesOfCameraAnim(UCameraAnim Anim,bool bImmediate=false);
		/// <summary>
		/// Play the indicated CameraAnim on this camera.
		/// @param Anim The animation that should play on this instance.
		/// @param Rate                          How fast to play the animation. 1.0 is normal.
		/// @param Scale                         How "intense" to play the animation. 1.0 is normal.
		/// @param BlendInTime           Time to linearly ramp in.
		/// @param BlendOutTime          Time to linearly ramp out.
		/// @param bLoop                         True to loop the animation if it hits the end.
		/// @param bRandomStartTime      Whether or not to choose a random time to start playing. Useful with bLoop=true and a duration to randomize things like shakes.
		/// @param Duration                      Optional total playtime for this animation, including blends. 0 means to use animations natural duration, or infinite if looping.
		/// @param PlaySpace                     Which space to play the animation in.
		/// @param UserPlaySpaceRot  Custom play space, used when PlaySpace is UserDefined.
		/// @return The CameraAnim instance, which can be stored to manipulate/stop the anim after the fact.
		/// </summary>
		public extern virtual UCameraAnimInst PlayCameraAnim(UCameraAnim Anim,float Rate=1.000000f,float Scale=1.000000f,float BlendInTime=0.000000f,float BlendOutTime=0.000000f,bool bLoop=false,bool bRandomStartTime=false,float Duration=0.000000f,ECameraAnimPlaySpace PlaySpace=ECameraAnimPlaySpace.CameraLocal,FRotator UserPlaySpaceRot=default(FRotator));
		/// <summary>
		/// Turns on camera fading at the given opacity. Does not auto-animate, allowing user to animate themselves.
		/// Call StopCameraFade to turn fading back off.
		/// </summary>
		public extern virtual void SetManualCameraFade(float InFadeAmount,FLinearColor Color,bool bInFadeAudio);
		/// <summary>Stops camera fading.</summary>
		public extern virtual void StopCameraFade();
		/// <summary>
		/// Does a camera fade to/from a solid color.  Animates automatically.
		/// @param FromAlpha - Alpha at which to begin the fade. Range [0..1], where 0 is fully transparent and 1 is fully opaque solid color.
		/// @param ToAlpha - Alpha at which to finish the fade.
		/// @param Duration - How long the fade should take, in seconds.
		/// @param Color - Color to fade to/from.
		/// @param bShouldFadeAudio - True to fade audio volume along with the alpha of the solid color.
		/// @param bHoldWhenFinished - True for fade to hold at the ToAlpha until explicitly stopped (e.g. with StopCameraFade)
		/// </summary>
		public extern virtual void StartCameraFade(float FromAlpha,float ToAlpha,float Duration,FLinearColor Color,bool bShouldFadeAudio=false,bool bHoldWhenFinished=false);
		/// <summary>Stops all active camera shakes on this camera.</summary>
		public extern virtual void StopAllCameraShakes(bool bImmediately=true);
		/// <summary>Stops playing CameraShake of the given class.</summary>
		public extern virtual void StopAllInstancesOfCameraShake(TSubclassOf<UCameraShake>  Shake,bool bImmediately=true);
		/// <summary>Immediately stops the given shake instance and invalidates it.</summary>
		public extern virtual void StopCameraShake(UCameraShake ShakeInstance,bool bImmediately=true);
		/// <summary>
		/// Plays a camera shake on this camera.
		/// @param Shake - The class of camera shake to play.
		/// @param Scale - Scalar defining how "intense" to play the shake. 1.0 is normal (as authored).
		/// @param PlaySpace - Which coordinate system to play the shake in (affects oscillations and camera anims)
		/// @param UserPlaySpaceRot - Coordinate system to play shake when PlaySpace == CAPS_UserDefined.
		/// </summary>
		public extern virtual UCameraShake PlayCameraShake(TSubclassOf<UCameraShake>  ShakeClass,float Scale=1.000000f,ECameraAnimPlaySpace PlaySpace=ECameraAnimPlaySpace.CameraLocal,FRotator UserPlaySpaceRot=default(FRotator));
		/// <summary>Removes all camera lens effects.</summary>
		public extern virtual void ClearCameraLensEffects();
		/// <summary>
		/// Removes the given lens effect from the camera.
		/// @param Emitter - the emitter actor to remove from the camera
		/// </summary>
		public extern virtual void RemoveCameraLensEffect(AEmitterCameraLensEffectBase Emitter);
		/// <summary>
		/// Creates a camera lens effect of the given class on this camera.
		/// @param LensEffectEmitterClass - Class of lens effect emitter to create.
		/// @return Returns the new emitter actor.
		/// </summary>
		public extern virtual AEmitterCameraLensEffectBase AddCameraLensEffect(TSubclassOf<AEmitterCameraLensEffectBase>  LensEffectEmitterClass);
		/// <summary>@return Returns camera's current location.</summary>
		public extern FVector GetCameraLocation();
		/// <summary>@return Returns camera's current rotation.</summary>
		public extern FRotator GetCameraRotation();
		/// <summary>@return Returns the camera's current full FOV angle, in degrees.</summary>
		public extern virtual float GetFOVAngle();
		/// <summary>
		/// Removes the given camera modifier from this camera (if it's on the camera in the first place) and discards it.
		/// @return True if successfully removed, false otherwise.
		/// </summary>
		public extern virtual bool RemoveCameraModifier(UCameraModifier ModifierToRemove);
		/// <summary>
		/// Returns camera modifier for this camera of the given class, if it exists.
		/// Exact class match only. If there are multiple modifiers of the same class, the first one is returned.
		/// </summary>
		public extern virtual UCameraModifier FindCameraModifierByClass(TSubclassOf<UCameraModifier>  ModifierClass);
		/// <summary>
		/// Creates and initializes a new camera modifier of the specified class.
		/// @param ModifierClass - The class of camera modifier to create.
		/// @return Returns the newly created camera modifier.
		/// </summary>
		public extern virtual UCameraModifier AddNewCameraModifier(TSubclassOf<UCameraModifier>  ModifierClass);
		/// <summary>Returns the PlayerController that owns this camera.</summary>
		public extern virtual APlayerController GetOwningPlayerController();
		/// <summary>PlayerController that owns this Camera actor</summary>
		public APlayerController PCOwner;
		
		public USceneComponent TransformComponent;
		
		/// <summary>FOV to use by default.</summary>
		public float DefaultFOV;
		
		/// <summary>The default desired width (in world units) of the orthographic view (ignored in Perspective mode)</summary>
		public float DefaultOrthoWidth;
		
		/// <summary>Default aspect ratio</summary>
		public float DefaultAspectRatio;
		
		/// <summary>Cached camera properties.</summary>
		public FCameraCacheEntry CameraCache;
		
		/// <summary>Cached camera properties, one frame old.</summary>
		public FCameraCacheEntry LastFrameCameraCache;
		
		/// <summary>Current ViewTarget</summary>
		public FTViewTarget ViewTarget;
		
		/// <summary>Pending view target for blending</summary>
		public FTViewTarget PendingViewTarget;
		
		/// <summary>Distance to place free camera from view target (used in certain CameraStyles)</summary>
		public float FreeCamDistance;
		
		/// <summary>Offset to Z free camera position (used in certain CameraStyles)</summary>
		public FVector FreeCamOffset;
		
		/// <summary>Offset to view target (used in certain CameraStyles)</summary>
		public FVector ViewTargetOffset;
		
		/// <summary>Cached ref to modifier for code-driven screen shakes</summary>
		public UCameraModifier_CameraShake CachedCameraShakeMod;
		
		/// <summary>Internal pool of camera anim instance objects available for playing camera animations. Defines the max number of camera anims that can play simultaneously.</summary>
		public UCameraAnimInst AnimInstPool;
		
		/// <summary>Internal. Receives the output of individual camera animations.</summary>
		public ACameraActor AnimCameraActor;
		
		/// <summary>True when this camera should use an orthographic perspective instead of FOV</summary>
		public bool bIsOrthographic;
		
		/// <summary>True if server will use camera positions replicated from the client instead of calculating them locally.</summary>
		public bool bUseClientSideCameraUpdates;
		
		/// <summary>Minimum view pitch, in degrees.</summary>
		public float ViewPitchMin;
		
		/// <summary>Maximum view pitch, in degrees.</summary>
		public float ViewPitchMax;
		
		/// <summary>Minimum view yaw, in degrees.</summary>
		public float ViewYawMin;
		
		/// <summary>Maximum view yaw, in degrees.</summary>
		public float ViewYawMax;
		
		/// <summary>Minimum view roll, in degrees.</summary>
		public float ViewRollMin;
		
		/// <summary>Maximum view roll, in degrees.</summary>
		public float ViewRollMax;
		
		
	}
	
}
