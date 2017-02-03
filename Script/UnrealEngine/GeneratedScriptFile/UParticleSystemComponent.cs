using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine{
public partial class UParticleSystemComponent:UPrimitiveComponent 
{
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void GenerateParticleEvent(IntPtr _this,string InEventName,float InEmitterTime,ref FVector InLocation,ref FVector InDirection,ref FVector InVelocity);
/// <summary>
/// Record a kismet event.
/// @param  InEventName                             The name of the event that fired.
/// @param  InEmitterTime                   The emitter time when the event fired.
/// @param  InLocation                              The location of the particle when the event fired.
/// @param  InVelocity                              The velocity of the particle when the event fired.
/// @param  InNormal                                Normal vector of the collision in coordinate system of the returner. Zero=none.
/// </summary>
public  void GenerateParticleEvent(string InEventName,float InEmitterTime,FVector InLocation,FVector InDirection,FVector InVelocity)
{
	CheckIsValid();
	GenerateParticleEvent(_this.Get(),InEventName,InEmitterTime,ref InLocation,ref InDirection,ref InVelocity);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static IntPtr GetNamedMaterial(IntPtr _this,string InName);
/// <summary>Returns a named material. If this named material is not found, returns NULL.</summary>
public  UMaterialInterface GetNamedMaterial(string InName)
{
	CheckIsValid();
	IntPtr ___ret = GetNamedMaterial(_this.Get(),InName);
	if(___ret==IntPtr.Zero) return null; UMaterialInterface ___ret2= new UMaterialInterface(){ _this = ___ret }; return ___ret2;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static IntPtr CreateNamedDynamicMaterialInstance(IntPtr _this,string InName,IntPtr SourceMaterial);
/// <summary>
/// Creates a Dynamic Material Instance for the specified named material override, optionally from the supplied material.
/// @param Name - The slot name of the material to replace.  If invalid, the material is unchanged and NULL is returned.
/// </summary>
public  UMaterialInstanceDynamic CreateNamedDynamicMaterialInstance(string InName,UMaterialInterface SourceMaterial)
{
	CheckIsValid();
	IntPtr ___ret = CreateNamedDynamicMaterialInstance(_this.Get(),InName,SourceMaterial);
	if(___ret==IntPtr.Zero) return null; UMaterialInstanceDynamic ___ret2= new UMaterialInstanceDynamic(){ _this = ___ret }; return ___ret2;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SetTrailSourceData(IntPtr _this,string InFirstSocketName,string InSecondSocketName,int InWidthMode,float InWidth);
/// <summary>
/// Sets the defining data for all trails in this component.
/// @param        InFirstSocketName       The name of the first socket for the trail.
/// @param        InSecondSocketName      The name of the second socket for the trail.
/// @param        InWidthMode                     How the width value is applied to the trail.
/// @param        InWidth                         The width of the trail.
/// </summary>
public  void SetTrailSourceData(string InFirstSocketName,string InSecondSocketName,ETrailWidthMode InWidthMode,float InWidth)
{
	CheckIsValid();
	SetTrailSourceData(_this.Get(),InFirstSocketName,InSecondSocketName,(int)InWidthMode,InWidth);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void EndTrails(IntPtr _this);
/// <summary>Ends all trail emitters in this component.</summary>
public  void EndTrails()
{
	CheckIsValid();
	EndTrails(_this.Get());
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void BeginTrails(IntPtr _this,string InFirstSocketName,string InSecondSocketName,int InWidthMode,float InWidth);
/// <summary>
/// Begins all trail emitters in this component.
/// @param        InFirstSocketName       The name of the first socket for the trail.
/// @param        InSecondSocketName      The name of the second socket for the trail.
/// @param        InWidthMode                     How the width value is applied to the trail.
/// @param        InWidth                         The width of the trail.
/// </summary>
public  void BeginTrails(string InFirstSocketName,string InSecondSocketName,ETrailWidthMode InWidthMode,float InWidth)
{
	CheckIsValid();
	BeginTrails(_this.Get(),InFirstSocketName,InSecondSocketName,(int)InWidthMode,InWidth);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static int GetNumActiveParticles(IntPtr _this);
/// <summary>Get the current number of active particles in this system</summary>
public  int GetNumActiveParticles()
{
	CheckIsValid();
	int ___ret = GetNumActiveParticles(_this.Get());
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SetTemplate(IntPtr _this,IntPtr NewTemplate);
/// <summary>Change the ParticleSystem used by this ParticleSystemComponent</summary>
public  void SetTemplate(UParticleSystem NewTemplate)
{
	CheckIsValid();
	SetTemplate(_this.Get(),NewTemplate);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SetMaterialParameter(IntPtr _this,string ParameterName,IntPtr Param);
/// <summary>
/// Set a named material instance parameter on this ParticleSystemComponent.
/// Updates the parameter if it already exists, or creates a new entry if not.
/// </summary>
public  void SetMaterialParameter(string ParameterName,UMaterialInterface Param)
{
	CheckIsValid();
	SetMaterialParameter(_this.Get(),ParameterName,Param);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SetActorParameter(IntPtr _this,string ParameterName,IntPtr Param);
/// <summary>
/// Set a named actor instance parameter on this ParticleSystemComponent.
/// Updates the parameter if it already exists, or creates a new entry if not.
/// </summary>
public  void SetActorParameter(string ParameterName,AActor Param)
{
	CheckIsValid();
	SetActorParameter(_this.Get(),ParameterName,Param);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SetColorParameter(IntPtr _this,string ParameterName,ref FLinearColor Param);
/// <summary>
/// Set a named color instance parameter on this ParticleSystemComponent.
/// Updates the parameter if it already exists, or creates a new entry if not.
/// </summary>
public  void SetColorParameter(string ParameterName,FLinearColor Param)
{
	CheckIsValid();
	SetColorParameter(_this.Get(),ParameterName,ref Param);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SetVectorParameter(IntPtr _this,string ParameterName,ref FVector Param);
/// <summary>
/// Set a named vector instance parameter on this ParticleSystemComponent.
/// Updates the parameter if it already exists, or creates a new entry if not.
/// </summary>
public  void SetVectorParameter(string ParameterName,FVector Param)
{
	CheckIsValid();
	SetVectorParameter(_this.Get(),ParameterName,ref Param);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SetFloatParameter(IntPtr _this,string ParameterName,float Param);
/// <summary>Change a named float parameter</summary>
public  void SetFloatParameter(string ParameterName,float Param)
{
	CheckIsValid();
	SetFloatParameter(_this.Get(),ParameterName,Param);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SetEmitterEnable(IntPtr _this,string EmitterName,int bNewEnableState);
/// <summary>
/// Enables/Disables a sub-emitter
/// @param  EmitterName                     The name of the sub-emitter to set it on
/// @param  bNewEnableState         The value to set it to
/// </summary>
public  void SetEmitterEnable(string EmitterName,bool bNewEnableState)
{
	CheckIsValid();
	SetEmitterEnable(_this.Get(),EmitterName,bNewEnableState?1:0);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static int GetBeamTargetStrength(IntPtr _this,int EmitterIndex,int TargetIndex,out float OutTargetStrength);
/// <summary>
/// Get the beam target strength
/// @param  EmitterIndex            The index of the emitter to get
/// @param  TargetIndex                     Which beam within the emitter to get
/// @param  OutTargetStrength       Value of target tangent
/// @return true            EmitterIndex and TargetIndex are valid - OutTargetStrength is valid
///                 false           EmitterIndex or TargetIndex is invalid - OutTargetStrength is invalid
/// </summary>
public  bool GetBeamTargetStrength(int EmitterIndex,int TargetIndex,out float OutTargetStrength)
{
	CheckIsValid();
	int ___ret = GetBeamTargetStrength(_this.Get(),EmitterIndex,TargetIndex,out OutTargetStrength);
	return ___ret!=0;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static int GetBeamTargetTangent(IntPtr _this,int EmitterIndex,int TargetIndex,out FVector OutTangentPoint);
/// <summary>
/// Get the beam target tangent
/// @param  EmitterIndex            The index of the emitter to get
/// @param  TargetIndex                     Which beam within the emitter to get
/// @param  OutTangentPoint         Value of target tangent
/// @return true            EmitterIndex and TargetIndex are valid - OutTangentPoint is valid
///                 false           EmitterIndex or TargetIndex is invalid - OutTangentPoint is invalid
/// </summary>
public  bool GetBeamTargetTangent(int EmitterIndex,int TargetIndex,out FVector OutTangentPoint)
{
	CheckIsValid();
	int ___ret = GetBeamTargetTangent(_this.Get(),EmitterIndex,TargetIndex,out OutTangentPoint);
	return ___ret!=0;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static int GetBeamTargetPoint(IntPtr _this,int EmitterIndex,int TargetIndex,out FVector OutTargetPoint);
/// <summary>
/// Get the beam target point
/// @param  EmitterIndex            The index of the emitter to get
/// @param  TargetIndex                     Which beam within the emitter to get
/// @param  OutTargetPoint          Value of target point
/// @return true            EmitterIndex and TargetIndex are valid - OutTargetPoint is valid
///                 false           EmitterIndex or TargetIndex is invalid - OutTargetPoint is invalid
/// </summary>
public  bool GetBeamTargetPoint(int EmitterIndex,int TargetIndex,out FVector OutTargetPoint)
{
	CheckIsValid();
	int ___ret = GetBeamTargetPoint(_this.Get(),EmitterIndex,TargetIndex,out OutTargetPoint);
	return ___ret!=0;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static int GetBeamSourceStrength(IntPtr _this,int EmitterIndex,int SourceIndex,out float OutSourceStrength);
/// <summary>
/// Get the beam source strength
/// @param  EmitterIndex            The index of the emitter to get
/// @param  SourceIndex                     Which beam within the emitter to get
/// @param  OutSourceStrength               Value of source tangent
/// @return true            EmitterIndex and SourceIndex are valid - OutSourceStrength is valid
///                 false           EmitterIndex or SourceIndex is invalid - OutSourceStrength is invalid
/// </summary>
public  bool GetBeamSourceStrength(int EmitterIndex,int SourceIndex,out float OutSourceStrength)
{
	CheckIsValid();
	int ___ret = GetBeamSourceStrength(_this.Get(),EmitterIndex,SourceIndex,out OutSourceStrength);
	return ___ret!=0;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static int GetBeamSourceTangent(IntPtr _this,int EmitterIndex,int SourceIndex,out FVector OutTangentPoint);
/// <summary>
/// Get the beam source tangent
/// @param  EmitterIndex            The index of the emitter to get
/// @param  SourceIndex                     Which beam within the emitter to get
/// @param  OutTangentPoint         Value of source tangent
/// @return true            EmitterIndex and SourceIndex are valid - OutTangentPoint is valid
///                 false           EmitterIndex or SourceIndex is invalid - OutTangentPoint is invalid
/// </summary>
public  bool GetBeamSourceTangent(int EmitterIndex,int SourceIndex,out FVector OutTangentPoint)
{
	CheckIsValid();
	int ___ret = GetBeamSourceTangent(_this.Get(),EmitterIndex,SourceIndex,out OutTangentPoint);
	return ___ret!=0;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static int GetBeamSourcePoint(IntPtr _this,int EmitterIndex,int SourceIndex,out FVector OutSourcePoint);
/// <summary>
/// Get the beam source point
/// @param  EmitterIndex            The index of the emitter to get
/// @param  SourceIndex                     Which beam within the emitter to get
/// @param  OutSourcePoint          Value of source point
/// @return true            EmitterIndex and SourceIndex are valid - OutSourcePoint is valid
///                 false           EmitterIndex or SourceIndex is invalid - OutSourcePoint is invalid
/// </summary>
public  bool GetBeamSourcePoint(int EmitterIndex,int SourceIndex,out FVector OutSourcePoint)
{
	CheckIsValid();
	int ___ret = GetBeamSourcePoint(_this.Get(),EmitterIndex,SourceIndex,out OutSourcePoint);
	return ___ret!=0;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static int GetBeamEndPoint(IntPtr _this,int EmitterIndex,out FVector OutEndPoint);
/// <summary>
/// Get the beam end point
/// @param  EmitterIndex            The index of the emitter to get the value of
/// @return true            EmitterIndex is valid and End point is set - OutEndPoint is valid
///                 false           EmitterIndex invalid or End point is not set - OutEndPoint is invalid
/// </summary>
public  bool GetBeamEndPoint(int EmitterIndex,out FVector OutEndPoint)
{
	CheckIsValid();
	int ___ret = GetBeamEndPoint(_this.Get(),EmitterIndex,out OutEndPoint);
	return ___ret!=0;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SetBeamTargetStrength(IntPtr _this,int EmitterIndex,float NewTargetStrength,int TargetIndex);
/// <summary>
/// Set the beam target strength
/// @param  EmitterIndex            The index of the emitter to set it on
/// @param  NewTargetStrength       The value to set it to
/// @param  TargetIndex                     Which beam within the emitter to set it on
/// </summary>
public  void SetBeamTargetStrength(int EmitterIndex,float NewTargetStrength,int TargetIndex)
{
	CheckIsValid();
	SetBeamTargetStrength(_this.Get(),EmitterIndex,NewTargetStrength,TargetIndex);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SetBeamTargetTangent(IntPtr _this,int EmitterIndex,ref FVector NewTangentPoint,int TargetIndex);
/// <summary>
/// Set the beam target tangent
/// @param  EmitterIndex            The index of the emitter to set it on
/// @param  NewTangentPoint         The value to set it to
/// @param  TargetIndex                     Which beam within the emitter to set it on
/// </summary>
public  void SetBeamTargetTangent(int EmitterIndex,FVector NewTangentPoint,int TargetIndex)
{
	CheckIsValid();
	SetBeamTargetTangent(_this.Get(),EmitterIndex,ref NewTangentPoint,TargetIndex);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SetBeamTargetPoint(IntPtr _this,int EmitterIndex,ref FVector NewTargetPoint,int TargetIndex);
/// <summary>
/// Set the beam target point
/// @param  EmitterIndex            The index of the emitter to set it on
/// @param  NewTargetPoint          The value to set it to
/// @param  TargetIndex                     Which beam within the emitter to set it on
/// </summary>
public  void SetBeamTargetPoint(int EmitterIndex,FVector NewTargetPoint,int TargetIndex)
{
	CheckIsValid();
	SetBeamTargetPoint(_this.Get(),EmitterIndex,ref NewTargetPoint,TargetIndex);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SetBeamSourceStrength(IntPtr _this,int EmitterIndex,float NewSourceStrength,int SourceIndex);
/// <summary>
/// Set the beam source strength
/// @param  EmitterIndex            The index of the emitter to set it on
/// @param  NewSourceStrength       The value to set it to
/// @param  SourceIndex                     Which beam within the emitter to set it on
/// </summary>
public  void SetBeamSourceStrength(int EmitterIndex,float NewSourceStrength,int SourceIndex)
{
	CheckIsValid();
	SetBeamSourceStrength(_this.Get(),EmitterIndex,NewSourceStrength,SourceIndex);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SetBeamSourceTangent(IntPtr _this,int EmitterIndex,ref FVector NewTangentPoint,int SourceIndex);
/// <summary>
/// Set the beam source tangent
/// @param  EmitterIndex            The index of the emitter to set it on
/// @param  NewTangentPoint         The value to set it to
/// @param  SourceIndex                     Which beam within the emitter to set it on
/// </summary>
public  void SetBeamSourceTangent(int EmitterIndex,FVector NewTangentPoint,int SourceIndex)
{
	CheckIsValid();
	SetBeamSourceTangent(_this.Get(),EmitterIndex,ref NewTangentPoint,SourceIndex);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SetBeamSourcePoint(IntPtr _this,int EmitterIndex,ref FVector NewSourcePoint,int SourceIndex);
/// <summary>
/// Set the beam source point
/// @param  EmitterIndex            The index of the emitter to set it on
/// @param  NewSourcePoint          The value to set it to
/// @param  SourceIndex                     Which beam within the emitter to set it on
/// </summary>
public  void SetBeamSourcePoint(int EmitterIndex,FVector NewSourcePoint,int SourceIndex)
{
	CheckIsValid();
	SetBeamSourcePoint(_this.Get(),EmitterIndex,ref NewSourcePoint,SourceIndex);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SetBeamEndPoint(IntPtr _this,int EmitterIndex,ref FVector NewEndPoint);
/// <summary>
/// Set the beam end point
/// @param  EmitterIndex            The index of the emitter to set it on
/// @param  NewEndPoint                     The value to set it to
/// </summary>
public  void SetBeamEndPoint(int EmitterIndex,FVector NewEndPoint)
{
	CheckIsValid();
	SetBeamEndPoint(_this.Get(),EmitterIndex,ref NewEndPoint);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SetAutoAttachmentParameters(IntPtr _this,IntPtr Parent,string SocketName,int LocationRule,int RotationRule,int ScaleRule);
/// <summary>
/// Set AutoAttachParent, AutoAttachSocketName, AutoAttachLocationRule, AutoAttachRotationRule, AutoAttachScaleRule to the specified parameters. Does not change bAutoManageAttachment; that must be set separately.
/// @param  Parent                       Component to attach to.
/// @param  SocketName           Socket on Parent to attach to.
/// @param  LocationRule         Option for how we handle our location when we attach to Parent.
/// @param  RotationRule         Option for how we handle our rotation when we attach to Parent.
/// @param  ScaleRule            Option for how we handle our scale when we attach to Parent.
/// @see bAutoManageAttachment, AutoAttachParent, AutoAttachSocketName, AutoAttachLocationRule, AutoAttachRotationRule, AutoAttachScaleRule
/// </summary>
public  void SetAutoAttachmentParameters(USceneComponent Parent,string SocketName,EAttachmentRule LocationRule,EAttachmentRule RotationRule,EAttachmentRule ScaleRule)
{
	CheckIsValid();
	SetAutoAttachmentParameters(_this.Get(),Parent,SocketName,(int)LocationRule,(int)RotationRule,(int)ScaleRule);
	
}
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	public extern static new IntPtr StaticClass();
}
}
