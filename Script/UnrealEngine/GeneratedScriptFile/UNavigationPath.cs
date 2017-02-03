using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine{
public partial class UNavigationPath:UObject 
{
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static int IsStringPulled(IntPtr _this);
public  bool IsStringPulled()
{
	CheckIsValid();
	int ___ret = IsStringPulled(_this.Get());
	return ___ret!=0;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static int IsValid(IntPtr _this);
public  bool IsValid()
{
	CheckIsValid();
	int ___ret = IsValid(_this.Get());
	return ___ret!=0;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static int IsPartial(IntPtr _this);
public  bool IsPartial()
{
	CheckIsValid();
	int ___ret = IsPartial(_this.Get());
	return ___ret!=0;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static float GetPathCost(IntPtr _this);
public  float GetPathCost()
{
	CheckIsValid();
	float ___ret = GetPathCost(_this.Get());
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static float GetPathLength(IntPtr _this);
public  float GetPathLength()
{
	CheckIsValid();
	float ___ret = GetPathLength(_this.Get());
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void EnableRecalculationOnInvalidation(IntPtr _this,int DoRecalculation);
/// <summary>if enabled path will request recalculation if it gets invalidated due to a change to underlying navigation</summary>
public  void EnableRecalculationOnInvalidation(ENavigationOptionFlag DoRecalculation)
{
	CheckIsValid();
	EnableRecalculationOnInvalidation(_this.Get(),(int)DoRecalculation);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void EnableDebugDrawing(IntPtr _this,int bShouldDrawDebugData,ref FLinearColor PathColor);
public  void EnableDebugDrawing(bool bShouldDrawDebugData,FLinearColor PathColor=default(FLinearColor))
{
	CheckIsValid();
	EnableDebugDrawing(_this.Get(),bShouldDrawDebugData?1:0,ref PathColor);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static string GetDebugString(IntPtr _this);
/// <summary>UObject end</summary>
public  string GetDebugString()
{
	CheckIsValid();
	string ___ret = GetDebugString(_this.Get());
	return ___ret;
	
}
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	public extern static new IntPtr StaticClass();
}
}
