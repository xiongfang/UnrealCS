using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine{
public partial class UKismetMaterialLibrary:UBlueprintFunctionLibrary 
{
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static IntPtr CreateDynamicMaterialInstance(IntPtr _this,IntPtr WorldContextObject,IntPtr Parent);
/// <summary>Creates a Dynamic Material Instance which you can modify during gameplay.</summary>
public static UMaterialInstanceDynamic CreateDynamicMaterialInstance(UObject WorldContextObject,UMaterialInterface Parent)
{
	IntPtr ___ret = CreateDynamicMaterialInstance(IntPtr.Zero,WorldContextObject,Parent);
	if(___ret==IntPtr.Zero) return null; UMaterialInstanceDynamic ___ret2= new UMaterialInstanceDynamic(){ _this = ___ret }; return ___ret2;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static FLinearColor GetVectorParameterValue(IntPtr _this,IntPtr WorldContextObject,IntPtr Collection,string ParameterName);
/// <summary>Gets a vector parameter value from the material collection instance. Logs if ParameterName is invalid.</summary>
public static FLinearColor GetVectorParameterValue(UObject WorldContextObject,UMaterialParameterCollection Collection,string ParameterName)
{
	FLinearColor ___ret = GetVectorParameterValue(IntPtr.Zero,WorldContextObject,Collection,ParameterName);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static float GetScalarParameterValue(IntPtr _this,IntPtr WorldContextObject,IntPtr Collection,string ParameterName);
/// <summary>Gets a scalar parameter value from the material collection instance. Logs if ParameterName is invalid.</summary>
public static float GetScalarParameterValue(UObject WorldContextObject,UMaterialParameterCollection Collection,string ParameterName)
{
	float ___ret = GetScalarParameterValue(IntPtr.Zero,WorldContextObject,Collection,ParameterName);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SetVectorParameterValue(IntPtr _this,IntPtr WorldContextObject,IntPtr Collection,string ParameterName,ref FLinearColor ParameterValue);
/// <summary>Sets a vector parameter value on the material collection instance. Logs if ParameterName is invalid.</summary>
public static void SetVectorParameterValue(UObject WorldContextObject,UMaterialParameterCollection Collection,string ParameterName,FLinearColor ParameterValue)
{
	SetVectorParameterValue(IntPtr.Zero,WorldContextObject,Collection,ParameterName,ref ParameterValue);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SetScalarParameterValue(IntPtr _this,IntPtr WorldContextObject,IntPtr Collection,string ParameterName,float ParameterValue);
/// <summary>Sets a scalar parameter value on the material collection instance. Logs if ParameterName is invalid.</summary>
public static void SetScalarParameterValue(UObject WorldContextObject,UMaterialParameterCollection Collection,string ParameterName,float ParameterValue)
{
	SetScalarParameterValue(IntPtr.Zero,WorldContextObject,Collection,ParameterName,ParameterValue);
	
}
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	public extern static new IntPtr StaticClass();
}
}
