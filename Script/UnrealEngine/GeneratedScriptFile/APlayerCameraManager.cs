using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine{
public partial class APlayerCameraManager:AActor 
{
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void StopAllCameraAnims(IntPtr _this,int bImmediate);
/// <summary>
/// Stop playing all CameraAnims on this CameraManager.
/// @param bImmediate    True to stop it right now and ignore blend out, false to let it blend out as indicated.
/// </summary>
public  void StopAllCameraAnims(bool bImmediate=false)
{
	CheckIsValid();
	StopAllCameraAnims(_this.Get(),bImmediate?1:0);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void StopCameraAnimInst(IntPtr _this,IntPtr AnimInst,int bImmediate);
/// <summary>
/// Stops the given CameraAnimInst from playing.  The given pointer should be considered invalid after this.
/// @param bImmediate    True to stop it right now and ignore blend out, false to let it blend out as indicated.
/// </summary>
public  void StopCameraAnimInst(UCameraAnimInst AnimInst,bool bImmediate=false)
{
	CheckIsValid();
	StopCameraAnimInst(_this.Get(),AnimInst,bImmediate?1:0);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void StopAllInstancesOfCameraAnim(IntPtr _this,IntPtr Anim,int bImmediate);
/// <summary>
/// Stop playing all instances of the indicated CameraAnim.
/// @param bImmediate    True to stop it right now and ignore blend out, false to let it blend out as indicated.
/// </summary>
public  void StopAllInstancesOfCameraAnim(UCameraAnim Anim,bool bImmediate=false)
{
	CheckIsValid();
	StopAllInstancesOfCameraAnim(_this.Get(),Anim,bImmediate?1:0);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static IntPtr PlayCameraAnim(IntPtr _this,IntPtr Anim,float Rate,float Scale,float BlendInTime,float BlendOutTime,int bLoop,int bRandomStartTime,float Duration,int PlaySpace,ref FRotator UserPlaySpaceRot);
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
public  UCameraAnimInst PlayCameraAnim(UCameraAnim Anim,float Rate=1.000000f,float Scale=1.000000f,float BlendInTime=0.000000f,float BlendOutTime=0.000000f,bool bLoop=false,bool bRandomStartTime=false,float Duration=0.000000f,ECameraAnimPlaySpace PlaySpace=ECameraAnimPlaySpace.CameraLocal,FRotator UserPlaySpaceRot=default(FRotator))
{
	CheckIsValid();
	IntPtr ___ret = PlayCameraAnim(_this.Get(),Anim,Rate,Scale,BlendInTime,BlendOutTime,bLoop?1:0,bRandomStartTime?1:0,Duration,(int)PlaySpace,ref UserPlaySpaceRot);
	if(___ret==IntPtr.Zero) return null; UCameraAnimInst ___ret2= new UCameraAnimInst(){ _this = ___ret }; return ___ret2;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SetManualCameraFade(IntPtr _this,float InFadeAmount,ref FLinearColor Color,int bInFadeAudio);
/// <summary>
/// Turns on camera fading at the given opacity. Does not auto-animate, allowing user to animate themselves.
/// Call StopCameraFade to turn fading back off.
/// </summary>
public  void SetManualCameraFade(float InFadeAmount,FLinearColor Color,bool bInFadeAudio)
{
	CheckIsValid();
	SetManualCameraFade(_this.Get(),InFadeAmount,ref Color,bInFadeAudio?1:0);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void StopCameraFade(IntPtr _this);
/// <summary>Stops camera fading.</summary>
public  void StopCameraFade()
{
	CheckIsValid();
	StopCameraFade(_this.Get());
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void StartCameraFade(IntPtr _this,float FromAlpha,float ToAlpha,float Duration,ref FLinearColor Color,int bShouldFadeAudio,int bHoldWhenFinished);
/// <summary>
/// Does a camera fade to/from a solid color.  Animates automatically.
/// @param FromAlpha - Alpha at which to begin the fade. Range [0..1], where 0 is fully transparent and 1 is fully opaque solid color.
/// @param ToAlpha - Alpha at which to finish the fade.
/// @param Duration - How long the fade should take, in seconds.
/// @param Color - Color to fade to/from.
/// @param bShouldFadeAudio - True to fade audio volume along with the alpha of the solid color.
/// @param bHoldWhenFinished - True for fade to hold at the ToAlpha until explicitly stopped (e.g. with StopCameraFade)
/// </summary>
public  void StartCameraFade(float FromAlpha,float ToAlpha,float Duration,FLinearColor Color,bool bShouldFadeAudio=false,bool bHoldWhenFinished=false)
{
	CheckIsValid();
	StartCameraFade(_this.Get(),FromAlpha,ToAlpha,Duration,ref Color,bShouldFadeAudio?1:0,bHoldWhenFinished?1:0);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void StopAllCameraShakes(IntPtr _this,int bImmediately);
/// <summary>Stops all active camera shakes on this camera.</summary>
public  void StopAllCameraShakes(bool bImmediately=true)
{
	CheckIsValid();
	StopAllCameraShakes(_this.Get(),bImmediately?1:0);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void StopAllInstancesOfCameraShake(IntPtr _this,IntPtr Shake,int bImmediately);
/// <summary>Stops playing CameraShake of the given class.</summary>
public  void StopAllInstancesOfCameraShake(TSubclassOf<UCameraShake>  Shake,bool bImmediately=true)
{
	CheckIsValid();
	StopAllInstancesOfCameraShake(_this.Get(),Shake.NativeClass,bImmediately?1:0);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void StopCameraShake(IntPtr _this,IntPtr ShakeInstance,int bImmediately);
/// <summary>Immediately stops the given shake instance and invalidates it.</summary>
public  void StopCameraShake(UCameraShake ShakeInstance,bool bImmediately=true)
{
	CheckIsValid();
	StopCameraShake(_this.Get(),ShakeInstance,bImmediately?1:0);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static IntPtr PlayCameraShake(IntPtr _this,IntPtr ShakeClass,float Scale,int PlaySpace,ref FRotator UserPlaySpaceRot);
/// <summary>
/// Plays a camera shake on this camera.
/// @param Shake - The class of camera shake to play.
/// @param Scale - Scalar defining how "intense" to play the shake. 1.0 is normal (as authored).
/// @param PlaySpace - Which coordinate system to play the shake in (affects oscillations and camera anims)
/// @param UserPlaySpaceRot - Coordinate system to play shake when PlaySpace == CAPS_UserDefined.
/// </summary>
public  UCameraShake PlayCameraShake(TSubclassOf<UCameraShake>  ShakeClass,float Scale=1.000000f,ECameraAnimPlaySpace PlaySpace=ECameraAnimPlaySpace.CameraLocal,FRotator UserPlaySpaceRot=default(FRotator))
{
	CheckIsValid();
	IntPtr ___ret = PlayCameraShake(_this.Get(),ShakeClass.NativeClass,Scale,(int)PlaySpace,ref UserPlaySpaceRot);
	if(___ret==IntPtr.Zero) return null; UCameraShake ___ret2= new UCameraShake(){ _this = ___ret }; return ___ret2;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void ClearCameraLensEffects(IntPtr _this);
/// <summary>Removes all camera lens effects.</summary>
public  void ClearCameraLensEffects()
{
	CheckIsValid();
	ClearCameraLensEffects(_this.Get());
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void RemoveCameraLensEffect(IntPtr _this,IntPtr Emitter);
/// <summary>
/// Removes the given lens effect from the camera.
/// @param Emitter - the emitter actor to remove from the camera
/// </summary>
public  void RemoveCameraLensEffect(AEmitterCameraLensEffectBase Emitter)
{
	CheckIsValid();
	RemoveCameraLensEffect(_this.Get(),Emitter);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static IntPtr AddCameraLensEffect(IntPtr _this,IntPtr LensEffectEmitterClass);
/// <summary>
/// Creates a camera lens effect of the given class on this camera.
/// @param LensEffectEmitterClass - Class of lens effect emitter to create.
/// @return Returns the new emitter actor.
/// </summary>
public  AEmitterCameraLensEffectBase AddCameraLensEffect(TSubclassOf<AEmitterCameraLensEffectBase>  LensEffectEmitterClass)
{
	CheckIsValid();
	IntPtr ___ret = AddCameraLensEffect(_this.Get(),LensEffectEmitterClass.NativeClass);
	if(___ret==IntPtr.Zero) return null; AEmitterCameraLensEffectBase ___ret2= new AEmitterCameraLensEffectBase(){ _this = ___ret }; return ___ret2;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static FVector GetCameraLocation(IntPtr _this);
/// <summary>@return Returns camera's current location.</summary>
public  FVector GetCameraLocation()
{
	CheckIsValid();
	FVector ___ret = GetCameraLocation(_this.Get());
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static FRotator GetCameraRotation(IntPtr _this);
/// <summary>@return Returns camera's current rotation.</summary>
public  FRotator GetCameraRotation()
{
	CheckIsValid();
	FRotator ___ret = GetCameraRotation(_this.Get());
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static float GetFOVAngle(IntPtr _this);
/// <summary>@return Returns the camera's current full FOV angle, in degrees.</summary>
public  float GetFOVAngle()
{
	CheckIsValid();
	float ___ret = GetFOVAngle(_this.Get());
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static int RemoveCameraModifier(IntPtr _this,IntPtr ModifierToRemove);
/// <summary>
/// Removes the given camera modifier from this camera (if it's on the camera in the first place) and discards it.
/// @return True if successfully removed, false otherwise.
/// </summary>
public  bool RemoveCameraModifier(UCameraModifier ModifierToRemove)
{
	CheckIsValid();
	int ___ret = RemoveCameraModifier(_this.Get(),ModifierToRemove);
	return ___ret!=0;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static IntPtr FindCameraModifierByClass(IntPtr _this,IntPtr ModifierClass);
/// <summary>
/// Returns camera modifier for this camera of the given class, if it exists.
/// Exact class match only. If there are multiple modifiers of the same class, the first one is returned.
/// </summary>
public  UCameraModifier FindCameraModifierByClass(TSubclassOf<UCameraModifier>  ModifierClass)
{
	CheckIsValid();
	IntPtr ___ret = FindCameraModifierByClass(_this.Get(),ModifierClass.NativeClass);
	if(___ret==IntPtr.Zero) return null; UCameraModifier ___ret2= new UCameraModifier(){ _this = ___ret }; return ___ret2;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static IntPtr AddNewCameraModifier(IntPtr _this,IntPtr ModifierClass);
/// <summary>
/// Creates and initializes a new camera modifier of the specified class.
/// @param ModifierClass - The class of camera modifier to create.
/// @return Returns the newly created camera modifier.
/// </summary>
public  UCameraModifier AddNewCameraModifier(TSubclassOf<UCameraModifier>  ModifierClass)
{
	CheckIsValid();
	IntPtr ___ret = AddNewCameraModifier(_this.Get(),ModifierClass.NativeClass);
	if(___ret==IntPtr.Zero) return null; UCameraModifier ___ret2= new UCameraModifier(){ _this = ___ret }; return ___ret2;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static IntPtr GetOwningPlayerController(IntPtr _this);
/// <summary>Returns the PlayerController that owns this camera.</summary>
public  APlayerController GetOwningPlayerController()
{
	CheckIsValid();
	IntPtr ___ret = GetOwningPlayerController(_this.Get());
	if(___ret==IntPtr.Zero) return null; APlayerController ___ret2= new APlayerController(){ _this = ___ret }; return ___ret2;
	
}
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	public extern static new IntPtr StaticClass();
}
}
