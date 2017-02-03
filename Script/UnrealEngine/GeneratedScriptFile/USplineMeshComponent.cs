using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine{
public partial class USplineMeshComponent:UStaticMeshComponent 
{
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SetBoundaryMax(IntPtr _this,float InBoundaryMax,int bUpdateMesh);
/// <summary>Set the boundary max</summary>
public  void SetBoundaryMax(float InBoundaryMax,bool bUpdateMesh=true)
{
	CheckIsValid();
	SetBoundaryMax(_this.Get(),InBoundaryMax,bUpdateMesh?1:0);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static float GetBoundaryMax(IntPtr _this);
/// <summary>Get the boundary max</summary>
public  float GetBoundaryMax()
{
	CheckIsValid();
	float ___ret = GetBoundaryMax(_this.Get());
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SetBoundaryMin(IntPtr _this,float InBoundaryMin,int bUpdateMesh);
/// <summary>Set the boundary min</summary>
public  void SetBoundaryMin(float InBoundaryMin,bool bUpdateMesh=true)
{
	CheckIsValid();
	SetBoundaryMin(_this.Get(),InBoundaryMin,bUpdateMesh?1:0);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static float GetBoundaryMin(IntPtr _this);
/// <summary>Get the boundary min</summary>
public  float GetBoundaryMin()
{
	CheckIsValid();
	float ___ret = GetBoundaryMin(_this.Get());
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SetSplineUpDir(IntPtr _this,ref FVector InSplineUpDir,int bUpdateMesh);
/// <summary>Set the spline up direction</summary>
public  void SetSplineUpDir(FVector InSplineUpDir,bool bUpdateMesh=true)
{
	CheckIsValid();
	SetSplineUpDir(_this.Get(),ref InSplineUpDir,bUpdateMesh?1:0);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static FVector GetSplineUpDir(IntPtr _this);
/// <summary>Get the spline up direction</summary>
public  FVector GetSplineUpDir()
{
	CheckIsValid();
	FVector ___ret = GetSplineUpDir(_this.Get());
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SetForwardAxis(IntPtr _this,int InForwardAxis,int bUpdateMesh);
/// <summary>Set the forward axis</summary>
public  void SetForwardAxis(ESplineMeshAxis InForwardAxis,bool bUpdateMesh=true)
{
	CheckIsValid();
	SetForwardAxis(_this.Get(),(int)InForwardAxis,bUpdateMesh?1:0);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static int GetForwardAxis(IntPtr _this);
/// <summary>Get the forward axis</summary>
public  ESplineMeshAxis GetForwardAxis()
{
	CheckIsValid();
	int ___ret = GetForwardAxis(_this.Get());
	return (ESplineMeshAxis)___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SetEndOffset(IntPtr _this,ref FVector2D EndOffset,int bUpdateMesh);
/// <summary>Set the end offset</summary>
public  void SetEndOffset(FVector2D EndOffset,bool bUpdateMesh=true)
{
	CheckIsValid();
	SetEndOffset(_this.Get(),ref EndOffset,bUpdateMesh?1:0);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static FVector2D GetEndOffset(IntPtr _this);
/// <summary>Get the end offset</summary>
public  FVector2D GetEndOffset()
{
	CheckIsValid();
	FVector2D ___ret = GetEndOffset(_this.Get());
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SetEndRoll(IntPtr _this,float EndRoll,int bUpdateMesh);
/// <summary>Set the end roll</summary>
public  void SetEndRoll(float EndRoll,bool bUpdateMesh=true)
{
	CheckIsValid();
	SetEndRoll(_this.Get(),EndRoll,bUpdateMesh?1:0);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static float GetEndRoll(IntPtr _this);
/// <summary>Get the end roll</summary>
public  float GetEndRoll()
{
	CheckIsValid();
	float ___ret = GetEndRoll(_this.Get());
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SetEndScale(IntPtr _this,ref FVector2D EndScale,int bUpdateMesh);
/// <summary>Set the end scaling</summary>
public  void SetEndScale(FVector2D EndScale=default(FVector2D),bool bUpdateMesh=true)
{
	CheckIsValid();
	SetEndScale(_this.Get(),ref EndScale,bUpdateMesh?1:0);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static FVector2D GetEndScale(IntPtr _this);
/// <summary>Get the end scaling</summary>
public  FVector2D GetEndScale()
{
	CheckIsValid();
	FVector2D ___ret = GetEndScale(_this.Get());
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SetStartOffset(IntPtr _this,ref FVector2D StartOffset,int bUpdateMesh);
/// <summary>Set the start offset</summary>
public  void SetStartOffset(FVector2D StartOffset,bool bUpdateMesh=true)
{
	CheckIsValid();
	SetStartOffset(_this.Get(),ref StartOffset,bUpdateMesh?1:0);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static FVector2D GetStartOffset(IntPtr _this);
/// <summary>Get the start offset</summary>
public  FVector2D GetStartOffset()
{
	CheckIsValid();
	FVector2D ___ret = GetStartOffset(_this.Get());
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SetStartRoll(IntPtr _this,float StartRoll,int bUpdateMesh);
/// <summary>Set the start roll</summary>
public  void SetStartRoll(float StartRoll,bool bUpdateMesh=true)
{
	CheckIsValid();
	SetStartRoll(_this.Get(),StartRoll,bUpdateMesh?1:0);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static float GetStartRoll(IntPtr _this);
/// <summary>Get the start roll</summary>
public  float GetStartRoll()
{
	CheckIsValid();
	float ___ret = GetStartRoll(_this.Get());
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SetStartScale(IntPtr _this,ref FVector2D StartScale,int bUpdateMesh);
/// <summary>Set the start scaling</summary>
public  void SetStartScale(FVector2D StartScale=default(FVector2D),bool bUpdateMesh=true)
{
	CheckIsValid();
	SetStartScale(_this.Get(),ref StartScale,bUpdateMesh?1:0);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static FVector2D GetStartScale(IntPtr _this);
/// <summary>Get the start scaling</summary>
public  FVector2D GetStartScale()
{
	CheckIsValid();
	FVector2D ___ret = GetStartScale(_this.Get());
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SetStartAndEnd(IntPtr _this,ref FVector StartPos,ref FVector StartTangent,ref FVector EndPos,ref FVector EndTangent,int bUpdateMesh);
/// <summary>Set the start and end, position and tangent, all in local space</summary>
public  void SetStartAndEnd(FVector StartPos,FVector StartTangent,FVector EndPos,FVector EndTangent,bool bUpdateMesh=true)
{
	CheckIsValid();
	SetStartAndEnd(_this.Get(),ref StartPos,ref StartTangent,ref EndPos,ref EndTangent,bUpdateMesh?1:0);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SetEndTangent(IntPtr _this,ref FVector EndTangent,int bUpdateMesh);
/// <summary>Set the end tangent vector of spline in local space</summary>
public  void SetEndTangent(FVector EndTangent,bool bUpdateMesh=true)
{
	CheckIsValid();
	SetEndTangent(_this.Get(),ref EndTangent,bUpdateMesh?1:0);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static FVector GetEndTangent(IntPtr _this);
/// <summary>Get the end tangent vector of spline in local space</summary>
public  FVector GetEndTangent()
{
	CheckIsValid();
	FVector ___ret = GetEndTangent(_this.Get());
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SetEndPosition(IntPtr _this,ref FVector EndPos,int bUpdateMesh);
/// <summary>Set the end position of spline in local space</summary>
public  void SetEndPosition(FVector EndPos,bool bUpdateMesh=true)
{
	CheckIsValid();
	SetEndPosition(_this.Get(),ref EndPos,bUpdateMesh?1:0);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static FVector GetEndPosition(IntPtr _this);
/// <summary>Get the end position of spline in local space</summary>
public  FVector GetEndPosition()
{
	CheckIsValid();
	FVector ___ret = GetEndPosition(_this.Get());
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SetStartTangent(IntPtr _this,ref FVector StartTangent,int bUpdateMesh);
/// <summary>Set the start tangent vector of spline in local space</summary>
public  void SetStartTangent(FVector StartTangent,bool bUpdateMesh=true)
{
	CheckIsValid();
	SetStartTangent(_this.Get(),ref StartTangent,bUpdateMesh?1:0);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static FVector GetStartTangent(IntPtr _this);
/// <summary>Get the start tangent vector of spline in local space</summary>
public  FVector GetStartTangent()
{
	CheckIsValid();
	FVector ___ret = GetStartTangent(_this.Get());
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SetStartPosition(IntPtr _this,ref FVector StartPos,int bUpdateMesh);
/// <summary>Set the start position of spline in local space</summary>
public  void SetStartPosition(FVector StartPos,bool bUpdateMesh=true)
{
	CheckIsValid();
	SetStartPosition(_this.Get(),ref StartPos,bUpdateMesh?1:0);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static FVector GetStartPosition(IntPtr _this);
/// <summary>Get the start position of spline in local space</summary>
public  FVector GetStartPosition()
{
	CheckIsValid();
	FVector ___ret = GetStartPosition(_this.Get());
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void UpdateMesh(IntPtr _this);
/// <summary>Update the collision and render state on the spline mesh following changes to its geometry</summary>
public  void UpdateMesh()
{
	CheckIsValid();
	UpdateMesh(_this.Get());
	
}
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	public extern static new IntPtr StaticClass();
}
}
