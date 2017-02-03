using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine{
public partial class UCameraComponent:USceneComponent 
{
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void GetCameraView(IntPtr _this,float DeltaTime,out FMinimalViewInfo DesiredView);
/// <summary>
/// Returns camera's Point of View.
/// Called by Camera class. Subclass and postprocess to add any effects.
/// </summary>
public  void GetCameraView(float DeltaTime,out FMinimalViewInfo DesiredView)
{
	CheckIsValid();
	GetCameraView(_this.Get(),DeltaTime,out DesiredView);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SetPostProcessBlendWeight(IntPtr _this,float InPostProcessBlendWeight);
public  void SetPostProcessBlendWeight(float InPostProcessBlendWeight)
{
	CheckIsValid();
	SetPostProcessBlendWeight(_this.Get(),InPostProcessBlendWeight);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SetProjectionMode(IntPtr _this,int InProjectionMode);
public  void SetProjectionMode(ECameraProjectionMode InProjectionMode)
{
	CheckIsValid();
	SetProjectionMode(_this.Get(),(int)InProjectionMode);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SetUseFieldOfViewForLOD(IntPtr _this,int bInUseFieldOfViewForLOD);
public  void SetUseFieldOfViewForLOD(bool bInUseFieldOfViewForLOD)
{
	CheckIsValid();
	SetUseFieldOfViewForLOD(_this.Get(),bInUseFieldOfViewForLOD?1:0);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SetConstraintAspectRatio(IntPtr _this,int bInConstrainAspectRatio);
public  void SetConstraintAspectRatio(bool bInConstrainAspectRatio)
{
	CheckIsValid();
	SetConstraintAspectRatio(_this.Get(),bInConstrainAspectRatio?1:0);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SetAspectRatio(IntPtr _this,float InAspectRatio);
public  void SetAspectRatio(float InAspectRatio)
{
	CheckIsValid();
	SetAspectRatio(_this.Get(),InAspectRatio);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SetOrthoFarClipPlane(IntPtr _this,float InOrthoFarClipPlane);
public  void SetOrthoFarClipPlane(float InOrthoFarClipPlane)
{
	CheckIsValid();
	SetOrthoFarClipPlane(_this.Get(),InOrthoFarClipPlane);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SetOrthoNearClipPlane(IntPtr _this,float InOrthoNearClipPlane);
public  void SetOrthoNearClipPlane(float InOrthoNearClipPlane)
{
	CheckIsValid();
	SetOrthoNearClipPlane(_this.Get(),InOrthoNearClipPlane);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SetOrthoWidth(IntPtr _this,float InOrthoWidth);
public  void SetOrthoWidth(float InOrthoWidth)
{
	CheckIsValid();
	SetOrthoWidth(_this.Get(),InOrthoWidth);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SetFieldOfView(IntPtr _this,float InFieldOfView);
public  void SetFieldOfView(float InFieldOfView)
{
	CheckIsValid();
	SetFieldOfView(_this.Get(),InFieldOfView);
	
}
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	public extern static new IntPtr StaticClass();
}
}
